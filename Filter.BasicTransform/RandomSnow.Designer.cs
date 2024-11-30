namespace Filter.BasicTransform
{
    partial class RandomSnow
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
            this.ParaSnowPointRange = new FilterBase.Parts.InputMaxMin();
            this.ParaSnowPointLower = new FilterBase.Parts.InputTrackBar();
            this.inputTrackBar1 = new FilterBase.Parts.InputTrackBar();
            this.ParaBrightnessCoeff = new FilterBase.Parts.InputValueUpDown();
            this.ParaMethod = new FilterBase.Parts.ComboBoxWithLabelParts();
            this.FLPParam.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ParaSnowPointRange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaSnowPointLower)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputTrackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaBrightnessCoeff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaMethod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // FLPParam
            // 
            this.FLPParam.AutoSize = true;
            this.FLPParam.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.FLPParam.Controls.Add(this.ParaSnowPointRange);
            this.FLPParam.Controls.Add(this.ParaSnowPointLower);
            this.FLPParam.Controls.Add(this.inputTrackBar1);
            this.FLPParam.Controls.Add(this.ParaBrightnessCoeff);
            this.FLPParam.Controls.Add(this.ParaMethod);
            this.FLPParam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FLPParam.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.FLPParam.Location = new System.Drawing.Point(0, 25);
            this.FLPParam.Name = "FLPParam";
            this.FLPParam.Size = new System.Drawing.Size(128, 258);
            this.FLPParam.TabIndex = 5;
            // 
            // ParaSnowPointRange
            // 
            this.ParaSnowPointRange.ArgumentName = "snow_point_range";
            this.ParaSnowPointRange.AutoSize = true;
            this.ParaSnowPointRange.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ParaSnowPointRange.DecimalPlace = 1;
            this.ParaSnowPointRange.Description = "積雪しきい値の範囲。\r\n両方の値は (0, 1) の範囲になければなりません。\r\n　　デフォルト: (0.1, 0.3)。";
            this.ParaSnowPointRange.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.ParaSnowPointRange.InvalidValue = "";
            this.ParaSnowPointRange.Location = new System.Drawing.Point(3, 3);
            this.ParaSnowPointRange.MaxValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ParaSnowPointRange.MaxVersion = null;
            this.ParaSnowPointRange.MinimumSize = new System.Drawing.Size(124, 21);
            this.ParaSnowPointRange.MinValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.ParaSnowPointRange.MinVersion = "1.4.8";
            this.ParaSnowPointRange.Name = "ParaSnowPointRange";
            this.ParaSnowPointRange.Required = false;
            this.ParaSnowPointRange.Size = new System.Drawing.Size(124, 39);
            this.ParaSnowPointRange.TabIndex = 0;
            this.ParaSnowPointRange.Title = "積雪しきい値";
            this.ParaSnowPointRange.UseLargeValue = false;
            this.ParaSnowPointRange.UseValid = false;
            this.ParaSnowPointRange.Value = "(0.1,0.3)";
            this.ParaSnowPointRange.ValueType = FilterBase.Parts.PartsFunc.VALUE_TYPE.TYPE_FLOAT;
            this.ParaSnowPointRange.ParameterChange += new FilterBase.Parts.ParameterChangeEventHandler(this.Param_ParameterChange);
            // 
            // ParaSnowPointLower
            // 
            this.ParaSnowPointLower.ArgumentName = "snow_point_lower";
            this.ParaSnowPointLower.AutoSize = true;
            this.ParaSnowPointLower.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ParaSnowPointLower.DecimalPlace = 1;
            this.ParaSnowPointLower.Description = "積雪しきい値(最小)";
            this.ParaSnowPointLower.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.ParaSnowPointLower.InvalidValue = "";
            this.ParaSnowPointLower.Location = new System.Drawing.Point(3, 48);
            this.ParaSnowPointLower.MaxValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ParaSnowPointLower.MaxVersion = "1.4.7";
            this.ParaSnowPointLower.MinimumSize = new System.Drawing.Size(124, 21);
            this.ParaSnowPointLower.MinValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.ParaSnowPointLower.MinVersion = null;
            this.ParaSnowPointLower.Name = "ParaSnowPointLower";
            this.ParaSnowPointLower.Required = false;
            this.ParaSnowPointLower.Size = new System.Drawing.Size(124, 65);
            this.ParaSnowPointLower.TabIndex = 3;
            this.ParaSnowPointLower.Title = "積雪しきい値(最小)";
            this.ParaSnowPointLower.UseValid = false;
            this.ParaSnowPointLower.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.ParaSnowPointLower.ParameterChange += new FilterBase.Parts.ParameterChangeEventHandler(this.Param_ParameterChange);
            // 
            // inputTrackBar1
            // 
            this.inputTrackBar1.ArgumentName = "snow_point_upper";
            this.inputTrackBar1.AutoSize = true;
            this.inputTrackBar1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.inputTrackBar1.DecimalPlace = 1;
            this.inputTrackBar1.Description = "積雪しきい値(最大)";
            this.inputTrackBar1.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.inputTrackBar1.InvalidValue = "";
            this.inputTrackBar1.Location = new System.Drawing.Point(3, 119);
            this.inputTrackBar1.MaxValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.inputTrackBar1.MaxVersion = "1.4.7";
            this.inputTrackBar1.MinimumSize = new System.Drawing.Size(124, 21);
            this.inputTrackBar1.MinValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.inputTrackBar1.MinVersion = null;
            this.inputTrackBar1.Name = "inputTrackBar1";
            this.inputTrackBar1.Required = false;
            this.inputTrackBar1.Size = new System.Drawing.Size(124, 65);
            this.inputTrackBar1.TabIndex = 4;
            this.inputTrackBar1.Title = "積雪しきい値(最大)";
            this.inputTrackBar1.UseValid = false;
            this.inputTrackBar1.Value = new decimal(new int[] {
            3,
            0,
            0,
            65536});
            this.inputTrackBar1.ParameterChange += new FilterBase.Parts.ParameterChangeEventHandler(this.Param_ParameterChange);
            // 
            // ParaBrightnessCoeff
            // 
            this.ParaBrightnessCoeff.ArgumentName = "brightness_coeff";
            this.ParaBrightnessCoeff.AutoSize = true;
            this.ParaBrightnessCoeff.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ParaBrightnessCoeff.ControlLayout = FilterBase.Parts.InputValue.LAYOUT.Horizontal;
            this.ParaBrightnessCoeff.DecimalPlace = 1;
            this.ParaBrightnessCoeff.Description = "積雪しきい値以下のピクセルの明るさを上げるために適用される係数。\r\n値が大きいほど、雪の効果が顕著になります。\r\n0 より大きい必要があります。\r\n　　デフォルト" +
    ": 2.5。";
            this.ParaBrightnessCoeff.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.ParaBrightnessCoeff.InvalidValue = "";
            this.ParaBrightnessCoeff.Location = new System.Drawing.Point(3, 190);
            this.ParaBrightnessCoeff.MaxValue = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.ParaBrightnessCoeff.MaxVersion = null;
            this.ParaBrightnessCoeff.MinimumSize = new System.Drawing.Size(124, 21);
            this.ParaBrightnessCoeff.MinValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.ParaBrightnessCoeff.MinVersion = null;
            this.ParaBrightnessCoeff.Name = "ParaBrightnessCoeff";
            this.ParaBrightnessCoeff.Required = false;
            this.ParaBrightnessCoeff.Size = new System.Drawing.Size(124, 21);
            this.ParaBrightnessCoeff.TabIndex = 1;
            this.ParaBrightnessCoeff.Title = "明るさ係数";
            this.ParaBrightnessCoeff.Unit = "";
            this.ParaBrightnessCoeff.UseValid = false;
            this.ParaBrightnessCoeff.Value = new decimal(new int[] {
            25,
            0,
            0,
            65536});
            this.ParaBrightnessCoeff.ValueType = FilterBase.Parts.InputValue.VALUE_TYPE.FLOAT;
            this.ParaBrightnessCoeff.ParameterChange += new FilterBase.Parts.ParameterChangeEventHandler(this.Param_ParameterChange);
            // 
            // ParaMethod
            // 
            this.ParaMethod.ArgumentName = "method";
            this.ParaMethod.AutoSize = true;
            this.ParaMethod.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ParaMethod.DefaultValue = "";
            this.ParaMethod.Description = "使用する雪のシミュレーション方法。\r\nオプションは次のとおりです:\r\n- 「bleach」: 単純なピクセル値のしきい値設定手法を使用します。\r\n- 「textu" +
    "re」: よりリアルな雪のテクスチャ オーバーレイを適用します。\r\n　　　デフォルト: 「texture」。";
            this.ParaMethod.InvalidValue = "";
            this.ParaMethod.ItemType = "System.String";
            this.ParaMethod.Location = new System.Drawing.Point(3, 217);
            this.ParaMethod.MaxVersion = null;
            this.ParaMethod.MinimumSize = new System.Drawing.Size(124, 21);
            this.ParaMethod.MinVersion = "1.4.16";
            this.ParaMethod.Name = "ParaMethod";
            this.ParaMethod.Required = false;
            this.ParaMethod.Size = new System.Drawing.Size(124, 38);
            this.ParaMethod.TabIndex = 2;
            this.ParaMethod.Title = "雪のシミュレーション方法";
            this.ParaMethod.UseValid = false;
            this.ParaMethod.Value = null;
            this.ParaMethod.ParameterChange += new FilterBase.Parts.ParameterChangeEventHandler(this.Param_ParameterChange);
            // 
            // RandomSnow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.FLPParam);
            this.Name = "RandomSnow";
            this.Size = new System.Drawing.Size(128, 308);
            this.Target = FilterBase.BaseFilterControl.TRANSFORM_TARGET.IMAGE;
            this.Controls.SetChildIndex(this.FLPParam, 0);
            this.FLPParam.ResumeLayout(false);
            this.FLPParam.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ParaSnowPointRange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaSnowPointLower)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputTrackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaBrightnessCoeff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaMethod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel FLPParam;
        private FilterBase.Parts.InputMaxMin ParaSnowPointRange;
        private FilterBase.Parts.InputValueUpDown ParaBrightnessCoeff;
        private FilterBase.Parts.ComboBoxWithLabelParts ParaMethod;
        private FilterBase.Parts.InputTrackBar ParaSnowPointLower;
        private FilterBase.Parts.InputTrackBar inputTrackBar1;
    }
}
