namespace FilterBase.Parts
{
    partial class InputMaxMin
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

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.NUDTo = new System.Windows.Forms.NumericUpDown();
            this.NUDFrom = new System.Windows.Forms.NumericUpDown();
            this.LbBar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NUDTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // LbTitle
            // 
            this.LbTitle.Location = new System.Drawing.Point(1, 24);
            // 
            // NUDTo
            // 
            this.NUDTo.Location = new System.Drawing.Point(73, 40);
            this.NUDTo.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.NUDTo.Name = "NUDTo";
            this.NUDTo.Size = new System.Drawing.Size(50, 19);
            this.NUDTo.TabIndex = 7;
            this.NUDTo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.NUDTo.ValueChanged += new System.EventHandler(this.NUDTo_ValueChanged);
            // 
            // NUDFrom
            // 
            this.NUDFrom.Location = new System.Drawing.Point(0, 40);
            this.NUDFrom.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.NUDFrom.Name = "NUDFrom";
            this.NUDFrom.Size = new System.Drawing.Size(50, 19);
            this.NUDFrom.TabIndex = 6;
            this.NUDFrom.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.NUDFrom.ValueChanged += new System.EventHandler(this.NUDFrom_ValueChanged);
            // 
            // LbBar
            // 
            this.LbBar.AutoSize = true;
            this.LbBar.Location = new System.Drawing.Point(53, 42);
            this.LbBar.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.LbBar.Name = "LbBar";
            this.LbBar.Size = new System.Drawing.Size(17, 12);
            this.LbBar.TabIndex = 8;
            this.LbBar.Text = "～";
            // 
            // InputMaxMin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.Controls.Add(this.LbBar);
            this.Controls.Add(this.NUDTo);
            this.Controls.Add(this.NUDFrom);
            this.Name = "InputMaxMin";
            this.Size = new System.Drawing.Size(124, 62);
            this.Controls.SetChildIndex(this.LbTitle, 0);
            this.Controls.SetChildIndex(this.NUDFrom, 0);
            this.Controls.SetChildIndex(this.NUDTo, 0);
            this.Controls.SetChildIndex(this.LbBar, 0);
            this.Controls.SetChildIndex(this.CbValid, 0);
            ((System.ComponentModel.ISupportInitialize)(this.NUDTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.NumericUpDown NUDTo;
        protected System.Windows.Forms.NumericUpDown NUDFrom;
        private System.Windows.Forms.Label LbBar;
    }
}
