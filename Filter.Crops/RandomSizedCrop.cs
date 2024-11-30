using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FilterBase;

namespace Filter.Crops
{
    [ModuleCategory("crops", "切り抜き"), Index(0), DisplayName("RandomSizedCrop"), Description("入力のランダムな部分を切り取り、特定のサイズに再スケールします。\r\n\r\n" +
        "この変換は、最初に入力のランダムな部分を切り取り、次に指定されたサイズにサイズ変更します。\r\n" +
        "ランダム切り取りのサイズは、「min_max_height」パラメータによって制御されます。")]
    public partial class RandomSizedCrop : FilterBase.BaseFilterControl
    {
        public RandomSizedCrop():base()
        {
            InitializeComponent();
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
