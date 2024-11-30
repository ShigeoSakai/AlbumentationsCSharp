using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FilterBase;
namespace Filter.Blur
{
    [ModuleCategory("blur", "ぼかし"), Index(3), DisplayName("MotionBlur"), Description("ランダムサイズのカーネルを使用して、入力画像にモーションブラーを適用します。\r\n\r\n" +
        "この変換は、画像キャプチャ中のカメラまたはオブジェクトの動きの効果をシミュレートし、方向性のあるブラーを作成します。\r\n" +
        "この効果を実現するために、ランダムな方向の線状のカーネルを使用します。\r\n")]
    public partial class MotionBlur : BaseFilterControl
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public MotionBlur() :base()
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
