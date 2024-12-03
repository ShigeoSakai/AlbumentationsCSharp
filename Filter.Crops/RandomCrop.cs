using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using static System.Net.Mime.MediaTypeNames;
using FilterBase.Enums;
using FilterBase;

namespace Filter.Crops
{
    [ModuleCategory("crops", "切り抜き"), Index(0), DisplayName("ランダム切り抜き"), Description("入力のランダムな部分を切り取ります。")]
    public partial class RandomCrop : BaseFilterControl
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public RandomCrop() :base()
        {
            InitializeComponent();

            // コンボボックスの生成
            ParaPadPosition.DefaultValue = "center";
            ParaPadPosition.ItemType = typeof(CenterCrop.PadPosition).ToString();
            // Pad Modeの変更処理
            ChangeParaPadMod();
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
        /// Pad Modeの変更処理
        /// </summary>
        private void ChangeParaPadMod()
        {
            if (ParaPadMode.Value is BorderTypes border)
            {
                ParaPadCval.Enabled = (border.Value == CV2_BORDER.CONSTANT);
                ParaPadMaskCval.Enabled = (border.Value == CV2_BORDER.CONSTANT);
            }
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
                return GetArguments(FLPParam.Controls,always_apply);
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
        /// Pad Modeが変更になった
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="index"></param>
        /// <param name="value"></param>
        private void ParaPadMode_SelectionChangeCommitted(object sender, int index, object value)
        {
            // Pad Modeの変更処理
            ChangeParaPadMod();
        }
        /// <summary>
        /// パラメータ変更イベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="name"></param>
        /// <param name="value"></param>
        private void Ctrl_ParameterChange(object sender, string name, object value)
        {
            // パラメータ変更イベント発行
            OnParameterChange(name, value);
        }
    }
}
