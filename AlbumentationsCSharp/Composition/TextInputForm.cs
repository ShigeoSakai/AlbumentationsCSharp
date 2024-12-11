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
    public partial class TextInputForm : Form
    {
        /// <summary>
        /// 入力テキスト
        /// </summary>
        public string InputText
        {
            get => TbInput.Text;
            set => TbInput.Text = value;
        }
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public TextInputForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="text">初期表示テキスト</param>
        public TextInputForm(string text) :this()
        {
            TbInput.Text = text;
        }
        /// <summary>
        /// OKボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtOk_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
