using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FilterBase.Parts
{
    public partial class InputTrackBar : PartsBase
    {
        /// <summary>
        /// 小数点位置
        /// </summary>
        private int _decimalPlace = 0;
        /// <summary>
        /// 小数点位置
        /// </summary>
        [Category("値入力")]
        public int DecimalPlace
        {
            get => _decimalPlace;
            set
            {   // 小数点位置変更
                ChnageDecimalPlace(value);
            }
        }
        /// <summary>
        /// 最大値
        /// </summary>
        [Category("値入力")]
        public decimal MaxValue
        {
            get => ToDecimal(ValueTrackBar.Maximum, _decimalPlace);
            set
            {
                ValueTrackBar.Maximum = ToInt(value, _decimalPlace);
                ValueTrackBar.DescriptionMax = ToString(value, _decimalPlace);
                // 目盛りの設定
                SetTickFreq();
            }
        }
        /// <summary>
        /// 最小値
        /// </summary>
        [Category("値入力")]
        public decimal MinValue
        {
            get => ToDecimal(ValueTrackBar.Minimum, _decimalPlace);
            set
            {
                ValueTrackBar.Minimum = ToInt(value, _decimalPlace);
                ValueTrackBar.DescriptionMin = ToString(value,_decimalPlace);
                // 目盛りの設定
                SetTickFreq();
            }
        }
        /// <summary>
        /// 値
        /// </summary>
        [Category("値入力")]
        public decimal Value
        {
            get => ToDecimal(ValueTrackBar.Value,_decimalPlace);
            set => ValueTrackBar.Value = ToInt(value,_decimalPlace);
        }
        /// <summary>
        /// 増分
        /// </summary>
        [Category("値入力")]
        public decimal Increment
        {
            get => ToDecimal(ValueTrackBar.SmallChange, _decimalPlace);
            set
            {
                if (value < 0)
                    value = -1 * value;
                if (value != 0)
                {
                    ValueTrackBar.SmallChange = ToInt(value, _decimalPlace);
                    if (ValueTrackBar.SmallChange * 5 > ValueTrackBar.Maximum)
                        ValueTrackBar.LargeChange = ValueTrackBar.SmallChange;
                    else
                        ValueTrackBar.LargeChange = ValueTrackBar.SmallChange * 5;
                }
            }
        }


        /// <summary>
        /// 設定中か？
        /// </summary>
        private volatile bool isInit = false;
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public InputTrackBar()
        {
            InitializeComponent();

            // TrackBarの初期設定
            ValueTrackBar.DescriptionMin = ToString((decimal)ValueTrackBar.Minimum, _decimalPlace);
            ValueTrackBar.DescriptionMax = ToString((decimal)ValueTrackBar.Maximum, _decimalPlace);
            // 目盛りの設定
            SetTickFreq();

            // レイアウト実行
            ExecLayout();
        }

        /// <summary>
        /// レイアウトの実行
        /// </summary>
        protected override void ExecLayout()
        {
            base.ExecLayout();

            SuspendLayout();

            // TrackBar位置
            ValueTrackBar.Location = new Point(ValueTrackBar.Margin.Left,
                LbTitle.Location.Y +  LbTitle.Height + LbTitle.Margin.Bottom + ValueTrackBar.Margin.Top);
            ValueTrackBar.Size = new Size(PartsConst.FIXED_WIDTH - ValueTrackBar.Margin.Horizontal, ValueTrackBar.Height);
            ResumeLayout();
        }
        /// <summary>
        /// Int値をDecimal値に変換する
        /// </summary>
        /// <param name="value"></param>
        /// <param name="decimalPlace"></param>
        /// <returns></returns>
        private decimal ToDecimal(int value,int decimalPlace)
        {
            decimal result = value;
            if (decimalPlace != 0)
            {
                decimal pow = (decimal)Math.Pow(10, decimalPlace);
                result = result / pow;
            }
            return result;
        }
        /// <summary>
        /// Decimal値をInt型に変換する
        /// </summary>
        /// <param name="value"></param>
        /// <param name="decimalPlace"></param>
        /// <returns></returns>
        private int ToInt(decimal value, int decimalPlace)
        {
            if (decimalPlace != 0)
            {
                decimal pow = (decimal)Math.Pow(10, decimalPlace);
                value = value * pow;
            }
            return (int)value;
        }
        /// <summary>
        /// Decimal値を文字列に変換
        /// </summary>
        /// <param name="value"></param>
        /// <param name="decimalPlace"></param>
        /// <returns></returns>
        private string ToString(decimal value, int decimalPlace)
        {
            string fmt = "{0:,0";
            if (decimalPlace > 0)
                fmt += "." + new string('0', decimalPlace);
            fmt += "}";
            return string.Format(fmt, value);
        }

        private volatile bool isSetDecimalPlace = false;
        /// <summary>
        /// 小数点位置の変更
        /// </summary>
        /// <param name="newPlace"></param>
        private void ChnageDecimalPlace(int newPlace)
        {
            isSetDecimalPlace = true;

            // 現在の位置で最大、最小、値を取得
            decimal max = ToDecimal(ValueTrackBar.Maximum, _decimalPlace);
            decimal min = ToDecimal(ValueTrackBar.Minimum, _decimalPlace);
            decimal value = ToDecimal(ValueTrackBar.Value, _decimalPlace);
            // 新しい位置に変更
            _decimalPlace = newPlace;
            // 再設定
            ValueTrackBar.Maximum = ToInt(max, _decimalPlace);
            ValueTrackBar.DescriptionMax = ToString(max, _decimalPlace);
            ValueTrackBar.Minimum = ToInt(min, _decimalPlace);
            ValueTrackBar.DescriptionMin = ToString(min, _decimalPlace);
            ValueTrackBar.Value = ToInt(value, _decimalPlace);
            // 目盛りの設定
            SetTickFreq();

            isSetDecimalPlace = false;
        }
        /// <summary>
        /// メモリ線の設定
        /// </summary>
        private void SetTickFreq()
        {
            int max = ValueTrackBar.Maximum;
            int min = ValueTrackBar.Minimum;
            if (max > min)
            {
                int diff = max - min;
                int result = diff / 10;
                if (result == 0) result = 1;
                ValueTrackBar.TickFrequency = result;
            }
        }

        /// <summary>
        /// 値の変更
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ValueTrackBar_ValueChanged(object sender, EventArgs e)
        {
            if ((isInit == false) && (isSetDecimalPlace == false))
            {
                // イベント発行
                OnParameterChange(ToDecimal(ValueTrackBar.Value, _decimalPlace));
            }
        }
        /// <summary>
        /// 初期化開始
        /// </summary>
        public override void BeginInit()
        {
            base.BeginInit();

            isInit = true;
        }
        /// <summary>
        /// 初期化終了
        /// </summary>
        public override void EndInit()
        {
            base.EndInit();

            isInit = false;
        }
        /// <summary>
        /// 引数の値を取得
        /// </summary>
        /// <returns></returns>
        protected override string GetArgumentValue()
        {
            return ToString(Value, _decimalPlace);
        }
        /// <summary>
        /// 有効無効のチェックが変わった
        /// </summary>
        /// <param name="isValid"></param>
        protected override void ValidCheckChange(bool isValid)
        {
            ValueTrackBar.Enabled = isValid;
        }
    }
}
