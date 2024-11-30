using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FilterBase;
namespace Filter.BasicTransform
{
    [ModuleCategory("transform", "基本変換"), Index(0), DisplayName("効果:雨"), Description("画像に雨の効果を追加します。\r\n\r\n" +
        "この変換は、画像に半透明の縞を重ねて降雨をシミュレートし、リアルな雨の効果を生み出します。" +
        "雨天時に優れたパフォーマンスを発揮する必要があるコンピュータービジョンタスクのデータセットを拡張するために使用できます。")]
    public partial class RandomRain : BaseFilterControl
    {

        /// <summary>
        /// 雨の種類
        /// </summary>
        private class RainType : IComboBox
        {
            /// <summary>
            /// 名前
            /// </summary>
            public string Name { get; private set; }
            /// <summary>
            /// 値
            /// </summary>
            public string ArgumentValue { get; set; }
            /// <summary>
            /// コンストラクタ
            /// </summary>
            /// <param name="name"></param>
            /// <param name="argumentValue"></param>
            public RainType(string name, string argumentValue)
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
                comboBox.Items.Add(new RainType("霧雨", "'drizzle'"));
                comboBox.Items.Add(new RainType("大雨", "'heavy'"));
                comboBox.Items.Add(new RainType("集中豪雨", "'torrential'"));
                comboBox.Items.Add(new RainType("普通", "'default'"));
                for (int i = 0; i < comboBox.Items.Count; i++)
                {
                    if ((comboBox.Items[i] is RainType item) &&
                        ((item.ArgumentValue.Trim('\'') == default_item) ||
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
        public RandomRain():base()
        {
            InitializeComponent();

            // コンボボックスの生成
            ParaRainType.DefaultValue = "default";
            ParaRainType.ItemType = typeof(RainType).ToString();
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


            // 1.4.16からRainTypeがNone->'default'に変わる
            foreach(object obj in ParaRainType.Items)
            {
                if (obj is RainType item)
                {
                    if (item.Name == "普通")
                    {
                        if (version.CompareTo(1, 4, 6) < 0)
                            item.ArgumentValue = "None";
                        else
                            item.ArgumentValue = "'default'";
                    }
                }
            }
            // 1.4.7から範囲が変わる
            if (version.CompareTo(1, 4, 7) < 0)
            {
                if (ParaDropLength.Value > 100)
                    ParaDropLength.Value = 100;
                ParaDropLength.MaxValue = 100;
                if (ParaDropWidth.Value > 5)
                    ParaDropWidth.Value = 5;
                ParaDropWidth.MaxValue = 5;
            }
            else
            {
                ParaDropLength.MaxValue = 10000;
                ParaDropWidth.MaxValue = 10000;
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
