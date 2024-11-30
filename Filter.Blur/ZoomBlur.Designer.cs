namespace Filter.Blur
{
    partial class ZoomBlur
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
            this.ParaMaxFactor = new FilterBase.Parts.InputMaxMin();
            this.ParaStepFactor = new FilterBase.Parts.InputMaxMin();
            this.FLPParam.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ParaMaxFactor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaStepFactor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // FLPParam
            // 
            this.FLPParam.AutoSize = true;
            this.FLPParam.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.FLPParam.Controls.Add(this.ParaMaxFactor);
            this.FLPParam.Controls.Add(this.ParaStepFactor);
            this.FLPParam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FLPParam.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.FLPParam.Location = new System.Drawing.Point(0, 25);
            this.FLPParam.Name = "FLPParam";
            this.FLPParam.Size = new System.Drawing.Size(128, 96);
            this.FLPParam.TabIndex = 5;
            // 
            // ParaMaxFactor
            // 
            this.ParaMaxFactor.ArgumentName = "max_factor";
            this.ParaMaxFactor.AutoSize = true;
            this.ParaMaxFactor.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ParaMaxFactor.DecimalPlace = 2;
            this.ParaMaxFactor.Description = "ぼかしの最大係数の範囲。\r\nすべての max_factor 値は 1 より大きくする必要があります。\r\n　　デフォルト: (1, 1.31)。\r\n";
            this.ParaMaxFactor.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.ParaMaxFactor.Location = new System.Drawing.Point(3, 3);
            this.ParaMaxFactor.MaxValue = null;
            this.ParaMaxFactor.MaxVersion = null;
            this.ParaMaxFactor.MinimumSize = new System.Drawing.Size(124, 21);
            this.ParaMaxFactor.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ParaMaxFactor.MinVersion = null;
            this.ParaMaxFactor.Name = "ParaMaxFactor";
            this.ParaMaxFactor.Required = false;
            this.ParaMaxFactor.Size = new System.Drawing.Size(124, 42);
            this.ParaMaxFactor.TabIndex = 0;
            this.ParaMaxFactor.Title = "ぼかしの最大係数";
            this.ParaMaxFactor.Value = "(1.00,1.31)";
            this.ParaMaxFactor.ValueType = FilterBase.Parts.PartsFunc.VALUE_TYPE.TYPE_FLOAT;
            this.ParaMaxFactor.ParameterChange += new FilterBase.Parts.ParameterChangeEventHandler(this.Param_ParameterChange);
            // 
            // ParaStepFactor
            // 
            this.ParaStepFactor.ArgumentName = "step_factor";
            this.ParaStepFactor.AutoSize = true;
            this.ParaStepFactor.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ParaStepFactor.DecimalPlace = 2;
            this.ParaStepFactor.Description = "すべての step_factor 値は正である必要があります。\r\n　　デフォルト: (0.01, 0.03)。";
            this.ParaStepFactor.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.ParaStepFactor.Location = new System.Drawing.Point(3, 51);
            this.ParaStepFactor.MaxValue = null;
            this.ParaStepFactor.MaxVersion = null;
            this.ParaStepFactor.MinimumSize = new System.Drawing.Size(124, 21);
            this.ParaStepFactor.MinValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.ParaStepFactor.MinVersion = null;
            this.ParaStepFactor.Name = "ParaStepFactor";
            this.ParaStepFactor.Required = false;
            this.ParaStepFactor.Size = new System.Drawing.Size(124, 42);
            this.ParaStepFactor.TabIndex = 1;
            this.ParaStepFactor.Title = "ステップ";
            this.ParaStepFactor.Value = "(0.01,0.03)";
            this.ParaStepFactor.ValueType = FilterBase.Parts.PartsFunc.VALUE_TYPE.TYPE_FLOAT;
            this.ParaStepFactor.ParameterChange += new FilterBase.Parts.ParameterChangeEventHandler(this.Param_ParameterChange);
            // 
            // ZoomBlur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.FLPParam);
            this.Name = "ZoomBlur";
            this.Size = new System.Drawing.Size(128, 146);
            this.Target = FilterBase.BaseFilterControl.TRANSFORM_TARGET.IMAGE;
            this.Controls.SetChildIndex(this.FLPParam, 0);
            this.FLPParam.ResumeLayout(false);
            this.FLPParam.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ParaMaxFactor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaStepFactor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel FLPParam;
        private FilterBase.Parts.InputMaxMin ParaMaxFactor;
        private FilterBase.Parts.InputMaxMin ParaStepFactor;
    }
}
