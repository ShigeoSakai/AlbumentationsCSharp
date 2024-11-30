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
    [ModuleCategory("transform", "基本変換"), Index(0), DisplayName("ソラリゼーション"), Description("しきい値を超えるすべてのピクセル値を反転します。\r\n\r\n" +
        "この変換は、入力画像にソラリゼーション効果を適用します。" +
        "ソラリゼーションとは、ネガまたは写真プリントに記録された画像の色調が全体的または部分的に反転する写真撮影の現象です。" +
        "暗い領域が明るく見えたり、明るい領域が暗く見えたりします。\r\n\r\nこの実装では、しきい値を超えるすべてのピクセル値が反転されます。")]
    public partial class Solarize : BaseFilterControl
    {
        public Solarize():base()
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
