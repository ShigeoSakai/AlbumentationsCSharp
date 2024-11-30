using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilterBase.Parts
{
    public partial class CustomColorDialog : Form
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public CustomColorDialog()
        {
            InitializeComponent();

            // 初期表示は拡張しない
            IsExpand = false;

            // カラーパレットを生成
            MakePalette(_colorMode);
            StorePalleteImage(_colorMode);

            // 色の初期値は黒
            Color = Color.Black;
        }
        /// <summary>
        /// 拡張可能か？
        /// </summary>
        public bool AllowExpand
        {
            get => BtExpand.Enabled;
            set
            {
                BtExpand.Enabled = value;
                // 拡張不可で、拡張していたら戻す
                if ((value == false) && (IsExpand))
                    IsExpand = false;
            }
        }
        /// <summary>
        /// フルオープン
        /// </summary>
        private bool _fullopen = false;
        /// <summary>
        /// フルオープンプロパティ
        /// </summary>
        public bool FullOpen
        {
            get => _fullopen;
            set
            {
                _fullopen = value;
                // フルオープンなら拡張許可
                if (value)
                    AllowExpand = true;
                // 拡張する
                IsExpand = true;
            }
        }
        /// <summary>
        /// 拡張状態
        /// </summary>
        private bool _isExpand = false;
        private bool IsExpand
        {
            get => _isExpand;
            set
            {   // 拡張可能の場合のみ
                if (AllowExpand)
                {
                    _isExpand = value;

                    if (_isExpand)
                        BtExpand.Text = "<< 色の選択";
                    else
                        BtExpand.Text = "色の選択 >> ";
                    // 拡張 or 縮小
                    ExecPanel2Layout(_colorMode,_isExpand);
                }
            }
        }

        /// <summary>
        /// 色
        /// </summary>
        private HSLColor _HSL = new HSLColor(Color.Black);

        private HSLColor HSL
        {
            get => _HSL;
            set
            {
                _HSL = value;
                TbHSL_H.Text = string.Format("{0:#0.0}", _HSL.H);
                TbHSL_S.Text = string.Format("{0:0.00}", _HSL.S);
                TbHSL_L.Text = string.Format("{0:0.00}", _HSL.L);
                TbBright.Value = (int)(_HSL.L * 100);

                Color c = _HSL.Color;
                // ラベルの色
                LbColor.BackColor = c;
                TbR.Text = c.R.ToString();
                TbG.Text = c.G.ToString();
                TbB.Text = c.B.ToString();
                TbA.Text = c.A.ToString();
                // HSVを求める
                HSVColor hsv = _HSL.toHSV();
                TbHSV_H.Text = hsv.H.ToString();
                TbHSV_S.Text = hsv.S.ToString();
                TbHSV_V.Text = hsv.V.ToString();
                PbColor.Refresh();
            }
        }
        /// <summary>
        /// 色プロパティ
        /// </summary>
        public Color Color
        {
            get => HSL.ToRGB();
            set
            {
                // HSLで格納する
                HSL = new HSLColor(value);
            }
        }

        /// <summary>
        /// 色選択のモード
        /// </summary>
        public enum COLOR_MODE
        {
            GRAY = 0,
            RGB = 1,
            RGBA = 2,
        }
        /// <summary>
        /// 色選択モード
        /// </summary>
        private COLOR_MODE _colorMode = COLOR_MODE.RGB;
        /// <summary>
        /// 色選択モードプロパティ
        /// </summary>
        public COLOR_MODE ColorMode
        {
            get => _colorMode;
            set
            {
                if (_colorMode != value)
                {
                    _colorMode = value;
                    // α値の表示・非表示
                    LbA.Visible = TbA.Visible = (_colorMode == COLOR_MODE.RGBA);

                    // カラーパレットを生成
                    MakePalette(_colorMode);
                    StorePalleteImage(_colorMode);
                    // 拡張 or 縮小
                    ExecPanel2Layout(_colorMode, _isExpand);
                }
            }
        }

        #region [HSL Color]
        /// <summary>
        /// HSLカラー構造体
        /// </summary>
        private class HSLColor
        {
            public float H { get; set; } = 160.0F;
            public float S { get; set; } = 0.0F;
            public float L { get; set; } = 1.0F;

            /// <summary>
            /// コンストラクタ
            /// </summary>
            /// <param name="color"></param>
            public HSLColor(Color color)
            {
                fromRGB(color);
            }
            /// <summary>
            /// コンストラクタ
            /// </summary>
            /// <param name="h"></param>
            /// <param name="s"></param>
            /// <param name="l"></param>
            public HSLColor(float h, float s, float l)
            {
                H = h;
                S = s;
                L = l;
            }
            public HSLColor(HSVColor hsv) : this(hsv.toHSL())
            {
            }
            /// <summary>
            /// コピーコンストラクタ
            /// </summary>
            /// <param name="src"></param>
            public HSLColor(HSLColor src)
            {
                H = src.H;
                S = src.S;
                L = src.L;
            }

            /// <summary>
            /// 色の設定と取得
            /// </summary>
            public Color Color
            {
                get => toRGB(H,S,L);
                set => fromRGB(value);
            }

            /// <summary>
            /// RGB=>HSL変換
            /// </summary>
            /// <param name="color"></param>
            public void fromRGB(Color color)
            {
                H = color.GetHue();
                S = color.GetSaturation();
                if ((H == 0) && (S == 0))
                    H = 160.0F;
                L = color.GetBrightness();
            }
            public Color ToRGB()
            {
                return toRGB(H,S,L);
            }
            /// <summary>
            /// HSL=>RGB
            /// </summary>
            /// <param name="h">0.0～360.0</param>
            /// <param name="s">0.0～1.0</param>
            /// <param name="l">0.0～1.0</param>
            /// <returns></returns>
            public static Color toRGB(float h, float s, float l)
            {
                h = h % 360.0F;
                if (h < 0) h += 360.0F;

                float r1, g1, b1;
                if (s == 0.0F)
                {
                    r1 = g1 = b1 = l;
                }
                else
                {
                    h /= 60f;
                    int i = (int)Math.Floor(h);
                    float f = h - i;
                    float c = 2f * s * ((l < 0.5F) ? l : (1.0F - l));
                    float m = l - c / 2f;
                    float p = c + m;
                    float q = l + ((i % 2 == 0) ? 1.0F : -1.0F) * c * (f - 0.5f);
                    switch (i)
                    {
                        case 0:
                            r1 = p; g1 = q; b1 = m;
                            break;
                        case 1:
                            r1 = q; g1 = p; b1 = m;
                            break;
                        case 2:
                            r1 = m; g1 = p; b1 = q;
                            break;
                        case 3:
                            r1 = m; g1 = q; b1 = p;
                            break;
                        case 4:
                            r1 = q; g1 = m; b1 = p;
                            break;
                        default: // i == 5
                            r1 = p; g1 = m; b1 = q;
                            break;
                    }
                }
                return Color.FromArgb(
                    (int)Math.Round(r1 * 255f),
                    (int)Math.Round(g1 * 255f),
                    (int)Math.Round(b1 * 255f));
            }
            private float[] sl2sv(float s,float l)
            {
                float sf = (s < 0.0F) ? 0.0F : (s > 1.0F) ? 1.0F : s;
                float lf = (l < 0.0F) ? 0.0F : (l > 1.0F) ? 1.0F : l;

                float n = lf + sf * Math.Min(lf, 1.0F - lf);
                float s_ = (n != 0) ? (1 - lf / n) * 2 : sl2sv(sf, 0.5F)[0];
                return new float[2] {s_,n };
            }
            public HSVColor toHSV()
            {
                float[] sv = sl2sv(S, L);
                return new HSVColor((int)(H + 0.5F), (int)(sv[0]*255.0F),(int)(sv[1]*255.0F));
            }
        }
        #endregion [HSL Color]

        #region [HSV Color]
        /// <summary>
        /// HSVカラー構造体
        /// </summary>
        private class HSVColor
        {
            public int H { get; set; }
            public int S { get; set; }
            public int V { get; set; }
            /// <summary>
            /// コンストラクタ
            /// </summary>
            /// <param name="color"></param>
            public HSVColor(Color color)
            {
                fromRGB(color);
            }
            /// <summary>
            /// コンストラクタ
            /// </summary>
            /// <param name="h"></param>
            /// <param name="s"></param>
            /// <param name="v"></param>
            public HSVColor(int h, int s, int v)
            {
                H = h;
                S = s;
                V = v;
            }
            public HSVColor(HSLColor hsl) : this(hsl.toHSV()) { }
            /// <summary>
            /// コピーコンストラクタ
            /// </summary>
            /// <param name="src"></param>
            public HSVColor(HSVColor src)
            {
                H = src.H;
                S = src.S;
                V = src.V;
            }
            /// <summary>
            /// 色の設定と取得
            /// </summary>
            public Color Color
            {
                get => toRGB(H, S, V);
                set => fromRGB(value);
            }
            /// <summary>
            /// RGBの定義
            /// </summary>
            private enum MAX_RGB
            {
                R = 0,
                G = 1,
                B = 2,
            }

            /// <summary>
            /// RGB=>HSL変換
            /// </summary>
            /// <param name="color"></param>
            private void fromRGB(Color color)
            {
                // 色相を求める
                //    R・G・Bのうち、最も大きな値をMAX、最も小さな値をMINとして
                //      Rが最大値の場合色の相 H = 60 × ((G - B) ÷ (MAX - MIN))
                //      Gが最大値の場合色の相 H = 60 × ((B - R) ÷ (MAX - MIN)) +120
                //      Bが最大値の場合色の相 H = 60 × ((R - G) ÷ (MAX - MIN)) +240
                //    R・G・Bが同じ値の場合の色相 H = 0
                // 彩度を求める
                //    R・G・Bのうち、最も大きな値をMAX、最も小さな値をMINとして
                //    彩度 S = (MAX - MIN) ÷ MAX
                // 明度を求める
                //    R・G・Bのうち、最も大きな値をMAXとして
                //    明度 V = MAX

                int max = color.R; MAX_RGB maxRGB = MAX_RGB.R;
                int min = color.R;
                if (max < color.G) { max = color.G; maxRGB = MAX_RGB.G; }
                if (max < color.B) { max = color.B; maxRGB = MAX_RGB.B; }
                if (min > color.G) { min = color.G; }
                if (min > color.B) { min = color.B; }

                if ((color.R == color.G) && (color.R == color.B))
                    H = 0;
                else
                {
                    switch (maxRGB)
                    {
                        case MAX_RGB.R:
                            H = (int)(60 * ((float)(color.G - color.B) / (max - min)));
                            break;
                        case MAX_RGB.G:
                            H = (int)(60 * ((float)(color.B - color.R) / (max - min))) + 120;
                            break;
                        default:
                            H = (int)(60 * ((float)(color.R - color.G) / (max - min))) + 240;
                            break;
                    }
                    if (H < 0) H += 360;
                    if (H > 360) H -= 360;
                }
                if (max != 0)
                    S = (int)((float)(max - min) / max * 255F);
                else
                    S = 0;
                V = max;
            }
            /// <summary>
            /// HSV=>RGB
            /// </summary>
            /// <param name="h"></param>
            /// <param name="s"></param>
            /// <param name="v"></param>
            /// <returns></returns>
            public static Color toRGB(int h, int s, int v)
            {
                // 最大値と最小値を求める
                //   RGBからHSVへの変換式を逆算することで、
                //   HSVの値からRGBの最大値と最小値を求める式を導くことができます。
                //  S・Vの範囲が0～255の場合の場合は下記のとおりです。
                //   最大値 MAX = V
                //   最小値 MIN = MAX - ((S ÷ 255) × MAX)
                // RGB値を求める
                //   色相はRGBの最大値・最小値を使って求めているため、
                //   逆算することでどの色が最大値・最小値になるかがわかります。
                //   残った色も変換式の逆算で求めます。
                //   Hの範囲が0～360、S・Vの範囲が0～255の場合は下記のとおりです。
                //
                //   Hが0～60の場合
                //     R = MAX
                //     G = (H ÷ 60) × (MAX - MIN) + MIN
                //     B = MIN
                //   Hが60～120の場合
                //     R = ((120 - H) ÷ 60) × (MAX - MIN) + MIN
                //     G = MAX
                //     B = MIN
                //   Hが120～180の場合
                //     R = MIN
                //     G = MAX
                //     B = ((H - 120) ÷ 60) × (MAX - MIN) + MIN
                //   Hが180～240の場合
                //     R = MIN
                //     G = ((240 - H) ÷ 60) × (MAX - MIN) + MIN
                //     B = MAX
                //   Hが240～300の場合
                //     R = ((H - 240) ÷ 60) × (MAX - MIN) + MIN
                //     G = MIN
                //     B = MAX
                //   Hが300～360の場合
                //     R = MAX
                //     G = MIN
                //     B = ((360 - H) ÷ 60) × (MAX - MIN) + MIN

                if (h < 0) h += 360;
                if (h > 360) h -= 360;
                if (s < 0) s = 0;
                if (s > 255) s = 255;
                if (v < 0) v = 0;
                if (v > 255) v = 255;


                int max = v;
                int min = v - (int)(((float)s / 255.0F) * v);
                int r, g, b;
                if (h < 60)
                {
                    r = max; b = min;
                    g = (int)(((float)h / 60.0F) * (max - min)) + min;
                }
                else if (h < 120)
                {
                    g = max; b = min;
                    r = (int)(((float)(120 - h) / 60.0F) * (max - min)) + min;
                }
                else if (h < 180)
                {
                    g = max; r = min;
                    b = (int)(((float)(h - 120) / 60.0F) * (max - min)) + min;
                }
                else if (h < 240)
                {
                    b = max; r = min;
                    g = (int)(((float)(240 - h) / 60.0F) * (max - min)) + min;
                }
                else if (h < 300)
                {
                    b = max; g = min;
                    r = (int)(((float)(h - 240) / 60.0F) * (max - min)) + min;
                }
                else
                {
                    r = max; g = min;
                    b = (int)(((float)(360 - h) / 60.0F) * (max - min)) + min;
                }
                return Color.FromArgb(r, g, b);
            }
            private static float[] sv2sl(float s, float v)
            {
                s = (s < 0.0F) ? 0.0F : (s > 1.0F) ? 1.0F : s;
                v = (v < 0.0F) ? 0.0F : (v > 1.0F) ? 1.0F : v;
                float n = v * (1 - s / 2);
                float s_ = (n != 0.0F) ? (v - n) / Math.Min(n, 1.0F - n) : sv2sl(s, 0.5F)[0];
                return new float[] { s_, v };
            }
            public HSLColor toHSL()
            {
                return toHSL(H, S, V);
            }
            public static HSLColor toHSL(int h,int s, int v)
            {
                float[] sl = sv2sl((float)s / 255.0F, (float)v / 255.0F);
                return new HSLColor((float)h, sl[0], sl[1]);
            }

        }
        #endregion [HSV Color]


        /// <summary>
        /// デフォルトのカラーパレットを生成
        /// </summary>
        /// <param name="colorMode"></param>
        private void MakePalette(COLOR_MODE colorMode)
        {
            Label[] labels = new Label[]
            {
                LbColor00, LbColor01, LbColor02, LbColor03, LbColor04, LbColor05, LbColor06, LbColor07,
                LbColor10, LbColor11, LbColor12, LbColor13, LbColor14, LbColor15, LbColor16, LbColor17,
                LbColor20, LbColor21, LbColor22, LbColor23, LbColor24, LbColor25, LbColor26, LbColor27,
                LbColor30, LbColor31, LbColor32, LbColor33, LbColor34, LbColor35, LbColor36, LbColor37,
                LbColor40, LbColor41, LbColor42, LbColor43, LbColor44, LbColor45, LbColor46, LbColor47,
                LbColor50, LbColor51, LbColor52, LbColor53, LbColor54, LbColor55, LbColor56, LbColor57,
                LbColor60, LbColor61, LbColor62, LbColor63, LbColor64, LbColor65, LbColor66, LbColor67,
                LbColor70, LbColor71, LbColor72, LbColor73, LbColor74, LbColor75, LbColor76, LbColor77,
            };
            if (colorMode == COLOR_MODE.GRAY)
            {
                for (int i = 0; i < labels.Length; i++)
                {
                    labels[i].BackColor = Color.FromArgb(i*4, i*4, i * 4);
                }
                // 最後を白に
                labels[labels.Length-1].BackColor = Color.FromArgb(255, 255, 255);
            }
            else
            {   // 256色 8bit -- R:3bit(0-7) G:3bit(0-7) B:2bit(0-3)
                //  64色 6bit -- R:2bit(0-3) G:2bit(0-3) B:2bit(0-3)
                //               0 : 0  1 : 85   2: 170  3:255
                for (int i = 0; i < labels.Length; i++)
                {
                    int r_i = i >> 4;
                    int g_i = (i >> 2) & 0x03;
                    int b_i = i & 0x03;

                    labels[i].BackColor = Color.FromArgb(r_i * 85, g_i * 85, b_i * 85);
                }
            }
        }

        /// <summary>
        /// 色のクリック
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LbColor_Click(object sender, EventArgs e)
        {
            if (sender is Label label)
            {
                Color = label.BackColor;
            }
        }
        /// <summary>
        /// 色のダブルクリック
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LbColor_DoubleClick(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 拡張をクリック
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtExpand_Click(object sender, EventArgs e)
        {
            // 拡張状態を反転
            IsExpand = !IsExpand;
        }
        /// <summary>
        /// OKボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtOK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }
        /// <summary>
        /// キャンセルボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtCancel_Click(object sender, EventArgs e)
        {
            DialogResult=DialogResult.Cancel;
            this.Close();
        }

        /// <summary>
        /// パレットイメージを格納
        /// </summary>
        /// <param name="color_mode"></param>
        private void StorePalleteImage(COLOR_MODE color_mode)
        {
            if (PbColor.Image != null)
            {
                PbColor.Image.Dispose();
                PbColor.Image = null;
            }
            if (color_mode == COLOR_MODE.GRAY)
                PbColor.Image = MakeGrayImage();
            else
                PbColor.Image = MakeColorImage();

        }
        /// <summary>
        /// カラー用のイメージ作成
        /// </summary>
        /// <returns></returns>
        private Bitmap MakeColorImage()
        {
            Bitmap bmp = new Bitmap(380, 276, PixelFormat.Format32bppArgb);
            Graphics g = Graphics.FromImage(bmp);
            g.FillRectangle(new SolidBrush(Color.Transparent),0,0,bmp.Width,bmp.Height);
            g.Dispose();

            BitmapData data = bmp.LockBits(new Rectangle(0, 0, bmp.Width, bmp.Height), ImageLockMode.WriteOnly, PixelFormat.Format32bppArgb);
            byte[] wrtData = new byte[data.Stride];
            for (int row = 10; row < 266; row++)
            {
                IntPtr wrt_p = data.Scan0 + (row * data.Stride) + (4*10) ;

                int pos = 0;
                for (int col = 0; col < 360; col++)
                {
                    Color c = HSLColor.toRGB((float)col, 1.0F -((float)row / 256.0F), 0.5F);
                    wrtData[pos] = c.B;
                    wrtData[pos + 1] = c.G;
                    wrtData[pos + 2] = c.R;
                    wrtData[pos + 3] = 255;
                    pos += 4;                   
                }
                Marshal.Copy(wrtData,0,wrt_p, data.Stride);
            }
            bmp.UnlockBits(data);
            return bmp;
        }
        /// <summary>
        /// グレースケール用のイメージ作成
        /// </summary>
        /// <returns></returns>
        private Bitmap MakeGrayImage()
        {
            Bitmap bmp = new Bitmap(276, 276, PixelFormat.Format32bppArgb);
            Graphics g = Graphics.FromImage(bmp);
            g.FillRectangle(new SolidBrush(Color.Transparent), 0, 0, bmp.Width, bmp.Height);
            for (int row = 0; row < 16; row ++)
            {
                for (int col = 0; col < 16; col ++)
                {
                    int c = row * 16 + col;
                    g.FillRectangle(new SolidBrush(Color.FromArgb(255,c, c, c)),
                        (col * 16 + 10), (row * 16) + 10, 16, 16);
                }
            }
            g.Dispose();
            return bmp;
        }

        /// <summary>
        /// Panel2のサイズを算出
        /// </summary>
        /// <param name="color_mode"></param>
        /// <returns></returns>
        private int CalcPanel2Width(COLOR_MODE color_mode)
        {
            int pb_width = 360 + 20 + 2;
            if (color_mode == COLOR_MODE.GRAY)
                pb_width = 256 + 20 + 2;
            int result_width = PbColor.Location.X + pb_width;

            if (color_mode != COLOR_MODE.GRAY)
                result_width += 3 + TbBright.Width + 3;

            return result_width;
        }
        /// <summary>
        /// レイアウトの実行
        /// </summary>
        /// <param name="color_mode"></param>
        /// <param name="isExpand"></param>
        private void ExecPanel2Layout(COLOR_MODE color_mode,bool isExpand)
        {
            // TbBright ... (371,50) (45, 258)    416 +3 = 419 
            // PbColor  ... (3, 48) (362, 258),
            // Panel1 ... 226 ... Spea = 1
            // (649, 393) どこかに3 

            int panel1_width = MainSplitContainer.Panel1MinSize + 3 + MainSplitContainer.SplitterWidth;
            int panel2_width = CalcPanel2Width(color_mode);
            Size clientSize = new Size(panel1_width + panel2_width,this.ClientSize.Height);
            int pbsize_width = ((color_mode == COLOR_MODE.GRAY) ? (256 + 20): (360 + 20)) + 2;

            SuspendLayout();

            MainSplitContainer.Panel2Collapsed = !isExpand;
            if (isExpand)
            {
                this.ClientSize = clientSize;
                PbColor.Location = new Point(3, 21);
                PbColor.Size = new Size(pbsize_width,PbColor.Height);
                TbBright.Visible = (color_mode != COLOR_MODE.GRAY);
                if (color_mode != COLOR_MODE.GRAY)
                    TbBright.Location = new Point(PbColor.Location.X + PbColor.Width + 3,TbBright.Location.Y);

                GbHSLColor.Visible = GbHSVColor.Visible = (color_mode != COLOR_MODE.GRAY);

            }
            else
            {
                this.ClientSize = new Size(MainSplitContainer.Panel1MinSize, this.ClientSize.Height);
            }
            ResumeLayout();
        }
        /// <summary>
        /// パレット上でマウスクリック
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PbColor_Click(object sender, EventArgs e)
        {
            // クリック座標
            Point pt = PbColor.PointToClient(Cursor.Position);
            int x = pt.X - 10;
            int y = pt.Y - 10;
            if ((x < 0) || (x >= (PbColor.Width - 22)) || (y < 0) || (y >= (PbColor.Height - 22))) return;
            if (_colorMode != COLOR_MODE.GRAY)
            {   // カラー
                float h = (float)x;
                float s = 1.0F - ((float)y / 256.0F);
                float l = 0.5F;
                HSL = new HSLColor(h, s, l);
            }
            else
            {   // Grayscale
                int dx = x / 16;
                int dy = (y & 0x0F0) + dx;
                HSL = new HSLColor(Color.FromArgb(dy, dy, dy));
            }


        }
        /// <summary>
        /// マウスの移動
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PbColor_MouseMove(object sender, MouseEventArgs e)
        {
            int x = e.X - 10;
            int y = e.Y - 10;
            if ((x < 0) || (x >= (PbColor.Width - 22))|| (y < 0) || (y >= (PbColor.Height - 22))) return; 

            if (_colorMode != COLOR_MODE.GRAY)
            {   // カラー
                float h = (float)x;
                float s = 1.0F - ((float)y / 256.0F);
                float l = (float)TbBright.Value / 100.0F;
                Color c = HSLColor.toRGB(h,s,l);
                LbPosition.Text = string.Format("R:{0:##0} G:{1:##0} B:{2:##0}\r\nH:{3:##0} S:{4:0.00} L:{5:0.00}",
                    c.R,c.G,c.B,h,s,l);
            }
            else
            {   // Grayscale
                int dx = x / 16;
                int dy = (y & 0x0F0) + dx;
                LbPosition.Text = string.Format("Value:{0}  --({1},{2})", dy,x,y);
            }
        }

        /// <summary>
        /// ペイント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PbColor_Paint(object sender, PaintEventArgs e)
        {
            if (e.Graphics != null)
            {
                Graphics g = e.Graphics;
                if (_colorMode != COLOR_MODE.GRAY)
                {
                    Color pen_color = HSLColor.toRGB(HSL.H - 180,1.0F - HSL.S, 0.5F);

                    float x = HSL.H + 10.0F;
                    float y = ((1.0F - HSL.S) * 256.0F) + 10.0F;
                    g.DrawLine(new Pen(pen_color, 2.0F), x - 10.0F, y, x - 2.0F, y);
                    g.DrawLine(new Pen(pen_color, 2.0F), x + 2.0F, y, x + 10.0F, y);
                    g.DrawLine(new Pen(pen_color, 2.0F), x, y -10.0F, x, y  - 2.0F);
                    g.DrawLine(new Pen(pen_color, 2.0F), x, y + 2.0F, x, y + 10.0F);
                }
                else
                {
                    int c = Color.R;
                    int x = (c & 0x0F) * 16 + 18;
                    int y = (c & 0x0F0)  + 18;

                    Color pen_color = Color.Red;

                    g.DrawLine(new Pen(pen_color, 2.0F), x - 10, y, x - 2, y);
                    g.DrawLine(new Pen(pen_color, 2.0F), x + 2, y, x + 10, y);
                    g.DrawLine(new Pen(pen_color, 2.0F), x, y - 10, x, y - 2);
                    g.DrawLine(new Pen(pen_color, 2.0F), x, y + 2, x, y + 10);

                }
            }
        }
        /// <summary>
        /// スライダーの値が変わった
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TbBright_ValueChanged(object sender, EventArgs e)
        {
            float l = (float)TbBright.Value / 100.0F;
            HSL = new HSLColor(HSL.H, HSL.S, l);
        }
        /// <summary>
        /// RGB値のテキストボックス変更
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RGB_TextChanged(object sender, EventArgs e)
        {
            if ((TbR.Text.Trim().Length > 0) && (byte.TryParse(TbR.Text, out byte b_r)))
            {
                if (_colorMode != COLOR_MODE.GRAY)
                {
                    if ((TbG.Text.Trim().Length > 0) && (byte.TryParse(TbG.Text, out byte b_g)) &&
                        (TbB.Text.Trim().Length > 0) && (byte.TryParse(TbB.Text, out byte b_b)))
                    {
                        if ((_colorMode == COLOR_MODE.RGBA) &&
                            (TbA.Text.Trim().Length > 0) && (byte.TryParse(TbR.Text, out byte b_a)))
                        {
                            HSL = new HSLColor(Color.FromArgb(b_a, b_r, b_g, b_b));
                        }
                        else if (_colorMode == COLOR_MODE.RGB)
                            HSL = new HSLColor(Color.FromArgb(b_r, b_g, b_b));

                    }
                }
                else
                    HSL = new HSLColor(Color.FromArgb(b_r, b_r, b_r));
            }
        }
        /// <summary>
        /// HSVのテキストボックス変更
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HSV_TextChanged(object sender, EventArgs e)
        {
            if ((TbHSV_H.Text.Trim().Length > 0) && (int.TryParse(TbHSV_H.Text, out int hsv_h)) &&
                (hsv_h >= 0) && (hsv_h < 360) &&
                (TbHSV_S.Text.Trim().Length > 0) && (int.TryParse(TbHSV_S.Text, out int hsv_s)) &&
                (hsv_s >= 0) && (hsv_s < 256) &&
                (TbHSV_V.Text.Trim().Length > 0) && (int.TryParse(TbHSV_V.Text, out int hsv_v)) &&
                (hsv_v >= 0) && (hsv_v < 256))
                HSL = HSVColor.toHSL(hsv_h, hsv_s, hsv_v);
        }
        /// <summary>
        /// HSLのテキストボックス変更
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HSL_TextChanged(object sender, EventArgs e)
        {
            if ((TbHSL_H.Text.Trim().Length > 0) && (float.TryParse(TbHSL_H.Text, out float hsl_h)) &&
                (hsl_h >= 0.0F) && (hsl_h < 360.0F) &&
                (TbHSL_S.Text.Trim().Length > 0) && (float.TryParse(TbHSL_S.Text, out float hsl_s)) &&
                (hsl_s >= 0.0F) && (hsl_s <= 1.0F) &&
                (TbHSL_L.Text.Trim().Length > 0) && (float.TryParse(TbHSL_L.Text, out float hsl_l)) &&
                (hsl_l >= 0.0F) && (hsl_l < 1.0F))
                HSL = new HSLColor(hsl_h, hsl_s, hsl_l);
        }
    }
}
