using AlbumentationsCSharp.Composition;
using FilterBase;
using SSTools;
using SSTools.Shape;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static FilterBase.BaseFilterControl;
using static SSTools.WndMsgAnalysis;

namespace AlbumentationsCSharp
{
    public partial class MainForm : SSTools.FullscreenForm
    {
        /// <summary>
        /// コマンド実行
        /// </summary>
        private CmdExecutor CmdExec;
        /// <summary>
        /// Albumentationsのバージョン
        /// </summary>
        private VersionInfo AlbumentationsVersion;

        /// <summary>
        /// Albumentationsの別名
        /// </summary>
        private const string AlbumentationsName = "A";

        /// <summary>
        /// 待ちダイアログ
        /// </summary>
        private WaitDialog WaitDialog;

        /// <summary>
        /// Pythonの起動状態
        /// </summary>
        private bool PythonIsOk = false;

        /// <summary>
        /// アプリケーション設定
        /// </summary>
        private AppConfig AppConfig = new AppConfig();

        /// <summary>
        /// 選択された画像ファイル名
        /// </summary>
        private string ImageFilePath;
        /// <summary>
        /// 画像
        /// </summary>
        private Bitmap OrigImage = null;
        /// <summary>
        /// 選択されたマスク画像ファイル名
        /// </summary>
        private string MaskFilePath;
        /// <summary>
        /// マスク画像
        /// </summary>
        private Bitmap MaskImage = null;
        /// <summary>
        /// BBox
        /// </summary>
        private BoundingBox BoundingBox = null;
        /// <summary>
        /// KeyPoint
        /// </summary>
        private KeyPoints KeyPoints = null;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public MainForm()
        {
            InitializeComponent();

            // アプリケーション設定を読み込む
            AppConfig.Reload();

            // BBox編集ボタン無効 
            BtBBoxEdit.Enabled = false;
            // KeyPoint編集ボタン無効
            BtKeyPointEdit.Enabled = false;

            // プラグインマネージャ初期化
            PluginManager.LoadPlugins(Path.Combine(Directory.GetCurrentDirectory(), "plugins"));

            // コンボボックスを生成
            PluginManager.MakeCategoryComboBox(CbCategory);

            // BBoxのコンボボックス作成
            BBoxFormatClass.MakeComboBox(CbBBoxType,BBoxFormat.COCO);

            // KeyPointsのコンボボックス作成
            KeyPoints.KeyPointsTypeDef.MakeComboBox(CbKeyPointType,KeyPoints.KeyPointsFileConverters,KeyPoints.KeyPointType.COCO);

            // ダイアログを表示
            InitPythonExec(AppConfig.PythonSetting, true);

           
        }


        #region [Python実行関連]
        /// <summary>
        /// Python実行を設定
        /// </summary>
        /// <param name="setting"></param>
        /// <param name="force_show_dialog"></param>
        /// <returns></returns>
        private bool InitPythonExec(string setting, bool force_show_dialog = false)
        {
            PythonSetting config;
            // パラメータを生成
            if (string.IsNullOrEmpty(setting))
                config = new PythonSetting();
            else
                config = new PythonSetting(setting);

            if (force_show_dialog)
            {   // ダイアログを表示
                PythonEnvForm setting_form = new PythonEnvForm(config);
                if (setting_form.ShowDialog() == DialogResult.OK)
                {
                    // 設定をコピー
                    config = setting_form.Setting;
                    // アプリケーション設定に保存
                    AppConfig.PythonSetting = config.ToString();
                }
                else
                {   // キャンセルされた
                    return false;
                }
            }
            if (config.Check(out string err_msg) == false)
            {   // 設定にNGがある
                return false;
            }
            else
            {
                // 引数
                string arg = "script.py";
                // 実行コマンドを取得
                List<string> exec_cmd = config.StartPython(arg, out string init_directory);
                // コマンド実行
                if (CmdExec != null)
                {   // 既に実行されている
                    CmdExec.Dispose();
                    CmdExec = null;
                    // Python実行不可
                    PythonIsOk = false;
                }
                // 待ちフォームを表示
                WaitDialog = new WaitDialog();
                WaitDialog.Show(this);

                // コマンド実行を起動
                CmdExec = new CmdExecutor(init_directory, Executor_CmdError);
                for (int i = 0; i < exec_cmd.Count; i++)
                {
                    if (i != exec_cmd.Count - 1)
                        CmdExec.ExecCommand(exec_cmd[i]);
                    else
                        CmdExec.ExecCommand(exec_cmd[i], ">", AlbumentationsVersionGet);
                }
                return true;
            }
        }
        /// <summary>
        /// Python環境リスタート
        /// </summary>
        private void PythonRestart(bool force_show_dialog = false)
        {
            // Python環境再起動
            if (InitPythonExec(AppConfig.PythonSetting, force_show_dialog))
            {   // 起動成功したので、画像とマスクを転送
                // コマンド送信
                if (CmdExec != null)
                {
                    if ((string.IsNullOrEmpty(ImageFilePath) == false) &&
                        (File.Exists(ImageFilePath)))
                    {
                        CmdExec.ExecCommand("", ">");  // 空行を送信
                        CmdExec.ExecCommand("IMG:" + ImageFilePath, ">");
                        CmdExec.ExecCommand("IMG!");
                    }
                    if ((string.IsNullOrEmpty(MaskFilePath) == false) &&
                        (File.Exists(MaskFilePath)))
                    {
                        CmdExec.ExecCommand("", ">");  // 空行を送信
                        CmdExec.ExecCommand("MASK:" + MaskFilePath, ">");
                        CmdExec.ExecCommand("MASK!");
                    }
                    // BBOXを送信
                    SendBBox();
                    // キーポイントを送信
                    SendKeyPoints();
                }
            }
        }

        /// <summary>
        /// Python実行エラー発生
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="err_txt"></param>
        private void Executor_CmdError(object sender, string err_txt)
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)delegate { Executor_CmdError(sender, err_txt); });
                return;
            }
            if (WaitDialog != null)
                WaitDialog.SetResult(false);

            string msg = err_txt.Trim();
            MessageBoxButtons messageBoxButtons = MessageBoxButtons.OK;
            if (msg.StartsWith("## "))
            {   // 継続可能な実行エラー
                msg = msg.Substring(3);
                int pos = msg.IndexOf(':');
                if ((pos > 0) && (pos < msg.Length - 1))
                    msg = msg.Substring(0, pos + 1) + "\r\n" + msg.Substring(pos + 1);

                msg += "\r\n\r\n継続する場合は[Yes]、Python環境を再起動は[No]を選択";
                messageBoxButtons = MessageBoxButtons.YesNo;
            }
            DialogResult d_result = MessageBox.Show(msg, "Pythonエラー", messageBoxButtons, MessageBoxIcon.Error);

            if (d_result == DialogResult.No)
            {   // Python環境再起動
                PythonRestart(false);
            }
            else if (d_result == DialogResult.OK)
            {   // Pythonスクリプト自体にエラー
                if (CmdExec != null)
                {   // 既に実行されている
                    CmdExec.Dispose();
                    CmdExec = null;
                }
                // Python実行不可
                PythonIsOk = false;
            }
        }
        #endregion [Python実行関連]

        /// <summary>
        /// フォームが閉じた
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <exception cref="NotImplementedException"></exception>
        private void WaitDialog_FormClosed(object sender, FormClosedEventArgs e)
        {
            // ダイアログがOKで閉じたら、Python起動可能
            PythonIsOk = (WaitDialog.DialogResult == DialogResult.OK);
            WaitDialog = null;
        }

        /// <summary>
        /// Albumentationのバージョン情報を取得
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="sendCmd"></param>
        /// <param name="resp"></param>
        /// <param name="isOK"></param>
        private bool AlbumentationsVersionGet(object sender, string sendCmd, string resp, bool isOK)
        {
            if (InvokeRequired)
            {
                bool result = (bool)Invoke((Func<bool>)(()=> AlbumentationsVersionGet(sender, sendCmd, resp, isOK)));
                return result;
            }
            AlbumentationsVersion = new VersionInfo(resp);
            BaseFilterControl ctrl = GetPanelFilterControl();
            if (ctrl != null)
            {   // バージョンを設定
                ctrl.Version = AlbumentationsVersion;
            }
            // 待ち表示ダイアログを閉じる
            if (WaitDialog != null)
                WaitDialog.SetResult(true);

#if DEBUG
            // デバッグモードにする
            CmdExec.ExecCommand("DBG:ON", ">");
#endif
            return true;
        }


        /// <summary>
        /// パネルに貼り付いているコントロールを取得する
        /// </summary>
        /// <returns></returns>
        private BaseFilterControl GetPanelFilterControl()
        {
            if (PanelParam.Controls.Count > 0)
            {
                if (PanelParam.Controls[0] is BaseFilterControl filter)
                    return filter;

                // 不明なコントロールを削除
                for(int index = PanelParam.Controls.Count - 1; index >= 0; index--)
                {
                    PanelParam.Controls.RemoveAt(index);
                }
            }
            return null;
        }
        /// <summary>
        /// カテゴリーコンボボックスの内容は変わった
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 詳細コンボボックスの割り当て
            PluginManager.MakeMethodComboBox(CbCategory, CbAlbumentations);
        }
        /// <summary>
        /// フィルタのコンボボックスの内容が変わった
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CbAlbumentations_SelectedIndexChanged(object sender, EventArgs e)
        {
            BaseFilterControl ctrl = PluginManager.GetFilterControl(CbAlbumentations.SelectedItem);
            if (ctrl != null)
            {
                BaseFilterControl oldCtrl = GetPanelFilterControl();
                if (oldCtrl != null)
                {
                    // イベントを削除
                    oldCtrl.ParameterChange -= Filter_ParameterChange;
                    oldCtrl.Dispose();
                    oldCtrl = null;
                }
                // バージョンを設定
                ctrl.Version = AlbumentationsVersion;
                // イベントを追加
                ctrl.ParameterChange += Filter_ParameterChange;
                // パネルに貼り付け
                PanelParam.Controls.Add(ctrl);

                // コントロールが有効なら...
                if (CheckControlTarget(ctrl))
                {   // 画像ファイルが指定されていたら、最初の実行
                    ExecFilter(true);
                }

            }
        }


        #region [画像関連]
        /// <summary>
        /// 画像ファイル拡張子
        /// </summary>
        private string[] ImageExtensions = new string[]
        {
            ".jpg",".jpeg",".bmp",".png",".tif",".tiff"
        };

        /// <summary>
        /// グレースケール変換
        /// </summary>
        /// <param name="img"></param>
        /// <returns></returns>
        private Bitmap ToGrayscale(Image img)
        {
            if (img != null)
            {
                //グレースケールの描画先となるImageオブジェクトを作成
                Bitmap newImg = new Bitmap(img.Width, img.Height);
                //newImgのGraphicsオブジェクトを取得
                Graphics g = Graphics.FromImage(newImg);

                //ColorMatrixオブジェクトの作成
                //グレースケールに変換するための行列を指定する
                System.Drawing.Imaging.ColorMatrix cm =
                    new System.Drawing.Imaging.ColorMatrix(
                        new float[][]{
                            new float[]{0.3086f, 0.3086f, 0.3086f, 0 ,0},
                            new float[]{0.6094f, 0.6094f, 0.6094f, 0, 0},
                            new float[]{0.0820f, 0.0820f, 0.0820f, 0, 0},
                            new float[]{0, 0, 0, 1, 0},
                            new float[]{0, 0, 0, 0, 1}
                        });
                //ImageAttributesオブジェクトの作成
                System.Drawing.Imaging.ImageAttributes ia =
                    new System.Drawing.Imaging.ImageAttributes();
                //ColorMatrixを設定する
                ia.SetColorMatrix(cm);

                //ImageAttributesを使用してグレースケールを描画
                g.DrawImage(img,
                    new Rectangle(0, 0, img.Width, img.Height),
                    0, 0, img.Width, img.Height, GraphicsUnit.Pixel, ia);

                //リソースを解放する
                g.Dispose();

                return newImg;
            }
            return null;
        }

        /// <summary>
        /// 画像ファイルを開く
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtImageOpen_Click(object sender, EventArgs e)
        {
            if ((TbImageFile.Text.Trim().Length > 0) &&
                (File.Exists(TbImageFile.Text)))
            {
                ImageFilePath = TbImageFile.Text;
                Bitmap bmp = null;
                using (FileStream fs = new FileStream(ImageFilePath, FileMode.Open, FileAccess.Read))
                    bmp = new Bitmap(fs);
                if (bmp != null)
                {
                    // 解像度を96DPIにする
                    bmp.SetResolution(96.0F, 96.0F);

                    if (RbGray.Checked)
                    {   // グレースケール変換
                        Bitmap gray =ToGrayscale(bmp);
                        bmp.Dispose();
                        bmp = null;
                        bmp = gray;
                    }

                    // 図形をクリア
                    PbOrigImage.ClearShape();
                    // マスクをクリア
                    PbOrigImage.MaskImage = null;
                    OrigImage = bmp;
                    PbOrigImage.Image = bmp;

                    // 画像読み込みフラグ
                    string read_mode = "";
                    if ((RbFloat.Checked) || (RbGray.Checked))
                    {
                        if (RbFloat.Checked)
                            read_mode += "float" + "|";
                        if (RbGray.Checked)
                            read_mode += "gray" + "|";
                    }

                    // コマンド送信
                    if (CmdExec != null)
                    {
                        CmdExec.ExecCommand("", ">");  // 空行を送信
                        CmdExec.ExecCommand("IMG:" + read_mode + ImageFilePath, ">");
#if DEBUG
                        CmdExec.ExecCommand("IMG!");
#endif
                        CmdExec.ExecCommand("", ">");  // 空行を送信
                        CmdExec.ExecCommand("MASK:");   // マスク画像を消去

                    }
                    // マスク画像と図形をクリアする
                    if (MaskImage != null)
                    {
                        MaskImage.Dispose();
                        MaskFilePath = string.Empty;
                    }

                    // マスク画像他の自動読み込み
                    string dir = Path.GetDirectoryName(ImageFilePath);
                    string fname = Path.GetFileNameWithoutExtension(ImageFilePath);
                    
                    // マスク画像
                    foreach (string mask_name in Directory.EnumerateFiles(dir, fname + "_mask.*"))
                    {
                        string ext = Path.GetExtension(mask_name);
                        if (ImageExtensions.Contains(ext))
                        {
                            TbMaskImage.Text = mask_name;
                            // マスク画像を開く
                            BtMaskImageOpen_Click(this, new EventArgs());
                            break;
                        }
                    }
                    // BBOX
                    if (File.Exists(Path.Combine(dir, fname + "_bbox.csv")))
                    {
                        TbBBoxFile.Text = Path.Combine(dir, fname + "_bbox.csv");
                        // BBOXを開く
                        BtBBoxFileOpen_Click(this, new EventArgs());
                    }
                    // Keypoints
                    if (File.Exists(Path.Combine(dir, fname + "_keypoints.csv")))
                    {
                        TbKeyPoint.Text = Path.Combine(dir, fname + "_keypoints.csv");
                        // Keypointファイルを開く
                        BtKeyPointOpen_Click(this, new EventArgs());
                    }

                }
            }
        }
        /// <summary>
        /// マスク画像を開く
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtMaskImageOpen_Click(object sender, EventArgs e)
        {
            if ((TbMaskImage.Text.Trim().Length > 0) &&
                (File.Exists(TbMaskImage.Text)))
            {
                MaskFilePath = TbMaskImage.Text;
                Bitmap bmp = null;
                using (FileStream fs = new FileStream(MaskFilePath, FileMode.Open, FileAccess.Read))
                    bmp = new Bitmap(fs);
                if (bmp != null)
                {
                    // 解像度を96DPIにする
                    bmp.SetResolution(96.0F, 96.0F);
                    // 透過設定
                    bmp.MakeTransparent(Color.Black);
                    MaskImage = bmp;
                    // マスク画像の設定
                    PbOrigImage.MaskImage = MaskImage;

                    // コマンド送信
                    if (CmdExec != null)
                    {
                        CmdExec.ExecCommand("", ">");  // 空行を送信
                        CmdExec.ExecCommand("MASK:" + MaskFilePath, ">");
#if DEBUG
                        CmdExec.ExecCommand("MASK!");
#endif
                    }
                }
            }
        }

        /// <summary>
        /// マスク表示のチェックが変更になった
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CbShowMask_CheckedChanged(object sender, EventArgs e)
        {
            // 画像の描画
            PbOrigImage.MaskShow = CbShowMask.Checked;
        }
        #endregion [画像関連]

        /// <summary>
        /// 実行可能かチェック
        /// </summary>
        /// <param name="ctrl"></param>
        /// <returns></returns>
        private bool CheckControlTarget(BaseFilterControl ctrl)
        {
            bool result = ctrl.Enabled;
            if ((ctrl.Require.HasFlag(TRANSFORM_TARGET.IMAGE)) && ((string.IsNullOrEmpty(ImageFilePath)) ||
                    (File.Exists(ImageFilePath) == false)))
                result = false;
            if ((ctrl.Require.HasFlag(TRANSFORM_TARGET.MASK)) && ((string.IsNullOrEmpty(MaskFilePath)) ||
                    (File.Exists(MaskFilePath) == false)))
                result = false;
            if ((ctrl.Require.HasFlag(TRANSFORM_TARGET.BBOX)) && (BoundingBox == null)) result = false;
            if ((ctrl.Require.HasFlag(TRANSFORM_TARGET.KEY_POINT)) && (KeyPoints == null)) result = false;

            return result;
        }


        /// <summary>
        /// フィルタ実行
        /// </summary>
        /// <param name="always_applay"></param>
        /// <returns></returns>
        private bool ExecFilter(bool always_applay = false)
        {
            BaseFilterControl ctrl = GetPanelFilterControl();
            if ((ctrl != null) && (CmdExec != null))
            {
                if (CheckControlTarget(ctrl))
                {
                    // パラメータチェック
                    if (ctrl.CheckParameter(out string msg) == false)
                    {
                        MessageBox.Show(msg, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }

                    string alb_cmd = ctrl.GetPythonCommand(always_applay);
                    if (string.IsNullOrEmpty(alb_cmd) == false)
                    {
                        // Composeを追加する
                        alb_cmd = string.Format("{0}.Compose([{1}]", AlbumentationsName, alb_cmd);
                        if (BoundingBox != null)
                        {   // bbox_paramsを追加
                            alb_cmd += string.Format(",bbox_params={0}.BboxParams(format='{1}'",
                                AlbumentationsName, BoundingBox.GetFormat());
                            string lbox = BoundingBox.GetClassName();
                            if (string.IsNullOrEmpty(lbox) == false)
                                alb_cmd += ", label_fields=['bbox_label']";
                            alb_cmd += ")";
                        }
                        if (KeyPoints != null)
                        {   // keypoint_paramsを追加
                            alb_cmd += string.Format(",keypoint_params={0}.KeypointParams(format='{1}'",
                                AlbumentationsName, KeyPoints.GetFormat());
                            string lkp = KeyPoints.GetLabels();
                            if (string.IsNullOrEmpty(lkp) == false)
                                alb_cmd += ", label_fields=['keypoints_label']";
                            alb_cmd += ")";
                        }
                        alb_cmd += ")";

                        // コマンドを発行
                        CmdExec.ExecCommand("", ">");  // 空行を送信
                        CmdExec.ExecCommand("TR:" + alb_cmd, ">", ExecCallback);
                    }
                }
                return true;
            }
            return false;
        }

        /// <summary>
        /// フィルターのパラメータが変わった
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="name"></param>
        /// <param name="value"></param>
        /// <exception cref="NotImplementedException"></exception>
        private void Filter_ParameterChange(object sender, string name, object value)
        {
            if (CbImmediate.Checked)
            {
                // フィルタ実行
                ExecFilter(true);
            }
        }

        /// <summary>
        /// フィルタ適用
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtExec_Click(object sender, EventArgs e)
        {
            // フィルタ実行
            ExecFilter(false);
        }
        /// <summary>
        /// フィルタ実行の応答処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="cmd"></param>
        /// <param name="recvCmd"></param>
        /// <param name="isOK"></param>
        private bool ExecCallback(object sender, string cmd, string recvCmd, bool isOK)
        {
            if (InvokeRequired)
            {
                bool result = (bool)Invoke((Func<bool>)(()=> ExecCallback(sender, cmd, recvCmd, isOK)));
                return result;
            }
            // TRコマンドの応答
            if ((isOK) && (cmd.StartsWith("TR:")))
            {   // 結果がOK
                int width = 640;
                int height = 480;

                // 図形をクリア
                PbResultImage.ClearShape();

                if (File.Exists("result.bmp"))
                {   // 結果画像ファイルがある
                    Bitmap bmp = null;
                    using (FileStream fs = new FileStream("result.bmp", FileMode.Open, FileAccess.Read))
                        bmp = new Bitmap(fs);
                    if (bmp != null)
                    {
                        PbResultImage.Image = bmp;
                        width = bmp.Width;
                        height = bmp.Height;
                    }
                }
                if (File.Exists("mask.bmp"))
                {   // 結果マスクファイルがある
                    Bitmap mask_bmp = null;
                    using (FileStream fs = new FileStream("mask.bmp", FileMode.Open, FileAccess.Read))
                        mask_bmp = new Bitmap(fs);
                    if (mask_bmp != null)
                    {
                        //透過設定
                        mask_bmp.MakeTransparent(Color.Black);
                        PbResultImage.MaskImage = mask_bmp;
                    }
                }
                if (File.Exists("bbox.csv"))
                {   // BBoxファイルがある
                    BoundingBox resultBBox = new BoundingBox(BoundingBox.Format, "bbox.csv");
                    if (resultBBox != null)
                    {
                        List<BoundingBox.BBoxShape> rects =  resultBBox.GetShapes(width,height);
                        if ((rects != null) && (rects.Count > 0))
                        {
                            int color_index = 0;
                            for (int i = 0; i < rects.Count; i++)
                            {
                                RectangleShape shape = new RectangleShape(string.Format("bbox_{0}", i), rects[i].Rectangle)
                                {
                                    Text = BoundingBox.GetJapanese(rects[i].Name),
                                    Color = CMap.Get(color_index),
                                    ShowLable = true,
                                    LabelFill = true,
                                    Visible = CbShowResultBBox.Checked,
                                };
                                PbResultImage.AddShape(shape);
                                color_index = (color_index + 64) & 0x0FF;
                            }
                            PbResultImage.Refresh();
                        }
                    }
                    resultBBox = null;

                }
                if (File.Exists("keypoints.csv"))
                {   // キーポイントファイルがある
                    KeyPoints  resultKeyPoints = new KeyPoints("keypoints.csv");
                    if (resultKeyPoints != null)
                    {
                        List<KeyPoints.KeyPointShape> pts = resultKeyPoints.GetShapes();
                        if ((pts != null) && (pts.Count > 0))
                        {
                            int color_index = 0;
                            for (int i = 0; i < pts.Count; i++)
                            {
                                PointShape shape = new PointShape(string.Format("kpt_{0}", i))
                                {
                                    Text = KeyPoints.GetJapanese(pts[i].Name),
                                    Point = pts[i].Point,
                                    Color = CMap.Get(color_index),
                                    ShowLable = ((string.IsNullOrEmpty(pts[i].Name) == false) & (CbResultShowKeyPointsLabel.Checked)),
                                    Visible = CbShowResultKeyPoints.Checked,
                                    LabelFill = true,
                                    MarkerType = BaseShape.MARKER_TYPE.CROSS,
                                    LineWidth = 2.0F
                                };
                                PbResultImage.AddShape(shape);
                                color_index = (color_index + 64) & 0x0FF;
                            }
                            PbResultImage.Refresh();
                        }
                    }
                    resultKeyPoints = null;
                }

            }
            return true;
        }



        /// <summary>
        /// Python環境を再設定
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ToolStripMenuItemPythonConfig_Click(object sender, EventArgs e)
        {
            // 現在の内容で設定を開く
            PythonRestart(true);
        }
        /// <summary>
        /// BBoxファイルを開く
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtBBoxFileOpen_Click(object sender, EventArgs e)
        {
            if ((TbBBoxFile.Text.Trim().Length > 0) &&
                (File.Exists(TbBBoxFile.Text)))
            {
                if (BoundingBox != null)
                    BoundingBox = null;

                // 読み込みフォーマット
                BBoxFormat format = BBoxFormatClass.GetItem(CbBBoxType);
                // BBoxファイルを読み込む
                BoundingBox = new BoundingBox(format, TbBBoxFile.Text);
                // 編集ボタンの有効無効
                BtBBoxEdit.Enabled = (BoundingBox.BBoxes.Count > 0);
                // BBOXを送信
                SendBBox();
                // BBOXを設定
                SetOrigBBox();
            }
        }
        /// <summary>
        /// BBox編集
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtBBoxEdit_Click(object sender, EventArgs e)
        {
            if (BoundingBox != null)
            {
                BBoxForm form = new BBoxForm(BoundingBox);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    // BBOXをコピー
                    BoundingBox = new BoundingBox(form.BoundingBox);
                    // BBOXを送信
                    SendBBox();
                    // BBOXを設定
                    SetOrigBBox();
                }
                form.Dispose();
                form = null;
            }
        }
        /// <summary>
        /// 新規BBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtNewBox_Click(object sender, EventArgs e)
        {
            BBoxForm form = new BBoxForm(BoundingBox);
            if (form.ShowDialog() == DialogResult.OK)
            {
                // BBOXをコピー
                BoundingBox = new BoundingBox(form.BoundingBox);
                // BBOXを送信
                SendBBox();
                // BBOXを設定
                SetOrigBBox();
            }
            form.Dispose();
            form = null;
        }
        /// <summary>
        /// BBOXを送信
        /// </summary>
        private void SendBBox()
        {
            if (BoundingBox != null)
            {
                string bbox = BoundingBox.GetBoundingBox();
                string bbox_label = BoundingBox.GetClassName();
                if ((string.IsNullOrEmpty(bbox) == false) && (CmdExec != null))
                {
                    // コマンドを発行
                    CmdExec.ExecCommand("", ">");  // 空行を送信
                    CmdExec.ExecCommand("BBOX:" + bbox, ">");
#if DEBUG
                    CmdExec.ExecCommand("BBOX!", ">");
#endif

                    if (string.IsNullOrEmpty(bbox_label) == false)
                    {
                        // コマンドを発行
                        CmdExec.ExecCommand("", ">");  // 空行を送信
                        CmdExec.ExecCommand("LBOX:" + bbox_label, ">");
#if DEBUG
                        CmdExec.ExecCommand("LBOX!", ">");
#endif
                    }
                }
            }
        }


        /// <summary>
        /// カラーマップ
        /// </summary>
        private SSTools.ColorMap.Miscellaneous.RainbowColorMap CMap = new SSTools.ColorMap.Miscellaneous.RainbowColorMap();

        /// <summary>
        /// 元画像にBBOXを設定
        /// </summary>
        private void SetOrigBBox()
        {
            if ((BoundingBox != null) && ((OrigImage != null) || (MaskImage != null)))
            {
                // 画像の幅と高さ
                int width = (OrigImage != null) ? OrigImage.Width :MaskImage.Width;
                int height = (OrigImage != null) ? OrigImage.Height : MaskImage.Height;

                // 図形をクリア
                ClearOrigBBox();
                List<BoundingBox.BBoxShape> rects = BoundingBox.GetShapes(width, height);
                if ((rects != null) && (rects.Count > 0))
                {
                    int color_index = 0;
                    for (int i = 0; i < rects.Count; i++)
                    {
                        RectangleShape shape = new RectangleShape(string.Format("bbox_{0}", i), rects[i].Rectangle)
                        {
                            Text = BoundingBox.GetJapanese(rects[i].Name),
                            Color = CMap.Get(color_index),
                            ShowLable = true,
                            LabelFill = true,
                            Visible = CbShowBBox.Checked,
                        };
                        PbOrigImage.AddShape(shape);
                        color_index = (color_index + 64) & 0x0FF;
                    }
                    PbOrigImage.Refresh();
                }
            }
        }
        private void ClearOrigBBox()
        {
            PbOrigImage.RemovePattern(@"bbox_\d+");
        }

        /// <summary>
        /// BBOXのチェックが変更になった
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CbShowBBox_CheckedChanged(object sender, EventArgs e)
        {
            // 元画像側
            foreach(BaseShape shape in PbOrigImage.EnumerableShapes(@"bbox_\d+"))
            {
                shape.Visible = CbShowBBox.Checked;
            }
            PbOrigImage.Refresh();
        }
        /// <summary>
        /// キーポイントファイルを開く
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtKeyPointOpen_Click(object sender, EventArgs e)
        {
            if ((TbKeyPoint.Text.Trim().Length > 0) &&
                (File.Exists(TbKeyPoint.Text)))
            {
                if (KeyPoints != null)
                    KeyPoints = null;

                // 読み込みフォーマット
                KeyPoints.KeyPointType format = KeyPoints.KeyPointsTypeDef.GetItemType(CbKeyPointType, KeyPoints.KeyPointType.COCO); ;
                // BBoxファイルを読み込む
                KeyPoints = new KeyPoints(format, TbKeyPoint.Text);
                // 編集ボタンの有効無効
                BtNewKeyPoint.Enabled = (KeyPoints.Data.Count > 0);
                // KeyPointを送信
                SendKeyPoints();
                // KeyPointsを設定
                SetOrigKeyPoints();
            }

        }
        /// <summary>
        /// KeyPoint図形を削除
        /// </summary>
        private void ClearOrigKeyPoints()
        {
            PbOrigImage.RemovePattern(@"kpt_\d+");
        }

        /// <summary>
        /// 元画像にKeyPointを設定
        /// </summary>
        private void SetOrigKeyPoints()
        {
            if ((KeyPoints != null) && ((OrigImage != null) || (MaskImage != null)))
            {
                // 画像の幅と高さ
                int width = (OrigImage != null) ? OrigImage.Width : MaskImage.Width;
                int height = (OrigImage != null) ? OrigImage.Height : MaskImage.Height;

                // 図形をクリア
                ClearOrigKeyPoints();
                List<KeyPoints.KeyPointShape> pts = KeyPoints.GetShapes();
                if ((pts != null) && (pts.Count > 0))
                {
                    int color_index = 0;
                    for (int i = 0; i < pts.Count; i++)
                    {
                        PointShape shape = new PointShape(string.Format("kpt_{0}", i))
                        {
                            Text = KeyPoints.GetJapanese(pts[i].Name),
                            Point = pts[i].Point,
                            Color = CMap.Get(color_index),
                            ShowLable = ((string.IsNullOrEmpty(pts[i].Name) == false) & (CbShowKeyPointLabel.Checked)),
                            LabelFill = true,
                            MarkerType = BaseShape.MARKER_TYPE.CROSS,
                            LineWidth = 2.0F,
                            Visible = CbShowKeyPoints.Checked,
                        };
                        PbOrigImage.AddShape(shape);
                        color_index = (color_index + 64) & 0x0FF;
                    }
                    PbOrigImage.Refresh();
                }
            }
        }
        /// <summary>
        /// KeyPointsを送信
        /// </summary>
        private void SendKeyPoints()
        {
            if (KeyPoints != null)
            {
                string keypoints = KeyPoints.GetKeyPoints();
                string keypoints_label = KeyPoints.GetLabels();
                if ((string.IsNullOrEmpty(keypoints) == false) && (CmdExec != null))
                {
                    // コマンドを発行
                    CmdExec.ExecCommand("", ">");  // 空行を送信
                    CmdExec.ExecCommand("KP:" + keypoints, ">");
#if DEBUG
                    CmdExec.ExecCommand("KP!", ">");
#endif

                    if (string.IsNullOrEmpty(keypoints_label) == false)
                    {
                        // コマンドを発行
                        CmdExec.ExecCommand("", ">");  // 空行を送信
                        CmdExec.ExecCommand("LKP:" + keypoints_label, ">");
#if DEBUG
                        CmdExec.ExecCommand("LKP!", ">");
#endif
                    }
                }
            }
        }
        /// <summary>
        /// キーポイント表示切替
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CbShowKeyPoints_CheckedChanged(object sender, EventArgs e)
        {
            // 元画像側
            foreach (BaseShape shape in PbOrigImage.EnumerableShapes(@"kpt_\d+"))
            {
                shape.Visible = CbShowKeyPoints.Checked;
            }
            PbOrigImage.Refresh();
        }
        /// <summary>
        /// キーポイントラベル表示切替
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CbShowKeyPointLabel_CheckedChanged(object sender, EventArgs e)
        {
            // 元画像側
            foreach (BaseShape shape in PbOrigImage.EnumerableShapes(@"kpt_\d+"))
            {
                shape.ShowLable = CbShowKeyPointLabel.Checked;
            }
            PbOrigImage.Refresh();

        }
        /// <summary>
        /// 画像をクリップボードにコピー
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
		private void ToolStripMenuItemImageCopy_Click(object sender, EventArgs e)
		{
            if (sender is ToolStripMenuItem menu)
            {
                ContextMenuStrip root = menu.GetCurrentParent() as ContextMenuStrip;
                if ((root.SourceControl != null) &&
                    (root.SourceControl is ZoomPictureBox pictBox))
                {
                    bool drawMask = (pictBox.Equals(PbOrigImage)) ? CbShowMask.Checked : CbShowResultMask.Checked;
                    pictBox.ToClipBoard(true,drawMask);
                }
            }
		}
        /// <summary>
        /// 結果画像のマスク表示
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CbShowResultMask_CheckedChanged(object sender, EventArgs e)
        {
            // 結果画像
            PbResultImage.MaskShow = CbShowResultMask.Checked;
        }
        /// <summary>
        /// 結果画像のBBOX表示
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CbShowResultBBox_CheckedChanged(object sender, EventArgs e)
        {
            // 結果画像側
            foreach (BaseShape shape in PbResultImage.EnumerableShapes(@"bbox_\d+"))
            {
                shape.Visible = CbShowResultBBox.Checked;
            }
            PbResultImage.Refresh();

        }
        /// <summary>
        /// 結果画像のキーポイント表示
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CbShowResultKeyPoints_CheckedChanged(object sender, EventArgs e)
        {
            // 結果画像側
            foreach (BaseShape shape in PbResultImage.EnumerableShapes(@"kpt_\d+"))
            {
                shape.Visible = CbShowResultKeyPoints.Checked;
            }
            PbResultImage.Refresh();

        }
        /// <summary>
        /// 結果画像のキーポイントラベル表示
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CbResultShowKeyPointsLabel_CheckedChanged(object sender, EventArgs e)
        {
            // 結果画像側
            foreach (BaseShape shape in PbResultImage.EnumerableShapes(@"kpt_\d+"))
            {
                shape.ShowLable = CbResultShowKeyPointsLabel.Checked;
            }
            PbResultImage.Refresh();
        }
        /// <summary>
        /// 画像のチェック変更
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CbShowImage_CheckedChanged(object sender, EventArgs e)
        {
            PbOrigImage.ShowImage = CbShowImage.Checked;
        }
        /// <summary>
        /// 結果画像のチェック変更
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CbShowResultImage_CheckedChanged(object sender, EventArgs e)
        {
            PbResultImage.ShowImage = CbShowResultImage.Checked;
        }
        /// <summary>
        /// メニューから終了
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ToolStripMenuItemFileExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CompositionForm form = new CompositionForm();
            form.ShowDialog();
        }
    }
}
