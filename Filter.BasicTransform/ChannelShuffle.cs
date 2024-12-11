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
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public ChannelShuffle() :base()
        {
            InitializeComponent();
        }
        /// <summary>
        /// コンストラクタ（パラメータ指定）
        /// </summary>
        /// <param name="parameters">パラメータ</param>
        public ChannelShuffle(Dictionary<string, string> parameters) : this()
        {
            // パラメータ設定
            SetParameters(parameters);
        }
        /// <summary>
        /// バージョン指定コンストラクタ
        /// </summary>
        /// <param name="version">バージョン</param>
        public ChannelShuffle(VersionInfo version) : this()
        {
            Version = version;
        }

    }
}
