using FilterBase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlbumentationsCSharp.Composition
{
    public partial class CompositionForm : Form
    {
        public CompositionForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// メニュー：ファイルから読み込み
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ToolStripMenuItemLoadFile_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// メニュー：テキスト入力
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ToolStripMenuItemLoadText_Click(object sender, EventArgs e)
        {
            TextInputForm form = new TextInputForm();
            if (form.ShowDialog() == DialogResult.OK)
            {   // ツリーを生成
                PanelCompositionControl.SetText(form.InputText);
            }
            form.Dispose();
            form = null;
        }
    }
}
