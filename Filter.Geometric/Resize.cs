using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FilterBase;
namespace Filter.Geometric
{
    [ModuleCategory("geometric", "幾何学変換"),Index(0), DisplayName("リサイズ"), Description("入力を指定された高さと幅にサイズ変更します。")]
    public partial class Resize : BaseFilterControl
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public Resize() :base()
        {
            InitializeComponent();
        }
        /// <summary>
        /// バージョンの設定
        /// </summary>
        /// <param name="version"></param>
        protected override void SetVersion(VersionInfo version)
        {
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
        /// パラメータ変更イベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="name"></param>
        /// <param name="value"></param>
        private void ParameterChange_Event(object sender, string name, object value)
        {
            // パラメータ変更イベント発行
            OnParameterChange(name, value);
        }
    }
}
