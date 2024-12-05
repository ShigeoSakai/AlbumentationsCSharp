namespace Filter.Geometric
{
    partial class GridDistortion
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
            this.ParaNumSteps = new FilterBase.Parts.InputValueUpDown();
            this.ParaDistortLimit = new FilterBase.Parts.InputMaxMin();
            this.ParaInterpolation = new FilterBase.Parts.ComboBoxWithLabelParts();
            this.ParaBorderMode = new FilterBase.Parts.ComboBoxWithLabelParts();
            this.ParaValue = new FilterBase.Parts.ColorSelectorParts();
            this.ParaMaskValue = new FilterBase.Parts.ColorSelectorParts();
            this.ParaNormalized = new FilterBase.Parts.CheckBoxParts();
            this.ParaMaskInterpolation = new FilterBase.Parts.ComboBoxWithLabelParts();
            this.FLPParam.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ParaNumSteps)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaDistortLimit)).BeginInit();
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
            this.FLPParam.Controls.Add(this.ParaNumSteps);
            this.FLPParam.Controls.Add(this.ParaDistortLimit);
            this.FLPParam.Controls.Add(this.ParaInterpolation);
            this.FLPParam.Controls.Add(this.ParaBorderMode);
            this.FLPParam.Controls.Add(this.ParaValue);
            this.FLPParam.Controls.Add(this.ParaMaskValue);
            this.FLPParam.Controls.Add(this.ParaNormalized);
            this.FLPParam.Controls.Add(this.ParaMaskInterpolation);
            this.FLPParam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FLPParam.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.FLPParam.Location = new System.Drawing.Point(0, 24);
            this.FLPParam.Name = "FLPParam";
            this.FLPParam.Size = new System.Drawing.Size(128, 375);
            this.FLPParam.TabIndex = 5;
            // 
            // ParaNumSteps
            // 
            this.ParaNumSteps.ArgumentName = "num_steps";
            this.ParaNumSteps.AutoSize = true;
            this.ParaNumSteps.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ParaNumSteps.ControlLayout = FilterBase.Parts.InputValue.LAYOUT.Horizontal;
            this.ParaNumSteps.DecimalPlace = 0;
            this.ParaNumSteps.Description = "画像の各辺のグリッド セルの数。\r\n値が大きいほど、より細かい歪みが生じます。少なくとも 1 である必要があります。\r\n　　既定値: 5。";
            this.ParaNumSteps.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ParaNumSteps.InvalidValue = "";
            this.ParaNumSteps.Location = new System.Drawing.Point(3, 3);
            this.ParaNumSteps.MaxValue = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.ParaNumSteps.MaxVersion = null;
            this.ParaNumSteps.MinimumSize = new System.Drawing.Size(124, 21);
            this.ParaNumSteps.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ParaNumSteps.MinVersion = null;
            this.ParaNumSteps.Name = "ParaNumSteps";
            this.ParaNumSteps.Required = false;
            this.ParaNumSteps.Size = new System.Drawing.Size(124, 21);
            this.ParaNumSteps.TabIndex = 16;
            this.ParaNumSteps.Title = "グリッドセル数";
            this.ParaNumSteps.Unit = "";
            this.ParaNumSteps.UseValid = false;
            this.ParaNumSteps.Valid = true;
            this.ParaNumSteps.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.ParaNumSteps.ValueType = FilterBase.Parts.InputValue.VALUE_TYPE.INT;
            this.ParaNumSteps.ParameterChange += new FilterBase.Parts.ParameterChangeEventHandler(this.Param_ParameterChange);
            // 
            // ParaDistortLimit
            // 
            this.ParaDistortLimit.ArgumentName = "distort_limit";
            this.ParaDistortLimit.AutoSize = true;
            this.ParaDistortLimit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ParaDistortLimit.DecimalPlace = 1;
            this.ParaDistortLimit.Description = "歪みの範囲。\r\n値が大きいほど歪みが強くなります。\r\n-1 から 1 の範囲にする必要があります。\r\n　　デフォルト: (-0.3, 0.3)。";
            this.ParaDistortLimit.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.ParaDistortLimit.InvalidValue = "";
            this.ParaDistortLimit.Location = new System.Drawing.Point(3, 30);
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
            this.ParaDistortLimit.TabIndex = 17;
            this.ParaDistortLimit.Title = "歪みの範囲";
            this.ParaDistortLimit.UseLargeValue = false;
            this.ParaDistortLimit.UseValid = false;
            this.ParaDistortLimit.Valid = true;
            this.ParaDistortLimit.Value = "(-0.3,0.3)";
            this.ParaDistortLimit.ValueType = FilterBase.Parts.PartsFunc.VALUE_TYPE.TYPE_FLOAT;
            this.ParaDistortLimit.ParameterChange += new FilterBase.Parts.ParameterChangeEventHandler(this.Param_ParameterChange);
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
            this.ParaInterpolation.Location = new System.Drawing.Point(3, 75);
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
            this.ParaBorderMode.Location = new System.Drawing.Point(3, 119);
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
            this.ParaValue.Location = new System.Drawing.Point(3, 163);
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
            this.ParaMaskValue.Location = new System.Drawing.Point(3, 235);
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
            // ParaNormalized
            // 
            this.ParaNormalized.ArgumentName = "normalized";
            this.ParaNormalized.AutoSize = true;
            this.ParaNormalized.CheckedValue = "";
            this.ParaNormalized.Description = "True の場合、歪みによってピクセルが画像の境界外に移動されないようにします。\r\nこれにより、歪みはそれほど大きくならず、情報が失われないことが保証されます。\r" +
    "\n　　　デフォルト: True。";
            this.ParaNormalized.IndeterminateValue = "";
            this.ParaNormalized.Location = new System.Drawing.Point(3, 307);
            this.ParaNormalized.Margin = new System.Windows.Forms.Padding(3, 3, 1, 3);
            this.ParaNormalized.MaxVersion = null;
            this.ParaNormalized.MinimumSize = new System.Drawing.Size(122, 21);
            this.ParaNormalized.MinVersion = null;
            this.ParaNormalized.Name = "ParaNormalized";
            this.ParaNormalized.Size = new System.Drawing.Size(122, 21);
            this.ParaNormalized.TabIndex = 18;
            this.ParaNormalized.Text = "正規化";
            this.ParaNormalized.Title = "正規化";
            this.HelpToolTip.SetToolTip(this.ParaNormalized, "True の場合、歪みによってピクセルが画像の境界外に移動されないようにします。\r\nこれにより、歪みはそれほど大きくならず、情報が失われないことが保証されます。\r" +
        "\n　　　デフォルト: True。");
            this.ParaNormalized.UncheckedValue = "";
            this.ParaNormalized.UseVisualStyleBackColor = true;
            this.ParaNormalized.Value = "";
            this.ParaNormalized.ParameterChange += new FilterBase.Parts.ParameterChangeEventHandler(this.Param_ParameterChange);
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
            this.ParaMaskInterpolation.Location = new System.Drawing.Point(3, 334);
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
            // GridDistortion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.FLPParam);
            this.Name = "GridDistortion";
            this.Size = new System.Drawing.Size(128, 424);
            this.Controls.SetChildIndex(this.FLPParam, 0);
            this.FLPParam.ResumeLayout(false);
            this.FLPParam.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ParaNumSteps)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaDistortLimit)).EndInit();
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
        private FilterBase.Parts.InputValueUpDown ParaNumSteps;
        private FilterBase.Parts.ComboBoxWithLabelParts ParaInterpolation;
        private FilterBase.Parts.ComboBoxWithLabelParts ParaBorderMode;
        private FilterBase.Parts.ColorSelectorParts ParaValue;
        private FilterBase.Parts.ColorSelectorParts ParaMaskValue;
        private FilterBase.Parts.ComboBoxWithLabelParts ParaMaskInterpolation;
        private FilterBase.Parts.InputMaxMin ParaDistortLimit;
        private FilterBase.Parts.CheckBoxParts ParaNormalized;
    }
}
