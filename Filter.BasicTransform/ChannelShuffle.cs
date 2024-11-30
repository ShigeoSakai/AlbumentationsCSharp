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
    [ModuleCategory("transform", "基本変換"), Index(0), DisplayName("チャネルシャフル"), Description("画像のチャンネルをランダムに並べ替えます。")]
    public partial class ChannelShuffle : BaseFilterControl
    {
        public ChannelShuffle() :base()
        {
            InitializeComponent();
        }
    }
}
