using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using FilterBase;

namespace Filter.DropOut
{
    [ModuleCategory("dropout", "ドロップアウト"), Index(0), DisplayName("チャネル"), Description("入力画像内のチャネルをランダムにドロップします。\r\n\r\n" +
        "この変換は、入力画像からドロップするチャネルの数をランダムに選択し、指定された塗りつぶし値で置き換えます。\r\n" + 
        "これにより、欠落または破損したチャネルに対するモデルの堅牢性が向上します。\r\n" +
        "この手法は、概念的に次のものと似ています。\r\n" +
        "- ニューラルネットワークのドロップアウトレイヤー。トレーニング中に入力ユニットをランダムに0に設定します。\r\n" +
        "- CoarseDropout拡張。画像の空間次元内の領域をドロップします。\r\n" +
        "ただし、ChannelDropoutはチャネル次元で動作し、カラーチャネルまたは特徴マップ全体を効果的に「ドロップアウト」します。")]
    public partial class ChannelDropout : FilterBase.BaseFilterControl
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public ChannelDropout():base()
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
