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
    [ModuleCategory("transform", "基本変換"), Index(0), DisplayName("グレースケール"), Description("画像をグレースケールに変換し、オプションでグレースケールチャネルを複製します。\r\n\r\n" +
        "この変換では、まずさまざまな方法を使用してカラー画像を単一チャネルのグレースケール画像に変換し、次に num_output_channels が 1 より大きい場合はグレースケール チャネルを複製します。")]
    public partial class ToGray : BaseFilterControl
    {
        /// <summary>
        /// 変換方法
        /// </summary>
        private class GrayMethod : IComboBox
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
            public GrayMethod(string name, string argumentValue)
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
                comboBox.Items.Add(new GrayMethod("加重平均", "'weighted_average'"));
                comboBox.Items.Add(new GrayMethod("LAB色空間", "'from_lab'"));
                comboBox.Items.Add(new GrayMethod("彩度低下", "'desaturation'"));
                comboBox.Items.Add(new GrayMethod("単純平均", "'average'"));
                comboBox.Items.Add(new GrayMethod("最大値", "'max'"));
                comboBox.Items.Add(new GrayMethod("主成分分析", "'pca'"));
                for (int i = 0; i < comboBox.Items.Count; i++)
                {
                    if ((comboBox.Items[i] is GrayMethod item) &&
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
        public ToGray():base()
        {
            InitializeComponent();
            // コンボボックスの生成
            ParaMethod.DefaultValue = "weighted_average";
            ParaMethod.ItemType = typeof(GrayMethod).ToString();
        }
        /// <summary>
        /// コンストラクタ（パラメータ指定）
        /// </summary>
        /// <param name="parameters">パラメータ</param>
        public ToGray(Dictionary<string, string> parameters) : this()
        {
            // パラメータ設定
            SetParameters(parameters);
        }
        /// <summary>
        /// バージョン指定コンストラクタ
        /// </summary>
        /// <param name="version">バージョン</param>
        public ToGray(VersionInfo version) : this()
        {
            Version = version;
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
