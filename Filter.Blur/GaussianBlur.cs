﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FilterBase;
namespace Filter.Blur
{
    [ModuleCategory("blur", "ぼかし"), Index(1), DisplayName("ガウスぼかし"), Description("ランダムサイズのカーネルを使用して、入力画像にガウスぼかしを適用します。\r\n\r\n" +
        "この変換では、ランダムカーネル サイズとシグマ値を持つガウスフィルターを使用して入力画像をぼかします。\r\n" +
        "ガウスぼかしは、画像のノイズとディテールを減らしてスムージング効果を生み出す、広く使用されている画像処理手法です。")]

    public partial class GaussianBlur : BaseFilterControl
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public GaussianBlur() : base()
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
        private void ParaKernel_ParameterChange(object sender, string name, object value)
        {
            // イベント発行
            OnParameterChange(name, value);
        }

    }
}