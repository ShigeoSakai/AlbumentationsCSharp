namespace Filter.Blur
{
    partial class MedianBlur
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

        #region コンポーネント デザイナーで生成されたコード

        /// <summary> 
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を 
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.FLPParam = new System.Windows.Forms.FlowLayoutPanel();
            this.ParaKernel = new FilterBase.Parts.InputKernelSize();
            this.FLPParam.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ParaKernel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // FLPParam
            // 
            this.FLPParam.AutoSize = true;
            this.FLPParam.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.FLPParam.Controls.Add(this.ParaKernel);
            this.FLPParam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FLPParam.Location = new System.Drawing.Point(0, 25);
            this.FLPParam.Name = "FLPParam";
            this.FLPParam.Size = new System.Drawing.Size(128, 47);
            this.FLPParam.TabIndex = 5;
            // 
            // ParaKernel
            // 
            this.ParaKernel.ArgumentName = "blur_limit";
            this.ParaKernel.AutoSize = true;
            this.ParaKernel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ParaKernel.DecimalPlace = 0;
            this.ParaKernel.Description = "入力画像をぼかすための最大アパーチャ線形サイズ。\r\n奇数で、[3, inf) の範囲でなければなりません。\r\n- 2 つの int のタプルが指定された場合、可能" +
    "なカーネル サイズの包括的な範囲を定義します。\r\n　　　デフォルト: (3, 7)";
            this.ParaKernel.FirstMaxIsSecondValue = true;
            this.ParaKernel.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.ParaKernel.Location = new System.Drawing.Point(1, 3);
            this.ParaKernel.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.ParaKernel.MaxValue = "";
            this.ParaKernel.MaxVersion = null;
            this.ParaKernel.MinimumSize = new System.Drawing.Size(124, 20);
            this.ParaKernel.MinValue = "(3,3)";
            this.ParaKernel.MinVersion = null;
            this.ParaKernel.Name = "ParaKernel";
            this.ParaKernel.Required = false;
            this.ParaKernel.Size = new System.Drawing.Size(124, 41);
            this.ParaKernel.TabIndex = 0;
            this.ParaKernel.Title = "カーネルサイズ";
            this.ParaKernel.Value = "(3,7)";
            this.ParaKernel.ValueType = FilterBase.Parts.PartsFunc.VALUE_TYPE.TYPE_INT_ODD;
            this.ParaKernel.ParameterChange += new FilterBase.Parts.ParameterChangeEventHandler(this.ParaKernel_ParameterChange);
            // 
            // MedianBlur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.FLPParam);
            this.Name = "MedianBlur";
            this.Size = new System.Drawing.Size(128, 97);
            this.Target = FilterBase.BaseFilterControl.TRANSFORM_TARGET.IMAGE;
            this.Controls.SetChildIndex(this.FLPParam, 0);
            this.FLPParam.ResumeLayout(false);
            this.FLPParam.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ParaKernel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel FLPParam;
        private FilterBase.Parts.InputKernelSize ParaKernel;
    }
}
