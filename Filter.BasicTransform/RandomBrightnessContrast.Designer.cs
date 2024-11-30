namespace Filter.BasicTransform
{
    partial class RandomBrightnessContrast
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
            this.ParaBrightnessLimit = new FilterBase.Parts.InputMaxMin();
            this.ParaContrastLimit = new FilterBase.Parts.InputMaxMin();
            this.ParaBrightnessByMax = new FilterBase.Parts.CheckBoxParts();
            this.FLPParam.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ParaBrightnessLimit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaContrastLimit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // FLPParam
            // 
            this.FLPParam.AutoSize = true;
            this.FLPParam.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.FLPParam.Controls.Add(this.ParaBrightnessLimit);
            this.FLPParam.Controls.Add(this.ParaContrastLimit);
            this.FLPParam.Controls.Add(this.ParaBrightnessByMax);
            this.FLPParam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FLPParam.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.FLPParam.Location = new System.Drawing.Point(0, 25);
            this.FLPParam.Name = "FLPParam";
            this.FLPParam.Size = new System.Drawing.Size(128, 123);
            this.FLPParam.TabIndex = 5;
            // 
            // ParaBrightnessLimit
            // 
            this.ParaBrightnessLimit.ArgumentName = "brightness_limit";
            this.ParaBrightnessLimit.AutoSize = true;
            this.ParaBrightnessLimit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ParaBrightnessLimit.DecimalPlace = 1;
            this.ParaBrightnessLimit.Description = "明るさを変更するための係数範囲。\r\n値は通常 [-1.0, 1.0] の範囲で、\r\n　0 は変更なし、\r\n　1.0 は最大明るさ、-\r\n　1.0 は最小明るさを意" +
    "味します。\r\n　　デフォルト: (-0.2, 0.2)。";
            this.ParaBrightnessLimit.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.ParaBrightnessLimit.Location = new System.Drawing.Point(3, 3);
            this.ParaBrightnessLimit.MaxValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ParaBrightnessLimit.MaxVersion = null;
            this.ParaBrightnessLimit.MinimumSize = new System.Drawing.Size(124, 21);
            this.ParaBrightnessLimit.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.ParaBrightnessLimit.MinVersion = null;
            this.ParaBrightnessLimit.Name = "ParaBrightnessLimit";
            this.ParaBrightnessLimit.Required = false;
            this.ParaBrightnessLimit.Size = new System.Drawing.Size(124, 42);
            this.ParaBrightnessLimit.TabIndex = 0;
            this.ParaBrightnessLimit.Title = "明るさ係数範囲";
            this.ParaBrightnessLimit.Value = "(-0.2,0.2)";
            this.ParaBrightnessLimit.ValueType = FilterBase.Parts.PartsFunc.VALUE_TYPE.TYPE_FLOAT;
            this.ParaBrightnessLimit.ParameterChange += new FilterBase.Parts.ParameterChangeEventHandler(this.Param_ParameterChange);
            // 
            // ParaContrastLimit
            // 
            this.ParaContrastLimit.ArgumentName = "contrast_limit";
            this.ParaContrastLimit.AutoSize = true;
            this.ParaContrastLimit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ParaContrastLimit.DecimalPlace = 1;
            this.ParaContrastLimit.Description = "コントラストを変更するための係数範囲。\r\n値は通常、[-1.0, 1.0] の範囲で、\r\n　0 は変更なし、\r\n　1.0 はコントラストの最大増加、\r\n　-1.0" +
    " はコントラストの最大減少を意味します。\r\n　　　デフォルト: (-0.2, 0.2)。";
            this.ParaContrastLimit.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.ParaContrastLimit.Location = new System.Drawing.Point(3, 51);
            this.ParaContrastLimit.MaxValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ParaContrastLimit.MaxVersion = null;
            this.ParaContrastLimit.MinimumSize = new System.Drawing.Size(124, 21);
            this.ParaContrastLimit.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.ParaContrastLimit.MinVersion = null;
            this.ParaContrastLimit.Name = "ParaContrastLimit";
            this.ParaContrastLimit.Required = false;
            this.ParaContrastLimit.Size = new System.Drawing.Size(124, 42);
            this.ParaContrastLimit.TabIndex = 1;
            this.ParaContrastLimit.Title = "コントラスト係数範囲";
            this.ParaContrastLimit.Value = "(-0.2,0.2)";
            this.ParaContrastLimit.ValueType = FilterBase.Parts.PartsFunc.VALUE_TYPE.TYPE_FLOAT;
            this.ParaContrastLimit.ParameterChange += new FilterBase.Parts.ParameterChangeEventHandler(this.Param_ParameterChange);
            // 
            // ParaBrightnessByMax
            // 
            this.ParaBrightnessByMax.ArgumentName = "brightness_by_max";
            this.ParaBrightnessByMax.AutoSize = true;
            this.ParaBrightnessByMax.CheckedValue = "";
            this.ParaBrightnessByMax.Description = "True の場合、ピクセル値を画像の dtype の最大値まで拡大して明るさを調整します。\r\nFalse の場合、調整には平均ピクセル値を使用します。\r\n　　デフ" +
    "ォルト: True。";
            this.ParaBrightnessByMax.IndeterminateValue = "";
            this.ParaBrightnessByMax.Location = new System.Drawing.Point(3, 99);
            this.ParaBrightnessByMax.Margin = new System.Windows.Forms.Padding(3, 3, 1, 3);
            this.ParaBrightnessByMax.MaxVersion = null;
            this.ParaBrightnessByMax.MinimumSize = new System.Drawing.Size(122, 21);
            this.ParaBrightnessByMax.MinVersion = null;
            this.ParaBrightnessByMax.Name = "ParaBrightnessByMax";
            this.ParaBrightnessByMax.Size = new System.Drawing.Size(122, 21);
            this.ParaBrightnessByMax.TabIndex = 2;
            this.ParaBrightnessByMax.Text = "明るさ拡大";
            this.ParaBrightnessByMax.Title = "明るさ拡大";
            this.HelpToolTip.SetToolTip(this.ParaBrightnessByMax, "True の場合、ピクセル値を画像の dtype の最大値まで拡大して明るさを調整します。\r\nFalse の場合、調整には平均ピクセル値を使用します。\r\n　　デフ" +
        "ォルト: True。");
            this.ParaBrightnessByMax.UncheckedValue = "";
            this.ParaBrightnessByMax.UseVisualStyleBackColor = true;
            this.ParaBrightnessByMax.Value = "";
            this.ParaBrightnessByMax.ParameterChange += new FilterBase.Parts.ParameterChangeEventHandler(this.Param_ParameterChange);
            // 
            // RandomBrightnessContrast
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.FLPParam);
            this.Name = "RandomBrightnessContrast";
            this.Size = new System.Drawing.Size(128, 173);
            this.Target = FilterBase.BaseFilterControl.TRANSFORM_TARGET.IMAGE;
            this.Controls.SetChildIndex(this.FLPParam, 0);
            this.FLPParam.ResumeLayout(false);
            this.FLPParam.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ParaBrightnessLimit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaContrastLimit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel FLPParam;
        private FilterBase.Parts.InputMaxMin ParaBrightnessLimit;
        private FilterBase.Parts.InputMaxMin ParaContrastLimit;
        private FilterBase.Parts.CheckBoxParts ParaBrightnessByMax;
    }
}
