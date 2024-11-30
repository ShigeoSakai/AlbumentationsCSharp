using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FilterBase.Parts
{
    public partial class InputValueWithType : FilterBase.Parts.InputValue
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public InputValueWithType()
        {
            InitializeComponent();

            // レイアウト固定
            _controlLayout = LAYOUT.Vertical;
            // デフォルトはFloat
            base.ValueType = VALUE_TYPE.FLOAT;
        }
        /// <summary>
        /// コントロールのレイアウト
        /// </summary>
        /// <remarks>
        /// プロパティエディタで編集できないようにする
        /// </remarks>
        [Browsable(false)]
        public override LAYOUT ControlLayout { get => base.ControlLayout; set => base.ControlLayout = LAYOUT.Vertical; }

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
        /// 値の種別
        /// </summary>
        public override VALUE_TYPE ValueType 
        { 
            get => base.ValueType;
            set 
            {
                if (base.ValueType != value)
                {
                    if (value == VALUE_TYPE.INT)
                    {
                        CbIntFloat.Checked = false;
                        base.ValueType = value;
                    }
                    else if (value == VALUE_TYPE.FLOAT)
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
        private float? _floatMaxValue;
        [Category("値入力"),Description("Float型の最大値")]
        public float? FloatMaxValue
        {
            get => _floatMaxValue;
            set
            {
                _floatMaxValue = value;
                if (base.ValueType == VALUE_TYPE.FLOAT)
                    base.MaxValue = (_floatMaxValue.HasValue) ? (decimal?)_floatMaxValue.Value : null;
            }
        }
        /// <summary>
        /// Float型の最小値
        /// </summary>
        private float? _floatMinValue;
        [Category("値入力"), Description("Float型の最小値")]
        public float? FloatMinValue
        {
            get => _floatMinValue;
            set
            {
                _floatMinValue = value;
                if (base.ValueType == VALUE_TYPE.FLOAT)
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
                if (base.ValueType == VALUE_TYPE.INT)
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
                if (base.ValueType == VALUE_TYPE.INT)
                    base.MinValue = (_intMinValue.HasValue) ? (decimal?)_intMinValue.Value : null;
            }
        }
        /// <summary>
        /// 小数点位置
        /// </summary>
        private int _floatDecimapPlace = 0;
        public override int DecimalPlace
        {
            get => _floatDecimapPlace;
            set 
            { 
                _floatDecimapPlace = value; 
                if (base.ValueType == VALUE_TYPE.FLOAT)
                    base.DecimalPlace = value;
            }
        }

        /// <summary>
        /// レイアウト実行
        /// </summary>
        protected override void ExecLayout()
        {
            base.ExecLayout();

            SuspendLayout();
            int y = LbTitle.Location.Y;

            // 垂直レイアウトのみ
            if (_controlLayout == LAYOUT.Vertical)
            {
                // チェックボックスの位置
                int cb_posX = PartsConst.FIXED_WIDTH - CbIntFloat.Width - CbIntFloat.Margin.Right;
                int cb_posY;
                int tb_posY;
                // ラベルの位置とサイズ
                int lb_posX = LbTitle.Margin.Left;
                int lb_width = cb_posX - lb_posX - CbIntFloat.Margin.Left - LbTitle.Margin.Right;
                int lb_posY;
                if (CbIntFloat.Height > LbTitle.Height)
                {   // チェックボックス基準でレイアウト
                    cb_posY = y;
                    lb_posY = cb_posY + (CbIntFloat.Height - LbTitle.Height) / 2;
                    tb_posY = cb_posY + CbIntFloat.Height + CbIntFloat.Margin.Bottom + TbValue.Margin.Top;
                }
                else
                {   // ラベル基準でレイアウト
                    cb_posY = y + (LbTitle.Height - CbIntFloat.Height )/2;
                    lb_posY = y;
                    tb_posY = lb_posY + LbTitle.Height + LbTitle.Margin.Bottom + TbValue.Margin.Top;
                }

                // チェックボックス位置
                CbIntFloat.Location = new Point(cb_posX, cb_posY);
                // ラベルの位置とサイズ
                LbTitle.Location = new Point(lb_posX, lb_posY);
                LbTitle.MaxTextWidth = lb_width;
                // 値の位置
                // テキストボックスの位置とサイズ
                TbValue.Location = new Point(3, tb_posY);
                int tbWidth_V = PartsConst.FIXED_WIDTH - LbUnit.Width - TbValue.Location.X - 4;
                TbValue.Size = new Size(tbWidth_V, TbValue.Size.Height);
                // 単位の位置
                LbUnit.Location = new Point(TbValue.Location.X + TbValue.Size.Width,
                    (int)((float)(TbValue.Size.Height - LbUnit.Height) / 2.0F + 0.5F) + TbValue.Location.Y);
            }
            ResumeLayout();
        }
        /// <summary>
        /// Int型とFloat型の切替
        /// </summary>
        private void IntFloatChnage()
        {
            decimal? now_value = base.Value;
            // 初期化開始
            this.BeginInit();
            if (CbIntFloat.Checked)
            {   // Float型へ
                base.ValueType = VALUE_TYPE.FLOAT;
                base.DecimalPlace = _floatDecimapPlace;
                base.MaxValue = (_floatMaxValue.HasValue) ? (decimal?)_floatMaxValue.Value : null;
                base.MinValue = (_floatMinValue.HasValue) ? (decimal?)_floatMinValue.Value : null;
                base.Value = now_value;
            }
            else
            {   // Int型へ
                if (now_value.HasValue) 
                    now_value = (int?)now_value.Value;
                base.ValueType = VALUE_TYPE.INT;
                base.DecimalPlace = 0;
                base.MaxValue = (_intMaxValue.HasValue) ? (decimal?)_intMaxValue.Value : null;
                base.MinValue = (_intMinValue.HasValue) ? (decimal?)_intMinValue.Value : null;
                base.Value = now_value;
            }
            // 初期化終了
            this.EndInit();
        }
        /// <summary>
        /// Int <=> Floatチェックボックス変更
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CbIntFloat_CheckedChanged(object sender, EventArgs e)
        {
            // IntとFloat切替
            IntFloatChnage();
        }
    }
}
