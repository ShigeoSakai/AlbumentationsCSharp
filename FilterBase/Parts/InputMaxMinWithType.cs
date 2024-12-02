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

    /// <summary>
    /// 型指定できるMax/Min
    /// </summary>
    public partial class InputMaxMinWithType : FilterBase.Parts.InputMaxMin
    {
        /// <summary>
        /// 最大値
        /// </summary>
        /// <remarks>
        /// プロパティエディタで編集できないようにする
        /// </remarks>
        [Browsable(false)]
        public override decimal? MaxValue { get => base.MaxValue; set => base.MaxValue = value; }


        /// <summary>
        /// 最小値
        /// </summary>
        /// <remarks>
        /// プロパティエディタで編集できないようにする
        /// </remarks>
        [Browsable(false)]
        public override decimal? MinValue { get => base.MinValue; set => base.MinValue = value; }

        /// <summary>
        /// 増分プロパティ
        /// </summary>
        /// <remarks>
        /// プロパティエディタで編集できないようにする
        /// </remarks>
        [Browsable(false)]
        public override decimal Increment { get =>base.Increment; set => base.Increment = value; }　

        /// <summary>
        /// 値の種別
        /// </summary>
        public override VALUE_TYPE ValueType
        {
            get => base.ValueType;
            set
            {
                if (base.ValueType != value)
                {
                    if (value == VALUE_TYPE.TYPE_INT)
                    {
                        CbIntFloat.Checked = false;
                        base.ValueType = value;
                    }
                    else if (value == VALUE_TYPE.TYPE_FLOAT)
                    {
                        CbIntFloat.Checked = true;
                        base.ValueType = value;
                    }
                }
            }
        }

        /// <summary>
        /// Float型の最大値
        /// </summary>
        private decimal? _floatMaxValue;
        [Category("値入力"), Description("Float型の最大値")]
        public decimal? FloatMaxValue
        {
            get => _floatMaxValue;
            set
            {
                _floatMaxValue = value;
                if (base.ValueType == VALUE_TYPE.TYPE_FLOAT)
                    base.MaxValue = (_floatMaxValue.HasValue) ? (decimal?)_floatMaxValue.Value : null;
            }
        }
        /// <summary>
        /// Float型の最小値
        /// </summary>
        private decimal? _floatMinValue;
        [Category("値入力"), Description("Float型の最小値")]
        public decimal? FloatMinValue
        {
            get => _floatMinValue;
            set
            {
                _floatMinValue = value;
                if (base.ValueType == VALUE_TYPE.TYPE_FLOAT)
                    base.MinValue = (_floatMinValue.HasValue) ? (decimal?)_floatMinValue.Value : null;
            }
        }
        /// <summary>
        /// int型の最大値
        /// </summary>
        private int? _intMaxValue;
        [Category("値入力"), Description("Int型の最大値")]
        public int? IntMaxValue
        {
            get => _intMaxValue;
            set
            {
                _intMaxValue = value;
                if (base.ValueType == VALUE_TYPE.TYPE_INT)
                    base.MaxValue = (_intMaxValue.HasValue) ? (decimal?)_intMaxValue.Value : null;
            }
        }
        /// <summary>
        /// int型の最小値
        /// </summary>
        private int? _intMinValue;
        [Category("値入力"), Description("Int型の最小値")]
        public int? IntMinValue
        {
            get => _intMinValue;
            set
            {
                _intMinValue = value;
                if (base.ValueType == VALUE_TYPE.TYPE_INT)
                    base.MinValue = (_intMinValue.HasValue) ? (decimal?)_intMinValue.Value : null;
            }
        }
        /// <summary>
        /// 小数点位置
        /// </summary>
        private int _floatDecimapPlace = 0;
        [Category("値入力"), Description("Float型の小数点位置")]
        public override int DecimalPlace
        {
            get => _floatDecimapPlace;
            set
            {
                _floatDecimapPlace = value;
                if (base.ValueType == VALUE_TYPE.TYPE_FLOAT)
                    base.DecimalPlace = value;
            }
        }
        /// <summary>
        /// Int時の増分
        /// </summary>
        private decimal _intIncrement = 1;
        /// <summary>
        /// Int時の増分
        /// </summary>
        [Category("値入力"), Description("Int型の増分")]
        public decimal IntIncrement
        {
            get => _intIncrement;
            set
            {
                _intIncrement = value;
                if (base.ValueType == VALUE_TYPE.TYPE_INT)
                    base.Increment = _intIncrement;
            }
        }
        /// <summary>
        /// Float時の増分
        /// </summary>
        private decimal _floatIncrement = 1;
        /// <summary>
        /// Float時の増分
        /// </summary>
        [Category("値入力"), Description("Float型の増分")]
        public decimal FloatIncrement
        {
            get => _floatIncrement;
            set
            {
                _floatIncrement = value;
                if (base.ValueType == VALUE_TYPE.TYPE_FLOAT)
                    base.Increment = _floatIncrement;
            }
        }


        /// <summary>
        /// CbCbIntFloatへのアクセスできるか
        /// </summary>
        private bool meInit = false;
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public InputMaxMinWithType():base()
        {
            InitializeComponent();
            // デフォルトはFloat
            base.ValueType = VALUE_TYPE.TYPE_FLOAT;
            // 初期化終了したので、CbCbIntFloatへのアクセス可
            meInit = true;
            ExecLayout();
        }
        /// <summary>
        /// レイアウトを実行
        /// </summary>
        protected override void ExecLayout()
        {
            base.ExecLayout();

            // CbCbIntFloatへのアクセスできるか
            if (meInit)
            {
                // タイトルの最大横幅
                int cbPosX = PartsConst.FIXED_WIDTH - CbIntFloat.Margin.Horizontal - CbIntFloat.Size.Width;
                LbTitle.MaxTextWidth = cbPosX - LbTitle.Margin.Horizontal;
                // チェックボックスの位置
                CbIntFloat.Location = new Point(
                    cbPosX,
                    LbTitle.Location.Y + (LbTitle.Size.Height - CbIntFloat.Height) / 2);
            }
        }
        /// <summary>
        /// Int型とFloat型の切替
        /// </summary>
        private void IntFloatChnage()
        {
            Tuple<decimal, decimal> now_value = PartsFunc.GetTuppleFromString(base.Value, base.ValueType);
            // 初期化開始
            this.BeginInit();
            if (CbIntFloat.Checked)
            {   // Float型へ
                base.ValueType = VALUE_TYPE.TYPE_FLOAT;
                base.DecimalPlace = _floatDecimapPlace;
                base.Increment = _floatIncrement;
                base.MaxValue = (_floatMaxValue.HasValue) ? (decimal?)_floatMaxValue.Value : null;
                base.MinValue = (_floatMinValue.HasValue) ? (decimal?)_floatMinValue.Value : null;
                // 値の範囲を調整
                decimal item1 = now_value.Item1;
                decimal item2 = now_value.Item2;
                if (_floatMaxValue.HasValue)
                {  
                    if (item1 > _floatMaxValue.Value) item1 = _floatMaxValue.Value;
                    if (item2 > _floatMaxValue.Value) item2 = _floatMaxValue.Value;
                }
                if (_floatMinValue.HasValue)
                {
                    if (item1 < _floatMinValue.Value) item1 = _floatMinValue.Value;
                    if (item2 < _floatMinValue.Value) item2 = _floatMinValue.Value;
                }
                base.Value = PartsFunc.GetTuppleToString(new Tuple<decimal,decimal>(item2,item2), VALUE_TYPE.TYPE_FLOAT, _floatDecimapPlace); ;
            }
            else
            {   // Int型へ
                base.ValueType = VALUE_TYPE.TYPE_INT;
                base.DecimalPlace = 0;
                base.Increment = _intIncrement;
                base.MaxValue = (_intMaxValue.HasValue) ? (decimal?)_intMaxValue.Value : null;
                base.MinValue = (_intMinValue.HasValue) ? (decimal?)_intMinValue.Value : null;
                // 値の範囲を調整
                decimal item1 = now_value.Item1;
                decimal item2 = now_value.Item2;
                if (_intMaxValue.HasValue)
                {
                    if (item1 > _intMaxValue.Value) item1 = _intMaxValue.Value;
                    if (item2 > _intMaxValue.Value) item2 = _intMaxValue.Value;
                }
                if (_intMinValue.HasValue)
                {
                    if (item1 < _intMinValue.Value) item1 = _intMinValue.Value;
                    if (item2 < _intMinValue.Value) item2 = _intMinValue.Value;
                }
                base.Value = PartsFunc.GetTuppleToString(new Tuple<decimal, decimal>(item2, item2), VALUE_TYPE.TYPE_INT, _floatDecimapPlace); ;
            }
            // 初期化終了
            this.EndInit();
        }

        /// <summary>
        /// Int/Floatの型変更
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CbIntFloat_CheckedChanged(object sender, EventArgs e)
        {
            // IntとFloat切替
            IntFloatChnage();
            // イベント発行
            OnParameterChange(base.Value);
        }
    }
}
