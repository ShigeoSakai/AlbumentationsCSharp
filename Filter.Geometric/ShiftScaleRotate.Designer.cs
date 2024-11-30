namespace Filter.Geometric
{
    partial class ShiftScaleRotate
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
            this.ParaShiftLimit = new FilterBase.Parts.InputMaxMin();
            this.ParaScaleLimit = new FilterBase.Parts.InputMaxMin();
            this.ParaRotateLimit = new FilterBase.Parts.InputMaxMin();
            this.ParaInterpolation = new FilterBase.Parts.ComboBoxWithLabelParts();
            this.ParaBorderMode = new FilterBase.Parts.ComboBoxWithLabelParts();
            this.ParaValue = new FilterBase.Parts.ColorSelectorParts();
            this.ParaMaskValue = new FilterBase.Parts.ColorSelectorParts();
            this.ParaShiftLimitX = new FilterBase.Parts.InputMaxMin();
            this.ParaShiftLimitY = new FilterBase.Parts.InputMaxMin();
            this.ParaRotateMethod = new FilterBase.Parts.ComboBoxWithLabelParts();
            this.ParaMaskInterpolation = new FilterBase.Parts.ComboBoxWithLabelParts();
            this.FLPParam.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ParaShiftLimit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaScaleLimit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaRotateLimit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaInterpolation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaBorderMode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaMaskValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaShiftLimitX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaShiftLimitY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaRotateMethod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaMaskInterpolation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // FLPParam
            // 
            this.FLPParam.AutoSize = true;
            this.FLPParam.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.FLPParam.Controls.Add(this.ParaShiftLimit);
            this.FLPParam.Controls.Add(this.ParaScaleLimit);
            this.FLPParam.Controls.Add(this.ParaRotateLimit);
            this.FLPParam.Controls.Add(this.ParaInterpolation);
            this.FLPParam.Controls.Add(this.ParaBorderMode);
            this.FLPParam.Controls.Add(this.ParaValue);
            this.FLPParam.Controls.Add(this.ParaMaskValue);
            this.FLPParam.Controls.Add(this.ParaShiftLimitX);
            this.FLPParam.Controls.Add(this.ParaShiftLimitY);
            this.FLPParam.Controls.Add(this.ParaRotateMethod);
            this.FLPParam.Controls.Add(this.ParaMaskInterpolation);
            this.FLPParam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FLPParam.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.FLPParam.Location = new System.Drawing.Point(0, 25);
            this.FLPParam.Name = "FLPParam";
            this.FLPParam.Size = new System.Drawing.Size(128, 628);
            this.FLPParam.TabIndex = 5;
            // 
            // ParaShiftLimit
            // 
            this.ParaShiftLimit.ArgumentName = "shift_limit";
            this.ParaShiftLimit.AutoSize = true;
            this.ParaShiftLimit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ParaShiftLimit.DecimalPlace = 4;
            this.ParaShiftLimit.Description = "高さと幅の両方のシフト係数の範囲。\r\n下限と上限の絶対値は [-1, 1] の範囲内にある必要があります。\r\nデフォルト: (-0.0625, 0.0625)。";
            this.ParaShiftLimit.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.ParaShiftLimit.InvalidValue = "";
            this.ParaShiftLimit.Location = new System.Drawing.Point(3, 3);
            this.ParaShiftLimit.MaxValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ParaShiftLimit.MaxVersion = null;
            this.ParaShiftLimit.MinimumSize = new System.Drawing.Size(124, 21);
            this.ParaShiftLimit.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.ParaShiftLimit.MinVersion = null;
            this.ParaShiftLimit.Name = "ParaShiftLimit";
            this.ParaShiftLimit.Required = false;
            this.ParaShiftLimit.Size = new System.Drawing.Size(124, 64);
            this.ParaShiftLimit.TabIndex = 8;
            this.ParaShiftLimit.Title = "シフト係数範囲";
            this.ParaShiftLimit.UseLargeValue = true;
            this.ParaShiftLimit.UseValid = false;
            this.ParaShiftLimit.Value = "(-0.0625,0.0625)";
            this.ParaShiftLimit.ValueType = FilterBase.Parts.PartsFunc.VALUE_TYPE.TYPE_FLOAT;
            this.ParaShiftLimit.ParameterChange += new FilterBase.Parts.ParameterChangeEventHandler(this.Param_ParameterChange);
            // 
            // ParaScaleLimit
            // 
            this.ParaScaleLimit.ArgumentName = "scale_limit";
            this.ParaScaleLimit.AutoSize = true;
            this.ParaScaleLimit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ParaScaleLimit.DecimalPlace = 1;
            this.ParaScaleLimit.Description = "スケーリング係数の範囲。\r\nscale_limit は 1 ずつバイアスされることに注意してください。\r\nscale_limit が (low, high) のよ" +
    "うなタプルの場合、\r\nサンプリングは範囲 (1 + low, 1 + high) から行われます。\r\nデフォルト: (-0.1, 0.1)。";
            this.ParaScaleLimit.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.ParaScaleLimit.InvalidValue = "";
            this.ParaScaleLimit.Location = new System.Drawing.Point(3, 73);
            this.ParaScaleLimit.MaxValue = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.ParaScaleLimit.MaxVersion = null;
            this.ParaScaleLimit.MinimumSize = new System.Drawing.Size(124, 21);
            this.ParaScaleLimit.MinValue = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.ParaScaleLimit.MinVersion = null;
            this.ParaScaleLimit.Name = "ParaScaleLimit";
            this.ParaScaleLimit.Required = false;
            this.ParaScaleLimit.Size = new System.Drawing.Size(124, 39);
            this.ParaScaleLimit.TabIndex = 9;
            this.ParaScaleLimit.Title = "スケーリング係数の範囲";
            this.ParaScaleLimit.UseLargeValue = false;
            this.ParaScaleLimit.UseValid = false;
            this.ParaScaleLimit.Value = "(-0.1,0.1)";
            this.ParaScaleLimit.ValueType = FilterBase.Parts.PartsFunc.VALUE_TYPE.TYPE_FLOAT;
            this.ParaScaleLimit.ParameterChange += new FilterBase.Parts.ParameterChangeEventHandler(this.Param_ParameterChange);
            // 
            // ParaRotateLimit
            // 
            this.ParaRotateLimit.ArgumentName = "rotate_limit";
            this.ParaRotateLimit.AutoSize = true;
            this.ParaRotateLimit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ParaRotateLimit.DecimalPlace = 0;
            this.ParaRotateLimit.Description = "回転範囲。\r\n　　デフォルト: (-45, 45)。";
            this.ParaRotateLimit.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ParaRotateLimit.InvalidValue = "";
            this.ParaRotateLimit.Location = new System.Drawing.Point(3, 118);
            this.ParaRotateLimit.MaxValue = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.ParaRotateLimit.MaxVersion = null;
            this.ParaRotateLimit.MinimumSize = new System.Drawing.Size(124, 21);
            this.ParaRotateLimit.MinValue = new decimal(new int[] {
            180,
            0,
            0,
            -2147483648});
            this.ParaRotateLimit.MinVersion = null;
            this.ParaRotateLimit.Name = "ParaRotateLimit";
            this.ParaRotateLimit.Required = false;
            this.ParaRotateLimit.Size = new System.Drawing.Size(124, 39);
            this.ParaRotateLimit.TabIndex = 0;
            this.ParaRotateLimit.Title = "回転範囲";
            this.ParaRotateLimit.UseLargeValue = false;
            this.ParaRotateLimit.UseValid = false;
            this.ParaRotateLimit.Value = "(-45,45)";
            this.ParaRotateLimit.ValueType = FilterBase.Parts.PartsFunc.VALUE_TYPE.TYPE_INT;
            this.ParaRotateLimit.ParameterChange += new FilterBase.Parts.ParameterChangeEventHandler(this.Param_ParameterChange);
            // 
            // ParaInterpolation
            // 
            this.ParaInterpolation.ArgumentName = "interpolation";
            this.ParaInterpolation.AutoSize = true;
            this.ParaInterpolation.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ParaInterpolation.DefaultValue = "LINEAR";
            this.ParaInterpolation.Description = "補間アルゴリズムを指定するために使用されるフラグ。次のいずれかになります:\r\ncv2.INTER_NEAREST、cv2.INTER_LINEAR、cv2.INT" +
    "ER_CUBIC、cv2.INTER_AREA、cv2.INTER_LANCZOS4。\r\nデフォルト: cv2.INTER_LINEAR。";
            this.ParaInterpolation.ItemType = "InterpolationFlags";
            this.ParaInterpolation.Location = new System.Drawing.Point(3, 163);
            this.ParaInterpolation.MaxVersion = null;
            this.ParaInterpolation.MinimumSize = new System.Drawing.Size(124, 21);
            this.ParaInterpolation.MinVersion = null;
            this.ParaInterpolation.Name = "ParaInterpolation";
            this.ParaInterpolation.Required = false;
            this.ParaInterpolation.Size = new System.Drawing.Size(124, 38);
            this.ParaInterpolation.TabIndex = 1;
            this.ParaInterpolation.Title = "補間方法";
            this.ParaInterpolation.Value = null;
            this.ParaInterpolation.ParameterChange += new FilterBase.Parts.ParameterChangeEventHandler(this.Param_ParameterChange);
            // 
            // ParaBorderMode
            // 
            this.ParaBorderMode.ArgumentName = "border_mode";
            this.ParaBorderMode.AutoSize = true;
            this.ParaBorderMode.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ParaBorderMode.DefaultValue = "REFLECT_101";
            this.ParaBorderMode.Description = "ピクセル外挿方法を指定するために使用されるフラグ。次のいずれかになります:\r\ncv2.BORDER_CONSTANT、cv2.BORDER_REPLICATE、c" +
    "v2.BORDER_REFLECT、cv2.BORDER_WRAP、cv2.BORDER_REFLECT_101。\r\nデフォルト: cv2.BORDER_REF" +
    "LECT_101";
            this.ParaBorderMode.ItemType = "BorderTypes";
            this.ParaBorderMode.Location = new System.Drawing.Point(3, 207);
            this.ParaBorderMode.MaxVersion = null;
            this.ParaBorderMode.MinimumSize = new System.Drawing.Size(124, 21);
            this.ParaBorderMode.MinVersion = null;
            this.ParaBorderMode.Name = "ParaBorderMode";
            this.ParaBorderMode.Required = false;
            this.ParaBorderMode.Size = new System.Drawing.Size(124, 38);
            this.ParaBorderMode.TabIndex = 2;
            this.ParaBorderMode.Title = "ピクセル外挿方法";
            this.ParaBorderMode.Value = null;
            this.ParaBorderMode.SelectedIndexChanged += new FilterBase.Parts.ComboBoxWithLabelParts.ComboBoxSelectEventHandler(this.ParaBorderMode_SelectedIndexChanged);
            this.ParaBorderMode.ParameterChange += new FilterBase.Parts.ParameterChangeEventHandler(this.Param_ParameterChange);
            // 
            // ParaValue
            // 
            this.ParaValue.ArgumentName = "value";
            this.ParaValue.AutoSize = true;
            this.ParaValue.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ParaValue.Color = System.Drawing.Color.Black;
            this.ParaValue.Description = "border_mode が cv2.BORDER_CONSTANT の場合のパディング値。";
            this.ParaValue.IsColor = true;
            this.ParaValue.Location = new System.Drawing.Point(3, 251);
            this.ParaValue.MaxVersion = null;
            this.ParaValue.MinimumSize = new System.Drawing.Size(124, 21);
            this.ParaValue.MinVersion = null;
            this.ParaValue.Name = "ParaValue";
            this.ParaValue.Required = false;
            this.ParaValue.Size = new System.Drawing.Size(124, 48);
            this.ParaValue.TabIndex = 3;
            this.ParaValue.Title = "パディング色";
            this.ParaValue.ParameterChange += new FilterBase.Parts.ParameterChangeEventHandler(this.Param_ParameterChange);
            // 
            // ParaMaskValue
            // 
            this.ParaMaskValue.ArgumentName = "mask_value";
            this.ParaMaskValue.AutoSize = true;
            this.ParaMaskValue.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ParaMaskValue.Color = System.Drawing.Color.Black;
            this.ParaMaskValue.Description = "border_mode が cv2.BORDER_CONSTANT の場合のパディング値がマスクに適用されます。";
            this.ParaMaskValue.IsColor = true;
            this.ParaMaskValue.Location = new System.Drawing.Point(3, 305);
            this.ParaMaskValue.MaxVersion = null;
            this.ParaMaskValue.MinimumSize = new System.Drawing.Size(124, 21);
            this.ParaMaskValue.MinVersion = null;
            this.ParaMaskValue.Name = "ParaMaskValue";
            this.ParaMaskValue.Required = false;
            this.ParaMaskValue.Size = new System.Drawing.Size(124, 48);
            this.ParaMaskValue.TabIndex = 4;
            this.ParaMaskValue.Title = "Maskパディング色";
            this.ParaMaskValue.ParameterChange += new FilterBase.Parts.ParameterChangeEventHandler(this.Param_ParameterChange);
            // 
            // ParaShiftLimitX
            // 
            this.ParaShiftLimitX.ArgumentName = "shift_limit_x";
            this.ParaShiftLimitX.AutoSize = true;
            this.ParaShiftLimitX.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ParaShiftLimitX.DecimalPlace = 4;
            this.ParaShiftLimitX.Description = "幅のシフト係数の範囲。設定されている場合、shift_limit の代わりにこの値が幅のシフトに使用されます。\r\n下限と上限の絶対値は [-1、1] の範囲内であ" +
    "る必要があります。\r\n　　デフォルト: なし。";
            this.ParaShiftLimitX.Increment = new decimal(new int[] {
            1,
            0,
            0,
            262144});
            this.ParaShiftLimitX.InvalidValue = "";
            this.ParaShiftLimitX.Location = new System.Drawing.Point(3, 359);
            this.ParaShiftLimitX.MaxValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ParaShiftLimitX.MaxVersion = null;
            this.ParaShiftLimitX.MinimumSize = new System.Drawing.Size(124, 21);
            this.ParaShiftLimitX.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.ParaShiftLimitX.MinVersion = null;
            this.ParaShiftLimitX.Name = "ParaShiftLimitX";
            this.ParaShiftLimitX.Required = false;
            this.ParaShiftLimitX.Size = new System.Drawing.Size(124, 86);
            this.ParaShiftLimitX.TabIndex = 10;
            this.ParaShiftLimitX.Title = "X方向シフト係数範囲";
            this.ParaShiftLimitX.UseLargeValue = true;
            this.ParaShiftLimitX.UseValid = true;
            this.ParaShiftLimitX.Value = "(0.0000,0.0000)";
            this.ParaShiftLimitX.ValueType = FilterBase.Parts.PartsFunc.VALUE_TYPE.TYPE_FLOAT;
            this.ParaShiftLimitX.ParameterChange += new FilterBase.Parts.ParameterChangeEventHandler(this.Param_ParameterChange);
            // 
            // ParaShiftLimitY
            // 
            this.ParaShiftLimitY.ArgumentName = "shift_limit_y";
            this.ParaShiftLimitY.AutoSize = true;
            this.ParaShiftLimitY.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ParaShiftLimitY.DecimalPlace = 4;
            this.ParaShiftLimitY.Description = "高さのシフト係数の範囲。\r\n設定されている場合、shift_limit の代わりにこの値が高さのシフトに使用されます。\r\n下限と上限の絶対値は [-1、1] の範" +
    "囲内である必要があります。\r\nデフォルト: なし。";
            this.ParaShiftLimitY.Increment = new decimal(new int[] {
            1,
            0,
            0,
            262144});
            this.ParaShiftLimitY.InvalidValue = "";
            this.ParaShiftLimitY.Location = new System.Drawing.Point(3, 451);
            this.ParaShiftLimitY.MaxValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ParaShiftLimitY.MaxVersion = null;
            this.ParaShiftLimitY.MinimumSize = new System.Drawing.Size(124, 21);
            this.ParaShiftLimitY.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.ParaShiftLimitY.MinVersion = null;
            this.ParaShiftLimitY.Name = "ParaShiftLimitY";
            this.ParaShiftLimitY.Required = false;
            this.ParaShiftLimitY.Size = new System.Drawing.Size(124, 86);
            this.ParaShiftLimitY.TabIndex = 11;
            this.ParaShiftLimitY.Title = "Y方向シフト係数範囲";
            this.ParaShiftLimitY.UseLargeValue = true;
            this.ParaShiftLimitY.UseValid = true;
            this.ParaShiftLimitY.Value = "(0.0000,0.0000)";
            this.ParaShiftLimitY.ValueType = FilterBase.Parts.PartsFunc.VALUE_TYPE.TYPE_FLOAT;
            this.ParaShiftLimitY.ParameterChange += new FilterBase.Parts.ParameterChangeEventHandler(this.Param_ParameterChange);
            // 
            // ParaRotateMethod
            // 
            this.ParaRotateMethod.ArgumentName = "rotate_method";
            this.ParaRotateMethod.AutoSize = true;
            this.ParaRotateMethod.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ParaRotateMethod.DefaultValue = "";
            this.ParaRotateMethod.Description = "境界ボックスを回転する方法。\r\n\'largest_box\' または \'ellipse\' にする必要があります。\r\nデフォルト: \'largest_box\'";
            this.ParaRotateMethod.ItemType = "System.String";
            this.ParaRotateMethod.Location = new System.Drawing.Point(3, 543);
            this.ParaRotateMethod.MaxVersion = null;
            this.ParaRotateMethod.MinimumSize = new System.Drawing.Size(124, 21);
            this.ParaRotateMethod.MinVersion = null;
            this.ParaRotateMethod.Name = "ParaRotateMethod";
            this.ParaRotateMethod.Required = false;
            this.ParaRotateMethod.Size = new System.Drawing.Size(124, 38);
            this.ParaRotateMethod.TabIndex = 7;
            this.ParaRotateMethod.Title = "回転方法";
            this.ParaRotateMethod.Value = null;
            this.ParaRotateMethod.ParameterChange += new FilterBase.Parts.ParameterChangeEventHandler(this.Param_ParameterChange);
            // 
            // ParaMaskInterpolation
            // 
            this.ParaMaskInterpolation.ArgumentName = "mask_interpolation";
            this.ParaMaskInterpolation.AutoSize = true;
            this.ParaMaskInterpolation.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ParaMaskInterpolation.DefaultValue = "NEAREST";
            this.ParaMaskInterpolation.Description = "マスクの補間アルゴリズムを指定するために使用されるフラグ。\r\n次のいずれかである必要があります: cv2.INTER_NEAREST、cv2.INTER_LINE" +
    "AR、cv2.INTER_CUBIC、cv2.INTER_AREA、cv2.INTER_LANCZOS4。\r\nデフォルト: cv2.INTER_NEAREST。" +
    "";
            this.ParaMaskInterpolation.ItemType = "InterpolationFlags";
            this.ParaMaskInterpolation.Location = new System.Drawing.Point(3, 587);
            this.ParaMaskInterpolation.MaxVersion = null;
            this.ParaMaskInterpolation.MinimumSize = new System.Drawing.Size(124, 21);
            this.ParaMaskInterpolation.MinVersion = null;
            this.ParaMaskInterpolation.Name = "ParaMaskInterpolation";
            this.ParaMaskInterpolation.Required = false;
            this.ParaMaskInterpolation.Size = new System.Drawing.Size(124, 38);
            this.ParaMaskInterpolation.TabIndex = 6;
            this.ParaMaskInterpolation.Title = "マスク補間方法";
            this.ParaMaskInterpolation.Value = null;
            this.ParaMaskInterpolation.ParameterChange += new FilterBase.Parts.ParameterChangeEventHandler(this.Param_ParameterChange);
            // 
            // ShiftScaleRotate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.FLPParam);
            this.Name = "ShiftScaleRotate";
            this.Size = new System.Drawing.Size(128, 678);
            this.Controls.SetChildIndex(this.FLPParam, 0);
            this.FLPParam.ResumeLayout(false);
            this.FLPParam.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ParaShiftLimit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaScaleLimit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaRotateLimit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaInterpolation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaBorderMode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaMaskValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaShiftLimitX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaShiftLimitY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaRotateMethod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaMaskInterpolation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel FLPParam;
        private FilterBase.Parts.InputMaxMin ParaRotateLimit;
        private FilterBase.Parts.ComboBoxWithLabelParts ParaInterpolation;
        private FilterBase.Parts.ComboBoxWithLabelParts ParaBorderMode;
        private FilterBase.Parts.ColorSelectorParts ParaValue;
        private FilterBase.Parts.ColorSelectorParts ParaMaskValue;
        private FilterBase.Parts.ComboBoxWithLabelParts ParaMaskInterpolation;
        private FilterBase.Parts.ComboBoxWithLabelParts ParaRotateMethod;
        private FilterBase.Parts.InputMaxMin ParaShiftLimit;
        private FilterBase.Parts.InputMaxMin ParaScaleLimit;
        private FilterBase.Parts.InputMaxMin ParaShiftLimitX;
        private FilterBase.Parts.InputMaxMin ParaShiftLimitY;
    }
}
