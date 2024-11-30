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
    [ModuleCategory("transform", "基本変換"), Index(0), DisplayName("セピア"), Description("入力画像にセピアフィルターを適用します。\r\n\r\n" +
        "この変換により、カラー画像がセピア色に変換され、古い写真のような暖かみのある茶色がかった色合いになります。" +
        "セピア効果は、入力画像の RGB チャネルに特定の色変換マトリックスを適用することで実現されます。")]

    public partial class ToSepia : BaseFilterControl
    {
        public ToSepia():base()
        {
            InitializeComponent();
        }
    }
}
