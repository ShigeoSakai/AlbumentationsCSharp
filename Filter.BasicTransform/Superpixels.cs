using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FilterBase;
namespace Filter.BasicTransform
{
    [ModuleCategory("transform", "基本変換"), Index(0), DisplayName("Superpixels"), Description("画像を部分的または完全にスーパーピクセル表現に変換します。")]
    public partial class Superpixels : BaseFilterControl
    {
        public Superpixels():base()
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
