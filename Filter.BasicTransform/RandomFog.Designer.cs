namespace Filter.BasicTransform
{
    partial class RandomFog
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
            this.ParaFogCoefRange = new FilterBase.Parts.InputMaxMin();
            this.ParaAlphaCoef = new FilterBase.Parts.InputTrackBar();
            this.ParaFogCoefLower = new FilterBase.Parts.InputTrackBar();
            this.ParaFogCoefUpper = new FilterBase.Parts.InputTrackBar();
            this.FLPParam.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ParaFogCoefRange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaAlphaCoef)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaFogCoefLower)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaFogCoefUpper)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // FLPParam
            // 
            this.FLPParam.AutoSize = true;
            this.FLPParam.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.FLPParam.Controls.Add(this.ParaFogCoefRange);
            this.FLPParam.Controls.Add(this.ParaFogCoefLower);
            this.FLPParam.Controls.Add(this.ParaFogCoefUpper);
            this.FLPParam.Controls.Add(this.ParaAlphaCoef);
            this.FLPParam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FLPParam.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.FLPParam.Location = new System.Drawing.Point(0, 25);
            this.FLPParam.Name = "FLPParam";
            this.FLPParam.Size = new System.Drawing.Size(128, 261);
            this.FLPParam.TabIndex = 5;
            // 
            // ParaFogCoefRange
            // 
            this.ParaFogCoefRange.ArgumentName = "fog_coef_range";
            this.ParaFogCoefRange.AutoSize = true;
            this.ParaFogCoefRange.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ParaFogCoefRange.DecimalPlace = 1;
            this.ParaFogCoefRange.Description = "霧の強度係数の範囲。\r\n[0, 1] の範囲内である必要があります。";
            this.ParaFogCoefRange.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.ParaFogCoefRange.Location = new System.Drawing.Point(3, 3);
            this.ParaFogCoefRange.MaxValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ParaFogCoefRange.MaxVersion = null;
            this.ParaFogCoefRange.MinimumSize = new System.Drawing.Size(124, 21);
            this.ParaFogCoefRange.MinValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.ParaFogCoefRange.MinVersion = "1.4.9";
            this.ParaFogCoefRange.Name = "ParaFogCoefRange";
            this.ParaFogCoefRange.Required = false;
            this.ParaFogCoefRange.Size = new System.Drawing.Size(124, 42);
            this.ParaFogCoefRange.TabIndex = 0;
            this.ParaFogCoefRange.Title = "霧の強度係数範囲";
            this.ParaFogCoefRange.Value = "(0.3,1.0)";
            this.ParaFogCoefRange.ValueType = FilterBase.Parts.PartsFunc.VALUE_TYPE.TYPE_FLOAT;
            this.ParaFogCoefRange.ParameterChange += new FilterBase.Parts.ParameterChangeEventHandler(this.Param_ParameterChange);
            // 
            // ParaAlphaCoef
            // 
            this.ParaAlphaCoef.ArgumentName = "alpha_coef";
            this.ParaAlphaCoef.AutoSize = true;
            this.ParaAlphaCoef.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ParaAlphaCoef.DecimalPlace = 2;
            this.ParaAlphaCoef.Description = "霧の円の透明度。\r\n範囲は [0, 1] にする必要があります。\r\n　　デフォルト: 0.08。";
            this.ParaAlphaCoef.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.ParaAlphaCoef.Location = new System.Drawing.Point(3, 193);
            this.ParaAlphaCoef.MaxValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ParaAlphaCoef.MaxVersion = null;
            this.ParaAlphaCoef.MinimumSize = new System.Drawing.Size(124, 21);
            this.ParaAlphaCoef.MinValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.ParaAlphaCoef.MinVersion = null;
            this.ParaAlphaCoef.Name = "ParaAlphaCoef";
            this.ParaAlphaCoef.Required = false;
            this.ParaAlphaCoef.Size = new System.Drawing.Size(124, 65);
            this.ParaAlphaCoef.TabIndex = 1;
            this.ParaAlphaCoef.Title = "霧の透明度";
            this.ParaAlphaCoef.Value = new decimal(new int[] {
            8,
            0,
            0,
            131072});
            this.ParaAlphaCoef.ParameterChange += new FilterBase.Parts.ParameterChangeEventHandler(this.Param_ParameterChange);
            // 
            // ParaFogCoefLower
            // 
            this.ParaFogCoefLower.ArgumentName = "fog_coef_lower";
            this.ParaFogCoefLower.AutoSize = true;
            this.ParaFogCoefLower.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ParaFogCoefLower.DecimalPlace = 1;
            this.ParaFogCoefLower.Description = "霧の強度係数の下限。\r\n[0, 1]の範囲でなければなりません。";
            this.ParaFogCoefLower.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.ParaFogCoefLower.Location = new System.Drawing.Point(3, 51);
            this.ParaFogCoefLower.MaxValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ParaFogCoefLower.MaxVersion = "1.4.8";
            this.ParaFogCoefLower.MinimumSize = new System.Drawing.Size(124, 21);
            this.ParaFogCoefLower.MinValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.ParaFogCoefLower.MinVersion = null;
            this.ParaFogCoefLower.Name = "ParaFogCoefLower";
            this.ParaFogCoefLower.Required = false;
            this.ParaFogCoefLower.Size = new System.Drawing.Size(124, 65);
            this.ParaFogCoefLower.TabIndex = 2;
            this.ParaFogCoefLower.Title = "霧の強度係数の下限";
            this.ParaFogCoefLower.Value = new decimal(new int[] {
            3,
            0,
            0,
            65536});
            this.ParaFogCoefLower.ParameterChange += new FilterBase.Parts.ParameterChangeEventHandler(this.Param_ParameterChange);
            // 
            // ParaFogCoefUpper
            // 
            this.ParaFogCoefUpper.ArgumentName = "fog_coef_upper";
            this.ParaFogCoefUpper.AutoSize = true;
            this.ParaFogCoefUpper.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ParaFogCoefUpper.DecimalPlace = 1;
            this.ParaFogCoefUpper.Description = "霧の強度係数の上限。\r\n[0, 1]の範囲でなければなりません。";
            this.ParaFogCoefUpper.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.ParaFogCoefUpper.Location = new System.Drawing.Point(3, 122);
            this.ParaFogCoefUpper.MaxValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ParaFogCoefUpper.MaxVersion = "1.4.8";
            this.ParaFogCoefUpper.MinimumSize = new System.Drawing.Size(124, 21);
            this.ParaFogCoefUpper.MinValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.ParaFogCoefUpper.MinVersion = null;
            this.ParaFogCoefUpper.Name = "ParaFogCoefUpper";
            this.ParaFogCoefUpper.Required = false;
            this.ParaFogCoefUpper.Size = new System.Drawing.Size(124, 65);
            this.ParaFogCoefUpper.TabIndex = 3;
            this.ParaFogCoefUpper.Title = "霧の強度係数の上限";
            this.ParaFogCoefUpper.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ParaFogCoefUpper.ParameterChange += new FilterBase.Parts.ParameterChangeEventHandler(this.Param_ParameterChange);
            // 
            // RandomFog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.FLPParam);
            this.Name = "RandomFog";
            this.Size = new System.Drawing.Size(128, 311);
            this.Target = FilterBase.BaseFilterControl.TRANSFORM_TARGET.IMAGE;
            this.Controls.SetChildIndex(this.FLPParam, 0);
            this.FLPParam.ResumeLayout(false);
            this.FLPParam.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ParaFogCoefRange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaAlphaCoef)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaFogCoefLower)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaFogCoefUpper)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel FLPParam;
        private FilterBase.Parts.InputMaxMin ParaFogCoefRange;
        private FilterBase.Parts.InputTrackBar ParaAlphaCoef;
        private FilterBase.Parts.InputTrackBar ParaFogCoefLower;
        private FilterBase.Parts.InputTrackBar ParaFogCoefUpper;
    }
}
