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
    [ModuleCategory("blur", "ぼかし"), Index(0), DisplayName("ガラスぼかし"), Description("入力画像にガラスのぼかし効果を適用します。\r\n\r\n" +
        "この変換は、画像内のピクセルをローカルにシャッフルすることで、テクスチャガラスを通して見る効果をシミュレートします。" +
        "歪んだ、すりガラスのような外観を作成します。")]

    public partial class GlassBlur : BaseFilterControl
    {
        /// <summary>
        /// 計算モードクラス
        /// </summary>
        private class CalcMode : IComboBox
        {
            /// <summary>
            /// 名前
            /// </summary>
            public string Name { get; private set; }
            /// <summary>
            /// 引数に使用する値
            /// </summary>
            public string ArgumentValue { get; private set; }

            /// <summary>
            /// コンストラクタ
            /// </summary>
            /// <param name="name"></param>
            /// <param name="argumentValue"></param>
            public CalcMode(string name, string argumentValue)
            {
                Name = name;
                ArgumentValue = argumentValue;
            }
            /// <summary>
            /// 文字列変換
            /// </summary>
            /// <returns></returns>
            public override string ToString()
            {
                return Name;
            }
            /// <summary>
            /// コンボボックスの生成
            /// </summary>
            /// <param name="comboBox"></param>
            /// <param name="default_item"></param>
            public static void MakeComboBox(ComboBox comboBox, string default_item)
            {
                comboBox.Items.Clear();
                comboBox.Items.Add(new CalcMode("高速","'fast'"));
                comboBox.Items.Add(new CalcMode("正確", "'exact'"));
                for (int i = 0; i < comboBox.Items.Count; i++)
                {
                    if ((comboBox.Items[i] is CalcMode item) && 
                        ((item.ArgumentValue == default_item)  ||
                        (item.ArgumentValue.Trim('\'') == default_item) ||
                        (item.Name == default_item)))
                    {
                        comboBox.SelectedIndex = i;
                        return;
                    }
                }
                comboBox.SelectedIndex = 0;
            }
        }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public GlassBlur() : base()
        {
            InitializeComponent();
            // コンボボックスに設定
            ParaMode.DefaultValue = "fast";
            ParaMode.ItemType = typeof(CalcMode).ToString();
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
