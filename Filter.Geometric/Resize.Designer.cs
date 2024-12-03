namespace Filter.Geometric
{
    public partial class Resize
    {
        #region コンポーネント デザイナーで生成されたコード

        /// <summary> 
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を 
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.FLPParam = new System.Windows.Forms.FlowLayoutPanel();
            this.ParaWidth = new FilterBase.Parts.InputValue();
            this.ParaHeight = new FilterBase.Parts.InputValue();
            this.ParaInterpolation = new FilterBase.Parts.ComboBoxWithLabelParts();
            this.ParaMaskInterpolation = new FilterBase.Parts.ComboBoxWithLabelParts();
            this.FLPParam.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ParaWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaInterpolation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaMaskInterpolation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // FLPParam
            // 
            this.FLPParam.AutoSize = true;
            this.FLPParam.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.FLPParam.Controls.Add(this.ParaWidth);
            this.FLPParam.Controls.Add(this.ParaHeight);
            this.FLPParam.Controls.Add(this.ParaInterpolation);
            this.FLPParam.Controls.Add(this.ParaMaskInterpolation);
            this.FLPParam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FLPParam.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.FLPParam.Location = new System.Drawing.Point(0, 25);
            this.FLPParam.Name = "FLPParam";
            this.FLPParam.Size = new System.Drawing.Size(128, 142);
            this.FLPParam.TabIndex = 13;
            // 
            // ParaWidth
            // 
            this.ParaWidth.ArgumentName = "width";
            this.ParaWidth.AutoSize = true;
            this.ParaWidth.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ParaWidth.ControlLayout = FilterBase.Parts.InputValue.LAYOUT.Horizontal;
            this.ParaWidth.DecimalPlace = 0;
            this.ParaWidth.Description = "出力の希望する幅。";
            this.ParaWidth.InvalidValue = "";
            this.ParaWidth.Location = new System.Drawing.Point(3, 3);
            this.ParaWidth.MaxValue = null;
            this.ParaWidth.MaxVersion = null;
            this.ParaWidth.MinimumSize = new System.Drawing.Size(124, 21);
            this.ParaWidth.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ParaWidth.MinVersion = null;
            this.ParaWidth.Name = "ParaWidth";
            this.ParaWidth.Required = true;
            this.ParaWidth.Size = new System.Drawing.Size(124, 21);
            this.ParaWidth.TabIndex = 0;
            this.ParaWidth.Title = "　幅";
            this.ParaWidth.Unit = "";
            this.ParaWidth.UseValid = false;
            this.ParaWidth.Value = new decimal(new int[] {
            512,
            0,
            0,
            0});
            this.ParaWidth.ValueType = FilterBase.Parts.InputValue.VALUE_TYPE.INT;
            this.ParaWidth.ParameterChange += new FilterBase.Parts.ParameterChangeEventHandler(this.ParameterChange_Event);
            // 
            // ParaHeight
            // 
            this.ParaHeight.ArgumentName = "height";
            this.ParaHeight.AutoSize = true;
            this.ParaHeight.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ParaHeight.ControlLayout = FilterBase.Parts.InputValue.LAYOUT.Horizontal;
            this.ParaHeight.DecimalPlace = 0;
            this.ParaHeight.Description = "出力の希望の高さ。";
            this.ParaHeight.InvalidValue = "";
            this.ParaHeight.Location = new System.Drawing.Point(3, 30);
            this.ParaHeight.MaxValue = null;
            this.ParaHeight.MaxVersion = null;
            this.ParaHeight.MinimumSize = new System.Drawing.Size(124, 21);
            this.ParaHeight.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ParaHeight.MinVersion = null;
            this.ParaHeight.Name = "ParaHeight";
            this.ParaHeight.Required = true;
            this.ParaHeight.Size = new System.Drawing.Size(124, 21);
            this.ParaHeight.TabIndex = 1;
            this.ParaHeight.Title = "高さ";
            this.ParaHeight.Unit = "";
            this.ParaHeight.UseValid = false;
            this.ParaHeight.Value = new decimal(new int[] {
            512,
            0,
            0,
            0});
            this.ParaHeight.ValueType = FilterBase.Parts.InputValue.VALUE_TYPE.INT;
            this.ParaHeight.ParameterChange += new FilterBase.Parts.ParameterChangeEventHandler(this.ParameterChange_Event);
            // 
            // ParaInterpolation
            // 
            this.ParaInterpolation.ArgumentName = "interpolation";
            this.ParaInterpolation.AutoSize = true;
            this.ParaInterpolation.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ParaInterpolation.DefaultValue = "LINEAR";
            this.ParaInterpolation.Description = "補間アルゴリズムを指定するために使用されるフラグ。次のいずれかになります。\r\ncv2.INTER_NEAREST、cv2.INTER_LINEAR、cv2.INT" +
    "ER_CUBIC、cv2.INTER_AREA、cv2.INTER_LANCZOS4。\r\n            デフォルト: cv2.INTER_LINEAR" +
    "。\r\n";
            this.ParaInterpolation.InvalidValue = "";
            this.ParaInterpolation.ItemType = "InterpolationFlags";
            this.ParaInterpolation.Location = new System.Drawing.Point(1, 57);
            this.ParaInterpolation.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.ParaInterpolation.MaxVersion = null;
            this.ParaInterpolation.MinimumSize = new System.Drawing.Size(124, 21);
            this.ParaInterpolation.MinVersion = null;
            this.ParaInterpolation.Name = "ParaInterpolation";
            this.ParaInterpolation.Required = false;
            this.ParaInterpolation.Size = new System.Drawing.Size(124, 38);
            this.ParaInterpolation.TabIndex = 2;
            this.ParaInterpolation.Title = "補完方法";
            this.ParaInterpolation.UseValid = false;
            this.ParaInterpolation.Value = null;
            this.ParaInterpolation.ParameterChange += new FilterBase.Parts.ParameterChangeEventHandler(this.ParameterChange_Event);
            // 
            // ParaMaskInterpolation
            // 
            this.ParaMaskInterpolation.ArgumentName = "mask_interpolation";
            this.ParaMaskInterpolation.AutoSize = true;
            this.ParaMaskInterpolation.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ParaMaskInterpolation.DefaultValue = "NEAREST";
            this.ParaMaskInterpolation.Description = "マスクの補間アルゴリズムを指定するために使用されるフラグ。\r\n次のいずれかである必要があります: cv2.INTER_NEAREST、cv2.INTER_LINE" +
    "AR、cv2.INTER_CUBIC、cv2.INTER_AREA、cv2.INTER_LANCZOS4。\r\n            デフォルト: cv2.IN" +
    "TER_NEAREST。\r\n";
            this.ParaMaskInterpolation.InvalidValue = "";
            this.ParaMaskInterpolation.ItemType = "InterpolationFlags";
            this.ParaMaskInterpolation.Location = new System.Drawing.Point(1, 101);
            this.ParaMaskInterpolation.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.ParaMaskInterpolation.MaxVersion = null;
            this.ParaMaskInterpolation.MinimumSize = new System.Drawing.Size(124, 21);
            this.ParaMaskInterpolation.MinVersion = "1.4.19";
            this.ParaMaskInterpolation.Name = "ParaMaskInterpolation";
            this.ParaMaskInterpolation.Required = false;
            this.ParaMaskInterpolation.Size = new System.Drawing.Size(124, 38);
            this.ParaMaskInterpolation.TabIndex = 3;
            this.ParaMaskInterpolation.Title = "マスク補完方法";
            this.ParaMaskInterpolation.UseValid = false;
            this.ParaMaskInterpolation.Value = null;
            this.ParaMaskInterpolation.ParameterChange += new FilterBase.Parts.ParameterChangeEventHandler(this.ParameterChange_Event);
            // 
            // Resize
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.FLPParam);
            this.MinimumSize = new System.Drawing.Size(128, 128);
            this.Name = "Resize";
            this.Size = new System.Drawing.Size(128, 192);
            this.Controls.SetChildIndex(this.FLPParam, 0);
            this.FLPParam.ResumeLayout(false);
            this.FLPParam.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ParaWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaInterpolation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaMaskInterpolation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private System.Windows.Forms.FlowLayoutPanel FLPParam;
        private FilterBase.Parts.InputValue ParaWidth;
        private FilterBase.Parts.InputValue ParaHeight;
        private FilterBase.Parts.ComboBoxWithLabelParts ParaInterpolation;
        private FilterBase.Parts.ComboBoxWithLabelParts ParaMaskInterpolation;
    }
}
