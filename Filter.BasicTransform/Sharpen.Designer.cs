namespace Filter.BasicTransform
{
    partial class Sharpen
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
            this.ParaLightness = new FilterBase.Parts.InputMaxMin();
            this.FLPParam.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ParaAlpha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaLightness)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // FLPParam
            // 
            this.FLPParam.AutoSize = true;
            this.FLPParam.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.FLPParam.Controls.Add(this.ParaAlpha);
            this.FLPParam.Controls.Add(this.ParaLightness);
            this.FLPParam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FLPParam.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.FLPParam.Location = new System.Drawing.Point(0, 25);
            this.FLPParam.Name = "FLPParam";
            this.FLPParam.Size = new System.Drawing.Size(128, 96);
            this.FLPParam.TabIndex = 5;
            // 
            // ParaAlpha
            // 
            this.ParaAlpha.ArgumentName = "alpha";
            this.ParaAlpha.AutoSize = true;
            this.ParaAlpha.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ParaAlpha.DecimalPlace = 1;
            this.ParaAlpha.Description = "シャープ化された画像の可視性を選択する範囲。\r\n0 では元の画像のみが表示され、1.0 ではシャープ化された画像のみが表示されます。\r\n値は [0, 1] の範囲" +
    "にする必要があります。\r\n　　　デフォルト: (0.2, 0.5)。";
            this.ParaAlpha.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.ParaAlpha.Location = new System.Drawing.Point(3, 3);
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
            this.ParaAlpha.TabIndex = 0;
            this.ParaAlpha.Title = "α";
            this.ParaAlpha.Value = "(0.2,0.5)";
            this.ParaAlpha.ValueType = FilterBase.Parts.PartsFunc.VALUE_TYPE.TYPE_FLOAT;
            this.ParaAlpha.ParameterChange += new FilterBase.Parts.ParameterChangeEventHandler(this.Param_ParameterChange);
            // 
            // ParaLightness
            // 
            this.ParaLightness.ArgumentName = "lightness";
            this.ParaLightness.AutoSize = true;
            this.ParaLightness.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ParaLightness.DecimalPlace = 1;
            this.ParaLightness.Description = "シャープ化された画像の明るさを選択する範囲。\r\n値が大きいほど、コントラストの高い画像が作成されます。\r\n値は 0 より大きい必要があります。\r\n　　　デフォルト" +
    ": (0.5、1.0)。";
            this.ParaLightness.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.ParaLightness.Location = new System.Drawing.Point(3, 51);
            this.ParaLightness.MaxValue = null;
            this.ParaLightness.MaxVersion = null;
            this.ParaLightness.MinimumSize = new System.Drawing.Size(124, 21);
            this.ParaLightness.MinValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.ParaLightness.MinVersion = null;
            this.ParaLightness.Name = "ParaLightness";
            this.ParaLightness.Required = false;
            this.ParaLightness.Size = new System.Drawing.Size(124, 42);
            this.ParaLightness.TabIndex = 1;
            this.ParaLightness.Title = "明るさ";
            this.ParaLightness.Value = "(0.5,1.0)";
            this.ParaLightness.ValueType = FilterBase.Parts.PartsFunc.VALUE_TYPE.TYPE_FLOAT;
            this.ParaLightness.ParameterChange += new FilterBase.Parts.ParameterChangeEventHandler(this.Param_ParameterChange);
            // 
            // Sharpen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.FLPParam);
            this.Name = "Sharpen";
            this.Size = new System.Drawing.Size(128, 146);
            this.Target = FilterBase.BaseFilterControl.TRANSFORM_TARGET.IMAGE;
            this.Controls.SetChildIndex(this.FLPParam, 0);
            this.FLPParam.ResumeLayout(false);
            this.FLPParam.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ParaAlpha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaLightness)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel FLPParam;
        private FilterBase.Parts.InputMaxMin ParaAlpha;
        private FilterBase.Parts.InputMaxMin ParaLightness;
    }
}
