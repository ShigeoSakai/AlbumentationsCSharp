namespace Filter.BasicTransform
{
    partial class UnsharpMask
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
            this.ParaSigmaLimit = new FilterBase.Parts.InputMaxMin();
            this.ParaAlpha = new FilterBase.Parts.InputMaxMin();
            this.ParaThreshold = new FilterBase.Parts.InputValueUpDown();
            this.FLPParam.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ParaBlurLimit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaSigmaLimit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaAlpha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaThreshold)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // FLPParam
            // 
            this.FLPParam.AutoSize = true;
            this.FLPParam.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.FLPParam.Controls.Add(this.ParaBlurLimit);
            this.FLPParam.Controls.Add(this.ParaSigmaLimit);
            this.FLPParam.Controls.Add(this.ParaAlpha);
            this.FLPParam.Controls.Add(this.ParaThreshold);
            this.FLPParam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FLPParam.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.FLPParam.Location = new System.Drawing.Point(0, 25);
            this.FLPParam.Name = "FLPParam";
            this.FLPParam.Size = new System.Drawing.Size(128, 170);
            this.FLPParam.TabIndex = 5;
            // 
            // ParaBlurLimit
            // 
            this.ParaBlurLimit.ArgumentName = "blur_limit";
            this.ParaBlurLimit.AutoSize = true;
            this.ParaBlurLimit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ParaBlurLimit.DecimalPlace = 0;
            this.ParaBlurLimit.Description = "入力画像をぼかすための最大ガウスカーネルサイズ。\r\n0 または奇数で、範囲は [0, inf) である必要があります。\r\n0 に設定すると、シグマから `roun" +
    "d(sigma * (3 if img.dtype == np.uint8 else 4) * 2 + 1) + 1` として計算されます。\r\n　　デフォルト:" +
    " (3, 7)。";
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
            // ParaSigmaLimit
            // 
            this.ParaSigmaLimit.ArgumentName = "sigma_limit";
            this.ParaSigmaLimit.AutoSize = true;
            this.ParaSigmaLimit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ParaSigmaLimit.DecimalPlace = 1;
            this.ParaSigmaLimit.Description = "";
            this.ParaSigmaLimit.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.ParaSigmaLimit.Location = new System.Drawing.Point(3, 50);
            this.ParaSigmaLimit.MaxValue = null;
            this.ParaSigmaLimit.MaxVersion = null;
            this.ParaSigmaLimit.MinimumSize = new System.Drawing.Size(124, 21);
            this.ParaSigmaLimit.MinValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.ParaSigmaLimit.MinVersion = null;
            this.ParaSigmaLimit.Name = "ParaSigmaLimit";
            this.ParaSigmaLimit.Required = false;
            this.ParaSigmaLimit.Size = new System.Drawing.Size(124, 42);
            this.ParaSigmaLimit.TabIndex = 1;
            this.ParaSigmaLimit.Title = "Σリミット";
            this.ParaSigmaLimit.Value = "(0.0,0.0)";
            this.ParaSigmaLimit.ValueType = FilterBase.Parts.PartsFunc.VALUE_TYPE.TYPE_FLOAT;
            this.ParaSigmaLimit.ParameterChange += new FilterBase.Parts.ParameterChangeEventHandler(this.Param_ParameterChange);
            // 
            // ParaAlpha
            // 
            this.ParaAlpha.ArgumentName = "alpha";
            this.ParaAlpha.AutoSize = true;
            this.ParaAlpha.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ParaAlpha.DecimalPlace = 1;
            this.ParaAlpha.Description = "シャープ化された画像の可視性を選択する範囲。\r\n0 では元の画像のみが表示され、\r\n1.0 ではシャープ化された画像のみが表示されます。\r\n　　デフォルト: (0" +
    ".2、0.5)。";
            this.ParaAlpha.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ParaAlpha.Location = new System.Drawing.Point(3, 98);
            this.ParaAlpha.MaxValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ParaAlpha.MaxVersion = null;
            this.ParaAlpha.MinimumSize = new System.Drawing.Size(124, 21);
            this.ParaAlpha.MinValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.ParaAlpha.MinVersion = null;
            this.ParaAlpha.Name = "ParaAlpha";
            this.ParaAlpha.Required = false;
            this.ParaAlpha.Size = new System.Drawing.Size(124, 42);
            this.ParaAlpha.TabIndex = 2;
            this.ParaAlpha.Title = "α";
            this.ParaAlpha.Value = "(0.1,0.5)";
            this.ParaAlpha.ValueType = FilterBase.Parts.PartsFunc.VALUE_TYPE.TYPE_FLOAT;
            this.ParaAlpha.ParameterChange += new FilterBase.Parts.ParameterChangeEventHandler(this.Param_ParameterChange);
            // 
            // ParaThreshold
            // 
            this.ParaThreshold.ArgumentName = "threshold";
            this.ParaThreshold.AutoSize = true;
            this.ParaThreshold.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ParaThreshold.ControlLayout = FilterBase.Parts.InputValue.LAYOUT.Horizontal;
            this.ParaThreshold.DecimalPlace = 0;
            this.ParaThreshold.Description = "元の画像とスムージングされた画像の間のピクセル差が大きい領域のみにシャープニングを制限する値。\r\nしきい値が高いほど、平坦な領域でのシャープニングが少なくなります" +
    "。\r\n範囲は [0, 255] である必要があります。\r\n　　　デフォルト: 10。";
            this.ParaThreshold.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ParaThreshold.Location = new System.Drawing.Point(3, 146);
            this.ParaThreshold.MaxValue = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.ParaThreshold.MaxVersion = null;
            this.ParaThreshold.MinimumSize = new System.Drawing.Size(124, 21);
            this.ParaThreshold.MinValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.ParaThreshold.MinVersion = null;
            this.ParaThreshold.Name = "ParaThreshold";
            this.ParaThreshold.Required = false;
            this.ParaThreshold.Size = new System.Drawing.Size(124, 21);
            this.ParaThreshold.TabIndex = 3;
            this.ParaThreshold.Title = "閾値";
            this.ParaThreshold.Unit = "";
            this.ParaThreshold.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.ParaThreshold.ValueType = FilterBase.Parts.InputValue.VALUE_TYPE.INT;
            this.ParaThreshold.ParameterChange += new FilterBase.Parts.ParameterChangeEventHandler(this.Param_ParameterChange);
            // 
            // UnsharpMask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.FLPParam);
            this.Name = "UnsharpMask";
            this.Size = new System.Drawing.Size(128, 220);
            this.Target = FilterBase.BaseFilterControl.TRANSFORM_TARGET.IMAGE;
            this.Controls.SetChildIndex(this.FLPParam, 0);
            this.FLPParam.ResumeLayout(false);
            this.FLPParam.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ParaBlurLimit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaSigmaLimit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaAlpha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaThreshold)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel FLPParam;
        private FilterBase.Parts.InputKernelSize ParaBlurLimit;
        private FilterBase.Parts.InputMaxMin ParaSigmaLimit;
        private FilterBase.Parts.InputMaxMin ParaAlpha;
        private FilterBase.Parts.InputValueUpDown ParaThreshold;
    }
}
