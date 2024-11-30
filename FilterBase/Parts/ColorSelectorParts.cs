using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace FilterBase.Parts
{
    /// <summary>
    /// 色選択コントロール
    /// </summary>
    public partial class ColorSelectorParts : FilterBase.Parts.PartsBase
    {
        /// <summary>
        /// Color or Gray
        /// </summary>
        private bool _isColor = true;
        /// <summary>
        /// Color or Grayプロパティ
        /// </summary>
        [Category("値入力")]
        public bool IsColor
        {
            get => _isColor;
            set
            {
                _isColor = value;
                // 色モードの変更
                ChangeColor();
            }
        }
        /// <summary>
        /// 色
        /// </summary>
        [Category("値入力")]
        public Color Color
        {
            get
            {
                if (_isColor)
                {   // そのまま返す
                    return LbColor.BackColor;
                }
                // R成分のみ
                return Color.FromArgb(LbColor.BackColor.R, LbColor.BackColor.R, LbColor.BackColor.R);
            }
            set
            {   // 値の設定
                SetLabelColor(value);
            }
        }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public ColorSelectorParts()
        {
            InitializeComponent();
            // レイアウト実行
            ExecLayout();
        }

        /// <summary>
        /// 色モードの変更
        /// </summary>
        private void ChangeColor()
        {
            if (_isColor)
            {
                // ボタンアイコンの変更
                LbGrayColor.Image = global::FilterBase.Properties.Resources.Color;
            }
            else
            {
                // ボタンアイコンの変更
                LbGrayColor.Image = global::FilterBase.Properties.Resources.Gray;
            }
            // ラベル色の変更
            SetLabelColor(LbColor.BackColor);
        }
        /// <summary>
        /// 色モードの変更
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LbGrayColor_Click(object sender, EventArgs e)
        {
            _isColor = !_isColor;
            // 色モードの変更
            ChangeColor();
        }

        /// <summary>
        /// ラベルのクリック
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LbColor_Click(object sender, EventArgs e)
        {
            CustomColorDialog.COLOR_MODE mode = CustomColorDialog.COLOR_MODE.RGB;
            Color color = LbColor.BackColor;
            if (IsColor == false)
            {
                mode = CustomColorDialog.COLOR_MODE.GRAY;
                color = Color.FromArgb(color.R, color.R, color.R);
            }

            // 色設定ダイアログを開く
            CustomColorDialog colorDialog = new CustomColorDialog()
            {
                ColorMode = mode,
                Color = color,
            };
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                // 色更新
                SetLabelColor(colorDialog.Color); 
            }
            colorDialog.Dispose();
            colorDialog = null;
        }
        private Color ShiftColor(Color color)
        {
            int r = (color.R + 128) & 0x0FF;
            int g = (color.G + 128) & 0x0FF;
            int b = (color.B + 128) & 0x0FF;
            return Color.FromArgb(r, g, b);
        }
        /// <summary>
        /// 色を設定する
        /// </summary>
        /// <param name="color"></param>
        /// <param name="isTextBoxSet">TextBoxの内容を更新するか？</param>
        private void SetLabelColor(Color color, bool isTextBoxSet = true)
        {
            IsTextboxChanging = isTextBoxSet;
            if (IsColor)
            {
                LbColor.BackColor = color;
                if (isTextBoxSet)
                    TbValue.Text = string.Format("({0},{1},{2})",
                        color.R, color.G, color.B);
            }
            else
            {
                LbColor.BackColor = Color.FromArgb(color.R, color.R, color.R);
                if (isTextBoxSet)
                    TbValue.Text = color.R.ToString();
            }
            LbColor.ForeColor = ShiftColor(LbColor.BackColor);
            IsTextboxChanging = false;

            // イベントを発行する
            OnParameterChange(LbColor.BackColor);
        }

        private volatile bool IsTextboxChanging = false;

        /// <summary>
        /// テキストボックスの中身が変更になった
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TbValue_TextChanged(object sender, EventArgs e)
        {
            if (IsTextboxChanging == false)
            {
                string text = TbValue.Text.Trim();
                if ((text.StartsWith("(")) == (text.EndsWith(")")))
                {   // 正常入力
                    if (text.StartsWith("("))
                        text = text.Substring(1, text.Length - 2).Trim();
                    Match match = Regex.Match(text, @"^(\d+)\s*(\,\s*(\d+)\s*\,\s*(\d+)){0,1}");
                    if (match.Success)
                    {
                        int? r = null, g = null, b = null;
                        if (match.Groups.Count >= 5)
                        {
                            if ((match.Groups[1].Success) && (byte.TryParse(match.Groups[1].Value,out byte t_r)) &&
                                (t_r <= 255))
                                r = t_r;
                            if (match.Groups[2].Success)
                            {
                                if ((match.Groups[3].Success) && 
                                    (byte.TryParse(match.Groups[3].Value, out byte t_g)) &&
                                    (t_g < 255) &&
                                    (match.Groups[4].Success) &&
                                    (byte.TryParse(match.Groups[4].Value, out byte t_b)) &&
                                    (t_b < 255))
                                {
                                    g = t_g;
                                    b = t_b;
                                }
                            }
                            else if (IsColor == false)
                            {   // グレースケール
                                g = r; b = r;
                            }
                            if ((r.HasValue) && (g.HasValue) && (b.HasValue))
                            {   // ラベルに設定
                                SetLabelColor(Color.FromArgb(r.Value, g.Value, b.Value),false);
                            }
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("IsTextboxChanging is True");
            }
        }
        /// <summary>
        /// 引数の値を返す
        /// </summary>
        /// <returns></returns>
        protected override string GetArgumentValue()
        {
            if (_isColor)
            {
                return string.Format("({0},{1},{2})",
                    LbColor.BackColor.R,
                    LbColor.BackColor.G,
                    LbColor.BackColor.B);
            }
            return LbColor.BackColor.R.ToString();
        }
        /// <summary>
        /// レイアウト実行
        /// </summary>
        protected override void ExecLayout()
        {
            base.ExecLayout();
            SuspendLayout();
            // ラベル位置までは、PartsBaseがやってくれる
            int y = LbTitle.Location.Y;

            if (LbTitle.Height < LbGrayColor.Height)
            {
                LbTitle.Location = new Point(LbTitle.Location.X, y + (LbColor.Height - LbTitle.Height) / 2);
                LbGrayColor.Location = new Point(LbGrayColor.Location.X, y);
                y += LbGrayColor.Height + LbGrayColor.Margin.Bottom;
            }
            else
            {
                // Colorボタンの位置
                LbGrayColor.Location = new Point(LbGrayColor.Location.X, y + (LbTitle.Height - LbGrayColor.Height) / 2);
                y +=  LbTitle.Height + LbTitle.Margin.Bottom;
            }
            y += LbColor.Margin.Top;
            TbValue.Location = new Point(TbValue.Margin.Left, y + (LbColor.Height - LbColor.Height)/2 + 1);
            LbColor.Location = new Point(LbColor.Location.X, y);
            ResumeLayout();
        }
        /// <summary>
        /// 有効・無効チェックが変わった
        /// </summary>
        /// <param name="isValid"></param>
        protected override void ValidCheckChange(bool isValid)
        {
            LbColor.Enabled = isValid;
            LbGrayColor.Enabled = isValid;
            TbValue.Enabled = isValid; 
        }
    }
}
