namespace Filter.Geometric
{
    partial class OpticalDistortion
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
            this.ParaDistortLimit = new FilterBase.Parts.InputMaxMin();
            this.ParaShiftLimit = new FilterBase.Parts.InputMaxMin();
            this.ParaInterpolation = new FilterBase.Parts.ComboBoxWithLabelParts();
            this.ParaBorderMode = new FilterBase.Parts.ComboBoxWithLabelParts();
            this.ParaValue = new FilterBase.Parts.ColorSelectorParts();
            this.ParaMaskValue = new FilterBase.Parts.ColorSelectorParts();
            this.ParaMaskInterpolation = new FilterBase.Parts.ComboBoxWithLabelParts();
            this.FLPParam.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ParaDistortLimit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaShiftLimit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaInterpolation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaBorderMode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaMaskValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaMaskInterpolation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // FLPParam
            // 
            this.FLPParam.AutoSize = true;
            this.FLPParam.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.FLPParam.Controls.Add(this.ParaDistortLimit);
            this.FLPParam.Controls.Add(this.ParaShiftLimit);
            this.FLPParam.Controls.Add(this.ParaInterpolation);
            this.FLPParam.Controls.Add(this.ParaBorderMode);
            this.FLPParam.Controls.Add(this.ParaValue);
            this.FLPParam.Controls.Add(this.ParaMaskValue);
            this.FLPParam.Controls.Add(this.ParaMaskInterpolation);
            this.FLPParam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FLPParam.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.FLPParam.Location = new System.Drawing.Point(0, 24);
            this.FLPParam.Name = "FLPParam";
            this.FLPParam.Size = new System.Drawing.Size(128, 366);
            this.FLPParam.TabIndex = 5;
            // 
            // ParaDistortLimit
            // 
            this.ParaDistortLimit.ArgumentName = "distort_limit";
            this.ParaDistortLimit.AutoSize = true;
            this.ParaDistortLimit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ParaDistortLimit.DecimalPlace = 2;
            this.ParaDistortLimit.Description = "歪み係数の範囲。\r\nデフォルト: (-0.05, 0.05)。";
            this.ParaDistortLimit.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.ParaDistortLimit.InvalidValue = "";
            this.ParaDistortLimit.Location = new System.Drawing.Point(3, 3);
            this.ParaDistortLimit.MaxValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ParaDistortLimit.MaxVersion = null;
            this.ParaDistortLimit.MinimumSize = new System.Drawing.Size(124, 21);
            this.ParaDistortLimit.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.ParaDistortLimit.MinVersion = null;
            this.ParaDistortLimit.Name = "ParaDistortLimit";
            this.ParaDistortLimit.Required = false;
            this.ParaDistortLimit.Size = new System.Drawing.Size(124, 39);
            this.ParaDistortLimit.TabIndex = 16;
            this.ParaDistortLimit.Title = "歪み係数範囲";
            this.ParaDistortLimit.UseLargeValue = false;
            this.ParaDistortLimit.UseValid = false;
            this.ParaDistortLimit.Valid = true;
            this.ParaDistortLimit.Value = "(-0.05,0.05)";
            this.ParaDistortLimit.ValueType = FilterBase.Parts.PartsFunc.VALUE_TYPE.TYPE_FLOAT;
            this.ParaDistortLimit.ParameterChange += new FilterBase.Parts.ParameterChangeEventHandler(this.Param_ParameterChange);
            // 
            // ParaShiftLimit
            // 
            this.ParaShiftLimit.ArgumentName = "shift_limit";
            this.ParaShiftLimit.AutoSize = true;
            this.ParaShiftLimit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ParaShiftLimit.DecimalPlace = 2;
            this.ParaShiftLimit.Description = "画像の中心のシフトの範囲。\r\nデフォルト: (-0.05, 0.05)。";
            this.ParaShiftLimit.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.ParaShiftLimit.InvalidValue = "";
            this.ParaShiftLimit.Location = new System.Drawing.Point(3, 48);
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
            this.ParaShiftLimit.Size = new System.Drawing.Size(124, 39);
            this.ParaShiftLimit.TabIndex = 17;
            this.ParaShiftLimit.Title = "シフト範囲";
            this.ParaShiftLimit.UseLargeValue = false;
            this.ParaShiftLimit.UseValid = false;
            this.ParaShiftLimit.Valid = true;
            this.ParaShiftLimit.Value = "(-0.05,0.05)";
            this.ParaShiftLimit.ValueType = FilterBase.Parts.PartsFunc.VALUE_TYPE.TYPE_FLOAT;
            this.ParaShiftLimit.ParameterChange += new FilterBase.Parts.ParameterChangeEventHandler(this.Param_ParameterChange);
            // 
            // ParaInterpolation
            // 
            this.ParaInterpolation.ArgumentName = "interpolation";
            this.ParaInterpolation.AutoSize = true;
            this.ParaInterpolation.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ParaInterpolation.DefaultValue = "LINEAR";
            this.ParaInterpolation.Description = "画像変換に使用する補間方法。\r\nOpenCV 補間タイプの 1 つである必要があります。\r\nデフォルト: cv2.INTER_LINEAR";
            this.ParaInterpolation.InvalidValue = "";
            this.ParaInterpolation.ItemType = "InterpolationFlags";
            this.ParaInterpolation.Location = new System.Drawing.Point(3, 93);
            this.ParaInterpolation.MaxVersion = null;
            this.ParaInterpolation.MinimumSize = new System.Drawing.Size(124, 21);
            this.ParaInterpolation.MinVersion = null;
            this.ParaInterpolation.Name = "ParaInterpolation";
            this.ParaInterpolation.Required = false;
            this.ParaInterpolation.Size = new System.Drawing.Size(124, 38);
            this.ParaInterpolation.TabIndex = 11;
            this.ParaInterpolation.Title = "補間方法";
            this.ParaInterpolation.UseValid = false;
            this.ParaInterpolation.Valid = true;
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
            this.ParaBorderMode.InvalidValue = "";
            this.ParaBorderMode.ItemType = "BorderTypes";
            this.ParaBorderMode.Location = new System.Drawing.Point(3, 137);
            this.ParaBorderMode.MaxVersion = null;
            this.ParaBorderMode.MinimumSize = new System.Drawing.Size(124, 21);
            this.ParaBorderMode.MinVersion = null;
            this.ParaBorderMode.Name = "ParaBorderMode";
            this.ParaBorderMode.Required = false;
            this.ParaBorderMode.Size = new System.Drawing.Size(124, 38);
            this.ParaBorderMode.TabIndex = 13;
            this.ParaBorderMode.Title = "ピクセル外挿方法";
            this.ParaBorderMode.UseValid = false;
            this.ParaBorderMode.Valid = true;
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
            this.ParaValue.InvalidValue = "";
            this.ParaValue.IsColor = true;
            this.ParaValue.Location = new System.Drawing.Point(3, 181);
            this.ParaValue.MaxVersion = null;
            this.ParaValue.MinimumSize = new System.Drawing.Size(124, 21);
            this.ParaValue.MinVersion = null;
            this.ParaValue.Name = "ParaValue";
            this.ParaValue.Required = false;
            this.ParaValue.Size = new System.Drawing.Size(124, 66);
            this.ParaValue.TabIndex = 14;
            this.ParaValue.Title = "パディング色";
            this.ParaValue.UseValid = true;
            this.ParaValue.Valid = false;
            this.ParaValue.ParameterChange += new FilterBase.Parts.ParameterChangeEventHandler(this.Param_ParameterChange);
            // 
            // ParaMaskValue
            // 
            this.ParaMaskValue.ArgumentName = "mask_value";
            this.ParaMaskValue.AutoSize = true;
            this.ParaMaskValue.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ParaMaskValue.Color = System.Drawing.Color.Black;
            this.ParaMaskValue.Description = "border_mode が cv2.BORDER_CONSTANT の場合のパディング値がマスクに適用されます。";
            this.ParaMaskValue.InvalidValue = "";
            this.ParaMaskValue.IsColor = true;
            this.ParaMaskValue.Location = new System.Drawing.Point(3, 253);
            this.ParaMaskValue.MaxVersion = null;
            this.ParaMaskValue.MinimumSize = new System.Drawing.Size(124, 21);
            this.ParaMaskValue.MinVersion = null;
            this.ParaMaskValue.Name = "ParaMaskValue";
            this.ParaMaskValue.Required = false;
            this.ParaMaskValue.Size = new System.Drawing.Size(124, 66);
            this.ParaMaskValue.TabIndex = 15;
            this.ParaMaskValue.Title = "Maskパディング色";
            this.ParaMaskValue.UseValid = true;
            this.ParaMaskValue.Valid = false;
            this.ParaMaskValue.ParameterChange += new FilterBase.Parts.ParameterChangeEventHandler(this.Param_ParameterChange);
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
            this.ParaMaskInterpolation.InvalidValue = "";
            this.ParaMaskInterpolation.ItemType = "InterpolationFlags";
            this.ParaMaskInterpolation.Location = new System.Drawing.Point(3, 325);
            this.ParaMaskInterpolation.MaxVersion = null;
            this.ParaMaskInterpolation.MinimumSize = new System.Drawing.Size(124, 21);
            this.ParaMaskInterpolation.MinVersion = null;
            this.ParaMaskInterpolation.Name = "ParaMaskInterpolation";
            this.ParaMaskInterpolation.Required = false;
            this.ParaMaskInterpolation.Size = new System.Drawing.Size(124, 38);
            this.ParaMaskInterpolation.TabIndex = 12;
            this.ParaMaskInterpolation.Title = "マスク補間方法";
            this.ParaMaskInterpolation.UseValid = false;
            this.ParaMaskInterpolation.Valid = true;
            this.ParaMaskInterpolation.Value = null;
            this.ParaMaskInterpolation.ParameterChange += new FilterBase.Parts.ParameterChangeEventHandler(this.Param_ParameterChange);
            // 
            // OpticalDistortion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.FLPParam);
            this.Name = "OpticalDistortion";
            this.Size = new System.Drawing.Size(128, 415);
            this.Controls.SetChildIndex(this.FLPParam, 0);
            this.FLPParam.ResumeLayout(false);
            this.FLPParam.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ParaDistortLimit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaShiftLimit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaInterpolation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaBorderMode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaMaskValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaMaskInterpolation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel FLPParam;
        private FilterBase.Parts.ComboBoxWithLabelParts ParaInterpolation;
        private FilterBase.Parts.ComboBoxWithLabelParts ParaBorderMode;
        private FilterBase.Parts.ColorSelectorParts ParaValue;
        private FilterBase.Parts.ColorSelectorParts ParaMaskValue;
        private FilterBase.Parts.ComboBoxWithLabelParts ParaMaskInterpolation;
        private FilterBase.Parts.InputMaxMin ParaDistortLimit;
        private FilterBase.Parts.InputMaxMin ParaShiftLimit;
    }
}
