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
namespace Filter.Blur
{
    [ModuleCategory("blur", "ぼかし"), Index(1), DisplayName("MedianBlur"), Description("入力画像にメディアンブラーを適用します。\r\n\r\n" +
        "この変換では、メディアンフィルターを使用して入力画像をぼかします。\r\n" +
        "メディアンフィルタリングは、エッジを保持しながらごま塩ノイズを除去するのに特に効果的であるため、\r\n" +
        "画像処理におけるノイズ低減によく使用されます。")]
    public partial class MedianBlur : BaseFilterControl
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public MedianBlur() :base()
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
        /// パラメータ変更イベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="name"></param>
        /// <param name="value"></param>
        private void ParaKernel_ParameterChange(object sender, string name, object value)
        {
            // パラメータ変更イベント発行
            OnParameterChange(name, value);
        }
    }
}
