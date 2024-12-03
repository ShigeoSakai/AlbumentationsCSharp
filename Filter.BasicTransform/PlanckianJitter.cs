using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FilterBase;
using FilterBase.Parts;
namespace Filter.BasicTransform
{
    [ModuleCategory("transform", "基本変換"), Index(0), DisplayName("プランクジッター"), Description("プランクジッターを入力画像に適用し、照明の色温度の変化をシミュレートします。\r\n\r\n" +
        "この変換は、プランクの黒体放射の法則に基づいて、画像の色を調整し、光源のさまざまな色温度の効果を模倣します。" +
        "暖色 (赤みがかった) から寒色 (青みがかった) の色かぶりまで、さまざまな照明条件下での画像の外観をシミュレートできます。")]

    public partial class PlanckianJitter :BaseFilterControl
    {
        /// <summary>
        /// モード
        /// </summary>
        private class PlanckMode : IComboBox
        {
            /// <summary>
            /// 名前
            /// </summary>
            public string Name { get;private set; }
            /// <summary>
            /// 値
            /// </summary>
            public string ArgumentValue { get; private set; }
            /// <summary>
            /// コンストラクタ
            /// </summary>
            /// <param name="name"></param>
            /// <param name="argumentValue"></param>
            public PlanckMode(string name, string argumentValue)
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
                comboBox.Items.Add(new PlanckMode("黒体放射", "'blackbody'"));
                comboBox.Items.Add(new PlanckMode("CIE D光源", "'cied'"));
                for (int i = 0; i < comboBox.Items.Count; i++)
                {
                    if ((comboBox.Items[i] is PlanckMode item) &&
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
        /// サンプリング方法
        /// </summary>
        private class SamplingMethod : IComboBox
        {
            /// <summary>
            /// 名前
            /// </summary>
            public string Name { get; private set; }
            /// <summary>
            /// 値
            /// </summary>
            public string ArgumentValue { get; private set; }
            /// <summary>
            /// コンストラクタ
            /// </summary>
            /// <param name="name"></param>
            /// <param name="argumentValue"></param>
            public SamplingMethod(string name, string argumentValue)
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
                comboBox.Items.Add(new SamplingMethod("均一", "'uniform'"));
                comboBox.Items.Add(new SamplingMethod("ガウス分布", "'gaussian'"));
                for (int i = 0; i < comboBox.Items.Count; i++)
                {
                    if ((comboBox.Items[i] is SamplingMethod item) &&
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
        public PlanckianJitter():base()
        {
            InitializeComponent();

            // コンボボックスに設定
            ParaMode.DefaultValue = "blackbody";
            ParaMode.ItemType = typeof(PlanckMode).ToString();

            ParaSamplingMethod.DefaultValue = "uniform";
            ParaSamplingMethod.ItemType = typeof(SamplingMethod).ToString();

            // Limitの設定(黒体放射)
            ParaTemperatureLimit.MaxValue = 15000;
            ParaTemperatureLimit.MinValue = 3000;
            ParaTemperatureLimit.Value = "(3000, 15000)";

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
        /// パラメータ変更
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="name"></param>
        /// <param name="value"></param>
        private void Param_ParameterChange(object sender, string name, object value)
        {
            OnParameterChange(name, value);
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
        /// モードが変更になった
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="index"></param>
        /// <param name="value"></param>
        private void ParaMode_SelectedIndexChanged(object sender, int index, object value)
        {
            // 現在の色温度範囲を取得
            string nowValue = ParaTemperatureLimit.Value;
            Tuple<decimal,decimal> t_value = PartsFunc.GetTuppleFromString(nowValue,ParaTemperatureLimit.ValueType);

            if (value is PlanckMode mode)
            {
                if (mode.ArgumentValue == "blackbody")
                {
                    ParaTemperatureLimit.MinValue = 3000;
                    ParaTemperatureLimit.MaxValue = 15000;
                    ParaTemperatureLimit.Value = "(3000, 15000)";
                }
                else
                {
                    ParaTemperatureLimit.MinValue = 4000;
                    ParaTemperatureLimit.MaxValue = 15000;
                    ParaTemperatureLimit.Value = "(4000, 15000)";
                }
            }
        }
    }
}
