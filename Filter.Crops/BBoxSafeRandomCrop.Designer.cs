namespace Filter.Crops
{
    partial class BBoxSafeRandomCrop
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
            this.FLPParam = new System.Windows.Forms.FlowLayoutPanel();
            this.ParaErosionRate = new FilterBase.Parts.InputTrackBar();
            this.FLPParam.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ParaErosionRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // FLPParam
            // 
            this.FLPParam.AutoSize = true;
            this.FLPParam.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.FLPParam.Controls.Add(this.ParaErosionRate);
            this.FLPParam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FLPParam.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.FLPParam.Location = new System.Drawing.Point(0, 25);
            this.FLPParam.Name = "FLPParam";
            this.FLPParam.Size = new System.Drawing.Size(128, 71);
            this.FLPParam.TabIndex = 5;
            // 
            // ParaErosionRate
            // 
            this.ParaErosionRate.ArgumentName = "erosion_rate";
            this.ParaErosionRate.AutoSize = true;
            this.ParaErosionRate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ParaErosionRate.DecimalPlace = 1;
            this.ParaErosionRate.Description = "0.0 から 1.0 の間の値で、切り抜きの最小許容サイズを元の画像サイズの割合として決定します。\r\nたとえば、erosion_rate が 0.2 の場合、切り" +
    "抜きは元の画像の高さの少なくとも 80% になります。\r\n　デフォルト: 0.0 (最小サイズなし)。";
            this.ParaErosionRate.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.ParaErosionRate.InvalidValue = "";
            this.ParaErosionRate.Location = new System.Drawing.Point(3, 3);
            this.ParaErosionRate.MaxValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ParaErosionRate.MaxVersion = null;
            this.ParaErosionRate.MinimumSize = new System.Drawing.Size(124, 21);
            this.ParaErosionRate.MinValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.ParaErosionRate.MinVersion = null;
            this.ParaErosionRate.Name = "ParaErosionRate";
            this.ParaErosionRate.Required = false;
            this.ParaErosionRate.Size = new System.Drawing.Size(124, 65);
            this.ParaErosionRate.TabIndex = 0;
            this.ParaErosionRate.Title = "割合";
            this.ParaErosionRate.UseValid = false;
            this.ParaErosionRate.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.ParaErosionRate.ParameterChange += new FilterBase.Parts.ParameterChangeEventHandler(this.Param_ParameterChange);
            // 
            // BBoxSafeRandomCrop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.FLPParam);
            this.Name = "BBoxSafeRandomCrop";
            this.Require = ((FilterBase.BaseFilterControl.TRANSFORM_TARGET)((FilterBase.BaseFilterControl.TRANSFORM_TARGET.IMAGE | FilterBase.BaseFilterControl.TRANSFORM_TARGET.BBOX)));
            this.Size = new System.Drawing.Size(128, 121);
            this.Controls.SetChildIndex(this.FLPParam, 0);
            this.FLPParam.ResumeLayout(false);
            this.FLPParam.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ParaErosionRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel FLPParam;
        private FilterBase.Parts.InputTrackBar ParaErosionRate;
    }
}
