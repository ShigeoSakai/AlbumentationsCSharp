namespace Filter.Geometric
{
    partial class Perspective
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Perspective));
            this.FLPParam = new System.Windows.Forms.FlowLayoutPanel();
            this.ParaPadMode = new FilterBase.Parts.ComboBoxWithLabelParts();
            this.ParaValue = new FilterBase.Parts.ColorSelectorParts();
            this.ParaMaskValue = new FilterBase.Parts.ColorSelectorParts();
            this.ParaInterpolation = new FilterBase.Parts.ComboBoxWithLabelParts();
            this.ParaMaskInterpolation = new FilterBase.Parts.ComboBoxWithLabelParts();
            this.ParaScale = new FilterBase.Parts.InputMaxMin();
            this.ParaSizeKeep = new FilterBase.Parts.CheckBoxParts();
            this.ParaFitOutput = new FilterBase.Parts.CheckBoxParts();
            this.FLPParam.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ParaPadMode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaMaskValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaInterpolation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaMaskInterpolation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaScale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // FLPParam
            // 
            this.FLPParam.AutoSize = true;
            this.FLPParam.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.FLPParam.Controls.Add(this.ParaScale);
            this.FLPParam.Controls.Add(this.ParaSizeKeep);
            this.FLPParam.Controls.Add(this.ParaPadMode);
            this.FLPParam.Controls.Add(this.ParaValue);
            this.FLPParam.Controls.Add(this.ParaMaskValue);
            this.FLPParam.Controls.Add(this.ParaFitOutput);
            this.FLPParam.Controls.Add(this.ParaInterpolation);
            this.FLPParam.Controls.Add(this.ParaMaskInterpolation);
            this.FLPParam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FLPParam.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.FLPParam.Location = new System.Drawing.Point(0, 25);
            this.FLPParam.Name = "FLPParam";
            this.FLPParam.Size = new System.Drawing.Size(128, 339);
            this.FLPParam.TabIndex = 5;
            // 
            // ParaPadMode
            // 
            this.ParaPadMode.ArgumentName = "pad_mode";
            this.ParaPadMode.AutoSize = true;
            this.ParaPadMode.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ParaPadMode.DefaultValue = "CONSTANT";
            this.ParaPadMode.Description = "ピクセル外挿方法を指定するために使用されるフラグ。次のいずれかになります:\r\ncv2.BORDER_CONSTANT、cv2.BORDER_REPLICATE、c" +
    "v2.BORDER_REFLECT、cv2.BORDER_WRAP、cv2.BORDER_REFLECT_101。\r\nデフォルト: cv2.BORDER_REF" +
    "LECT_101";
            this.ParaPadMode.ItemType = "BorderTypes";
            this.ParaPadMode.Location = new System.Drawing.Point(3, 75);
            this.ParaPadMode.MaxVersion = null;
            this.ParaPadMode.MinimumSize = new System.Drawing.Size(124, 21);
            this.ParaPadMode.MinVersion = null;
            this.ParaPadMode.Name = "ParaPadMode";
            this.ParaPadMode.Required = false;
            this.ParaPadMode.Size = new System.Drawing.Size(124, 38);
            this.ParaPadMode.TabIndex = 16;
            this.ParaPadMode.Title = "ピクセル外挿方法";
            this.ParaPadMode.Value = null;
            this.ParaPadMode.SelectedIndexChanged += new FilterBase.Parts.ComboBoxWithLabelParts.ComboBoxSelectEventHandler(this.ParaBorderMode_SelectedIndexChanged);
            this.ParaPadMode.ParameterChange += new FilterBase.Parts.ParameterChangeEventHandler(this.Param_ParameterChange);
            // 
            // ParaValue
            // 
            this.ParaValue.ArgumentName = "pad_val";
            this.ParaValue.AutoSize = true;
            this.ParaValue.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ParaValue.Color = System.Drawing.Color.Black;
            this.ParaValue.Description = "border_mode が cv2.BORDER_CONSTANT の場合のパディング値。";
            this.ParaValue.IsColor = true;
            this.ParaValue.Location = new System.Drawing.Point(3, 119);
            this.ParaValue.MaxVersion = null;
            this.ParaValue.MinimumSize = new System.Drawing.Size(124, 21);
            this.ParaValue.MinVersion = null;
            this.ParaValue.Name = "ParaValue";
            this.ParaValue.Required = false;
            this.ParaValue.Size = new System.Drawing.Size(124, 48);
            this.ParaValue.TabIndex = 17;
            this.ParaValue.Title = "パディング色";
            this.ParaValue.ParameterChange += new FilterBase.Parts.ParameterChangeEventHandler(this.Param_ParameterChange);
            // 
            // ParaMaskValue
            // 
            this.ParaMaskValue.ArgumentName = "mask_pad_val";
            this.ParaMaskValue.AutoSize = true;
            this.ParaMaskValue.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ParaMaskValue.Color = System.Drawing.Color.Black;
            this.ParaMaskValue.Description = "border_mode が cv2.BORDER_CONSTANT の場合のパディング値がマスクに適用されます。";
            this.ParaMaskValue.IsColor = true;
            this.ParaMaskValue.Location = new System.Drawing.Point(3, 173);
            this.ParaMaskValue.MaxVersion = null;
            this.ParaMaskValue.MinimumSize = new System.Drawing.Size(124, 21);
            this.ParaMaskValue.MinVersion = null;
            this.ParaMaskValue.Name = "ParaMaskValue";
            this.ParaMaskValue.Required = false;
            this.ParaMaskValue.Size = new System.Drawing.Size(124, 48);
            this.ParaMaskValue.TabIndex = 18;
            this.ParaMaskValue.Title = "Maskパディング色";
            this.ParaMaskValue.ParameterChange += new FilterBase.Parts.ParameterChangeEventHandler(this.Param_ParameterChange);
            // 
            // ParaInterpolation
            // 
            this.ParaInterpolation.ArgumentName = "interpolation";
            this.ParaInterpolation.AutoSize = true;
            this.ParaInterpolation.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ParaInterpolation.DefaultValue = "LINEAR";
            this.ParaInterpolation.Description = "画像変換に使用する補間方法。\r\nOpenCV 補間タイプの 1 つである必要があります。\r\nデフォルト: cv2.INTER_LINEAR";
            this.ParaInterpolation.ItemType = "InterpolationFlags";
            this.ParaInterpolation.Location = new System.Drawing.Point(3, 254);
            this.ParaInterpolation.MaxVersion = null;
            this.ParaInterpolation.MinimumSize = new System.Drawing.Size(124, 21);
            this.ParaInterpolation.MinVersion = null;
            this.ParaInterpolation.Name = "ParaInterpolation";
            this.ParaInterpolation.Required = false;
            this.ParaInterpolation.Size = new System.Drawing.Size(124, 38);
            this.ParaInterpolation.TabIndex = 19;
            this.ParaInterpolation.Title = "補間方法";
            this.ParaInterpolation.Value = null;
            this.ParaInterpolation.ParameterChange += new FilterBase.Parts.ParameterChangeEventHandler(this.Param_ParameterChange);
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
            this.ParaMaskInterpolation.Location = new System.Drawing.Point(3, 298);
            this.ParaMaskInterpolation.MaxVersion = null;
            this.ParaMaskInterpolation.MinimumSize = new System.Drawing.Size(124, 21);
            this.ParaMaskInterpolation.MinVersion = null;
            this.ParaMaskInterpolation.Name = "ParaMaskInterpolation";
            this.ParaMaskInterpolation.Required = false;
            this.ParaMaskInterpolation.Size = new System.Drawing.Size(124, 38);
            this.ParaMaskInterpolation.TabIndex = 20;
            this.ParaMaskInterpolation.Title = "マスク補間方法";
            this.ParaMaskInterpolation.Value = null;
            this.ParaMaskInterpolation.ParameterChange += new FilterBase.Parts.ParameterChangeEventHandler(this.Param_ParameterChange);
            // 
            // ParaScale
            // 
            this.ParaScale.ArgumentName = "scale";
            this.ParaScale.AutoSize = true;
            this.ParaScale.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ParaScale.DecimalPlace = 2;
            this.ParaScale.Description = "正規分布の標準偏差。\r\nこれらは、サブイメージのコーナーからフルイメージのコーナーまでのランダムな距離をサンプリングするために使用されます。\r\n　　デフォルト: " +
    "(0.05, 0.1)。";
            this.ParaScale.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.ParaScale.InvalidValue = "";
            this.ParaScale.Location = new System.Drawing.Point(3, 3);
            this.ParaScale.MaxValue = null;
            this.ParaScale.MaxVersion = null;
            this.ParaScale.MinimumSize = new System.Drawing.Size(124, 21);
            this.ParaScale.MinValue = null;
            this.ParaScale.MinVersion = null;
            this.ParaScale.Name = "ParaScale";
            this.ParaScale.Required = false;
            this.ParaScale.Size = new System.Drawing.Size(124, 39);
            this.ParaScale.TabIndex = 21;
            this.ParaScale.Title = "スケール";
            this.ParaScale.UseLargeValue = false;
            this.ParaScale.UseValid = false;
            this.ParaScale.Value = "(0.05,0.10)";
            this.ParaScale.ValueType = FilterBase.Parts.PartsFunc.VALUE_TYPE.TYPE_FLOAT;
            this.ParaScale.ParameterChange += new FilterBase.Parts.ParameterChangeEventHandler(this.Param_ParameterChange);
            // 
            // ParaSizeKeep
            // 
            this.ParaSizeKeep.ArgumentName = "keep_size";
            this.ParaSizeKeep.AutoSize = true;
            this.ParaSizeKeep.Checked = true;
            this.ParaSizeKeep.CheckedValue = "";
            this.ParaSizeKeep.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ParaSizeKeep.Description = "パースペクティブ変換を適用した後、画像を元のサイズに戻すかどうか。\r\nFalse に設定すると、結果の画像の形状が異なる場合があります。\r\n　　デフォルト: Tr" +
    "ue。";
            this.ParaSizeKeep.IndeterminateValue = "";
            this.ParaSizeKeep.Location = new System.Drawing.Point(3, 48);
            this.ParaSizeKeep.Margin = new System.Windows.Forms.Padding(3, 3, 1, 3);
            this.ParaSizeKeep.MaxVersion = null;
            this.ParaSizeKeep.MinimumSize = new System.Drawing.Size(122, 21);
            this.ParaSizeKeep.MinVersion = null;
            this.ParaSizeKeep.Name = "ParaSizeKeep";
            this.ParaSizeKeep.Size = new System.Drawing.Size(122, 21);
            this.ParaSizeKeep.TabIndex = 22;
            this.ParaSizeKeep.Text = "サイズそのまま";
            this.ParaSizeKeep.Title = "サイズそのまま";
            this.ParaSizeKeep.UncheckedValue = "";
            this.ParaSizeKeep.UseVisualStyleBackColor = true;
            this.ParaSizeKeep.Value = "Checked";
            this.ParaSizeKeep.ParameterChange += new FilterBase.Parts.ParameterChangeEventHandler(this.Param_ParameterChange);
            // 
            // ParaFitOutput
            // 
            this.ParaFitOutput.ArgumentName = "fit_output";
            this.ParaFitOutput.AutoSize = true;
            this.ParaFitOutput.CheckedValue = "";
            this.ParaFitOutput.Description = resources.GetString("ParaFitOutput.Description");
            this.ParaFitOutput.IndeterminateValue = "";
            this.ParaFitOutput.Location = new System.Drawing.Point(3, 227);
            this.ParaFitOutput.Margin = new System.Windows.Forms.Padding(3, 3, 1, 3);
            this.ParaFitOutput.MaxVersion = null;
            this.ParaFitOutput.MinimumSize = new System.Drawing.Size(122, 21);
            this.ParaFitOutput.MinVersion = null;
            this.ParaFitOutput.Name = "ParaFitOutput";
            this.ParaFitOutput.Size = new System.Drawing.Size(122, 21);
            this.ParaFitOutput.TabIndex = 23;
            this.ParaFitOutput.Text = "出力サイズ調整";
            this.ParaFitOutput.Title = "出力サイズ調整";
            this.ParaFitOutput.UncheckedValue = "";
            this.ParaFitOutput.UseVisualStyleBackColor = true;
            this.ParaFitOutput.Value = "Unchecked";
            this.ParaFitOutput.ParameterChange += new FilterBase.Parts.ParameterChangeEventHandler(this.Param_ParameterChange);
            // 
            // Perspective
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.FLPParam);
            this.Name = "Perspective";
            this.Size = new System.Drawing.Size(128, 389);
            this.Controls.SetChildIndex(this.FLPParam, 0);
            this.FLPParam.ResumeLayout(false);
            this.FLPParam.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ParaPadMode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaMaskValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaInterpolation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaMaskInterpolation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaScale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel FLPParam;
        private FilterBase.Parts.ComboBoxWithLabelParts ParaPadMode;
        private FilterBase.Parts.ColorSelectorParts ParaValue;
        private FilterBase.Parts.ColorSelectorParts ParaMaskValue;
        private FilterBase.Parts.ComboBoxWithLabelParts ParaInterpolation;
        private FilterBase.Parts.ComboBoxWithLabelParts ParaMaskInterpolation;
        private FilterBase.Parts.InputMaxMin ParaScale;
        private FilterBase.Parts.CheckBoxParts ParaSizeKeep;
        private FilterBase.Parts.CheckBoxParts ParaFitOutput;
    }
}
