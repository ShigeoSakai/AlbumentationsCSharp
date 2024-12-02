namespace FilterBase.Parts
{
    partial class InputMaxMinWithType
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
            this.CbIntFloat = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.NUDTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // NUDTo
            // 
            this.NUDTo.Location = new System.Drawing.Point(72, 32);
            // 
            // NUDFrom
            // 
            this.NUDFrom.Location = new System.Drawing.Point(1, 32);
            // 
            // LbBar
            // 
            this.LbBar.Location = new System.Drawing.Point(53, 34);
            // 
            // LbTitle
            // 
            this.LbTitle.Location = new System.Drawing.Point(-1, 16);
            // 
            // CbValid
            // 
            this.CbValid.Location = new System.Drawing.Point(0, 3);
            // 
            // CbIntFloat
            // 
            this.CbIntFloat.AutoSize = true;
            this.CbIntFloat.Checked = true;
            this.CbIntFloat.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CbIntFloat.Location = new System.Drawing.Point(72, 10);
            this.CbIntFloat.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.CbIntFloat.Name = "CbIntFloat";
            this.CbIntFloat.Size = new System.Drawing.Size(47, 16);
            this.CbIntFloat.TabIndex = 12;
            this.CbIntFloat.Text = "float";
            this.CbIntFloat.UseVisualStyleBackColor = true;
            this.CbIntFloat.CheckedChanged += new System.EventHandler(this.CbIntFloat_CheckedChanged);
            // 
            // InputMaxMinWithType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.Controls.Add(this.CbIntFloat);
            this.Name = "InputMaxMinWithType";
            this.Size = new System.Drawing.Size(124, 54);
            this.Controls.SetChildIndex(this.LbBar, 0);
            this.Controls.SetChildIndex(this.LbTitle, 0);
            this.Controls.SetChildIndex(this.NUDFrom, 0);
            this.Controls.SetChildIndex(this.NUDTo, 0);
            this.Controls.SetChildIndex(this.CbValid, 0);
            this.Controls.SetChildIndex(this.CbIntFloat, 0);
            ((System.ComponentModel.ISupportInitialize)(this.NUDTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox CbIntFloat;
    }
}
