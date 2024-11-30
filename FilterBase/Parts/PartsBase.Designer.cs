namespace FilterBase.Parts
{
    partial class PartsBase
    {
        /// <summary> 
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        #region コンポーネント デザイナーで生成されたコード
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


        /// <summary> 
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を 
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.CbValid = new System.Windows.Forms.CheckBox();
            this.LbTitle = new SSTools.GrowLabel();
            this.SuspendLayout();
            // 
            // CbValid
            // 
            this.CbValid.AutoSize = true;
            this.CbValid.Checked = true;
            this.CbValid.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CbValid.Location = new System.Drawing.Point(3, 0);
            this.CbValid.Name = "CbValid";
            this.CbValid.Size = new System.Drawing.Size(48, 16);
            this.CbValid.TabIndex = 11;
            this.CbValid.Text = "有効";
            this.CbValid.UseVisualStyleBackColor = true;
            this.CbValid.CheckedChanged += new System.EventHandler(this.CbValid_CheckedChanged);
            // 
            // LbTitle
            // 
            this.LbTitle.BackColor = System.Drawing.SystemColors.Control;
            this.LbTitle.Location = new System.Drawing.Point(3, 21);
            this.LbTitle.Margin = new System.Windows.Forms.Padding(3, 1, 1, 1);
            this.LbTitle.MaxTextWidth = 124;
            this.LbTitle.Name = "LbTitle";
            this.LbTitle.Size = new System.Drawing.Size(35, 12);
            this.LbTitle.TabIndex = 0;
            this.LbTitle.Text = "label1";
            this.LbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LbTitle.SizeChanged += new System.EventHandler(this.LbTitle_SizeChanged);
            // 
            // PartsBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.CbValid);
            this.Controls.Add(this.LbTitle);
            this.MinimumSize = new System.Drawing.Size(124, 21);
            this.Name = "PartsBase";
            this.Size = new System.Drawing.Size(124, 34);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected SSTools.GrowLabel LbTitle;
        protected System.Windows.Forms.CheckBox CbValid;
    }
}
