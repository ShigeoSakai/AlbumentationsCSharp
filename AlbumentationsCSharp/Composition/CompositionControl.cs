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
    public partial class CompositionControl : UserControl
    {
        /// <summary>
        /// 解析結果
        /// </summary>
        private TransformParser transform;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public CompositionControl()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Pythonテキストを設定
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public bool SetText(string text)
        {
            return MakeTree(text);
        }
        /// <summary>
        /// Treeの生成
        /// </summary>
        /// <param name="text"></param>
        private bool MakeTree(string text)
        {
            if (transform != null)
            {
                transform.Dispose();
                transform = null;
            }
            // 文字列から解析
            transform = new TransformParser(text);
            if ((transform != null) && (transform.ErrorCode == SSTools.SimpleParser.ERROR_CODE.NONE))
            {   // 解析OK -> TreeViewに追加
                CompositionTreeView.Nodes.Clear();
                CompositionTreeView.Nodes.Add(CoreCompositionNode.GetNode(transform.RootFunc.Name, transform.RootFunc.Argumnet));
                CompositionTreeView.ExpandAll();
                return true;
            }
            return false;
        }
        /// <summary>
        /// TreeViewの選択範囲が変更になった
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CompositionTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if ((e.Node != null) && (e.Node.IsSelected) &&
                (e.Node is FilterNode filterNode))
            {
                BaseFilterControl ctrl = filterNode.GetControl();
                if (FilterPanel.Controls.Count > 0)
                {
                    FilterPanel.Controls.Clear();
                }
                FilterPanel.Controls.Add(ctrl);
            }
        }
    }
}
