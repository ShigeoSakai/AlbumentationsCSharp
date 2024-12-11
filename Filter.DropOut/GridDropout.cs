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
    [ModuleCategory("dropout", "ドロップアウト"), Index(0), DisplayName("グリッド"), Description("GridDropout 拡張を画像、マスク、境界ボックス、およびキーポイントに適用します。\r\n\r\n" +
        "GridDropout は、画像の長方形領域とそれに対応するマスクをグリッド形式でドロップします。\r\n\r\n" +
        "この手法は、ネットワークが特定のローカル機能ではなくより広いコンテキストに依存するように強制することで、モデルの堅牢性を向上させるのに役立ちます。")]

    public partial class GridDropout : FilterBase.BaseFilterControl
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public GridDropout() : base()
        {
            InitializeComponent();
        }
        /// <summary>
        /// コンストラクタ（パラメータ指定）
        /// </summary>
        /// <param name="parameters">パラメータ</param>
        public GridDropout(Dictionary<string, string> parameters) : this()
        {
            // パラメータ設定
            SetParameters(parameters);
        }
        /// <summary>
        /// バージョン指定コンストラクタ
        /// </summary>
        /// <param name="version">バージョン</param>
        public GridDropout(VersionInfo version) : this()
        {
            Version = version;
        }

        /// <summary>
        /// ランダムオフセットのチェックが変更になった
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ParaRandomOffset_CheckedChanged(object sender, EventArgs e)
        {
            ParaShiftXy.Enabled = !ParaRandomOffset.Checked;
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
