using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FilterBase.Parts
{
    /// <summary>
    /// 数値入力パーツ
    /// </summary>
    public partial class InputValue : PartsBase, ISupportInitialize
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
        /// 最大値
        /// </summary>
        private decimal? _maxValue;
        private decimal? _init_maxValue = null;
        /// <summary>
        /// 最大値プロパティ
        /// </summary>
        [Category("値入力")]
        public virtual decimal? MaxValue 
        { 
            get=> _maxValue;
            set
            {
                if (_isInit)
                {   // 初期化中をテンポラリへ
                    _init_maxValue = value;
                }
                else
                {
                    _maxValue = value;
                    // 最大・最小を考慮した値の設定
                    SetMaxMinConsiderationValue(_Value);
                }
            }
        }
        /// <summary>
        /// 最小値
        /// </summary>
        private decimal? _minValue;
        private decimal? _init_minValue = null;

        /// <summary>
        /// 最小値プロパティ
        /// </summary>
        [Category("値入力")]
        public virtual decimal? MinValue
        {
            get => _minValue;
            set
            {
                if (_isInit)
                {   // 初期化中をテンポラリへ
                    _init_minValue = value;
                }
                else
                {
                    _minValue = value;
                    // 最大・最小を考慮した値の設定
                    SetMaxMinConsiderationValue(_Value);
                }
            }
        }
        /// <summary>
        /// 値
        /// </summary>
        private decimal _Value
        {
            get
            {
                return GetValueFromTextBox();

            }
            set
            {
                SetDecimalValueToTextBox(value);
            }
        }
        private decimal? _init_Value = null;

        /// <summary>
        /// 値プロパティ
        /// </summary>
        [Category("値入力")]
        public virtual decimal? Value 
        { 
            get => _Value;
            set
            {
                if (_isInit)
                {   // 初期化中をテンポラリへ
                    _init_Value = value;
                }
                else
                {
                    if (value.HasValue)
                    {   // 最大・最小を考慮した値の設定
                        SetMaxMinConsiderationValue(value.Value);
                    }
                }
            }
        }

        /// <summary>
        /// 値の種別
        /// </summary>
        public enum VALUE_TYPE
        {
            INT = 0,
            FLOAT = 1,
            PERCENT = 2,
        }
        /// <summary>
        /// 値の種別
        /// </summary>
        private VALUE_TYPE _valueType = VALUE_TYPE.INT;
        private VALUE_TYPE? _init_valueType = null;
        /// <summary>
        /// 値の種別プロパティ
        /// </summary>
        [Category("値入力")]
        public virtual VALUE_TYPE ValueType
        {
            get => _valueType;
            set
            {
                if (_isInit)
                {   // 初期化中をテンポラリへ
                    _init_valueType = value;
                }
                else
                {
                    if (_valueType != value)
                    {
                        decimal now_value = _Value;
                        _valueType = value;
                        if (value == VALUE_TYPE.INT)
                        {
                            _decimalPlace = 0;
                            // 最大、最小の小数点位置調整
                            if (_maxValue.HasValue)
                                _maxValue = Math.Round(_maxValue.Value,_decimalPlace);
                            if (_minValue.HasValue)
                                _minValue = Math.Round(_minValue.Value, _decimalPlace);
                        }
                        _Value = now_value;
                    }
                }
            }
        }
        /// <summary>
        /// 小数点の位置
        /// </summary>
        private int _decimalPlace = 0;
        private int? _init_decimalPlace = null;
        /// <summary>
        /// 小数点の位置プロパティ
        /// </summary>
        [Category("値入力")]
        public virtual int DecimalPlace
        {
            get => _decimalPlace;
            set
            {
                if (_isInit)
                {   // 初期化中をテンポラリへ
                    _init_decimalPlace = value;
                }
                else
                {
                    decimal now_value = _Value;
                    _decimalPlace = value;
                    // 最大、最小の小数点位置調整
                    if (_maxValue.HasValue)
                        _maxValue = Math.Round(_maxValue.Value, _decimalPlace);
                    if (_minValue.HasValue)
                        _minValue = Math.Round(_minValue.Value, _decimalPlace);

                    _Value = now_value;
                }
            }
        }

        /// <summary>
        /// レイアウト方向定義
        /// </summary>
        public enum LAYOUT
        {
            Horizontal = 0,
            Vertical = 1
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
        /// 初期化中か？
        /// </summary>
        private bool _isInit = false;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public InputValue()
        {
            InitializeComponent();
            // 初期値を入れておく
            TbValue.Text = "0";
            // レイアウト実行
            ExecLayout();
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
                LbTitle.Location = new Point(LbTitle.Margin.Left, (int)((float)(TbValue.Size.Height - LbTitle.Height) / 2.0F + 0.5F) + tbY);
                // テキストボックスの横幅
                int tbWidth = PartsConst.FIXED_WIDTH - LbTitle.Width - LbTitle.Location.X - LbTitle.Margin.Horizontal -
                    LbUnit.Width - LbUnit.Margin.Horizontal - TbValue.Margin.Horizontal;
                if (tbWidth >= 32)
                {
                    // テキストボックスの位置
                    TbValue.Location = new Point(LbTitle.Location.X + LbTitle.Width + LbTitle.Margin.Right + TbValue.Margin.Left, tbY);
                    // テキストボックスのサイズ
                    TbValue.Size = new Size(tbWidth, TbValue.Size.Height);
                    // 単位の位置
                    LbUnit.Location = new Point(TbValue.Location.X + TbValue.Size.Width + TbValue.Margin.Right + LbUnit.Margin.Left,
                        (int)((float)(TbValue.Size.Height - LbUnit.Height) / 2.0F + 0.5F) + tbY);

                    ResumeLayout();
                    return;
                }
                // 垂直レイアウトに変更
                _controlLayout = LAYOUT.Horizontal;
            }
            // 垂直レイアウト

            // ラベル位置
            y += LbTitle.Height + LbTitle.Margin.Bottom + TbValue.Margin.Top;
            // テキストボックスの位置とサイズ
            TbValue.Location = new Point(TbValue.Margin.Left, y);
            int tbWidth_V = PartsConst.FIXED_WIDTH - LbUnit.Width - LbUnit.Margin.Horizontal - TbValue.Margin.Horizontal;
            TbValue.Size = new Size(tbWidth_V, TbValue.Size.Height);
            // 単位の位置
            LbUnit.Location = new Point(TbValue.Location.X + TbValue.Size.Width + TbValue.Margin.Right + TbValue.Margin.Left,
                (int)((float)(TbValue.Size.Height - LbUnit.Height) / 2.0F + 0.5F) + y);
        
            ResumeLayout();
        }
        /// <summary>
        /// 最大値・最小値を考慮した値の設定
        /// </summary>
        private void SetMaxMinConsiderationValue(decimal value)
        {
            bool isSet = false;
            // 最大値チェック
            if ((_maxValue.HasValue) && (_maxValue < value))
            {
                _Value = _maxValue.Value;
                isSet = true;
            }
            // 最小値チェック
            if ((_minValue.HasValue) && (_minValue > value))
            {
                _Value = _minValue.Value;
                isSet = true;
            }
            if (isSet == false)
            {
                // そのまま設定
                _Value = Math.Round(value,_decimalPlace);
            }
            
        }
        /// <summary>
        /// テキストボックスから数値を取得する
        /// </summary>
        /// <returns></returns>
        private decimal GetValueFromTextBox()
        {
            if ((TbValue.Text != null) && (TbValue.Text.Trim().Length > 0) &&
                (decimal.TryParse(TbValue.Text,out decimal value)))
            {
                // 指定桁数で丸めた数値
                decimal r_value = Math.Round(value, _decimalPlace);
                // パーセント指定なら1/100
                if (_valueType == VALUE_TYPE.PERCENT)
                    r_value /= 100;
                return r_value;
            }
            return 0;
        }
        /// <summary>
        /// 指定されたフォーマットの値を文字列で取得
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        private string GetFormatedValue(decimal value)
        {
            // 変換フォーマット
            string format = "{0:";
            if ((_valueType == VALUE_TYPE.INT) || (_decimalPlace == 0))
                format += "#0";
            else
                format += "#0." + new string('0', _decimalPlace);
            format += "}";

            // パーセントの補正
            decimal set_value = value;
            if (_valueType == VALUE_TYPE.PERCENT)
                set_value *= 100;
            return string.Format(format, set_value);
        }

        /// <summary>
        /// Decimal値をテキストボックスに設定する
        /// </summary>
        /// <param name="value"></param>
        private void SetDecimalValueToTextBox(decimal value)
        { 
            // テキストボックスに設定
            TbValue.Text = GetFormatedValue(value);
        }


        /// <summary>
        /// 単位のサイズが変更になった
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LabelSizeChange(object sender, EventArgs e)
        {   // レイアウトを実行
            ExecLayout();
        }
        /// <summary>
        /// 初期化開始
        /// </summary>
        /// <exception cref="NotImplementedException"></exception>
        public override void BeginInit()
        {
            base.BeginInit();
            // 初期化中
            _isInit = true;
        }
        /// <summary>
        /// 初期化終了
        /// </summary>
        /// <exception cref="NotImplementedException"></exception>
        public override void EndInit()
        {
            base.EndInit();
            // ペンディングされていた設定
            //
            //  値の種別
            if (_init_valueType.HasValue)
            {
                _valueType = _init_valueType.Value;
                if (_valueType == VALUE_TYPE.INT)
                {   // 整数型
                    _decimalPlace = 0;
                    _init_decimalPlace = null;
                }
                _init_valueType = null;
            }
            // 小数点位置
            if (_init_decimalPlace.HasValue)
            {
                if (_valueType != VALUE_TYPE.INT)
                    _decimalPlace = _init_decimalPlace.Value;
                _init_decimalPlace = null;
            }
            // 最大値
            if (_init_maxValue.HasValue)
            {
                _maxValue = Math.Round(_init_maxValue.Value,_decimalPlace);
                _init_maxValue = null;
            }
            // 最小値
            if (_init_minValue.HasValue)
            {
                _minValue = Math.Round(_init_minValue.Value,_decimalPlace);
                _init_minValue = null;
            }
            // 値
            if (_init_Value.HasValue)
            {   // 最大・最小を考慮して設定
                SetMaxMinConsiderationValue(_init_Value.Value);
                _init_Value = null;
            }
            else
            {   // 最大・最小を考慮して設定
                decimal value = _Value;
                SetMaxMinConsiderationValue(value);
            }
            // 初期化終了
            _isInit = false;
        }
        /// <summary>
        /// 値の取得
        /// </summary>
        /// <returns></returns>
        protected override string GetArgumentValue()
        {
            decimal value = _Value;
            return GetFormatedValue(value);
        }
        /// <summary>
        /// テキスト内容が変更になった
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TbValue_TextChanged(object sender, EventArgs e)
        {
           OnParameterChange(_Value);
        }
        /// <summary>
        /// 有効・無効のチェックが変わった事を通知
        /// </summary>
        /// <param name="isValid"></param>
        protected override void ValidCheckChange(bool isValid)
        {
            TbValue.Enabled = isValid;
        }

    }
}
