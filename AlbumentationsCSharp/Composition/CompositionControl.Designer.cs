namespace AlbumentationsCSharp.Composition
{
    partial class CompositionControl
    {
        /// <summary> 
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region コンポーネント デザイナーで生成されたコード

        /// <summary> 
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を 
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.MainSplitContainer = new System.Windows.Forms.SplitContainer();
            this.CompositionTreeView = new System.Windows.Forms.TreeView();
            this.PanelExec = new System.Windows.Forms.Panel();
            this.CbImmediate = new System.Windows.Forms.CheckBox();
            this.BtExec = new System.Windows.Forms.Button();
            this.FilterPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.MainSplitContainer)).BeginInit();
            this.MainSplitContainer.Panel1.SuspendLayout();
            this.MainSplitContainer.Panel2.SuspendLayout();
            this.MainSplitContainer.SuspendLayout();
            this.PanelExec.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainSplitContainer
            // 
            this.MainSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainSplitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.MainSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.MainSplitContainer.Name = "MainSplitContainer";
            // 
            // MainSplitContainer.Panel1
            // 
            this.MainSplitContainer.Panel1.Controls.Add(this.CompositionTreeView);
            // 
            // MainSplitContainer.Panel2
            // 
            this.MainSplitContainer.Panel2.Controls.Add(this.FilterPanel);
            this.MainSplitContainer.Panel2.Controls.Add(this.PanelExec);
            this.MainSplitContainer.Panel2MinSize = 151;
            this.MainSplitContainer.Size = new System.Drawing.Size(398, 296);
            this.MainSplitContainer.SplitterDistance = 243;
            this.MainSplitContainer.TabIndex = 0;
            // 
            // CompositionTreeView
            // 
            this.CompositionTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CompositionTreeView.Location = new System.Drawing.Point(0, 0);
            this.CompositionTreeView.Name = "CompositionTreeView";
            this.CompositionTreeView.Size = new System.Drawing.Size(243, 296);
            this.CompositionTreeView.TabIndex = 1;
            this.CompositionTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.CompositionTreeView_AfterSelect);
            // 
            // PanelExec
            // 
            this.PanelExec.AutoSize = true;
            this.PanelExec.Controls.Add(this.CbImmediate);
            this.PanelExec.Controls.Add(this.BtExec);
            this.PanelExec.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelExec.Location = new System.Drawing.Point(0, 241);
            this.PanelExec.Margin = new System.Windows.Forms.Padding(0);
            this.PanelExec.Name = "PanelExec";
            this.PanelExec.Size = new System.Drawing.Size(151, 55);
            this.PanelExec.TabIndex = 5;
            // 
            // CbImmediate
            // 
            this.CbImmediate.Checked = true;
            this.CbImmediate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CbImmediate.Location = new System.Drawing.Point(18, 3);
            this.CbImmediate.Name = "CbImmediate";
            this.CbImmediate.Size = new System.Drawing.Size(120, 24);
            this.CbImmediate.TabIndex = 0;
            this.CbImmediate.Text = "変更になったら実行";
            this.CbImmediate.UseVisualStyleBackColor = true;
            // 
            // BtExec
            // 
            this.BtExec.Location = new System.Drawing.Point(41, 29);
            this.BtExec.Name = "BtExec";
            this.BtExec.Size = new System.Drawing.Size(75, 23);
            this.BtExec.TabIndex = 1;
            this.BtExec.Text = "適用";
            this.BtExec.UseVisualStyleBackColor = true;
            // 
            // FilterPanel
            // 
            this.FilterPanel.AutoScroll = true;
            this.FilterPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.FilterPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FilterPanel.Location = new System.Drawing.Point(0, 0);
            this.FilterPanel.Name = "FilterPanel";
            this.FilterPanel.Size = new System.Drawing.Size(151, 241);
            this.FilterPanel.TabIndex = 6;
            // 
            // CompositionControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.MainSplitContainer);
            this.Name = "CompositionControl";
            this.Size = new System.Drawing.Size(398, 296);
            this.MainSplitContainer.Panel1.ResumeLayout(false);
            this.MainSplitContainer.Panel2.ResumeLayout(false);
            this.MainSplitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainSplitContainer)).EndInit();
            this.MainSplitContainer.ResumeLayout(false);
            this.PanelExec.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer MainSplitContainer;
        private System.Windows.Forms.TreeView CompositionTreeView;
        private System.Windows.Forms.Panel FilterPanel;
        private System.Windows.Forms.Panel PanelExec;
        private System.Windows.Forms.CheckBox CbImmediate;
        private System.Windows.Forms.Button BtExec;
    }
}
