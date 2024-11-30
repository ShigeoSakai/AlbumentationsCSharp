namespace FilterBase.Parts
{
    partial class InputKernelSize
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
            this.LbX = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NUDTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // NUDTo
            // 
            this.NUDTo.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.NUDTo.Location = new System.Drawing.Point(73, 20);
            this.NUDTo.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.NUDTo.Size = new System.Drawing.Size(50, 19);
            this.NUDTo.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // NUDFrom
            // 
            this.NUDFrom.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.NUDFrom.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.NUDFrom.Size = new System.Drawing.Size(50, 19);
            this.NUDFrom.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // LbX
            // 
            this.LbX.AutoSize = true;
            this.LbX.Location = new System.Drawing.Point(55, 22);
            this.LbX.Margin = new System.Windows.Forms.Padding(0);
            this.LbX.Name = "LbX";
            this.LbX.Size = new System.Drawing.Size(17, 12);
            this.LbX.TabIndex = 4;
            this.LbX.Text = "×";
            this.LbX.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // InputKernelSize
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.Controls.Add(this.LbX);
            this.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.MinValue = "(3,3)";
            this.Name = "InputKernelSize";
            this.Size = new System.Drawing.Size(124, 42);
            this.Value = "(3,3)";
            this.ValueType = FilterBase.Parts.PartsFunc.VALUE_TYPE.TYPE_INT_ODD;
            this.Controls.SetChildIndex(this.CbValid, 0);
            this.Controls.SetChildIndex(this.LbTitle, 0);
            this.Controls.SetChildIndex(this.NUDFrom, 0);
            this.Controls.SetChildIndex(this.NUDTo, 0);
            this.Controls.SetChildIndex(this.LbX, 0);
            ((System.ComponentModel.ISupportInitialize)(this.NUDTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LbX;
    }
}
