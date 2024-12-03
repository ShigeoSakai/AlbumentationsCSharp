using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FilterBase.Enums;
using FilterBase;
namespace Filter.Geometric
{
    [ModuleCategory("geometric", "幾何学変換"), Index(0), DisplayName("光学歪み"), Description("画像、マスク、境界ボックス、キーポイントに光学歪みを適用します。\r\n\r\n" +
        "この変換は、カメラ マトリックスと歪み係数を使用して画像を歪ませることで、レンズ歪み効果をシミュレートします。" +
        "これは、カメラ レンズ効果が関係するコンピューター ビジョン タスクでデータを拡張する場合に特に便利です。")]
    public partial class OpticalDistortion : BaseFilterControl
    {
        public OpticalDistortion():base()
        {
            InitializeComponent();
            // ボーダーモードの変更
            BorderModeChange(ParaBorderMode.Value);
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
        /// ボーダーモードの変更
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="index"></param>
        /// <param name="value"></param>
        private void ParaBorderMode_SelectedIndexChanged(object sender, int index, object value)
        {
            // ボーダーモードの変更
            BorderModeChange(value);
        }
        /// <summary>
        /// ボーダーモードの変更
        /// </summary>
        /// <param name="value"></param>
        private void BorderModeChange(object value)
        {
            if (value is BorderTypes item)
            {
                ParaValue.Enabled = (item.Value == CV2_BORDER.CONSTANT);
                ParaMaskValue.Enabled = (item.Value == CV2_BORDER.CONSTANT);
            }
        }
    }
}
