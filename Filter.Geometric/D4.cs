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
    [ModuleCategory("geometric", "幾何学変換"), Index(0), DisplayName("D4"), Description("正方形の入力に、正方形の形状を維持しながら、8つの可能な D4二面体グループ変換の1つを適用します。" +
        "これらの変換は、回転や反射を含む正方形の対称性に対応します。\r\n\r\n" +
        "D4 グループ変換には次のものが含まれます:\r\n" +
        "- 'e' (恒等): 変換は適用されません。\r\n" +
        "- 'r90' (反時計回りに 90 度回転)\r\n" +
        "- 'r180' (180 度回転)\r\n" +
        "- 'r270' (反時計回りに 270 度回転)\r\n" +
        "- 'v' (垂直中心線を横切る反射)\r\n" +
        "- 'hvt' (対角線を横切る反射)\r\n" +
        "- 'h' (水平中心線を横切る反射)\r\n" +
        "- 't' (主対角線を横切る反射)\r\n\r\n" +
        "変換を適用する確率 (`p`) が 1 に設定されている場合でも、恒等変換 'e' が発生する可能性があり、これは 8 ケースのうち 1 ケースでは入力が変更されないことを意味します。")]
    public partial class D4 : BaseFilterControl
    {
        public D4():base()
        {
            InitializeComponent();
        }
    }
}
