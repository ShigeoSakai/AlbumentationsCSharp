using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FilterBase.Enums;
using FilterBase;

namespace Filter.Geometric
{
    [ModuleCategory("geometric", "幾何学変換"), Index(0), DisplayName("弾性変換"), Description("画像、マスク、境界ボックス、キーポイントに弾性変形を適用します。\r\n\r\n" +
        "この変換により、入力データにランダムな弾性歪みが導入されます。" +
        "これは、ディープラーニング モデルのトレーニングにおけるデータ拡張、特に、リアルな変形を導入しながら特徴の相対位置を維持したい画像セグメンテーションやオブジェクト検出などのタスクに役立ちます。\r\n\r\n" +
        "この変換は、ランダムな変位フィールドを生成し、それを入力に適用することで機能します。\r\n\r\n" +
        "これらのフィールドは、ガウス フィルターを使用して平滑化され、より自然に見える歪みが作成されます。")]
    public partial class ElasticTransform : BaseFilterControl
    {
        /// <summary>
        /// ノイズ分布方法
        /// </summary>
        private class NoiseDistributionMethod : IComboBox
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
            public NoiseDistributionMethod(string name, string argumentValue)
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
                comboBox.Items.Add(new NoiseDistributionMethod("均一", "'uniform'"));
                comboBox.Items.Add(new NoiseDistributionMethod("ガウス分布", "'gaussian'"));
                for (int i = 0; i < comboBox.Items.Count; i++)
                {
                    if ((comboBox.Items[i] is NoiseDistributionMethod item) &&
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
        public ElasticTransform():base()
        {
            InitializeComponent();

            // コンボボックスの生成
            ParaNoiseDistribution.DefaultValue = "gaussian";
            ParaNoiseDistribution.ItemType = typeof(NoiseDistributionMethod).ToString();
            // ボーダーモードの変更
            BorderModeChange(ParaBorderMode.Value);

        }
        /// <summary>
        /// コンストラクタ（パラメータ指定）
        /// </summary>
        /// <param name="parameters">パラメータ</param>
        public ElasticTransform(Dictionary<string, string> parameters) : this()
        {
            // パラメータ設定
            SetParameters(parameters);
        }
        /// <summary>
        /// バージョン指定コンストラクタ
        /// </summary>
        /// <param name="version">バージョン</param>
        public ElasticTransform(VersionInfo version) : this()
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
        /// <summary>
        /// ボーダーモードの変更
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="index"></param>
        /// <param name="value"></param>
        private void ParaBorderMode_SelectedIndexChanged(object sender, int index, object value)
        {
            // ボーダーモードの変更
            BorderModeChange(value);
        }
        /// <summary>
        /// ボーダーモードの変更
        /// </summary>
        /// <param name="value"></param>
        private void BorderModeChange(object value)
        {
            if (value is BorderTypes item)
            {
                ParaValue.Enabled = (item.Value == CV2_BORDER.CONSTANT);
                ParaMaskValue.Enabled = (item.Value == CV2_BORDER.CONSTANT);
            }
        }
    }
}
