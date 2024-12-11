using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using static System.Net.Mime.MediaTypeNames;
using FilterBase;
using FilterBase.Enums;

namespace Filter.Crops
{
    [ModuleCategory("crops", "切り抜き"), Index(0), DisplayName("中央切り抜き"), Description("入力の中央部分を切り取ります。\r\n\r\n" +
        "この変換は、入力画像、マスク、境界ボックス、およびキーポイントの中央を指定された寸法に切り取ります。\r\n" +
        "入力の中央領域に焦点を合わせ、周辺情報を破棄したい場合に便利です。")]
    public partial class CenterCrop : BaseFilterControl
    {
        /// <summary>
        /// Pad位置
        /// </summary>
        public class PadPosition :IComboBox
        {
            // 'center'、'top_left'、'top_right'、'bottom_left'、 'bottom_right'、'random'
            public string Description { get; private set; }
            public string ArgumentValue { get; private set; }

            public PadPosition(string description, string value)
            {
                Description = description;
                ArgumentValue = value;
            }
            public override string ToString()
            {
                return Description;
            }
            public static void MakeComboBox(ComboBox comboBox,string default_value)
            {
                comboBox.Items.Clear();
                comboBox.Items.Add(new PadPosition("中央","'center'"));
                comboBox.Items.Add(new PadPosition("左上", "'top_left'"));
                comboBox.Items.Add(new PadPosition("右上", "'top_right'"));
                comboBox.Items.Add(new PadPosition("左下", "'bottom_left'"));
                comboBox.Items.Add(new PadPosition("右下", "'bottom_right'"));
                comboBox.Items.Add(new PadPosition("ランダム", "'random'"));

                for(int index = 0; index < comboBox.Items.Count; index ++)
                {
                    if ((comboBox.Items[index] is PadPosition item) &&
                        ((item.ArgumentValue.Trim('\'') == default_value) ||
                        (item.Description == default_value)))
                    {
                        comboBox.SelectedIndex = index;
                        return;
                    }
                }
                comboBox.SelectedIndex = 0;
            }
        }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public CenterCrop() :base()
        {
            InitializeComponent();

            // コンボボックスの生成
            ParaPadPosition.DefaultValue = "center";
            ParaPadPosition.ItemType = typeof(PadPosition).ToString();
            // Pad Modeの変更処理
            ChangeParaPadMod();
        }
        /// <summary>
        /// コンストラクタ（パラメータ指定）
        /// </summary>
        /// <param name="parameters">パラメータ</param>
        public CenterCrop(Dictionary<string, string> parameters) : this()
        {
            // パラメータ設定
            SetParameters(parameters);
        }
        /// <summary>
        /// バージョン指定コンストラクタ
        /// </summary>
        /// <param name="version">バージョン</param>
        public CenterCrop(VersionInfo version) : this()
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
        /// Pad Modeの変更処理
        /// </summary>
        private void ChangeParaPadMod()
        {
            if (ParaPadMode.Value is BorderTypes border)
            {
                ParaPadCval.Enabled = (border.Value == CV2_BORDER.CONSTANT);
                ParaPadMaskCval.Enabled = (border.Value == CV2_BORDER.CONSTANT);
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
                return GetArguments(FLPParam.Controls,always_apply);
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
        /// Pad Modeが変更になった
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="index"></param>
        /// <param name="value"></param>
        private void ParaPadMode_SelectionChangeCommitted(object sender, int index, object value)
        {
            // Pad Modeの変更処理
            ChangeParaPadMod();
        }
        /// <summary>
        /// パラメータ変更イベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="name"></param>
        /// <param name="value"></param>
        private void Ctrl_ParameterChange(object sender, string name, object value)
        {
            // パラメータ変更イベント発行
            OnParameterChange(name, value);
        }
    }
}
