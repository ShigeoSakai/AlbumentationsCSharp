using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace FilterBase.Parts
{
    /// <summary>
    /// 値のタイプ
    /// </summary>
    using VALUE_TYPE = PartsFunc.VALUE_TYPE;

    /// <summary>
    /// Tuple入力パーツ
    /// </summary>

    public partial class InputTuple : PartsBase
    {
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
        [Category("値入力")]
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
        [Category("値入力")]
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
        protected Tuple<decimal, decimal> _minValue = null;
        /// <summary>
        /// 最小値（後で設定用）
        /// </summary>
        private string _ini_minValue = null;

        /// <summary>
        /// 最小値プロパティ
        /// </summary>
        [Category("値入力")]
        public virtual string MinValue
        {
            get => PartsFunc.GetTuppleToString(_minValue, _valueType, _decimalPlace);
            set
            {
                if (_isInit)
                {   // 初期化中なので、後回し
                    _ini_minValue = value;
                }
                else
                {
                    _minValue = PartsFunc.GetTuppleFromString(value, _valueType);
                    if (_minValue != null)
                    {
                        NUDFrom.Minimum = _minValue.Item1;
                        NUDTo.Minimum = _minValue.Item2;
                    }
                }
            }
        }

        /// <summary>
        /// 最大値
        /// </summary>
        protected Tuple<decimal, decimal> _maxValue = null;
        /// <summary>
        /// 最大値（後で設定用）
        /// </summary>
        private string _ini_maxValue = null;

        /// <summary>
        /// 最大値プロパティ
        /// </summary>
        [Category("値入力")]
        public virtual string MaxValue
        {
            get => PartsFunc.GetTuppleToString(_maxValue,_valueType,_decimalPlace);
            set
            {
                if (_isInit)
                {   // 初期化中なので、後回し
                    _ini_maxValue = value;
                }
                else
                {
                    _maxValue = PartsFunc.GetTuppleFromString(value, _valueType);
                    if (_maxValue != null)
                    {
                        NUDFrom.Maximum = _maxValue.Item1;
                        NUDTo.Maximum = _maxValue.Item2;
                    }
                }
            }
        }
        /// <summary>
        /// 値
        /// </summary>
        protected Tuple<decimal, decimal> _value = null;
        /// <summary>
        /// 最大値（後で設定用）
        /// </summary>
        private string _ini_value = null;
        /// <summary>
        /// 値のプロパティ
        /// </summary>
        [Category("値入力")]
        public virtual string Value
        {
            get
            {   // 値を更新
                _value = GetValueFromInput();
                return PartsFunc.GetTuppleToString(_value,_valueType,_decimalPlace);
            }
            set
            {
                if (_isInit)
                {   // 初期化中なので、後回し
                    _ini_value = value;
                }
                else
                {
                    Tuple<decimal, decimal> tmp_value = PartsFunc.GetTuppleFromString(value,_valueType);
                    // 値が異なるかチェック
                    if (PartsFunc.TupleDiff(_value, tmp_value))
                    {
                        _value = PartsFunc.GetTuppleFromString(value,_valueType);
                        if (_value != null)
                        {
                            // パラメータ変更イベント禁止
                            isValueSetting = true;
                            // 値を変更
                            NUDFrom.Value = _value.Item1;
                            NUDTo.Value = _value.Item2;
                            // パラメータ変更イベント許可
                            isValueSetting = true;

                            // パラメータ変更イベント発行
                            OnParameterChange(_value);
                        }
                    }
                }
            }
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
                        PartsFunc.GetAdjustValue(value.Item1,(type == VALUE_TYPE.TYPE_INT_EVEN),isUp),
                        PartsFunc.GetAdjustValue(value.Item2, (type == VALUE_TYPE.TYPE_INT_EVEN), isUp)
                        ),_valueType,_decimalPlace);
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
            MinValue = GetAdjustValue(_minValue, type, false);
            // 最大値
            MaxValue = GetAdjustValue(_maxValue, type, true);
            // 値
            Value = GetAdjustValue(_value, type, true);
        }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public InputTuple():base()
        {
            InitializeComponent();
            // 現設定でレイアウト実行
            ExecLayout();
        }
        /// <summary>
        /// 初期化中フラグ
        /// </summary>
        private bool _isInit = false;
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
            if (_ini_maxValue != null)
            {
                _maxValue = PartsFunc.GetTuppleFromString(_ini_maxValue,_valueType);
                if (_maxValue != null)
                {
                    NUDFrom.Maximum = _maxValue.Item1;
                    NUDTo.Maximum = _maxValue.Item2;
                }
                _ini_maxValue = null;
            }
            // 最小値
            if (_ini_minValue != null)
            {
                _minValue = PartsFunc.GetTuppleFromString(_ini_minValue, _valueType);
                if (_minValue != null)
                {
                    NUDFrom.Minimum = _minValue.Item1;
                    NUDTo.Minimum = _minValue.Item2;
                }
                _ini_minValue = null;
            }
            // 値
            if (_ini_value != null)
            {
                _value = PartsFunc.GetTuppleFromString(_ini_value, _valueType);
                if (_value != null)
                {
                    NUDFrom.Value = _value.Item1;
                    NUDTo.Value = _value.Item2;
                }
                _ini_value = null;
            }
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
        /// 引数値を取得
        /// </summary>
        /// <returns></returns>
        protected override string GetArgumentValue()
        {
            if (_valueType == VALUE_TYPE.TYPE_FLOAT)
            {
                return string.Format("({0},{1})", (float)NUDFrom.Value, (float)NUDTo.Value);
            }
            else
            {
                return string.Format("({0},{1})", (int)NUDFrom.Value, (int)NUDTo.Value);
            }
        }
        /// <summary>
        /// 値を変更中
        /// </summary>
        private volatile bool isValueSetting = false;

        /// <summary>
        /// UpDownの値が変わった
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NUD_ValueChanged(object sender, EventArgs e)
        {
            if ((sender is NumericUpDown upDown) && (_isInit == false) && (isValueSetting == false))
            {
                string name = (ArgumentName != null) ? ArgumentName : "Unknown";
                // イベント発行
                OnParameterChange(name, this.Value);
            }
        }
        /// <summary>
        /// レイアウトを実行
        /// </summary>
        protected override void ExecLayout()
        {
            base.ExecLayout();

            SuspendLayout();
            int y = LbTitle.Location.Y + LbTitle.Height + LbTitle.Margin.Bottom + NUDFrom.Margin.Top; ;

            // UpDownの位置をラベルの下にする
            NUDFrom.Location = new Point(NUDFrom.Location.X, y);
            NUDTo.Location = new Point(NUDTo.Location.X, y);

            ResumeLayout();
        }
        /// <summary>
        /// 有効・無効のチェックが変わった事を通知
        /// </summary>
        /// <param name="isValid"></param>
        protected override void ValidCheckChange(bool isValid)
        {
            NUDFrom.Enabled = isValid;
            NUDTo.Enabled = isValid;
        }
    }
}
