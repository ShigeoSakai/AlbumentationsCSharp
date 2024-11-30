namespace FilterBase.Parts
{
    partial class InputValueWithType
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
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // TbValue
            // 
            this.TbValue.Location = new System.Drawing.Point(1, 15);
            this.TbValue.Size = new System.Drawing.Size(116, 19);
            // 
            // LbUnit
            // 
            this.LbUnit.Location = new System.Drawing.Point(119, 19);
            // 
            // LbTitle
            // 
            this.LbTitle.Location = new System.Drawing.Point(3, 1);
            // 
            // CbIntFloat
            // 
            this.CbIntFloat.AutoSize = true;
            this.CbIntFloat.Checked = true;
            this.CbIntFloat.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CbIntFloat.Location = new System.Drawing.Point(71, 3);
            this.CbIntFloat.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.CbIntFloat.Name = "CbIntFloat";
            this.CbIntFloat.Size = new System.Drawing.Size(47, 16);
            this.CbIntFloat.TabIndex = 3;
            this.CbIntFloat.Text = "float";
            this.CbIntFloat.UseVisualStyleBackColor = true;
            this.CbIntFloat.CheckedChanged += new System.EventHandler(this.CbIntFloat_CheckedChanged);
            // 
            // InputValueWithType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.ControlLayout = FilterBase.Parts.InputValue.LAYOUT.Vertical;
            this.Controls.Add(this.CbIntFloat);
            this.Name = "InputValueWithType";
            this.Size = new System.Drawing.Size(124, 35);
            this.Controls.SetChildIndex(this.CbValid, 0);
            this.Controls.SetChildIndex(this.TbValue, 0);
            this.Controls.SetChildIndex(this.LbUnit, 0);
            this.Controls.SetChildIndex(this.LbTitle, 0);
            this.Controls.SetChildIndex(this.CbIntFloat, 0);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox CbIntFloat;
    }
}
