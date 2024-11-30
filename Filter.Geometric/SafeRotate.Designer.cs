namespace Filter.Geometric
{
    partial class SafeRotate
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
            this.ParaLLimit = new FilterBase.Parts.InputMaxMin();
            this.ParaInterpolation = new FilterBase.Parts.ComboBoxWithLabelParts();
            this.ParaBorderMode = new FilterBase.Parts.ComboBoxWithLabelParts();
            this.ParaValue = new FilterBase.Parts.ColorSelectorParts();
            this.ParaMaskValue = new FilterBase.Parts.ColorSelectorParts();
            this.ParaRotateMethod = new FilterBase.Parts.ComboBoxWithLabelParts();
            this.ParaMaskInterpolation = new FilterBase.Parts.ComboBoxWithLabelParts();
            this.FLPParam.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ParaLLimit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaInterpolation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaBorderMode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaMaskValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaRotateMethod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaMaskInterpolation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // FLPParam
            // 
            this.FLPParam.AutoSize = true;
            this.FLPParam.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.FLPParam.Controls.Add(this.ParaLLimit);
            this.FLPParam.Controls.Add(this.ParaInterpolation);
            this.FLPParam.Controls.Add(this.ParaBorderMode);
            this.FLPParam.Controls.Add(this.ParaValue);
            this.FLPParam.Controls.Add(this.ParaMaskValue);
            this.FLPParam.Controls.Add(this.ParaRotateMethod);
            this.FLPParam.Controls.Add(this.ParaMaskInterpolation);
            this.FLPParam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FLPParam.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.FLPParam.Location = new System.Drawing.Point(0, 25);
            this.FLPParam.Name = "FLPParam";
            this.FLPParam.Size = new System.Drawing.Size(128, 329);
            this.FLPParam.TabIndex = 5;
            // 
            // ParaLLimit
            // 
            this.ParaLLimit.ArgumentName = "limit ";
            this.ParaLLimit.AutoSize = true;
            this.ParaLLimit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ParaLLimit.DecimalPlace = 0;
            this.ParaLLimit.Description = "ランダムな角度が選択される範囲。\r\n　　デフォルト: (-90, 90)";
            this.ParaLLimit.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ParaLLimit.InvalidValue = "";
            this.ParaLLimit.Location = new System.Drawing.Point(3, 3);
            this.ParaLLimit.MaxValue = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.ParaLLimit.MaxVersion = null;
            this.ParaLLimit.MinimumSize = new System.Drawing.Size(124, 21);
            this.ParaLLimit.MinValue = new decimal(new int[] {
            180,
            0,
            0,
            -2147483648});
            this.ParaLLimit.MinVersion = null;
            this.ParaLLimit.Name = "ParaLLimit";
            this.ParaLLimit.Required = false;
            this.ParaLLimit.Size = new System.Drawing.Size(124, 39);
            this.ParaLLimit.TabIndex = 0;
            this.ParaLLimit.Title = "角度範囲";
            this.ParaLLimit.UseLargeValue = false;
            this.ParaLLimit.UseValid = false;
            this.ParaLLimit.Value = "(-90,90)";
            this.ParaLLimit.ValueType = FilterBase.Parts.PartsFunc.VALUE_TYPE.TYPE_INT;
            this.ParaLLimit.ParameterChange += new FilterBase.Parts.ParameterChangeEventHandler(this.Param_ParameterChange);
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
            this.ParaInterpolation.Location = new System.Drawing.Point(3, 48);
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
            this.ParaBorderMode.Location = new System.Drawing.Point(3, 92);
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
            this.ParaValue.Location = new System.Drawing.Point(3, 136);
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
            this.ParaMaskValue.Location = new System.Drawing.Point(3, 190);
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
            // ParaRotateMethod
            // 
            this.ParaRotateMethod.ArgumentName = "rotate_method";
            this.ParaRotateMethod.AutoSize = true;
            this.ParaRotateMethod.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ParaRotateMethod.DefaultValue = "";
            this.ParaRotateMethod.Description = "境界ボックスを回転する方法。\r\n\'largest_box\' または \'ellipse\' にする必要があります。\r\nデフォルト: \'largest_box\'";
            this.ParaRotateMethod.ItemType = "System.String";
            this.ParaRotateMethod.Location = new System.Drawing.Point(3, 244);
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
            this.ParaMaskInterpolation.Location = new System.Drawing.Point(3, 288);
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
            // SafeRotate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.FLPParam);
            this.Name = "SafeRotate";
            this.Size = new System.Drawing.Size(128, 379);
            this.Controls.SetChildIndex(this.FLPParam, 0);
            this.FLPParam.ResumeLayout(false);
            this.FLPParam.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ParaLLimit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaInterpolation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaBorderMode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaMaskValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaRotateMethod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaMaskInterpolation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel FLPParam;
        private FilterBase.Parts.InputMaxMin ParaLLimit;
        private FilterBase.Parts.ComboBoxWithLabelParts ParaInterpolation;
        private FilterBase.Parts.ComboBoxWithLabelParts ParaBorderMode;
        private FilterBase.Parts.ColorSelectorParts ParaValue;
        private FilterBase.Parts.ColorSelectorParts ParaMaskValue;
        private FilterBase.Parts.ComboBoxWithLabelParts ParaMaskInterpolation;
        private FilterBase.Parts.ComboBoxWithLabelParts ParaRotateMethod;
    }
}
