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
    /// 値のタイプ
    /// </summary>
    using VALUE_TYPE = PartsFunc.VALUE_TYPE;

    public partial class InputMaxMin : PartsBase
    {
        /// <summary>
        /// 大きい数値を使うか？
        /// </summary>
        protected bool _useLargeValue = false;
        /// <summary>
        /// 大きい数値を使うか？
        /// </summary>
        [Category("値入力"),Description("大きい数値を使う(=2段表示)かどうか")]
        public virtual bool UseLargeValue
        {
            get { return _useLargeValue; }
            set
            {
                if (_useLargeValue != value)
                {
                    _useLargeValue = value;
                    // レイアウト実行
                    ExecLayout();
                }
            }
        }

        /// <summary>
        /// 値のタイプ
        /// </summary>
        private VALUE_TYPE _valueType = VALUE_TYPE.TYPE_INT;

        /// <summary>
        /// 値のタイプ（後で設定用）
        /// </summary>
        private VALUE_TYPE? _ini_valueType = null;
        /// <summary>
        /// 値の種別プロパティ
        /// </summary>
        [Category("値入力"),Description("値の種類")]
        public virtual VALUE_TYPE ValueType
        {
            get => _valueType;
            set => SetValueType(value);
        }
        /// <summary>
        /// 値のタイプを設定
        /// </summary>
        /// <param name="value"></param>
        private void SetValueType(VALUE_TYPE value)
        {
            // 値を設定
            _valueType = value;
            if ((value == VALUE_TYPE.TYPE_INT_EVEN) ||
                (value == VALUE_TYPE.TYPE_INT_ODD))
            {   // 値と最大値の補正
                if (_isInit)
                {   // 後で設定
                    _ini_valueType = value;
                }
                else
                {   // 補正を実行
                    EvenOddAdjust(_valueType);
                    // 増分を2に設定
                    Increment = 2;
                }
            }
        }


        /// <summary>
        /// 小数点位置
        /// </summary>
        private int _decimalPlace = 0;
        /// <summary>
        /// 小数点位置（後で設定用）
        /// </summary>
        private int? _ini_decimalPlace = null;
        /// <summary>
        /// 小数点位置プロパティ
        /// </summary>
        [Category("値入力"),Description("小数点位置(小数点桁数)")]
        public virtual int DecimalPlace
        {
            get => _decimalPlace;
            set
            {   // 初期化中は設定しない
                if ((_decimalPlace != value) && (_isInit == false))
                {
                    if (_valueType != VALUE_TYPE.TYPE_FLOAT)
                        _decimalPlace = 0;
                    else
                        _decimalPlace = value;
                    // コントロールに設定
                    NUDFrom.DecimalPlaces = _decimalPlace;
                    NUDTo.DecimalPlaces = _decimalPlace;
                }
                else if (_isInit)
                {   // 初期化中なので、後回し
                    _ini_decimalPlace = value;
                }
            }
        }
        /// <summary>
        /// 増分
        /// </summary>
        private decimal _increment = 1;
        /// <summary>
        /// 増分（後で設定用）
        /// </summary>
        private decimal? _ini_increment = null;
        /// <summary>
        /// 増分プロパティ
        /// </summary>
        [Category("値入力")]
        public virtual decimal Increment
        {
            get => _increment;
            set
            {
                if (value > 0)
                {
                    if (_isInit)
                    {   // 後で設定
                        _ini_increment = value;
                    }
                    else
                    {
                        SetIncrement(value);
                    }
                }
            }
        }
        /// <summary>
        /// 増分の設定
        /// </summary>
        /// <param name="value"></param>
        private void SetIncrement(decimal value)
        {
            if (value > 0)
            {
                if (_valueType == VALUE_TYPE.TYPE_FLOAT)
                {   // FLOATはそのまま
                    _increment = value;
                }
                else if (_valueType == VALUE_TYPE.TYPE_INT)
                {   // INTはcastして
                    int i_value = (int)value;
                    if (i_value > 0)
                        _increment = i_value;
                }
                else
                {   // 偶数・奇数の増分は固定
                    _increment = 2;
                }
                // UpDownに設定
                NUDFrom.Increment = _increment;
                NUDTo.Increment = _increment;
            }
        }
        /// <summary>
        /// 最小値
        /// </summary>
        private decimal? _minValue = null;
        /// <summary>
        /// 最小値(後で設定用)
        /// </summary>
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
                {   // 後で設定
                    _init_minValue = value;
                }
                else
                {
                    _minValue = value;
                    if (_minValue.HasValue)
                    {   // 値を補正して設定する
                        _value = SetAdjustmentValue(_value);
                    }
                }
            }
        }
        /// <summary>
        /// 最大値
        /// </summary>
        private decimal? _maxValue = null;
        /// <summary>
        /// 最大値(後で設定用)
        /// </summary>
        private decimal? _init_maxValue = null;
        /// <summary>
        /// 最大値プロパティ
        /// </summary>
        [Category("値入力")]
        public virtual decimal? MaxValue
        {
            get => _maxValue;
            set
            {
                if (_isInit)
                {   // 後で設定
                    _init_maxValue = value;
                }
                else
                {
                    _maxValue = value;
                    if (_maxValue.HasValue)
                    {   // 値を補正して設定する
                        _value = SetAdjustmentValue(_value);
                    }
                }
            }
        }
        /// <summary>
        /// 値
        /// </summary>
        private Tuple<decimal,decimal> _value;
        /// <summary>
        /// 値(後で設定用)
        /// </summary>
        private string _init_Value = null;
        /// <summary>
        /// 値プロパティ
        /// </summary>
        [Category("値入力")]
        public string Value
        {
            get
            {
                if (_isInit)
                {   // 初期化中なので...
                    return _init_Value;
                }
                else
                {
                    _value = GetValueFromInput();
                    return PartsFunc.GetTuppleToString(_value, _valueType, _decimalPlace);
                }
            }
            set
            {
                if (_isInit)
                {   // 後で設定
                    _init_Value = value;
                }
                else
                {   // 値を補正して設定する
                    isValueSetting = true;
                    Tuple<decimal,decimal> tmpValue = SetAdjustmentValue(PartsFunc.GetTuppleFromString(value, _valueType));
                    if (PartsFunc.TupleDiff(_value,tmpValue))
                    {   // イベント発行
                        _value = tmpValue;
                        OnParameterChange(_value);
                    }
                    isValueSetting = false;
                }
            }
        }
        /// <summary>
        /// 値を補正する
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        private Tuple<decimal, decimal> AdjustValue(Tuple<decimal, decimal> value)
        {
            decimal item1 = value.Item1, item2 = value.Item2;
            if (_minValue.HasValue)
            {   // 最小値チェック
                if (item1 < _minValue.Value) 
                    item1 = _minValue.Value;
                if (item2 < item1)
                    item2 = item1;
            }
            if (_maxValue.HasValue)
            {   // 最大値チェック
                if (item2 > _maxValue.Value)
                    item2 = _maxValue.Value;
                if (item1 > item2)
                    item1 = item2;
            }
            if (item1 > item2)
            {   // 入れ替える
                item1 = value.Item2;
                item2 = value.Item1;
            }
            return new Tuple<decimal, decimal>(item1, item2);
        }
        /// <summary>
        /// 最大・最小を設定して正規化した値を返す
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        private Tuple<decimal, decimal> SetAdjustmentValue(Tuple<decimal, decimal> value)
        {
            // 値を正規化する
            Tuple<decimal, decimal> result = AdjustValue(value);
            // 最大値を設定
            if (_maxValue.HasValue)
            {
                if (NUDTo.Value > _maxValue.Value)
                {   
                    // 先に最小値をチェック
                    if (NUDTo.Minimum >  _maxValue.Value)
                        NUDTo.Minimum = _maxValue.Value;
                    // 値に設定
                    NUDTo.Value = _maxValue.Value;
                }
                NUDTo.Maximum = _maxValue.Value;
            }
            if (NUDFrom.Value > result.Item2)
                NUDFrom.Value = result.Item2;
            NUDFrom.Maximum = result.Item2;
            // 最小値を設定
            if (_minValue.HasValue)
            {
                if (NUDFrom.Value < _minValue.Value)
                {
                    // 先に最大値をチェック
                    if (NUDFrom.Maximum <  _minValue.Value)
                        NUDFrom.Maximum = _minValue.Value;
                    // 値を設定
                    NUDFrom.Value = _minValue.Value;
                }
                NUDFrom.Minimum = _minValue.Value;
            }
            if (NUDTo.Value < result.Item1)
                NUDTo.Value = result.Item1;
            NUDTo.Minimum = result.Item1;

            // 値を設定
            NUDFrom.Value = result.Item1;
            NUDTo.Value = result.Item2;

            return result;
        }


        /// <summary>
        /// 初期化中フラグ
        /// </summary>
        private bool _isInit = false;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public InputMaxMin()
        {
            InitializeComponent();
            // 現設定でレイアウト実行
            ExecLayout();   
        }

        /// <summary>
        /// レイアウトを実行
        /// </summary>
        protected override void ExecLayout()
        {
            base.ExecLayout();

            SuspendLayout();
            // ラベルの位置までは、PartsBaseが行う
            int y = LbTitle.Location.Y;
            LbTitle.MaxTextWidth = PartsConst.FIXED_WIDTH - LbTitle.Margin.Horizontal;
            y += LbTitle.Height + LbTitle.Margin.Bottom;

            // UpDownの位置をラベルの下にする
            y += NUDFrom.Margin.Top;
            NUDFrom.Location = new Point(NUDFrom.Margin.Left, y);

            if (_useLargeValue)
            {   // 2段表示
                // From/Toのサイズ
                int one_width = PartsConst.FIXED_WIDTH - NUDFrom.Margin.Horizontal -
                    LbBar.Width - LbBar.Margin.Horizontal;
                NUDFrom.Size = new Size(one_width, NUDFrom.Height);
                // ラベルの位置
                LbBar.Location = new Point(NUDFrom.Location.X + one_width + NUDFrom.Margin.Right + LbBar.Margin.Left, y + 2);
                y += NUDFrom.Height + NUDFrom.Margin.Bottom + NUDTo.Margin.Top;
                // Toの位置とサイズ
                NUDTo.Size = new Size(one_width, NUDTo.Height);
                NUDTo.Location = new Point(
                    PartsConst.FIXED_WIDTH - NUDTo.Margin.Horizontal - one_width,
                    y);
            }
            else
            {   // 一段表示
                int one_width = PartsConst.FIXED_WIDTH - NUDFrom.Margin.Horizontal - NUDTo.Margin.Horizontal -
                    LbBar.Width - LbBar.Margin.Horizontal;
                one_width /= 2;
                NUDFrom.Size = new Size(one_width, NUDFrom.Height);
                // ラベル位置
                LbBar.Location = new Point(
                    NUDFrom.Location.X + NUDFrom.Width + NUDFrom.Margin.Right + LbBar.Margin.Left,
                    y + 2);
                // Toの位置とサイズ
                NUDTo.Size = new Size(one_width, NUDTo.Height);
                NUDTo.Location = new Point(LbBar.Location.X + LbBar.Width + LbBar.Margin.Right + NUDTo.Margin.Left, y);
            }

            ResumeLayout();
        }

        /// <summary>
        /// 初期化開始
        /// </summary>
        public override void BeginInit()
        {
            base.BeginInit();
            // 初期化中
            _isInit = true;

        }
        /// <summary>
        /// 初期化終了
        /// </summary>
        public override void EndInit()
        {
            base.EndInit();

            // ペンディングされている設定を順番に実行            
            // 小数点位置
            if (_ini_decimalPlace.HasValue)
            {
                //FLOAT時のみ有効
                int set_value = 0;
                if (_valueType == VALUE_TYPE.TYPE_FLOAT)
                    set_value = _ini_decimalPlace.Value;
                // UpDownに設定
                NUDFrom.DecimalPlaces = set_value;
                NUDTo.DecimalPlaces = set_value;
                _decimalPlace = set_value;

                _ini_decimalPlace = null;
            }
            // 最大値
            if (_init_maxValue.HasValue)
                _maxValue = _init_maxValue.Value;
            // 最小値
            if (_init_minValue.HasValue)
                _minValue = _init_minValue.Value;
            // 値
            Tuple<decimal, decimal> tmpValue = (_init_Value != null) ? 
                PartsFunc.GetTuppleFromString(_init_Value, _valueType) :
                GetValueFromInput();
            // 値を補正して設定する
            _value = SetAdjustmentValue(tmpValue);

            // 増分
            if (_ini_increment.HasValue)
            {
                // 増分を設定
                SetIncrement(_ini_increment.Value);
                _ini_increment = null;
            }
            // 偶数・奇数の補正
            if (_ini_valueType.HasValue)
            {
                if ((_ini_valueType == VALUE_TYPE.TYPE_INT_ODD) ||
                    (_ini_valueType == VALUE_TYPE.TYPE_INT_EVEN))
                {   // 補正を実行
                    EvenOddAdjust(_valueType);
                    // 増分の再設定
                    if (_increment != 2)
                        Increment = 2;
                }
                _ini_valueType = null;
            }

            // 初期化終了
            _isInit = false;
        }

        /// <summary>
        /// Tupple値の補正
        /// </summary>
        /// <param name="value"></param>
        /// <param name="type"></param>
        /// <param name="isUp"></param>
        /// <returns></returns>
        private string GetAdjustValue(Tuple<decimal, decimal> value, VALUE_TYPE type, bool isUp)
        {
            if (value != null)
            {
                return PartsFunc.GetTuppleToString(
                    new Tuple<decimal, decimal>(
                        PartsFunc.GetAdjustValue(value.Item1, (type == VALUE_TYPE.TYPE_INT_EVEN), isUp),
                        PartsFunc.GetAdjustValue(value.Item2, (type == VALUE_TYPE.TYPE_INT_EVEN), isUp)
                        ), _valueType, _decimalPlace);
            }
            return null;
        }

        /// <summary>
        /// 偶数・奇数の補正実行
        /// </summary>
        /// <param name="type"></param>
        private void EvenOddAdjust(VALUE_TYPE type)
        {
            // 最小値
            if (_minValue.HasValue)
                MinValue = PartsFunc.GetAdjustValue(_minValue.Value, (type == VALUE_TYPE.TYPE_INT_EVEN), false);
            // 最大値
            if (_maxValue.HasValue)
                MaxValue = PartsFunc.GetAdjustValue(_maxValue.Value, (type == VALUE_TYPE.TYPE_INT_EVEN), true);
            // 値
            Value = GetAdjustValue(_value, type, true);
        }
        /// <summary>
        /// 現在の入力値を取得
        /// </summary>
        /// <returns></returns>
        protected Tuple<decimal, decimal> GetValueFromInput()
        {
            return new Tuple<decimal, decimal>(NUDFrom.Value, NUDTo.Value);
        }

        /// <summary>
        /// 値を変更中
        /// </summary>
        private volatile bool isValueSetting = false;

        /// <summary>
        /// Fromの値が変わった
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NUDFrom_ValueChanged(object sender, EventArgs e)
        {
            if (isValueSetting == false)
            {
                isValueSetting = true;
                // 値を補正して設定する
                _value = SetAdjustmentValue(GetValueFromInput());

                // イベント発行
                if (_isInit == false)
                    OnParameterChange(_value);

                isValueSetting = false;
            }
        }
        /// <summary>
        /// Toの値が変わった
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NUDTo_ValueChanged(object sender, EventArgs e)
        {
            if (isValueSetting == false)
            {
                isValueSetting = true;
                // 値を補正して設定する
                _value = SetAdjustmentValue(GetValueFromInput());

                // イベント発行
                if (_isInit == false)
                    OnParameterChange(_value);

                isValueSetting = false;
            }
        }
        /// <summary>
        /// 引数値を取得
        /// </summary>
        /// <returns></returns>
        protected override string GetArgumentValue()
        {
            return PartsFunc.GetTuppleToString(new Tuple<decimal, decimal>(NUDFrom.Value, NUDTo.Value), _valueType, _decimalPlace);
        }
        /// <summary>
        /// 有効チェックボックスの値が変わった
        /// </summary>
        /// <param name="isValid"></param>
        protected override void ValidCheckChange(bool isValid)
        {
            NUDFrom.Enabled = isValid;
            NUDTo.Enabled = isValid;
        }
    }
}
