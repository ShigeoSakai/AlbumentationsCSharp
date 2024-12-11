using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FilterBase;
namespace Filter.BasicTransform
{
    [ModuleCategory("transform", "基本変換"), Index(0) ,DisplayName("画像反転"), Description("画像タイプの最大値からピクセル値を減算して入力画像を反転します。")]
    public partial class InvertImg : BaseFilterControl
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public InvertImg() : base()
        {
            InitializeComponent();
        }
        /// <summary>
        /// コンストラクタ（パラメータ指定）
        /// </summary>
        /// <param name="parameters">パラメータ</param>
        public InvertImg(Dictionary<string, string> parameters) : this()
        {
            // パラメータ設定
            SetParameters(parameters);
        }
        /// <summary>
        /// バージョン指定コンストラクタ
        /// </summary>
        /// <param name="version">バージョン</param>
        public InvertImg(VersionInfo version) : this()
        {
            Version = version;
        }

    }
}
