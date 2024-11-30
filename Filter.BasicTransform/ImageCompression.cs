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
    [ModuleCategory("transform", "基本変換"), Index(0), DisplayName("画像圧縮"), Description("JPEGまたはWebP圧縮を適用して画像の品質を下げます。\r\n\r\n" +
        "この変換は、圧縮アーティファクトが発生する可能性のある、低品質設定で画像を保存する効果をシミュレートします。" +
        "これは、データ拡張や、さまざまな画像品質に対するモデルの堅牢性をテストするのに役立ちます。")]
    public partial class ImageCompression : BaseFilterControl
    {
        /// <summary>
        /// 画像圧縮モードモードクラス
        /// </summary>
        private class CompressionMode : IComboBox
        {
            /// <summary>
            /// 名前
            /// </summary>
            public string Name { get; private set; }
            /// <summary>
            /// 引数に使用する値
            /// </summary>
            public string ArgumentValue { get; set; }

            /// <summary>
            /// コンストラクタ
            /// </summary>
            /// <param name="name"></param>
            /// <param name="argumentValue"></param>
            public CompressionMode(string name, string argumentValue)
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
                comboBox.Items.Add(new CompressionMode("JPEG", "'jpeg'"));
                comboBox.Items.Add(new CompressionMode("WebP", "'webp'"));
                for (int i = 0; i < comboBox.Items.Count; i++)
                {
                    if ((comboBox.Items[i] is CompressionMode item) &&
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
        public ImageCompression():base()
        {
            InitializeComponent();
            // コンボボックスに設定
            ParaCompressionType.DefaultValue = "jpeg";
            ParaCompressionType.ItemType = typeof(CompressionMode).ToString();
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


            // 1.4.7で圧縮方法を文字列指定が可能
            foreach (object obj in ParaCompressionType.Items)
            {
                if (obj is CompressionMode item)
                {
                    if (item.Name == "JPEG")
                    {
                        if (version.CompareTo(1, 4, 7) < 0)
                            item.ArgumentValue = "0";
                        else
                            item.ArgumentValue = "'jpeg'";
                    }
                    else if (item.Name == "WebP")
                    {
                        if (version.CompareTo(1, 4, 7) < 0)
                            item.ArgumentValue = "1";
                        else
                            item.ArgumentValue = "'webp'";
                    }
                }
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
