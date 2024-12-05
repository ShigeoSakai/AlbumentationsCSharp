using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FilterBase.Parts
{
	using static FilterBase.Parts.InputValue;
	/// <summary>
	/// 値のタイプ
	/// </summary>
	using VALUE_TYPE = PartsFunc.VALUE_TYPE;

	/// <summary>
	/// Tuple 3入力
	/// </summary>
	public partial class Input3Tuple : FilterBase.Parts.PartsBase
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
					NUDTuple1.DecimalPlaces = _decimalPlace;
					NUDTuple2.DecimalPlaces = _decimalPlace;
					NUDTuple3.DecimalPlaces = _decimalPlace;
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
				NUDTuple1.Increment = _increment;
				NUDTuple2.Increment = _increment;
				NUDTuple3.Increment = _increment;
			}
		}


		/// <summary>
		/// 最小値
		/// </summary>
		protected Tuple<decimal, decimal,decimal> _minValue = null;
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
					_minValue = PartsFunc.Get3TuppleFromString(value, _valueType);
					if (_minValue != null)
					{
						NUDTuple1.Minimum = _minValue.Item1;
						NUDTuple2.Minimum = _minValue.Item2;
						NUDTuple3.Minimum = _minValue.Item3;
					}
				}
			}
		}

		/// <summary>
		/// 最大値
		/// </summary>
		protected Tuple<decimal, decimal,decimal> _maxValue = null;
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
			get => PartsFunc.GetTuppleToString(_maxValue, _valueType, _decimalPlace);
			set
			{
				if (_isInit)
				{   // 初期化中なので、後回し
					_ini_maxValue = value;
				}
				else
				{
					_maxValue = PartsFunc.Get3TuppleFromString(value, _valueType);
					if (_maxValue != null)
					{
						NUDTuple1.Maximum = _maxValue.Item1;
						NUDTuple2.Maximum = _maxValue.Item2;
						NUDTuple3.Maximum = _maxValue.Item3;
					}
				}
			}
		}
		/// <summary>
		/// 値
		/// </summary>
		protected Tuple<decimal, decimal,decimal> _value = null;
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
				return PartsFunc.GetTuppleToString(_value, _valueType, _decimalPlace);
			}
			set
			{
				if (_isInit)
				{   // 初期化中なので、後回し
					_ini_value = value;
				}
				else
				{
					Tuple<decimal, decimal,decimal> tmp_value = PartsFunc.Get3TuppleFromString(value, _valueType);
					// 値が異なるかチェック
					if (PartsFunc.TupleDiff(_value, tmp_value))
					{
						_value = PartsFunc.Get3TuppleFromString(value, _valueType);
						if (_value != null)
						{
							// パラメータ変更イベント禁止
							isValueSetting = true;
							// 値を変更
							NUDTuple1.Value = _value.Item1;
							NUDTuple2.Value = _value.Item2;
							NUDTuple3.Value = _value.Item3;
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
		protected Tuple<decimal, decimal,decimal> GetValueFromInput()
		{
			return new Tuple<decimal, decimal, decimal>(NUDTuple1.Value, NUDTuple2.Value,NUDTuple3.Value);
		}

		/// <summary>
		/// Tupple値の補正
		/// </summary>
		/// <param name="value"></param>
		/// <param name="type"></param>
		/// <param name="isUp"></param>
		/// <returns></returns>
		private string GetAdjustValue(Tuple<decimal, decimal,decimal> value, VALUE_TYPE type, bool isUp)
		{
			if (value != null)
			{
				return PartsFunc.GetTuppleToString(
					new Tuple<decimal, decimal,decimal>(
						PartsFunc.GetAdjustValue(value.Item1, (type == VALUE_TYPE.TYPE_INT_EVEN), isUp),
						PartsFunc.GetAdjustValue(value.Item2, (type == VALUE_TYPE.TYPE_INT_EVEN), isUp),
						PartsFunc.GetAdjustValue(value.Item3, (type == VALUE_TYPE.TYPE_INT_EVEN), isUp)
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
			MinValue = GetAdjustValue(_minValue, type, false);
			// 最大値
			MaxValue = GetAdjustValue(_maxValue, type, true);
			// 値
			Value = GetAdjustValue(_value, type, true);
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
		/// ラベル１
		/// </summary>
		[Category("値入力")]
		public string Label1
		{
			get => LbTuple1.Text;
			set => LbTuple1.Text = value;
		}
		/// <summary>
		/// ラベル2
		/// </summary>
		[Category("値入力")]
		public string Label2
		{
			get => LbTuple2.Text;
			set => LbTuple2.Text = value;
		}
		/// <summary>
		/// ラベル3
		/// </summary>
		[Category("値入力")]
		public string Label3
		{
			get => LbTuple3.Text;
			set => LbTuple3.Text = value;
		}


		/// <summary>
		/// コンストラクタ
		/// </summary>
		public Input3Tuple()
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
				NUDTuple1.DecimalPlaces = set_value;
				NUDTuple2.DecimalPlaces = set_value;
				NUDTuple3.DecimalPlaces = set_value;
				_decimalPlace = set_value;

				_ini_decimalPlace = null;
			}
			// 最大値
			if (_ini_maxValue != null)
			{
				_maxValue = PartsFunc.Get3TuppleFromString(_ini_maxValue, _valueType);
				if (_maxValue != null)
				{
					NUDTuple1.Maximum = _maxValue.Item1;
					NUDTuple2.Maximum = _maxValue.Item2;
					NUDTuple3.Maximum = _maxValue.Item2;
				}
				_ini_maxValue = null;
			}
			// 最小値
			if (_ini_minValue != null)
			{
				_minValue = PartsFunc.Get3TuppleFromString(_ini_minValue, _valueType);
				if (_minValue != null)
				{
					NUDTuple1.Minimum = _minValue.Item1;
					NUDTuple2.Minimum = _minValue.Item2;
					NUDTuple3.Minimum = _minValue.Item2;
				}
				_ini_minValue = null;
			}
			// 値
			if (_ini_value != null)
			{
				_value = PartsFunc.Get3TuppleFromString(_ini_value, _valueType);
				if (_value != null)
				{
					NUDTuple1.Value = _value.Item1;
					NUDTuple2.Value = _value.Item2;
					NUDTuple3.Value = _value.Item2;
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
				return string.Format("({0},{1},{2})", (float)NUDTuple1.Value, (float)NUDTuple2.Value, (float)NUDTuple3.Value);
			}
			else
			{
				return string.Format("({0},{1},{2})", (int)NUDTuple1.Value, (int)NUDTuple2.Value, (int)NUDTuple3.Value);
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
			int y = LbTitle.Location.Y + LbTitle.Height + LbTitle.Margin.Bottom;

			if (_controlLayout == LAYOUT.Horizontal)
			{	// 水平レイアウト
				if (PartsConst.FIXED_WIDTH - LbTuple1.Width - LbTuple1.Margin.Horizontal - NUDTuple1.Margin.Horizontal  > 32)
				{
					// Tuple1
					if (LbTuple1.Height > NUDTuple1.Height)
					{
						y += LbTuple1.Margin.Top;
						LbTuple1.Location = new Point(LbTuple1.Margin.Left, y);
						NUDTuple1.Location = new Point(
							LbTuple1.Location.X + LbTuple1.Width + LbTuple1.Margin.Right + NUDTuple1.Margin.Left,
							y + (LbTuple1.Height - NUDTuple1.Height) / 2);
						y += LbTuple1.Height + LbTuple1.Margin.Bottom;
					}
					else
					{
						y += NUDTuple1.Margin.Top;
						LbTuple1.Location = new Point(
							LbTuple1.Margin.Left,
							y + (NUDTuple1.Height - LbTuple1.Height) / 2);
						NUDTuple1.Location = new Point(
							LbTuple1.Location.X + LbTuple1.Width + LbTuple1.Margin.Right + NUDTuple1.Margin.Left,
							y);
						y += NUDTuple1.Height + NUDTuple1.Margin.Bottom;
					}
					NUDTuple1.Size = new Size(
						PartsConst.FIXED_WIDTH - LbTuple1.Width - LbTuple1.Margin.Horizontal - NUDTuple1.Margin.Horizontal,
						NUDTuple1.Height);


					// Tuple2
					if (LbTuple2.Height > NUDTuple2.Height)
					{
						y += LbTuple2.Margin.Top;
						LbTuple2.Location = new Point(LbTuple2.Margin.Left, y);
						NUDTuple2.Location = new Point(
							LbTuple2.Location.X + LbTuple2.Width + LbTuple2.Margin.Right + NUDTuple2.Margin.Left,
							y + (LbTuple2.Height - NUDTuple2.Height) / 2);
						y += LbTuple2.Height + LbTuple2.Margin.Bottom;
					}
					else
					{
						y += NUDTuple2.Margin.Top;
						LbTuple2.Location = new Point(
							LbTuple2.Margin.Left,
							y + (NUDTuple2.Height - LbTuple2.Height) / 2);
						NUDTuple2.Location = new Point(
							LbTuple2.Location.X + LbTuple2.Width + LbTuple2.Margin.Right + NUDTuple2.Margin.Left,
							y);
						y += NUDTuple2.Height + NUDTuple2.Margin.Bottom;
					}
					NUDTuple2.Size = new Size(
						PartsConst.FIXED_WIDTH - LbTuple2.Width - LbTuple2.Margin.Horizontal - NUDTuple2.Margin.Horizontal,
						NUDTuple2.Height);

					// Tuple3
					if (LbTuple3.Height > NUDTuple3.Height)
					{
						y += LbTuple3.Margin.Top;
						LbTuple3.Location = new Point(LbTuple3.Margin.Left, y);
						NUDTuple3.Location = new Point(
							LbTuple3.Location.X + LbTuple3.Width + LbTuple3.Margin.Right + NUDTuple3.Margin.Left,
							y + (LbTuple3.Height - NUDTuple3.Height) / 2);
						y += LbTuple3.Height + LbTuple3.Margin.Bottom;
					}
					else
					{
						y += NUDTuple3.Margin.Top;
						LbTuple3.Location = new Point(
							LbTuple3.Margin.Left,
							y + (NUDTuple3.Height - LbTuple3.Height) / 2);
						NUDTuple3.Location = new Point(
							LbTuple3.Location.X + LbTuple3.Width + LbTuple3.Margin.Right + NUDTuple3.Margin.Left,
							y);
						y += NUDTuple3.Height + NUDTuple3.Margin.Bottom;
					}
					NUDTuple3.Size = new Size(
						PartsConst.FIXED_WIDTH - LbTuple3.Width - LbTuple3.Margin.Horizontal - NUDTuple3.Margin.Horizontal,
						NUDTuple3.Height);
					ResumeLayout();
					return;
				}
				// 垂直レイアウトへ
			}
			// Tuple1
			y += LbTuple1.Margin.Top;
			LbTuple1.Location = new Point(LbTuple1.Margin.Left,y);
			y += LbTuple1.Margin.Bottom + NUDTuple1.Margin.Top;
			NUDTuple1.Location = new Point(NUDTuple1.Margin.Left,y);
			NUDTuple1.Size = new Size(PartsConst.FIXED_WIDTH - NUDTuple1.Margin.Horizontal, NUDTuple1.Height);
			// Tuple2
			y += LbTuple2.Margin.Top + NUDTuple1.Margin.Bottom;
			LbTuple2.Location = new Point(LbTuple2.Margin.Left, y);
			y += LbTuple2.Margin.Bottom + NUDTuple2.Margin.Top;
			NUDTuple2.Location = new Point(NUDTuple2.Margin.Left, y);
			NUDTuple2.Size = new Size(PartsConst.FIXED_WIDTH - NUDTuple2.Margin.Horizontal, NUDTuple2.Height);
			// Tuple3
			y += LbTuple3.Margin.Top + NUDTuple2.Margin.Bottom;
			LbTuple3.Location = new Point(LbTuple3.Margin.Left, y);
			y += LbTuple3.Margin.Bottom + NUDTuple3.Margin.Top;
			NUDTuple3.Location = new Point(NUDTuple3.Margin.Left, y);
			NUDTuple3.Size = new Size(PartsConst.FIXED_WIDTH - NUDTuple3.Margin.Horizontal, NUDTuple3.Height);

			ResumeLayout();
		}
		/// <summary>
		/// 有効・無効のチェックが変わった事を通知
		/// </summary>
		/// <param name="isValid"></param>
		protected override void ValidCheckChange(bool isValid)
		{
			NUDTuple1.Enabled = isValid;
			NUDTuple2.Enabled = isValid;
			NUDTuple3.Enabled = isValid;
		}
		/// <summary>
		/// ラベルのサイズが変わった
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LbTuple1_SizeChanged(object sender, EventArgs e)
		{
			// レイアウトを実行
			ExecLayout();
		}
	}
}
