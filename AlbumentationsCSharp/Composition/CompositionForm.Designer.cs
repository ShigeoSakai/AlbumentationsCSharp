namespace AlbumentationsCSharp.Composition
{
    partial class CompositionForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ToolStripMenuItemFile = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemLoadFile = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemLoadText = new System.Windows.Forms.ToolStripMenuItem();
            this.PanelCompositionControl = new AlbumentationsCSharp.Composition.CompositionControl();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemFile});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(459, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ToolStripMenuItemFile
            // 
            this.ToolStripMenuItemFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemLoadFile,
            this.ToolStripMenuItemLoadText});
            this.ToolStripMenuItemFile.Name = "ToolStripMenuItemFile";
            this.ToolStripMenuItemFile.Size = new System.Drawing.Size(67, 20);
            this.ToolStripMenuItemFile.Text = "ファイル(&F)";
            // 
            // ToolStripMenuItemLoadFile
            // 
            this.ToolStripMenuItemLoadFile.Name = "ToolStripMenuItemLoadFile";
            this.ToolStripMenuItemLoadFile.Size = new System.Drawing.Size(173, 22);
            this.ToolStripMenuItemLoadFile.Text = "ファイルから読み込み";
            this.ToolStripMenuItemLoadFile.Click += new System.EventHandler(this.ToolStripMenuItemLoadFile_Click);
            // 
            // ToolStripMenuItemLoadText
            // 
            this.ToolStripMenuItemLoadText.Name = "ToolStripMenuItemLoadText";
            this.ToolStripMenuItemLoadText.Size = new System.Drawing.Size(173, 22);
            this.ToolStripMenuItemLoadText.Text = "テキストから生成";
            this.ToolStripMenuItemLoadText.Click += new System.EventHandler(this.ToolStripMenuItemLoadText_Click);
            // 
            // PanelCompositionControl
            // 
            this.PanelCompositionControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelCompositionControl.Location = new System.Drawing.Point(0, 24);
            this.PanelCompositionControl.Name = "PanelCompositionControl";
            this.PanelCompositionControl.Size = new System.Drawing.Size(459, 336);
            this.PanelCompositionControl.TabIndex = 1;
            // 
            // CompositionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 360);
            this.Controls.Add(this.PanelCompositionControl);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "CompositionForm";
            this.Text = "CompositionForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemFile;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemLoadFile;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemLoadText;
        private CompositionControl PanelCompositionControl;
    }
}