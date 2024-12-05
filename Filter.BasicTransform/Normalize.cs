using FilterBase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Compression;
using System.Text;
using System.Windows.Forms;

namespace Filter.BasicTransform
{
	[ModuleCategory("transform", "基本変換"), Index(0), DisplayName("正規化"), Description("画像にさまざまな正規化手法を適用します。特定の正規化手法は、`normalization` パラメータで選択できます。\r\n\r\n" +
		"標準の正規化は、次の式を使用して適用されます:\r\n\r\n`img = (img - mean * max_pixel_value) / (std * max_pixel_value)`。\r\n" +
		"その他の正規化手法では、グローバルまたはチャネルごとの統計に基づいて画像を調整したり、ピクセル値を指定された範囲にスケールしたりします。")]
	public partial class Normalize : FilterBase.BaseFilterControl
	{
		private class NormalizeMethod : IComboBox
		{
			/// <summary>
			/// 名前
			/// </summary>
			public string Name { get; private set; }
			/// <summary>
			/// 引数に使用する値
			/// </summary>
			public string ArgumentValue { get; set; }
			/// <summary>
			/// コンストラクタ
			/// </summary>
			/// <param name="name"></param>
			/// <param name="argumentValue"></param>
			public NormalizeMethod(string name, string argumentValue)
			{
				Name = name;
				ArgumentValue = argumentValue;
			}
			/// <summary>
			/// 文字列変換
			/// </summary>
			/// <returns></returns>
			public override string ToString()
			{
				return Name;
			}
			/// <summary>
			/// コンボボックスの生成
			/// </summary>
			/// <param name="comboBox"></param>
			/// <param name="default_item"></param>
			public static void MakeComboBox(ComboBox comboBox, string default_item)
			{
				// "standard", "image", "image_per_channel", "min_max", "min_max_per_channel"
				comboBox.Items.Clear();
				comboBox.Items.Add(new NormalizeMethod("standard", "'standard'"));
				comboBox.Items.Add(new NormalizeMethod("image", "'image'"));
				comboBox.Items.Add(new NormalizeMethod("image_per_channel", "'image_per_channel'"));
				comboBox.Items.Add(new NormalizeMethod("min_max", "'min_max'"));
				comboBox.Items.Add(new NormalizeMethod("min_max_per_channel", "'min_max_per_channel'"));
				for (int i = 0; i < comboBox.Items.Count; i++)
				{
					if ((comboBox.Items[i] is NormalizeMethod item) &&
						((item.ArgumentValue.Trim('\'') == default_item) ||
						(item.Name == default_item)))
					{
						comboBox.SelectedIndex = i;
						return;
					}
				}
				comboBox.SelectedIndex = 0;
			}

		}


		/// <summary>
		/// コンストラクタ
		/// </summary>
		public Normalize():base()
		{
			InitializeComponent();
			// コンボボックスに設定
			ParaNormalization.DefaultValue = "standard";
			ParaNormalization.ItemType = typeof(NormalizeMethod).ToString();

		}
		/// <summary>
		/// バージョンの設定
		/// </summary>
		/// <param name="version"></param>
		protected override void SetVersion(VersionInfo version)
		{
			base.SetVersion(version);
			// バージョンの設定
			SetVersion(version, FLPParam.Controls);
		}
		/// <summary>
		/// パラメータのチェック
		/// </summary>
		/// <param name="err_msg"></param>
		/// <returns></returns>
		public override bool CheckParameter(out string err_msg)
		{
			return CheckParameter(FLPParam.Controls, out err_msg);
		}

		/// <summary>
		/// パラメータ引数の生成
		/// </summary>
		/// <returns></returns>
		protected override string GetArguments(bool always_apply = false)
		{
			if (CheckParameter(out _))
				return GetArguments(FLPParam.Controls, always_apply);
			return null;
		}
		/// <summary>
		/// パラメータの設定
		/// </summary>
		/// <param name="controls"></param>
		/// <param name="parameters"></param>
		/// <returns></returns>
		protected override bool SetParameters(Dictionary<string, string> parameters)
		{
			bool result = SetParameters(FLPParam.Controls, parameters);
			result |= base.SetParameters(parameters);
			return result;
		}

		/// <summary>
		/// パラメータ変更イベント
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="name"></param>
		/// <param name="value"></param>
		private void Param_ParameterChange(object sender, string name, object value)
		{
			// イベント発行
			OnParameterChange(name, value);
		}
	}
}
