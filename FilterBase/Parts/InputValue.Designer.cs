namespace FilterBase.Parts
{
    partial class InputValue
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
            this.TbValue = new SSTools.CustomTextBox();
            this.LbUnit = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // LbTitle
            // 
            this.LbTitle.Location = new System.Drawing.Point(5, 24);
            // 
            // TbValue
            // 
            this.TbValue.CheckTime = 500;
            this.TbValue.Location = new System.Drawing.Point(42, 21);
            this.TbValue.Margin = new System.Windows.Forms.Padding(1);
            this.TbValue.Name = "TbValue";
            this.TbValue.Size = new System.Drawing.Size(51, 19);
            this.TbValue.TabIndex = 1;
            this.TbValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TbValue.TextChanged += new System.EventHandler(this.TbValue_TextChanged);
            // 
            // LbUnit
            // 
            this.LbUnit.AutoSize = true;
            this.LbUnit.Location = new System.Drawing.Point(97, 4);
            this.LbUnit.Name = "LbUnit";
            this.LbUnit.Size = new System.Drawing.Size(0, 12);
            this.LbUnit.TabIndex = 2;
            this.LbUnit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LbUnit.SizeChanged += new System.EventHandler(this.LabelSizeChange);
            // 
            // InputValue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.Controls.Add(this.LbUnit);
            this.Controls.Add(this.TbValue);
            this.Name = "InputValue";
            this.Size = new System.Drawing.Size(124, 41);
            this.Controls.SetChildIndex(this.LbTitle, 0);
            this.Controls.SetChildIndex(this.TbValue, 0);
            this.Controls.SetChildIndex(this.LbUnit, 0);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected SSTools.CustomTextBox TbValue;
        protected System.Windows.Forms.Label LbUnit;
    }
}
