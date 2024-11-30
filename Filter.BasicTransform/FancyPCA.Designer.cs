namespace Filter.BasicTransform
{
    partial class FancyPCA
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
            this.ParaAlpha = new FilterBase.Parts.InputMaxMin();
            this.ParaAlfaOld = new FilterBase.Parts.InputValueUpDown();
            this.FLPParam.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ParaAlpha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaAlfaOld)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // FLPParam
            // 
            this.FLPParam.AutoSize = true;
            this.FLPParam.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.FLPParam.Controls.Add(this.ParaAlpha);
            this.FLPParam.Controls.Add(this.ParaAlfaOld);
            this.FLPParam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FLPParam.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.FLPParam.Location = new System.Drawing.Point(0, 25);
            this.FLPParam.Name = "FLPParam";
            this.FLPParam.Size = new System.Drawing.Size(128, 72);
            this.FLPParam.TabIndex = 5;
            // 
            // ParaAlpha
            // 
            this.ParaAlpha.ArgumentName = "alpha";
            this.ParaAlpha.AutoSize = true;
            this.ParaAlpha.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ParaAlpha.DecimalPlace = 1;
            this.ParaAlpha.Description = "各主成分のランダムノイズを生成するために使用されるガウス分布の標準偏差。\r\n2 つの浮動小数点数 (最小、最大) のタプルが指定されている場合、\r\n標準偏差は実行" +
    "ごとにこの範囲から均一にサンプリングされます。\r\n　　　デフォルト: 0.1。";
            this.ParaAlpha.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.ParaAlpha.InvalidValue = "";
            this.ParaAlpha.Location = new System.Drawing.Point(3, 3);
            this.ParaAlpha.MaxValue = null;
            this.ParaAlpha.MaxVersion = null;
            this.ParaAlpha.MinimumSize = new System.Drawing.Size(124, 21);
            this.ParaAlpha.MinValue = null;
            this.ParaAlpha.MinVersion = "1.4.22";
            this.ParaAlpha.Name = "ParaAlpha";
            this.ParaAlpha.Required = false;
            this.ParaAlpha.Size = new System.Drawing.Size(124, 39);
            this.ParaAlpha.TabIndex = 0;
            this.ParaAlpha.Title = "α";
            this.ParaAlpha.UseLargeValue = false;
            this.ParaAlpha.UseValid = false;
            this.ParaAlpha.Value = "(0.1,1.0)";
            this.ParaAlpha.ValueType = FilterBase.Parts.PartsFunc.VALUE_TYPE.TYPE_FLOAT;
            this.ParaAlpha.ParameterChange += new FilterBase.Parts.ParameterChangeEventHandler(this.Param_ParameterChange);
            // 
            // ParaAlfaOld
            // 
            this.ParaAlfaOld.ArgumentName = "alpha";
            this.ParaAlfaOld.AutoSize = true;
            this.ParaAlfaOld.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ParaAlfaOld.ControlLayout = FilterBase.Parts.InputValue.LAYOUT.Horizontal;
            this.ParaAlfaOld.DecimalPlace = 1;
            this.ParaAlfaOld.Description = "各主成分のランダムノイズを生成するために使用されるガウス分布の標準偏差。\r\n単一の浮動小数点数が指定された場合、すべてのチャネルに使用されます。\r\n　　　デフォル" +
    "ト: 0.1。";
            this.ParaAlfaOld.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.ParaAlfaOld.InvalidValue = "";
            this.ParaAlfaOld.Location = new System.Drawing.Point(3, 48);
            this.ParaAlfaOld.MaxValue = null;
            this.ParaAlfaOld.MaxVersion = "1.4.21";
            this.ParaAlfaOld.MinimumSize = new System.Drawing.Size(124, 21);
            this.ParaAlfaOld.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.ParaAlfaOld.MinVersion = null;
            this.ParaAlfaOld.Name = "ParaAlfaOld";
            this.ParaAlfaOld.Required = false;
            this.ParaAlfaOld.Size = new System.Drawing.Size(124, 21);
            this.ParaAlfaOld.TabIndex = 1;
            this.ParaAlfaOld.Title = "α";
            this.ParaAlfaOld.Unit = "";
            this.ParaAlfaOld.UseValid = false;
            this.ParaAlfaOld.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.ParaAlfaOld.ValueType = FilterBase.Parts.InputValue.VALUE_TYPE.FLOAT;
            this.ParaAlfaOld.ParameterChange += new FilterBase.Parts.ParameterChangeEventHandler(this.Param_ParameterChange);
            // 
            // FancyPCA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.FLPParam);
            this.Name = "FancyPCA";
            this.Size = new System.Drawing.Size(128, 122);
            this.Target = FilterBase.BaseFilterControl.TRANSFORM_TARGET.IMAGE;
            this.Controls.SetChildIndex(this.FLPParam, 0);
            this.FLPParam.ResumeLayout(false);
            this.FLPParam.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ParaAlpha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaAlfaOld)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel FLPParam;
        private FilterBase.Parts.InputMaxMin ParaAlpha;
        private FilterBase.Parts.InputValueUpDown ParaAlfaOld;
    }
}
