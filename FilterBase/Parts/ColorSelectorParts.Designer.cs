namespace FilterBase.Parts
{
    partial class ColorSelectorParts
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
            this.LbGrayColor = new System.Windows.Forms.Label();
            this.LbColor = new System.Windows.Forms.Label();
            this.TbValue = new SSTools.CustomTextBox();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // LbTitle
            // 
            this.LbTitle.MaxTextWidth = 97;
            // 
            // LbGrayColor
            // 
            this.LbGrayColor.BackColor = System.Drawing.Color.Transparent;
            this.LbGrayColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LbGrayColor.ForeColor = System.Drawing.Color.White;
            this.LbGrayColor.Image = global::FilterBase.Properties.Resources.Color;
            this.LbGrayColor.Location = new System.Drawing.Point(101, 1);
            this.LbGrayColor.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.LbGrayColor.Name = "LbGrayColor";
            this.LbGrayColor.Size = new System.Drawing.Size(20, 20);
            this.LbGrayColor.TabIndex = 21;
            this.LbGrayColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LbGrayColor.Click += new System.EventHandler(this.LbGrayColor_Click);
            // 
            // LbColor
            // 
            this.LbColor.BackColor = System.Drawing.Color.Black;
            this.LbColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LbColor.ForeColor = System.Drawing.Color.White;
            this.LbColor.Location = new System.Drawing.Point(100, 38);
            this.LbColor.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.LbColor.Name = "LbColor";
            this.LbColor.Size = new System.Drawing.Size(23, 23);
            this.LbColor.TabIndex = 23;
            this.LbColor.Text = "色";
            this.LbColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LbColor.Click += new System.EventHandler(this.LbColor_Click);
            // 
            // TbValue
            // 
            this.TbValue.CheckTime = 500;
            this.TbValue.Location = new System.Drawing.Point(3, 40);
            this.TbValue.Name = "TbValue";
            this.TbValue.Size = new System.Drawing.Size(95, 19);
            this.TbValue.TabIndex = 22;
            this.TbValue.Text = "0";
            this.TbValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TbValue.TextChanged += new System.EventHandler(this.TbValue_TextChanged);
            // 
            // ColorSelectorParts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.Controls.Add(this.LbColor);
            this.Controls.Add(this.TbValue);
            this.Controls.Add(this.LbGrayColor);
            this.Name = "ColorSelectorParts";
            this.Size = new System.Drawing.Size(124, 62);
            this.Controls.SetChildIndex(this.CbValid, 0);
            this.Controls.SetChildIndex(this.LbTitle, 0);
            this.Controls.SetChildIndex(this.LbGrayColor, 0);
            this.Controls.SetChildIndex(this.TbValue, 0);
            this.Controls.SetChildIndex(this.LbColor, 0);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LbGrayColor;
        private System.Windows.Forms.Label LbColor;
        private SSTools.CustomTextBox TbValue;
    }
}
