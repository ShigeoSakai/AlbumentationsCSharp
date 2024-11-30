﻿using FilterBase;
using SSTools.Shape;
using System;
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
        /// 画像フィルタ文字列
        /// </summary>
        private const string ImgFilter = "画像ファイル|*.bmp;*.png;*.jpg;*.jpeg;*.tif;*.tiff|" +
            "ビットマップファイル|*.bmp|" +
            "PNGファイル|*.png|" +
            "JPEGファイル|*.jpg;*.jpeg|" +
            "TIFFファイル|*.tif;*.tiff|" +
            "全てのファイル|*.*";
        /// <summary>
        /// BBox
        /// </summary>
        private BoundingBox BoundingBox = null;

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

            // プラグインマネージャ初期化
            PluginManager.LoadPlugins(Path.Combine(Directory.GetCurrentDirectory(), "plugins"));

            // コンボボックスを生成
            PluginManager.MakeCategoryComboBox(CbCategory);

            // BBoxのコンボボックス作成
            BBoxFormatClass.MakeComboBox(CbBBoxType,BBoxFormat.COCO);

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
        private void AlbumentationsVersionGet(object sender, string sendCmd, string resp, bool isOK)
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)delegate { AlbumentationsVersionGet(sender, sendCmd, resp, isOK); });
                return;
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

                    // 図形をクリア
                    PbOrigImage.ClearShape();
                    // マスクをクリア
                    PbOrigImage.MaskImage = null;
                    OrigImage = bmp;
                    PbOrigImage.Image = bmp;
                    // コマンド送信
                    if (CmdExec != null)
                    {
                        CmdExec.ExecCommand("", ">");  // 空行を送信
                        CmdExec.ExecCommand("IMG:" + ImageFilePath, ">");
                        CmdExec.ExecCommand("IMG!");
                        CmdExec.ExecCommand("", ">");  // 空行を送信
                        CmdExec.ExecCommand("MASK:");   // マスク画像を消去

                    }
                    // マスク画像と図形をクリアする
                    if (MaskImage != null)
                    {
                        MaskImage.Dispose();
                        MaskFilePath = string.Empty;
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
                    MaskImage = bmp;
                    // マスク画像の設定
                    PbOrigImage.MaskImage = MaskImage;

                    // コマンド送信
                    if (CmdExec != null)
                    {
                        CmdExec.ExecCommand("", ">");  // 空行を送信
                        CmdExec.ExecCommand("MASK:" + MaskFilePath, ">");
                        CmdExec.ExecCommand("MASK!");
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
            // 結果画像
            PbResultImage.MaskShow = CbShowMask.Checked;
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
            if (ctrl.Require.HasFlag(TRANSFORM_TARGET.BBOX)) result = false;
            if (ctrl.Require.HasFlag(TRANSFORM_TARGET.KEY_POINT)) result = false;

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
            if (ctrl != null)
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
                        alb_cmd = string.Format("{0}.Compose([{1}])", "A", alb_cmd);

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
        private void ExecCallback(object sender, string cmd, string recvCmd, bool isOK)
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)delegate { ExecCallback(sender, cmd, recvCmd, isOK); });
                return;
            }
            if ((isOK) && (cmd.StartsWith("TR:")))
            {
                if (File.Exists("result.bmp"))
                {
                    Bitmap bmp = null;
                    using (FileStream fs = new FileStream("result.bmp", FileMode.Open, FileAccess.Read))
                        bmp = new Bitmap(fs);
                    if (bmp != null)
                    {
                        PbResultImage.Image = bmp;
                    }
                }
                if (File.Exists("mask.bmp"))
                {
                    Bitmap mask_bmp = null;
                    using (FileStream fs = new FileStream("mask.bmp", FileMode.Open, FileAccess.Read))
                        mask_bmp = new Bitmap(fs);
                    if (mask_bmp != null)
                    {
                        PbResultImage.MaskImage = mask_bmp;
                    }
                }

            }
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
                // BBOXを設定
                SetOrigBBox();
            }
            form.Dispose();
            form = null;
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
                PbOrigImage.ClearShape();
                List<BoundingBox.BBoxShape> rects = BoundingBox.GetShapes(width, height);
                if ((rects != null) && (rects.Count > 0))
                {
                    int color_index = 0;
                    for (int i = 0; i < rects.Count; i++)
                    {
                        RectangleShape shape = new RectangleShape(string.Format("bbox_{0}", i), rects[i].Rectangle)
                        {
                            Text = rects[i].Name,
                            Color = CMap.Get(color_index),
                            ShowLable = true,
                            LabelFill = true,
                        };
                        PbOrigImage.AddShape(shape);
                        color_index = (color_index + 64) & 0x0FF;
                    }
                    PbOrigImage.Refresh();
                }
            }
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
    }
}