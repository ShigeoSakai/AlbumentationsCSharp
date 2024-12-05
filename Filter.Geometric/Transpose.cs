﻿using FilterBase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Filter.Geometric
{
    [ModuleCategory("geometric", "幾何学変換"), Index(0), DisplayName("行列入れ替え"), Description("行と列を入れ替えて入力を転置します。\r\n\r\n" +
        "この変換は、画像を主対角線上で反転し、実質的に幅と高さを切り替えます。\r\n\r\n" +
        "これは、90 度回転してから水平反転するのと同じです。")]
    public partial class Transpose : FilterBase.BaseFilterControl
    {
        public Transpose():base()
        {
            InitializeComponent();
        }
    }
}