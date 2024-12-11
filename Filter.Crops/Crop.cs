using FilterBase;
using FilterBase.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static Filter.Crops.CenterCrop;

namespace Filter.Crops
{
    [ModuleCategory("crops", "切り抜き"), Index(0), DisplayName("切り抜き"), Description("入力画像から特定の領域を切り取ります。\r\n\r\n" +
        "この変換は、指定された座標に基づいて、入力画像、マスク、境界ボックス、キーポイントから長方形の領域を切り取ります。" +
        "入力から特定の関心領域を抽出したい場合に便利です。")]
    public partial class Crop : FilterBase.BaseFilterControl
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public Crop():base()
        {
            InitializeComponent();

            // コンボボックスの生成
            ParaPadPosition.DefaultValue = "center";
            ParaPadPosition.ItemType = typeof(PadPosition).ToString();
            // Pad Modeの変更処理
            ChangeParaPadMod();

        }
        /// <summary>
        /// コンストラクタ（パラメータ指定）
        /// </summary>
        /// <param name="parameters">パラメータ</param>
        public Crop(Dictionary<string, string> parameters) : this()
        {
            // パラメータ設定
            SetParameters(parameters);
        }
        /// <summary>
        /// バージョン指定コンストラクタ
        /// </summary>
        /// <param name="version">バージョン</param>
        public Crop(VersionInfo version) : this()
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
