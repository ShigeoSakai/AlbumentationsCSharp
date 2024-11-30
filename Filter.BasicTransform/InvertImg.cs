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
    }
}
