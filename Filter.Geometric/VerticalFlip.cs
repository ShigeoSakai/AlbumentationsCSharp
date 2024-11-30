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
    [ModuleCategory("geometric", "幾何学変換"), Index(2), DisplayName("縦反転"), Description("入力をx軸を中心に垂直に反転します。")]
    public partial class VerticalFlip : BaseFilterControl
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public VerticalFlip() : base()
        {
            InitializeComponent();
        }
    }
}
