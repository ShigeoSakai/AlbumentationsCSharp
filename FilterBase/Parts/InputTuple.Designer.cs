namespace FilterBase.Parts
{
    partial class InputTuple
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
            ((System.ComponentModel.ISupportInitialize)(this.NUDTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // LbTitle
            // 
            this.LbTitle.Location = new System.Drawing.Point(3, 1);
            this.LbTitle.MaxTextWidth = 120;
            // 
            // CbValid
            // 
            this.CbValid.Location = new System.Drawing.Point(3, 3);
            // 
            // NUDTo
            // 
            this.NUDTo.Location = new System.Drawing.Point(64, 36);
            this.NUDTo.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.NUDTo.Name = "NUDTo";
            this.NUDTo.Size = new System.Drawing.Size(59, 19);
            this.NUDTo.TabIndex = 5;
            this.NUDTo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.NUDTo.ValueChanged += new System.EventHandler(this.NUD_ValueChanged);
            // 
            // NUDFrom
            // 
            this.NUDFrom.Location = new System.Drawing.Point(0, 36);
            this.NUDFrom.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.NUDFrom.Name = "NUDFrom";
            this.NUDFrom.Size = new System.Drawing.Size(59, 19);
            this.NUDFrom.TabIndex = 4;
            this.NUDFrom.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.NUDFrom.ValueChanged += new System.EventHandler(this.NUD_ValueChanged);
            // 
            // InputTuple
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.Controls.Add(this.NUDTo);
            this.Controls.Add(this.NUDFrom);
            this.Name = "InputTuple";
            this.Size = new System.Drawing.Size(124, 58);
            this.Controls.SetChildIndex(this.CbValid, 0);
            this.Controls.SetChildIndex(this.LbTitle, 0);
            this.Controls.SetChildIndex(this.NUDFrom, 0);
            this.Controls.SetChildIndex(this.NUDTo, 0);
            ((System.ComponentModel.ISupportInitialize)(this.NUDTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.NumericUpDown NUDTo;
        protected System.Windows.Forms.NumericUpDown NUDFrom;
    }
}
