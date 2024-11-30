namespace Filter.Blur
{
    partial class GaussianBlur
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GaussianBlur));
            this.FLPParam = new System.Windows.Forms.FlowLayoutPanel();
            this.ParaBlurLimit = new FilterBase.Parts.InputKernelSize();
            this.ParaSigmaLlimit = new FilterBase.Parts.InputMaxMin();
            this.FLPParam.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ParaBlurLimit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaSigmaLlimit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // FLPParam
            // 
            this.FLPParam.AutoSize = true;
            this.FLPParam.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.FLPParam.Controls.Add(this.ParaBlurLimit);
            this.FLPParam.Controls.Add(this.ParaSigmaLlimit);
            this.FLPParam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FLPParam.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.FLPParam.Location = new System.Drawing.Point(0, 25);
            this.FLPParam.Name = "FLPParam";
            this.FLPParam.Size = new System.Drawing.Size(128, 94);
            this.FLPParam.TabIndex = 5;
            // 
            // ParaBlurLimit
            // 
            this.ParaBlurLimit.ArgumentName = "blur_limit";
            this.ParaBlurLimit.AutoSize = true;
            this.ParaBlurLimit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ParaBlurLimit.DecimalPlace = 0;
            this.ParaBlurLimit.Description = resources.GetString("ParaBlurLimit.Description");
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
            this.ParaBlurLimit.Title = "ガウスカーネル";
            this.ParaBlurLimit.Value = "(3,7)";
            this.ParaBlurLimit.ValueType = FilterBase.Parts.PartsFunc.VALUE_TYPE.TYPE_INT_ODD;
            this.ParaBlurLimit.ParameterChange += new FilterBase.Parts.ParameterChangeEventHandler(this.ParaKernel_ParameterChange);
            // 
            // ParaSigmaLlimit
            // 
            this.ParaSigmaLlimit.ArgumentName = "sigma_limit";
            this.ParaSigmaLlimit.AutoSize = true;
            this.ParaSigmaLlimit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ParaSigmaLlimit.DecimalPlace = 1;
            this.ParaSigmaLlimit.Description = "ガウスカーネル標準偏差 (シグマ) の範囲。範囲は [0, inf) である必要があります。\r\n- 2 つの浮動小数点数のタプルを指定した場合、シグマ値の可能な範" +
    "囲を定義します。\r\n0 に設定した場合、シグマは `sigma = 0.3*((ksize-1)*0.5 - 1) + 0.8` として計算されます。\r\nシグマ" +
    "値が大きいほど、ぼかし効果が強くなります。\r\n　　　デフォルト: 0";
            this.ParaSigmaLlimit.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.ParaSigmaLlimit.Location = new System.Drawing.Point(3, 50);
            this.ParaSigmaLlimit.MaxVersion = null;
            this.ParaSigmaLlimit.MinimumSize = new System.Drawing.Size(124, 21);
            this.ParaSigmaLlimit.MinVersion = null;
            this.ParaSigmaLlimit.Name = "ParaSigmaLlimit";
            this.ParaSigmaLlimit.Required = false;
            this.ParaSigmaLlimit.Size = new System.Drawing.Size(124, 41);
            this.ParaSigmaLlimit.TabIndex = 1;
            this.ParaSigmaLlimit.Title = "カーネル標準範囲";
            this.ParaSigmaLlimit.Value = "(0,0)";
            this.ParaSigmaLlimit.ValueType = FilterBase.Parts.PartsFunc.VALUE_TYPE.TYPE_FLOAT;
            this.ParaSigmaLlimit.ParameterChange += new FilterBase.Parts.ParameterChangeEventHandler(this.ParaKernel_ParameterChange);
            // 
            // GaussianBlur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.FLPParam);
            this.Name = "GaussianBlur";
            this.Size = new System.Drawing.Size(128, 144);
            this.Target = FilterBase.BaseFilterControl.TRANSFORM_TARGET.IMAGE;
            this.Controls.SetChildIndex(this.FLPParam, 0);
            this.FLPParam.ResumeLayout(false);
            this.FLPParam.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ParaBlurLimit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaSigmaLlimit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel FLPParam;
        private FilterBase.Parts.InputKernelSize ParaBlurLimit;
        private FilterBase.Parts.InputMaxMin ParaSigmaLlimit;
    }
}
