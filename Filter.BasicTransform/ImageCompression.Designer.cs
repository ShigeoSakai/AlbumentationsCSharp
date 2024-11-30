namespace Filter.BasicTransform
{
    partial class ImageCompression
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
            this.ParaQualityRange = new FilterBase.Parts.InputMaxMin();
            this.ParaQualityLower = new FilterBase.Parts.InputValueUpDown();
            this.ParaQalityUpper = new FilterBase.Parts.InputValueUpDown();
            this.ParaCompressionType = new FilterBase.Parts.ComboBoxWithLabelParts();
            this.FLPParam.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ParaQualityRange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaQualityLower)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaQalityUpper)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaCompressionType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // FLPParam
            // 
            this.FLPParam.AutoSize = true;
            this.FLPParam.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.FLPParam.Controls.Add(this.ParaQualityRange);
            this.FLPParam.Controls.Add(this.ParaQualityLower);
            this.FLPParam.Controls.Add(this.ParaQalityUpper);
            this.FLPParam.Controls.Add(this.ParaCompressionType);
            this.FLPParam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FLPParam.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.FLPParam.Location = new System.Drawing.Point(0, 25);
            this.FLPParam.Name = "FLPParam";
            this.FLPParam.Size = new System.Drawing.Size(128, 171);
            this.FLPParam.TabIndex = 5;
            // 
            // ParaQualityRange
            // 
            this.ParaQualityRange.ArgumentName = "quality_range";
            this.ParaQualityRange.AutoSize = true;
            this.ParaQualityRange.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ParaQualityRange.DecimalPlace = 0;
            this.ParaQualityRange.Description = "圧縮品質の範囲。\r\n値は [1, 100] の範囲でなければなりません。\r\n- 1 は最低品質 (最大圧縮)\r\n- 100 は最高品質 (最小圧縮)\r\n　　デフォ" +
    "ルト: (99, 100)";
            this.ParaQualityRange.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ParaQualityRange.InvalidValue = "";
            this.ParaQualityRange.Location = new System.Drawing.Point(3, 3);
            this.ParaQualityRange.MaxValue = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.ParaQualityRange.MaxVersion = null;
            this.ParaQualityRange.MinimumSize = new System.Drawing.Size(124, 21);
            this.ParaQualityRange.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ParaQualityRange.MinVersion = "1.4.7";
            this.ParaQualityRange.Name = "ParaQualityRange";
            this.ParaQualityRange.Required = false;
            this.ParaQualityRange.Size = new System.Drawing.Size(124, 39);
            this.ParaQualityRange.TabIndex = 0;
            this.ParaQualityRange.Title = "圧縮品質の範囲";
            this.ParaQualityRange.UseLargeValue = false;
            this.ParaQualityRange.UseValid = false;
            this.ParaQualityRange.Value = "(99,100)";
            this.ParaQualityRange.ValueType = FilterBase.Parts.PartsFunc.VALUE_TYPE.TYPE_INT;
            this.ParaQualityRange.ParameterChange += new FilterBase.Parts.ParameterChangeEventHandler(this.Param_ParameterChange);
            // 
            // ParaQualityLower
            // 
            this.ParaQualityLower.ArgumentName = "quality_lower";
            this.ParaQualityLower.AutoSize = true;
            this.ParaQualityLower.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ParaQualityLower.ControlLayout = FilterBase.Parts.InputValue.LAYOUT.Vertical;
            this.ParaQualityLower.DecimalPlace = 0;
            this.ParaQualityLower.Description = "";
            this.ParaQualityLower.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ParaQualityLower.InvalidValue = "";
            this.ParaQualityLower.Location = new System.Drawing.Point(3, 48);
            this.ParaQualityLower.MaxValue = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.ParaQualityLower.MaxVersion = "1.4.6";
            this.ParaQualityLower.MinimumSize = new System.Drawing.Size(124, 21);
            this.ParaQualityLower.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ParaQualityLower.MinVersion = null;
            this.ParaQualityLower.Name = "ParaQualityLower";
            this.ParaQualityLower.Required = false;
            this.ParaQualityLower.Size = new System.Drawing.Size(124, 35);
            this.ParaQualityLower.TabIndex = 2;
            this.ParaQualityLower.Title = "圧縮品質の範囲(最小)";
            this.ParaQualityLower.Unit = "%";
            this.ParaQualityLower.UseValid = false;
            this.ParaQualityLower.Value = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.ParaQualityLower.ValueType = FilterBase.Parts.InputValue.VALUE_TYPE.INT;
            // 
            // ParaQalityUpper
            // 
            this.ParaQalityUpper.ArgumentName = "quality_upper";
            this.ParaQalityUpper.AutoSize = true;
            this.ParaQalityUpper.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ParaQalityUpper.ControlLayout = FilterBase.Parts.InputValue.LAYOUT.Vertical;
            this.ParaQalityUpper.DecimalPlace = 0;
            this.ParaQalityUpper.Description = "";
            this.ParaQalityUpper.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ParaQalityUpper.InvalidValue = "";
            this.ParaQalityUpper.Location = new System.Drawing.Point(3, 89);
            this.ParaQalityUpper.MaxValue = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.ParaQalityUpper.MaxVersion = "1.4.6";
            this.ParaQalityUpper.MinimumSize = new System.Drawing.Size(124, 21);
            this.ParaQalityUpper.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ParaQalityUpper.MinVersion = null;
            this.ParaQalityUpper.Name = "ParaQalityUpper";
            this.ParaQalityUpper.Required = false;
            this.ParaQalityUpper.Size = new System.Drawing.Size(124, 35);
            this.ParaQalityUpper.TabIndex = 3;
            this.ParaQalityUpper.Title = "圧縮品質の範囲(最大)";
            this.ParaQalityUpper.Unit = "%";
            this.ParaQalityUpper.UseValid = false;
            this.ParaQalityUpper.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.ParaQalityUpper.ValueType = FilterBase.Parts.InputValue.VALUE_TYPE.INT;
            // 
            // ParaCompressionType
            // 
            this.ParaCompressionType.ArgumentName = "compression_type";
            this.ParaCompressionType.AutoSize = true;
            this.ParaCompressionType.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ParaCompressionType.DefaultValue = "";
            this.ParaCompressionType.Description = "適用する圧縮の種類。\r\n- \"jpeg\": JPEG 圧縮\r\n- \"webp\": WebP 圧縮\r\n　デフォルト: \"jpeg\"";
            this.ParaCompressionType.InvalidValue = "";
            this.ParaCompressionType.ItemType = "System.String";
            this.ParaCompressionType.Location = new System.Drawing.Point(3, 130);
            this.ParaCompressionType.MaxVersion = null;
            this.ParaCompressionType.MinimumSize = new System.Drawing.Size(124, 21);
            this.ParaCompressionType.MinVersion = null;
            this.ParaCompressionType.Name = "ParaCompressionType";
            this.ParaCompressionType.Required = false;
            this.ParaCompressionType.Size = new System.Drawing.Size(124, 38);
            this.ParaCompressionType.TabIndex = 1;
            this.ParaCompressionType.Title = "圧縮の種類";
            this.ParaCompressionType.UseValid = false;
            this.ParaCompressionType.Value = null;
            this.ParaCompressionType.ParameterChange += new FilterBase.Parts.ParameterChangeEventHandler(this.Param_ParameterChange);
            // 
            // ImageCompression
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.FLPParam);
            this.Name = "ImageCompression";
            this.Size = new System.Drawing.Size(128, 221);
            this.Target = FilterBase.BaseFilterControl.TRANSFORM_TARGET.IMAGE;
            this.Controls.SetChildIndex(this.FLPParam, 0);
            this.FLPParam.ResumeLayout(false);
            this.FLPParam.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ParaQualityRange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaQualityLower)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaQalityUpper)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaCompressionType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel FLPParam;
        private FilterBase.Parts.InputMaxMin ParaQualityRange;
        private FilterBase.Parts.ComboBoxWithLabelParts ParaCompressionType;
        private FilterBase.Parts.InputValueUpDown ParaQualityLower;
        private FilterBase.Parts.InputValueUpDown ParaQalityUpper;
    }
}
