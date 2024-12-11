using FilterBase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Filter.Crops
{
	[ModuleCategory("crops", "切り抜き"), Index(0), DisplayName("RandomSized BBoxSafeCrop"), Description("入力のランダムな部分を切り取り、境界ボックスを失うことなく特定のサイズに再スケールします。\r\n\r\n" +
		"この変換は、まず、すべての境界ボックスが切り取られた領域内に収まるようにしながら、入力画像のランダムな部分を切り取ろうとします。次に、切り取った部分を指定されたサイズに変更します。" +
		"これは、画像内のすべてのオブジェクトを保持しながら画像サイズを標準化することが重要なオブジェクト検出タスクに特に役立ちます。")]
	public partial class RandomSizedBBoxSafeCrop : FilterBase.BaseFilterControl
	{
		/// <summary>
		/// コンストラクタ
		/// </summary>
		public RandomSizedBBoxSafeCrop():base()
		{
			InitializeComponent();
		}
        /// <summary>
        /// コンストラクタ（パラメータ指定）
        /// </summary>
        /// <param name="parameters">パラメータ</param>
        public RandomSizedBBoxSafeCrop(Dictionary<string, string> parameters) : this()
        {
            // パラメータ設定
            SetParameters(parameters);
        }
        /// <summary>
        /// バージョン指定コンストラクタ
        /// </summary>
        /// <param name="version">バージョン</param>
        public RandomSizedBBoxSafeCrop(VersionInfo version) : this()
        {
            Version = version;
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
