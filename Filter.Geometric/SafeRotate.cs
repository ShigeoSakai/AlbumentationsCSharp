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
    [ModuleCategory("geometric", "幾何学変換"), Index(0), DisplayName("安全な回転"), Description("入力のフレーム内で、均一分布からランダムに選択された角度だけ入力を回転します。\r\n\r\n" +
        "この変換により、必要に応じて縮小して、回転した画像全体が元のフレーム内に収まるようになります。" +
        "結果の画像は元の寸法を維持しますが、回転と拡大縮小のプロセスによりアーティファクトが含まれる場合があります。")]
    public partial class SafeRotate : BaseFilterControl
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public SafeRotate():base()
        {
            InitializeComponent();

            // コンボボックスの生成
            ParaRotateMethod.DefaultValue = "largest_box";
            ParaRotateMethod.ItemType = typeof(Rotate.RotateMethod).ToString();
            // ボーダーモードで更新
            ChangeBorder(ParaBorderMode.Value);
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
        /// <summary>
        /// BorderModeが変更になった
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="index"></param>
        /// <param name="value"></param>
        private void ParaBorderMode_SelectedIndexChanged(object sender, int index, object value)
        {
            ChangeBorder(value);
        }
        /// <summary>
        /// BorderMode変更
        /// </summary>
        /// <param name="value"></param>
        private void ChangeBorder(object value)
        {
            if (value is BorderTypes item)
            {
                ParaValue.Enabled = (item.Value == CV2_BORDER.CONSTANT);
                ParaMaskValue.Enabled = (item.Value == CV2_BORDER.CONSTANT);
            }

        }
    }
}
