namespace Filter.Blur
{
    partial class MotionBlur
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
            this.ParaBlurLimit = new FilterBase.Parts.InputKernelSize();
            this.ParaAllowShifted = new FilterBase.Parts.CheckBoxParts();
            this.FLPParam.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ParaBlurLimit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // FLPParam
            // 
            this.FLPParam.AutoSize = true;
            this.FLPParam.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.FLPParam.Controls.Add(this.ParaBlurLimit);
            this.FLPParam.Controls.Add(this.ParaAllowShifted);
            this.FLPParam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FLPParam.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.FLPParam.Location = new System.Drawing.Point(0, 25);
            this.FLPParam.Name = "FLPParam";
            this.FLPParam.Size = new System.Drawing.Size(128, 74);
            this.FLPParam.TabIndex = 5;
            // 
            // ParaBlurLimit
            // 
            this.ParaBlurLimit.ArgumentName = "blur_limit";
            this.ParaBlurLimit.AutoSize = true;
            this.ParaBlurLimit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ParaBlurLimit.DecimalPlace = 0;
            this.ParaBlurLimit.Description = "入力画像をぼかすための最大カーネル サイズ。\r\n範囲は [3, inf) である必要があります。\r\n- 2 つの int のタプルが指定された場合、可能なカーネル" +
    " サイズの包括的な範囲を定義します。\r\n　　デフォルト: (3, 7)";
            this.ParaBlurLimit.FirstMaxIsSecondValue = true;
            this.ParaBlurLimit.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.ParaBlurLimit.Location = new System.Drawing.Point(3, 3);
            this.ParaBlurLimit.MaxValue = "";
            this.ParaBlurLimit.MaxVersion = null;
            this.ParaBlurLimit.MinimumSize = new System.Drawing.Size(124, 21);
            this.ParaBlurLimit.MinValue = "(3,3)";
            this.ParaBlurLimit.MinVersion = null;
            this.ParaBlurLimit.Name = "ParaBlurLimit";
            this.ParaBlurLimit.Required = false;
            this.ParaBlurLimit.Size = new System.Drawing.Size(124, 41);
            this.ParaBlurLimit.TabIndex = 0;
            this.ParaBlurLimit.Title = "カーネルサイズ";
            this.ParaBlurLimit.Value = "(3,7)";
            this.ParaBlurLimit.ValueType = FilterBase.Parts.PartsFunc.VALUE_TYPE.TYPE_INT_ODD;
            this.ParaBlurLimit.ParameterChange += new FilterBase.Parts.ParameterChangeEventHandler(this.Param_ParameterChange);
            // 
            // ParaAllowShifted
            // 
            this.ParaAllowShifted.ArgumentName = "allow_shifted";
            this.ParaAllowShifted.AutoSize = true;
            this.ParaAllowShifted.Checked = true;
            this.ParaAllowShifted.CheckedValue = "";
            this.ParaAllowShifted.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ParaAllowShifted.Description = "";
            this.ParaAllowShifted.IndeterminateValue = "";
            this.ParaAllowShifted.Location = new System.Drawing.Point(3, 50);
            this.ParaAllowShifted.Margin = new System.Windows.Forms.Padding(3, 3, 1, 3);
            this.ParaAllowShifted.MaxVersion = null;
            this.ParaAllowShifted.MinimumSize = new System.Drawing.Size(122, 21);
            this.ParaAllowShifted.MinVersion = null;
            this.ParaAllowShifted.Name = "ParaAllowShifted";
            this.ParaAllowShifted.Size = new System.Drawing.Size(122, 21);
            this.ParaAllowShifted.TabIndex = 1;
            this.ParaAllowShifted.Text = "ランダムシフト";
            this.ParaAllowShifted.Title = "ランダムシフト";
            this.ParaAllowShifted.UncheckedValue = "";
            this.ParaAllowShifted.UseVisualStyleBackColor = true;
            this.ParaAllowShifted.Value = "";
            this.ParaAllowShifted.ParameterChange += new FilterBase.Parts.ParameterChangeEventHandler(this.Param_ParameterChange);
            // 
            // MotionBlur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.FLPParam);
            this.Name = "MotionBlur";
            this.Size = new System.Drawing.Size(128, 124);
            this.Target = FilterBase.BaseFilterControl.TRANSFORM_TARGET.IMAGE;
            this.Controls.SetChildIndex(this.FLPParam, 0);
            this.FLPParam.ResumeLayout(false);
            this.FLPParam.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ParaBlurLimit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel FLPParam;
        private FilterBase.Parts.InputKernelSize ParaBlurLimit;
        private FilterBase.Parts.CheckBoxParts ParaAllowShifted;
    }
}
