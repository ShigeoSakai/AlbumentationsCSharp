using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static FilterBase.Parts.InputValue;

namespace FilterBase.Parts
{
    /// <summary>
    /// 値の種別
    /// </summary>
    using VALUE_TYPE = InputValue.VALUE_TYPE;
    /// <summary>
    /// レイアウト方向定義
    /// </summary>
    using LAYOUT = InputValue.LAYOUT;

    public partial class InputValueUpDown : PartsBase
    {
        /// <summary>
        /// 単位
        /// </summary>
        private string _Unit = string.Empty;
        /// <summary>
        /// 単位のプロパティ
        /// </summary>
        [Category("値入力")]
        public string Unit
        {
            get => _Unit;
            set
            {
                _Unit = value;
                LbUnit.Text = _Unit;
            }
        }
        /// <summary>
        /// 値の種別
        /// </summary>
        private VALUE_TYPE _valueType = VALUE_TYPE.INT;
        /// <summary>
        /// 値の種別プロパティ
        /// </summary>
        [Category("値入力")]
        public virtual VALUE_TYPE ValueType
        {
            get => _valueType;
            set
            {
                if (_valueType != value)
                {
                    _valueType = value;
                    if (value == VALUE_TYPE.INT)
                    {
                        NUDValue.DecimalPlaces = 0;
                    }
                }
            }
        }
        /// <summary>
        /// 最小値
        /// </summary>
        [Category("値入力")]
        public virtual decimal? MinValue
        {
            get =>(NUDValue.Minimum == decimal.MinValue) ? (decimal?)null :NUDValue.Minimum;
            set => NUDValue.Minimum = (value.HasValue) ? value.Value : decimal.MinValue;
        }
        /// <summary>
        /// 最大値
        /// </summary>
        [Category("値入力")]
        public virtual decimal? MaxValue
        {
            get => (NUDValue.Maximum == decimal.MaxValue) ? (decimal?)null :NUDValue.Maximum;
            set => NUDValue.Maximum = (value.HasValue) ? value.Value : decimal.MaxValue;
        }
        /// <summary>
        /// 増分
        /// </summary>
        [Category("値入力")]
        public virtual decimal Increment
        {
            get =>NUDValue.Increment;
            set => NUDValue.Increment = value;
        }
        /// <summary>
        /// 小数点位置(後から設定)
        /// </summary>
        private int? _init_decimalPlace = null;
        /// <summary>
        /// 小数点位置
        /// </summary>
        [Category("値入力")]
        public virtual int DecimalPlace
        {
            get => NUDValue.DecimalPlaces;
            set
            {
                if (_isInit)
                {
                    _init_decimalPlace = value;
                }
                else
                {
                    if (_valueType != VALUE_TYPE.INT)
                        NUDValue.DecimalPlaces = value;
                }
            }
        }
        /// <summary>
        /// 値
        /// </summary>
        [Category("値入力")]
        public virtual Decimal Value
        {
            get => NUDValue.Value;
            set => NUDValue.Value = value;
        }
        /// <summary>
        /// 初期化中か？
        /// </summary>
        private bool _isInit = false;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public InputValueUpDown()
        {
            InitializeComponent();

            // レイアウト実行
            ExecLayout();
        }
        /// <summary>
        /// レイアウト方向
        /// </summary>
        protected LAYOUT _controlLayout = LAYOUT.Horizontal;
        /// <summary>
        /// レイアウト方向プロパティ
        /// </summary>
        [Category("値入力")]
        public virtual LAYOUT ControlLayout
        {
            get => _controlLayout;
            set
            {
                _controlLayout = value;
                // レイアウト実行
                ExecLayout();
            }
        }
        /// <summary>
        /// レイアウト実行
        /// </summary>
        protected override void ExecLayout()
        {
            base.ExecLayout();

            SuspendLayout();
            // ラベルの位置までは、PartsBaseが行う
            int y = LbTitle.Location.Y;

            // 水平レイアウト
            if (_controlLayout == LAYOUT.Horizontal)
            {
                // テキストボックスのY座標
                int tbY = y;
                // ラベルの位置
                LbTitle.Location = new Point(LbTitle.Margin.Left, (int)((float)(NUDValue.Size.Height - LbTitle.Height) / 2.0F + 0.5F) + tbY);
                // テキストボックスの横幅
                int tbWidth = PartsConst.FIXED_WIDTH - LbTitle.Width - LbTitle.Location.X - LbTitle.Margin.Horizontal -
                    LbUnit.Width - LbUnit.Margin.Horizontal - NUDValue.Margin.Horizontal;
                if (tbWidth >= 32)
                {
                    // テキストボックスの位置
                    NUDValue.Location = new Point(LbTitle.Location.X + LbTitle.Width + LbTitle.Margin.Right + NUDValue.Margin.Left, tbY);
                    // テキストボックスのサイズ
                    NUDValue.Size = new Size(tbWidth, NUDValue.Size.Height);
                    // 単位の位置
                    LbUnit.Location = new Point(NUDValue.Location.X + NUDValue.Size.Width + NUDValue.Margin.Right + LbUnit.Margin.Left,
                        (int)((float)(NUDValue.Size.Height - LbUnit.Height) / 2.0F + 0.5F) + tbY);

                    ResumeLayout();
                    return;
                }
                // 垂直レイアウトに変更
                _controlLayout = LAYOUT.Horizontal;
            }
            // 垂直レイアウト

            // ラベル位置
            y += LbTitle.Height + LbTitle.Margin.Bottom + NUDValue.Margin.Top;
            // テキストボックスの位置とサイズ
            NUDValue.Location = new Point(NUDValue.Margin.Left, y);
            int tbWidth_V = PartsConst.FIXED_WIDTH - LbUnit.Width - LbUnit.Margin.Horizontal - NUDValue.Margin.Horizontal;
            NUDValue.Size = new Size(tbWidth_V, NUDValue.Size.Height);
            // 単位の位置
            LbUnit.Location = new Point(NUDValue.Location.X + NUDValue.Size.Width + NUDValue.Margin.Right + NUDValue.Margin.Left,
                (int)((float)(NUDValue.Size.Height - LbUnit.Height) / 2.0F + 0.5F) + y);


            ResumeLayout();
        }
        /// <summary>
        /// 単位のサイズが変わった
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LbUnit_SizeChanged(object sender, EventArgs e)
        {
            // レイアウトを実行
            ExecLayout();
        }
        /// <summary>
        /// 引数の値を取得
        /// </summary>
        /// <returns></returns>
        protected override string GetArgumentValue()
        {
            // 変換フォーマット
            string format = "{0:";
            if ((_valueType == VALUE_TYPE.INT) || (NUDValue.DecimalPlaces == 0))
                format += "#0";
            else
                format += "#0." + new string('0', NUDValue.DecimalPlaces);
            format += "}";


            decimal val = NUDValue.Value;
            if (_valueType == VALUE_TYPE.PERCENT)
                val /= 100;

            return string.Format(format,val);
        }
        /// <summary>
        /// 値が変わった
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NUDValue_ValueChanged(object sender, EventArgs e)
        {
            // イベント発行
            if (_isInit == false)
                OnParameterChange(NUDValue.Value);
        }
        /// <summary>
        /// 初期化開始
        /// </summary>
        public override void BeginInit()
        {
            base.BeginInit();
            _isInit = true;
        }
        /// <summary>
        /// 初期化終了
        /// </summary>
        public override void EndInit()
        {
            base.EndInit();

            if (_init_decimalPlace.HasValue)
            {
                if (_valueType != VALUE_TYPE.INT)
                    NUDValue.DecimalPlaces = _init_decimalPlace.Value;
                _init_decimalPlace = null;
            }


            _isInit = false;
        }
        /// <summary>
        /// 有効・無効のチェックが変わった事を通知
        /// </summary>
        /// <param name="isValid"></param>
        protected override void ValidCheckChange(bool isValid)
        {
            NUDValue.Enabled = isValid;
        }
    }
}
