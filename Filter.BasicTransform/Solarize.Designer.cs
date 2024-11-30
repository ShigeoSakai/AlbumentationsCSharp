namespace Filter.BasicTransform
{
    partial class Solarize
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
            this.ParaThreshold = new FilterBase.Parts.InputMaxMin();
            this.FLPParam.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ParaThreshold)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // FLPParam
            // 
            this.FLPParam.AutoSize = true;
            this.FLPParam.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.FLPParam.Controls.Add(this.ParaThreshold);
            this.FLPParam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FLPParam.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.FLPParam.Location = new System.Drawing.Point(0, 25);
            this.FLPParam.Name = "FLPParam";
            this.FLPParam.Size = new System.Drawing.Size(128, 48);
            this.FLPParam.TabIndex = 5;
            // 
            // ParaThreshold
            // 
            this.ParaThreshold.ArgumentName = "threshold";
            this.ParaThreshold.AutoSize = true;
            this.ParaThreshold.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ParaThreshold.DecimalPlace = 0;
            this.ParaThreshold.Description = "ソラリゼーションしきい値の範囲。\r\n\r\n(min, max) のタプルの場合、範囲は [min, max] になります。\r\nしきい値は、uint8 画像の場合は " +
    "[0, 255]、float 画像の場合は [0, 1.0] の範囲にする必要があります。\r\nデフォルト: 128。";
            this.ParaThreshold.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ParaThreshold.Location = new System.Drawing.Point(3, 3);
            this.ParaThreshold.MaxValue = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.ParaThreshold.MaxVersion = null;
            this.ParaThreshold.MinimumSize = new System.Drawing.Size(124, 21);
            this.ParaThreshold.MinValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.ParaThreshold.MinVersion = null;
            this.ParaThreshold.Name = "ParaThreshold";
            this.ParaThreshold.Required = false;
            this.ParaThreshold.Size = new System.Drawing.Size(124, 42);
            this.ParaThreshold.TabIndex = 0;
            this.ParaThreshold.Title = "閾値";
            this.ParaThreshold.Value = "(128,128)";
            this.ParaThreshold.ValueType = FilterBase.Parts.PartsFunc.VALUE_TYPE.TYPE_INT;
            this.ParaThreshold.ParameterChange += new FilterBase.Parts.ParameterChangeEventHandler(this.Param_ParameterChange);
            // 
            // Solarize
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.FLPParam);
            this.Name = "Solarize";
            this.Size = new System.Drawing.Size(128, 98);
            this.Target = FilterBase.BaseFilterControl.TRANSFORM_TARGET.IMAGE;
            this.Controls.SetChildIndex(this.FLPParam, 0);
            this.FLPParam.ResumeLayout(false);
            this.FLPParam.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ParaThreshold)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel FLPParam;
        private FilterBase.Parts.InputMaxMin ParaThreshold;
    }
}
