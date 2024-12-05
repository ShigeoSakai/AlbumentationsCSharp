using FilterBase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Filter.DropOut
{
    [ModuleCategory("dropout", "ドロップアウト"), Index(0), DisplayName("ピクセル"), Description("画像からランダムなピクセルを削除します。\r\n\r\n" +
        "この変換は、画像内のピクセルを指定された値にランダムに設定し、それらのピクセルを実質的に「削除」します。\r\n" +
        "これは、画像とそれに対応するマスクの両方に適用できます。")]
    public partial class PixelDropout : FilterBase.BaseFilterControl
    {
        public PixelDropout() : base()
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
        /// <summary>
        /// PerChannelのチェック変更
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ParaPerChannel_CheckedChanged(object sender, EventArgs e)
        {
            ParaMaskDropValue.Enabled = !ParaPerChannel.Checked;
        }
    }
}
