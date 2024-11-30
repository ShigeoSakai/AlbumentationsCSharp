namespace Filter.BasicTransform
{
    partial class RandomRain
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
            this.ParaSlantRange = new FilterBase.Parts.InputMaxMin();
            this.ParaDropLength = new FilterBase.Parts.InputValueUpDown();
            this.ParaDropWidth = new FilterBase.Parts.InputValueUpDown();
            this.ParaDropColor = new FilterBase.Parts.ColorSelectorParts();
            this.ParaBlurValue = new FilterBase.Parts.InputValueUpDown();
            this.ParaBrightnessCoefficient = new FilterBase.Parts.InputTrackBar();
            this.ParaRainType = new FilterBase.Parts.ComboBoxWithLabelParts();
            this.ParaSlantLower = new FilterBase.Parts.InputTrackBar();
            this.ParaSlantUpper = new FilterBase.Parts.InputTrackBar();
            this.FLPParam.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ParaSlantRange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaDropLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaDropWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaDropColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaBlurValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaBrightnessCoefficient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaRainType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaSlantLower)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaSlantUpper)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // FLPParam
            // 
            this.FLPParam.AutoSize = true;
            this.FLPParam.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.FLPParam.Controls.Add(this.ParaSlantRange);
            this.FLPParam.Controls.Add(this.ParaSlantLower);
            this.FLPParam.Controls.Add(this.ParaSlantUpper);
            this.FLPParam.Controls.Add(this.ParaDropLength);
            this.FLPParam.Controls.Add(this.ParaDropWidth);
            this.FLPParam.Controls.Add(this.ParaDropColor);
            this.FLPParam.Controls.Add(this.ParaBlurValue);
            this.FLPParam.Controls.Add(this.ParaBrightnessCoefficient);
            this.FLPParam.Controls.Add(this.ParaRainType);
            this.FLPParam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FLPParam.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.FLPParam.Location = new System.Drawing.Point(0, 25);
            this.FLPParam.Name = "FLPParam";
            this.FLPParam.Size = new System.Drawing.Size(128, 468);
            this.FLPParam.TabIndex = 5;
            // 
            // ParaSlantRange
            // 
            this.ParaSlantRange.ArgumentName = "slant_range";
            this.ParaSlantRange.AutoSize = true;
            this.ParaSlantRange.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ParaSlantRange.DecimalPlace = 0;
            this.ParaSlantRange.Description = "雨の傾斜角度の範囲（度）。\r\n負の値は左に傾斜し、正の値は右に傾斜します。\r\n　　デフォルト: (-10, 10)。";
            this.ParaSlantRange.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ParaSlantRange.Location = new System.Drawing.Point(3, 3);
            this.ParaSlantRange.MaxValue = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.ParaSlantRange.MaxVersion = null;
            this.ParaSlantRange.MinimumSize = new System.Drawing.Size(124, 21);
            this.ParaSlantRange.MinValue = new decimal(new int[] {
            180,
            0,
            0,
            -2147483648});
            this.ParaSlantRange.MinVersion = "1.4.8";
            this.ParaSlantRange.Name = "ParaSlantRange";
            this.ParaSlantRange.Required = false;
            this.ParaSlantRange.Size = new System.Drawing.Size(124, 42);
            this.ParaSlantRange.TabIndex = 0;
            this.ParaSlantRange.Title = "雨の傾斜角度(度)";
            this.ParaSlantRange.Value = "(-10,10)";
            this.ParaSlantRange.ValueType = FilterBase.Parts.PartsFunc.VALUE_TYPE.TYPE_INT;
            this.ParaSlantRange.ParameterChange += new FilterBase.Parts.ParameterChangeEventHandler(this.Param_ParameterChange);
            // 
            // ParaDropLength
            // 
            this.ParaDropLength.ArgumentName = "drop_length";
            this.ParaDropLength.AutoSize = true;
            this.ParaDropLength.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ParaDropLength.ControlLayout = FilterBase.Parts.InputValue.LAYOUT.Vertical;
            this.ParaDropLength.DecimalPlace = 0;
            this.ParaDropLength.Description = "雨滴の長さ（ピクセル単位）。\r\nデフォルト: 20";
            this.ParaDropLength.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ParaDropLength.Location = new System.Drawing.Point(3, 193);
            this.ParaDropLength.MaxValue = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.ParaDropLength.MaxVersion = null;
            this.ParaDropLength.MinimumSize = new System.Drawing.Size(124, 21);
            this.ParaDropLength.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ParaDropLength.MinVersion = null;
            this.ParaDropLength.Name = "ParaDropLength";
            this.ParaDropLength.Required = false;
            this.ParaDropLength.Size = new System.Drawing.Size(124, 35);
            this.ParaDropLength.TabIndex = 1;
            this.ParaDropLength.Title = "雨滴の長さ";
            this.ParaDropLength.Unit = "px";
            this.ParaDropLength.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.ParaDropLength.ValueType = FilterBase.Parts.InputValue.VALUE_TYPE.INT;
            this.ParaDropLength.ParameterChange += new FilterBase.Parts.ParameterChangeEventHandler(this.Param_ParameterChange);
            // 
            // ParaDropWidth
            // 
            this.ParaDropWidth.ArgumentName = "drop_width";
            this.ParaDropWidth.AutoSize = true;
            this.ParaDropWidth.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ParaDropWidth.ControlLayout = FilterBase.Parts.InputValue.LAYOUT.Vertical;
            this.ParaDropWidth.DecimalPlace = 0;
            this.ParaDropWidth.Description = "雨滴の幅（ピクセル単位）。\r\n　デフォルト: 1。";
            this.ParaDropWidth.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ParaDropWidth.Location = new System.Drawing.Point(3, 234);
            this.ParaDropWidth.MaxValue = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.ParaDropWidth.MaxVersion = null;
            this.ParaDropWidth.MinimumSize = new System.Drawing.Size(124, 21);
            this.ParaDropWidth.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ParaDropWidth.MinVersion = null;
            this.ParaDropWidth.Name = "ParaDropWidth";
            this.ParaDropWidth.Required = false;
            this.ParaDropWidth.Size = new System.Drawing.Size(124, 35);
            this.ParaDropWidth.TabIndex = 2;
            this.ParaDropWidth.Title = "雨滴の幅";
            this.ParaDropWidth.Unit = "px";
            this.ParaDropWidth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ParaDropWidth.ValueType = FilterBase.Parts.InputValue.VALUE_TYPE.INT;
            this.ParaDropWidth.ParameterChange += new FilterBase.Parts.ParameterChangeEventHandler(this.Param_ParameterChange);
            // 
            // ParaDropColor
            // 
            this.ParaDropColor.ArgumentName = "drop_color";
            this.ParaDropColor.AutoSize = true;
            this.ParaDropColor.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ParaDropColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.ParaDropColor.Description = "RGB 形式の雨滴の色。\r\nデフォルト: (200, 200, 200)。";
            this.ParaDropColor.IsColor = true;
            this.ParaDropColor.Location = new System.Drawing.Point(3, 275);
            this.ParaDropColor.MaxVersion = null;
            this.ParaDropColor.MinimumSize = new System.Drawing.Size(124, 21);
            this.ParaDropColor.MinVersion = null;
            this.ParaDropColor.Name = "ParaDropColor";
            this.ParaDropColor.Required = false;
            this.ParaDropColor.Size = new System.Drawing.Size(124, 48);
            this.ParaDropColor.TabIndex = 3;
            this.ParaDropColor.Title = "雨滴の色";
            this.ParaDropColor.ParameterChange += new FilterBase.Parts.ParameterChangeEventHandler(this.Param_ParameterChange);
            // 
            // ParaBlurValue
            // 
            this.ParaBlurValue.ArgumentName = "blur_value";
            this.ParaBlurValue.AutoSize = true;
            this.ParaBlurValue.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ParaBlurValue.ControlLayout = FilterBase.Parts.InputValue.LAYOUT.Horizontal;
            this.ParaBlurValue.DecimalPlace = 0;
            this.ParaBlurValue.Description = "雨の効果をシミュレートするためのぼかし値。\r\n雨が降っているビューは通常ぼやけています。\r\n　　デフォルト: 7。";
            this.ParaBlurValue.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ParaBlurValue.Location = new System.Drawing.Point(3, 329);
            this.ParaBlurValue.MaxValue = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.ParaBlurValue.MaxVersion = null;
            this.ParaBlurValue.MinimumSize = new System.Drawing.Size(124, 21);
            this.ParaBlurValue.MinValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.ParaBlurValue.MinVersion = null;
            this.ParaBlurValue.Name = "ParaBlurValue";
            this.ParaBlurValue.Required = false;
            this.ParaBlurValue.Size = new System.Drawing.Size(124, 21);
            this.ParaBlurValue.TabIndex = 4;
            this.ParaBlurValue.Title = "ぼかし値";
            this.ParaBlurValue.Unit = "";
            this.ParaBlurValue.Value = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.ParaBlurValue.ValueType = FilterBase.Parts.InputValue.VALUE_TYPE.INT;
            this.ParaBlurValue.ParameterChange += new FilterBase.Parts.ParameterChangeEventHandler(this.Param_ParameterChange);
            // 
            // ParaBrightnessCoefficient
            // 
            this.ParaBrightnessCoefficient.ArgumentName = "brightness_coefficient";
            this.ParaBrightnessCoefficient.AutoSize = true;
            this.ParaBrightnessCoefficient.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ParaBrightnessCoefficient.DecimalPlace = 1;
            this.ParaBrightnessCoefficient.Description = "画像の明るさを調整する係数。\r\n雨のシーンは通常暗くなります。\r\n範囲は (0, 1] である必要があります。\r\n　　デフォルト: 0.7。";
            this.ParaBrightnessCoefficient.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.ParaBrightnessCoefficient.Location = new System.Drawing.Point(3, 356);
            this.ParaBrightnessCoefficient.MaxValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ParaBrightnessCoefficient.MaxVersion = null;
            this.ParaBrightnessCoefficient.MinimumSize = new System.Drawing.Size(124, 21);
            this.ParaBrightnessCoefficient.MinValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.ParaBrightnessCoefficient.MinVersion = null;
            this.ParaBrightnessCoefficient.Name = "ParaBrightnessCoefficient";
            this.ParaBrightnessCoefficient.Required = false;
            this.ParaBrightnessCoefficient.Size = new System.Drawing.Size(124, 65);
            this.ParaBrightnessCoefficient.TabIndex = 5;
            this.ParaBrightnessCoefficient.Title = "明るさ係数";
            this.ParaBrightnessCoefficient.Value = new decimal(new int[] {
            7,
            0,
            0,
            65536});
            this.ParaBrightnessCoefficient.ParameterChange += new FilterBase.Parts.ParameterChangeEventHandler(this.Param_ParameterChange);
            // 
            // ParaRainType
            // 
            this.ParaRainType.ArgumentName = "rain_type";
            this.ParaRainType.AutoSize = true;
            this.ParaRainType.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ParaRainType.DefaultValue = "";
            this.ParaRainType.Description = "シミュレートする雨の種類。";
            this.ParaRainType.ItemType = "System.String";
            this.ParaRainType.Location = new System.Drawing.Point(3, 427);
            this.ParaRainType.MaxVersion = null;
            this.ParaRainType.MinimumSize = new System.Drawing.Size(124, 21);
            this.ParaRainType.MinVersion = null;
            this.ParaRainType.Name = "ParaRainType";
            this.ParaRainType.Required = false;
            this.ParaRainType.Size = new System.Drawing.Size(124, 38);
            this.ParaRainType.TabIndex = 6;
            this.ParaRainType.Title = "雨の種類";
            this.ParaRainType.Value = null;
            this.ParaRainType.ParameterChange += new FilterBase.Parts.ParameterChangeEventHandler(this.Param_ParameterChange);
            // 
            // ParaSlantLower
            // 
            this.ParaSlantLower.ArgumentName = "slant_lower";
            this.ParaSlantLower.AutoSize = true;
            this.ParaSlantLower.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ParaSlantLower.DecimalPlace = 0;
            this.ParaSlantLower.Description = "雨の傾斜角度(度)　最小値";
            this.ParaSlantLower.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ParaSlantLower.Location = new System.Drawing.Point(3, 51);
            this.ParaSlantLower.MaxValue = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.ParaSlantLower.MaxVersion = "1.4.7";
            this.ParaSlantLower.MinimumSize = new System.Drawing.Size(124, 21);
            this.ParaSlantLower.MinValue = new decimal(new int[] {
            20,
            0,
            0,
            -2147483648});
            this.ParaSlantLower.MinVersion = null;
            this.ParaSlantLower.Name = "ParaSlantLower";
            this.ParaSlantLower.Required = false;
            this.ParaSlantLower.Size = new System.Drawing.Size(124, 65);
            this.ParaSlantLower.TabIndex = 7;
            this.ParaSlantLower.Title = "雨の傾斜角度(最小)";
            this.ParaSlantLower.Value = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.ParaSlantLower.ParameterChange += new FilterBase.Parts.ParameterChangeEventHandler(this.Param_ParameterChange);
            // 
            // ParaSlantUpper
            // 
            this.ParaSlantUpper.ArgumentName = "slant_upper";
            this.ParaSlantUpper.AutoSize = true;
            this.ParaSlantUpper.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ParaSlantUpper.DecimalPlace = 0;
            this.ParaSlantUpper.Description = "雨の傾斜角度(度)　最大値";
            this.ParaSlantUpper.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ParaSlantUpper.Location = new System.Drawing.Point(3, 122);
            this.ParaSlantUpper.MaxValue = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.ParaSlantUpper.MaxVersion = "1.4.7";
            this.ParaSlantUpper.MinimumSize = new System.Drawing.Size(124, 21);
            this.ParaSlantUpper.MinValue = new decimal(new int[] {
            20,
            0,
            0,
            -2147483648});
            this.ParaSlantUpper.MinVersion = null;
            this.ParaSlantUpper.Name = "ParaSlantUpper";
            this.ParaSlantUpper.Required = false;
            this.ParaSlantUpper.Size = new System.Drawing.Size(124, 65);
            this.ParaSlantUpper.TabIndex = 8;
            this.ParaSlantUpper.Title = "雨の傾斜角度(最大)";
            this.ParaSlantUpper.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.ParaSlantUpper.ParameterChange += new FilterBase.Parts.ParameterChangeEventHandler(this.Param_ParameterChange);
            // 
            // RandomRain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.FLPParam);
            this.Name = "RandomRain";
            this.Size = new System.Drawing.Size(128, 518);
            this.Target = FilterBase.BaseFilterControl.TRANSFORM_TARGET.IMAGE;
            this.Controls.SetChildIndex(this.FLPParam, 0);
            this.FLPParam.ResumeLayout(false);
            this.FLPParam.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ParaSlantRange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaDropLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaDropWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaDropColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaBlurValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaBrightnessCoefficient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaRainType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaSlantLower)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaSlantUpper)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel FLPParam;
        private FilterBase.Parts.InputMaxMin ParaSlantRange;
        private FilterBase.Parts.InputValueUpDown ParaDropLength;
        private FilterBase.Parts.InputValueUpDown ParaDropWidth;
        private FilterBase.Parts.ColorSelectorParts ParaDropColor;
        private FilterBase.Parts.InputValueUpDown ParaBlurValue;
        private FilterBase.Parts.InputTrackBar ParaBrightnessCoefficient;
        private FilterBase.Parts.ComboBoxWithLabelParts ParaRainType;
        private FilterBase.Parts.InputTrackBar ParaSlantLower;
        private FilterBase.Parts.InputTrackBar ParaSlantUpper;
    }
}
