namespace Filter.BasicTransform
{
    partial class HueSaturationValue
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
            this.ParaHueShiftLimit = new FilterBase.Parts.InputMaxMin();
            this.ParaSatShiftLimit = new FilterBase.Parts.InputMaxMin();
            this.ParaValShiftLimit = new FilterBase.Parts.InputMaxMin();
            this.FLPParam.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ParaHueShiftLimit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaSatShiftLimit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaValShiftLimit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // FLPParam
            // 
            this.FLPParam.AutoSize = true;
            this.FLPParam.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.FLPParam.Controls.Add(this.ParaHueShiftLimit);
            this.FLPParam.Controls.Add(this.ParaSatShiftLimit);
            this.FLPParam.Controls.Add(this.ParaValShiftLimit);
            this.FLPParam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FLPParam.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.FLPParam.Location = new System.Drawing.Point(0, 25);
            this.FLPParam.Name = "FLPParam";
            this.FLPParam.Size = new System.Drawing.Size(128, 144);
            this.FLPParam.TabIndex = 5;
            // 
            // ParaHueShiftLimit
            // 
            this.ParaHueShiftLimit.ArgumentName = "hue_shift_limit";
            this.ParaHueShiftLimit.AutoSize = true;
            this.ParaHueShiftLimit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ParaHueShiftLimit.DecimalPlace = 0;
            this.ParaHueShiftLimit.Description = "色相を変更する範囲。\r\n値は [-180, 180] の範囲にする必要があります。\r\n　　　デフォルト: (-20, 20)。";
            this.ParaHueShiftLimit.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ParaHueShiftLimit.Location = new System.Drawing.Point(3, 3);
            this.ParaHueShiftLimit.MaxValue = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.ParaHueShiftLimit.MaxVersion = null;
            this.ParaHueShiftLimit.MinimumSize = new System.Drawing.Size(124, 21);
            this.ParaHueShiftLimit.MinValue = new decimal(new int[] {
            180,
            0,
            0,
            -2147483648});
            this.ParaHueShiftLimit.MinVersion = null;
            this.ParaHueShiftLimit.Name = "ParaHueShiftLimit";
            this.ParaHueShiftLimit.Required = false;
            this.ParaHueShiftLimit.Size = new System.Drawing.Size(124, 42);
            this.ParaHueShiftLimit.TabIndex = 0;
            this.ParaHueShiftLimit.Title = "色相";
            this.ParaHueShiftLimit.Value = "(-20,20)";
            this.ParaHueShiftLimit.ValueType = FilterBase.Parts.PartsFunc.VALUE_TYPE.TYPE_FLOAT;
            this.ParaHueShiftLimit.ParameterChange += new FilterBase.Parts.ParameterChangeEventHandler(this.Param_ParameterChange);
            // 
            // ParaSatShiftLimit
            // 
            this.ParaSatShiftLimit.ArgumentName = "sat_shift_limit";
            this.ParaSatShiftLimit.AutoSize = true;
            this.ParaSatShiftLimit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ParaSatShiftLimit.DecimalPlace = 0;
            this.ParaSatShiftLimit.Description = "彩度を変更する範囲。\r\n\r\n値は [-255, 255] の範囲にする必要があります。\r\n　　デフォルト: (-30, 30)。";
            this.ParaSatShiftLimit.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ParaSatShiftLimit.Location = new System.Drawing.Point(3, 51);
            this.ParaSatShiftLimit.MaxValue = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.ParaSatShiftLimit.MaxVersion = null;
            this.ParaSatShiftLimit.MinimumSize = new System.Drawing.Size(124, 21);
            this.ParaSatShiftLimit.MinValue = new decimal(new int[] {
            255,
            0,
            0,
            -2147483648});
            this.ParaSatShiftLimit.MinVersion = null;
            this.ParaSatShiftLimit.Name = "ParaSatShiftLimit";
            this.ParaSatShiftLimit.Required = false;
            this.ParaSatShiftLimit.Size = new System.Drawing.Size(124, 42);
            this.ParaSatShiftLimit.TabIndex = 1;
            this.ParaSatShiftLimit.Title = "彩度";
            this.ParaSatShiftLimit.Value = "(-30,30)";
            this.ParaSatShiftLimit.ValueType = FilterBase.Parts.PartsFunc.VALUE_TYPE.TYPE_FLOAT;
            this.ParaSatShiftLimit.ParameterChange += new FilterBase.Parts.ParameterChangeEventHandler(this.Param_ParameterChange);
            // 
            // ParaValShiftLimit
            // 
            this.ParaValShiftLimit.ArgumentName = "val_shift_limit";
            this.ParaValShiftLimit.AutoSize = true;
            this.ParaValShiftLimit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ParaValShiftLimit.DecimalPlace = 0;
            this.ParaValShiftLimit.Description = "明るさを変更する範囲。\r\n値は [-255, 255] の範囲内である必要があります。\r\n　　デフォルト: (-20, 20)。";
            this.ParaValShiftLimit.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ParaValShiftLimit.Location = new System.Drawing.Point(3, 99);
            this.ParaValShiftLimit.MaxValue = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.ParaValShiftLimit.MaxVersion = null;
            this.ParaValShiftLimit.MinimumSize = new System.Drawing.Size(124, 21);
            this.ParaValShiftLimit.MinValue = new decimal(new int[] {
            255,
            0,
            0,
            -2147483648});
            this.ParaValShiftLimit.MinVersion = null;
            this.ParaValShiftLimit.Name = "ParaValShiftLimit";
            this.ParaValShiftLimit.Required = false;
            this.ParaValShiftLimit.Size = new System.Drawing.Size(124, 42);
            this.ParaValShiftLimit.TabIndex = 2;
            this.ParaValShiftLimit.Title = "明るさ";
            this.ParaValShiftLimit.Value = "(-20,20)";
            this.ParaValShiftLimit.ValueType = FilterBase.Parts.PartsFunc.VALUE_TYPE.TYPE_FLOAT;
            this.ParaValShiftLimit.ParameterChange += new FilterBase.Parts.ParameterChangeEventHandler(this.Param_ParameterChange);
            // 
            // HueSaturationValue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.FLPParam);
            this.Name = "HueSaturationValue";
            this.Size = new System.Drawing.Size(128, 194);
            this.Target = FilterBase.BaseFilterControl.TRANSFORM_TARGET.IMAGE;
            this.Controls.SetChildIndex(this.FLPParam, 0);
            this.FLPParam.ResumeLayout(false);
            this.FLPParam.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ParaHueShiftLimit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaSatShiftLimit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaValShiftLimit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel FLPParam;
        private FilterBase.Parts.InputMaxMin ParaSatShiftLimit;
        private FilterBase.Parts.InputMaxMin ParaValShiftLimit;
        private FilterBase.Parts.InputMaxMin ParaHueShiftLimit;
    }
}
