using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FilterBase;
namespace Filter.Geometric
{
    [ModuleCategory("geometric", "幾何学変換"), Index(0), DisplayName("Random Rotate90"), Description("入力をランダムに 90 度回転します (0 回以上)。")]
    public partial class RandomRotate90 : BaseFilterControl
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public RandomRotate90():base()
        {
            InitializeComponent();
        }
        /// <summary>
        /// コンストラクタ（パラメータ指定）
        /// </summary>
        /// <param name="parameters">パラメータ</param>
        public RandomRotate90(Dictionary<string, string> parameters) : this()
        {
            // パラメータ設定
            SetParameters(parameters);
        }
        /// <summary>
        /// バージョン指定コンストラクタ
        /// </summary>
        /// <param name="version">バージョン</param>
        public RandomRotate90(VersionInfo version) : this()
        {
            Version = version;
        }

    }
}
