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
    /// カーネルサイズ用パーツ
    /// </summary>
    /// <remarks>
    /// InputTupleコントロールを継承し、奇数入力のみに限定
    /// </remarks>
    public partial class InputKernelSize : InputTuple
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public InputKernelSize() :base() 
        {
            InitializeComponent();
            // レイアウト実行
            ExecLayout();
        }
        /// <summary>
        /// 増分プロパティ
        /// </summary>
        /// <remarks>
        /// プロパティエディタで編集できないようにする
        /// </remarks>
        [Browsable(false)]
        public override decimal Increment 
        { 
            get => base.Increment; 
            set => base.Increment = 2; 
        }
        /// <summary>
        /// 値の種別プロパティ
        /// </summary>
        /// <remarks>
        /// プロパティエディタで編集できないようにする
        /// </remarks>
        [Browsable(false)]
        public override VALUE_TYPE ValueType 
        { 
            get => base.ValueType; 
            set => base.ValueType = VALUE_TYPE.TYPE_INT_ODD; 
        }
        /// <summary>
        /// 小数点位置プロパティ
        /// </summary>
        /// <remarks>
        /// プロパティエディタで編集できないようにする
        /// </remarks>
        [Browsable(false)]
        public override int DecimalPlace 
        { 
            get => base.DecimalPlace; 
            set => base.DecimalPlace = 0; 
        }
        /// <summary>
        /// 先頭の値が次の値を超えない設定
        /// </summary>
        private bool _FirstMaxIsSecondValue = true;
        /// <summary>
        /// 先頭の値が次の値を超えない設定
        /// </summary>
        [Category("値入力")]
        public bool FirstMaxIsSecondValue
        {
            get => _FirstMaxIsSecondValue;
            set
            {
                _FirstMaxIsSecondValue = value;
                if (_FirstMaxIsSecondValue)
                {
                    NUDFrom.Maximum = NUDTo.Value;
                }
            }
        }
        /// <summary>
        /// 初期化終了
        /// </summary>
        public override void EndInit()
        {
            base.EndInit();
            if (_FirstMaxIsSecondValue)
            {
                NUDFrom.Maximum = NUDTo.Value;
            }

        }
        /// <summary>
        /// パラメータ変更イベント
        /// </summary>
        /// <param name="name"></param>
        /// <param name="value"></param>
        protected override void OnParameterChange(string name, object value)
        {
            // FirstMaxIsSecondValueがfalse、もしくは
            //   先頭の値が次の値を超えていなかったらイベント発行
            if ((_FirstMaxIsSecondValue == false) ||
                (NUDFrom.Value <= NUDTo.Value)) 
                base.OnParameterChange(name, value);

            // FirstMaxIsSecondValueがTrueの場合は最大値に設定
            if (_FirstMaxIsSecondValue)
            {
                NUDFrom.Maximum = NUDTo.Value;
            }
        }
        /// <summary>
        /// レイアウトを実行
        /// </summary>
        protected override void ExecLayout()
        {
            base.ExecLayout();
            if (LbX != null)
            {
                // "x"の位置を調整する
                int x = NUDFrom.Location.X + NUDFrom.Width + NUDFrom.Margin.Right + LbX.Margin.Left;
                int x2 = NUDTo.Location.X - NUDTo.Margin.Right - LbX.Margin.Left;
                int diff = x2 - x - LbX.Width;
                LbX.Location = new Point(x + diff/2 + 1, NUDFrom.Location.Y + 3);
            }
        }
    }
}
