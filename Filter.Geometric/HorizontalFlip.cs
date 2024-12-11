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
namespace Filter.Geometric
{
    [ModuleCategory("geometric", "幾何学変換"), Index(1), DisplayName("横反転"), Description("入力をy軸を中心に水平に反転します。")]
    public partial class HorizontalFlip : BaseFilterControl
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public HorizontalFlip() : base()
        {
            InitializeComponent();
        }
        /// <summary>
        /// コンストラクタ（パラメータ指定）
        /// </summary>
        /// <param name="parameters">パラメータ</param>
        public HorizontalFlip(Dictionary<string, string> parameters) : this()
        {
            // パラメータ設定
            SetParameters(parameters);
        }
        /// <summary>
        /// バージョン指定コンストラクタ
        /// </summary>
        /// <param name="version">バージョン</param>
        public HorizontalFlip(VersionInfo version) : this()
        {
            Version = version;
        }
    }
}
