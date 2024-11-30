namespace Filter.BasicTransform
{
    partial class RingingOvershoot
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
            this.ParaCutoff = new FilterBase.Parts.InputMaxMin();
            this.FLPParam.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ParaBlurLimit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaCutoff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // FLPParam
            // 
            this.FLPParam.AutoSize = true;
            this.FLPParam.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.FLPParam.Controls.Add(this.ParaBlurLimit);
            this.FLPParam.Controls.Add(this.ParaCutoff);
            this.FLPParam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FLPParam.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.FLPParam.Location = new System.Drawing.Point(0, 25);
            this.FLPParam.Name = "FLPParam";
            this.FLPParam.Size = new System.Drawing.Size(128, 95);
            this.FLPParam.TabIndex = 5;
            // 
            // ParaBlurLimit
            // 
            this.ParaBlurLimit.ArgumentName = "blur_limit";
            this.ParaBlurLimit.AutoSize = true;
            this.ParaBlurLimit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ParaBlurLimit.DecimalPlace = 0;
            this.ParaBlurLimit.Description = "sinc フィルターの最大カーネル サイズ。\r\n[3, inf) の範囲内の奇数である必要があります。\r\nタプル (min, max) が指定された場合、カーネル" +
    " サイズは範囲 (min, max) からランダムに選択されます。\r\n　　デフォルト: (7, 15)。";
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
            // ParaCutoff
            // 
            this.ParaCutoff.ArgumentName = "cutoff";
            this.ParaCutoff.AutoSize = true;
            this.ParaCutoff.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ParaCutoff.DecimalPlace = 2;
            this.ParaCutoff.Description = "カットオフ周波数をラジアンで選択する範囲。\r\n値は (0, π) の範囲にする必要があります。カットオフ周波数が低いほど、\r\nリンギング効果が顕著になります。\r\n" +
    "　　　デフォルト: (π/4, π/2)。";
            this.ParaCutoff.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.ParaCutoff.Location = new System.Drawing.Point(3, 50);
            this.ParaCutoff.MaxValue = new decimal(new int[] {
            314,
            0,
            0,
            131072});
            this.ParaCutoff.MaxVersion = null;
            this.ParaCutoff.MinimumSize = new System.Drawing.Size(124, 21);
            this.ParaCutoff.MinValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.ParaCutoff.MinVersion = null;
            this.ParaCutoff.Name = "ParaCutoff";
            this.ParaCutoff.Required = false;
            this.ParaCutoff.Size = new System.Drawing.Size(124, 42);
            this.ParaCutoff.TabIndex = 1;
            this.ParaCutoff.Title = "カットオフ周波数";
            this.ParaCutoff.Value = "(0.78,1.57)";
            this.ParaCutoff.ValueType = FilterBase.Parts.PartsFunc.VALUE_TYPE.TYPE_FLOAT;
            this.ParaCutoff.ParameterChange += new FilterBase.Parts.ParameterChangeEventHandler(this.Param_ParameterChange);
            // 
            // RingingOvershoot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.FLPParam);
            this.Name = "RingingOvershoot";
            this.Size = new System.Drawing.Size(128, 145);
            this.Target = FilterBase.BaseFilterControl.TRANSFORM_TARGET.IMAGE;
            this.Controls.SetChildIndex(this.FLPParam, 0);
            this.FLPParam.ResumeLayout(false);
            this.FLPParam.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ParaBlurLimit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaCutoff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel FLPParam;
        private FilterBase.Parts.InputKernelSize ParaBlurLimit;
        private FilterBase.Parts.InputMaxMin ParaCutoff;
    }
}
