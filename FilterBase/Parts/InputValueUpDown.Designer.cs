namespace FilterBase.Parts
{
    partial class InputValueUpDown
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
            this.NUDValue = new System.Windows.Forms.NumericUpDown();
            this.LbUnit = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NUDValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // NUDValue
            // 
            this.NUDValue.Location = new System.Drawing.Point(40, 19);
            this.NUDValue.Margin = new System.Windows.Forms.Padding(1);
            this.NUDValue.Name = "NUDValue";
            this.NUDValue.Size = new System.Drawing.Size(52, 19);
            this.NUDValue.TabIndex = 1;
            this.NUDValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.NUDValue.ValueChanged += new System.EventHandler(this.NUDValue_ValueChanged);
            // 
            // LbUnit
            // 
            this.LbUnit.AutoSize = true;
            this.LbUnit.Location = new System.Drawing.Point(100, 4);
            this.LbUnit.Name = "LbUnit";
            this.LbUnit.Size = new System.Drawing.Size(0, 12);
            this.LbUnit.TabIndex = 2;
            this.LbUnit.SizeChanged += new System.EventHandler(this.LbUnit_SizeChanged);
            // 
            // InputValueUpDown
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.Controls.Add(this.LbUnit);
            this.Controls.Add(this.NUDValue);
            this.Name = "InputValueUpDown";
            this.Size = new System.Drawing.Size(124, 39);
            this.Controls.SetChildIndex(this.CbValid, 0);
            this.Controls.SetChildIndex(this.LbTitle, 0);
            this.Controls.SetChildIndex(this.NUDValue, 0);
            this.Controls.SetChildIndex(this.LbUnit, 0);
            ((System.ComponentModel.ISupportInitialize)(this.NUDValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown NUDValue;
        private System.Windows.Forms.Label LbUnit;
    }
}
