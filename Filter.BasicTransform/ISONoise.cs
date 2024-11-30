using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FilterBase;
namespace Filter.BasicTransform
{
    [ModuleCategory("transform", "基本変換"), Index(1), DisplayName("ISOノイズ"), Description("入力画像にカメラセンサーのノイズを適用し、高ISO設定をシミュレートします。\r\n\r\n" +
        "この変換は画像にランダムノイズを追加し、高ISO設定を使用した効果を模倣します。\r\n" +
        "デジタル写真におけるISOノイズの2つの主な要素をシミュレートします。\r\n" +
        "    1. カラーノイズ: 色相のランダムな変化\r\n" +
        "    2. 輝度ノイズ: ピクセルの輝度のランダムな変化\r\n")]
    public partial class ISONoise : BaseFilterControl
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public ISONoise() :base()
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
            SetVersion(version, FLPParts.Controls);
        }
        /// <summary>
        /// パラメータのチェック
        /// </summary>
        /// <param name="err_msg"></param>
        /// <returns></returns>
        public override bool CheckParameter(out string err_msg)
        {
            return CheckParameter(FLPParts.Controls, out err_msg);
        }

        /// <summary>
        /// パラメータ引数の生成
        /// </summary>
        /// <returns></returns>
        protected override string GetArguments(bool always_apply = false)
        {
            if (CheckParameter(out _))
                return GetArguments(FLPParts.Controls,always_apply);
            return null;
        }
        /// <summary>
        /// パラメータ変更
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="name"></param>
        /// <param name="value"></param>
        private void Param_ParameterChange(object sender, string name, object value)
        {
            OnParameterChange(name, value);
        }
    }
}
