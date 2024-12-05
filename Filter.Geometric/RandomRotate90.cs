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
        public RandomRotate90():base()
        {
            InitializeComponent();
        }
    }
}
