using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlbumentationsCSharp
{
    public partial class WaitDialog : Form
    {
        public WaitDialog()
        {
            InitializeComponent();
        }
        /// <summary>
        /// キャンセルボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        public void SetResult(bool isOk)
        {
            DialogResult = (isOk)? DialogResult.OK: DialogResult.Cancel;
            this.Close();
        }
    }
}
