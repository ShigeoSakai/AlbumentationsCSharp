namespace Filter.BasicTransform
{
    partial class ColorJitter
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
            this.ParaBrightness = new FilterBase.Parts.InputMaxMin();
            this.ParaContrast = new FilterBase.Parts.InputMaxMin();
            this.ParaSaturation = new FilterBase.Parts.InputMaxMin();
            this.ParaHue = new FilterBase.Parts.InputMaxMin();
            this.FLPParam.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ParaBrightness)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaContrast)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaSaturation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaHue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // FLPParam
            // 
            this.FLPParam.AutoSize = true;
            this.FLPParam.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.FLPParam.Controls.Add(this.ParaBrightness);
            this.FLPParam.Controls.Add(this.ParaContrast);
            this.FLPParam.Controls.Add(this.ParaSaturation);
            this.FLPParam.Controls.Add(this.ParaHue);
            this.FLPParam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FLPParam.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.FLPParam.Location = new System.Drawing.Point(0, 25);
            this.FLPParam.Name = "FLPParam";
            this.FLPParam.Size = new System.Drawing.Size(128, 192);
            this.FLPParam.TabIndex = 5;
            // 
            // ParaBrightness
            // 
            this.ParaBrightness.ArgumentName = "brightness";
            this.ParaBrightness.AutoSize = true;
            this.ParaBrightness.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ParaBrightness.DecimalPlace = 1;
            this.ParaBrightness.Description = "明るさをどの程度ジッターするか。\r\n明るさ係数は指定された範囲からサンプリングされます。\r\n負でない数値である必要があります。\r\n　　デフォルト: (0.8, 1" +
    ".2)";
            this.ParaBrightness.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.ParaBrightness.Location = new System.Drawing.Point(3, 3);
            this.ParaBrightness.MaxValue = null;
            this.ParaBrightness.MaxVersion = null;
            this.ParaBrightness.MinimumSize = new System.Drawing.Size(124, 21);
            this.ParaBrightness.MinValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.ParaBrightness.MinVersion = null;
            this.ParaBrightness.Name = "ParaBrightness";
            this.ParaBrightness.Required = false;
            this.ParaBrightness.Size = new System.Drawing.Size(124, 42);
            this.ParaBrightness.TabIndex = 0;
            this.ParaBrightness.Title = "明るさ";
            this.ParaBrightness.Value = "(0.8,1.2)";
            this.ParaBrightness.ValueType = FilterBase.Parts.PartsFunc.VALUE_TYPE.TYPE_FLOAT;
            this.ParaBrightness.ParameterChange += new FilterBase.Parts.ParameterChangeEventHandler(this.Param_ParameterChange);
            // 
            // ParaContrast
            // 
            this.ParaContrast.ArgumentName = "contrast";
            this.ParaContrast.AutoSize = true;
            this.ParaContrast.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ParaContrast.DecimalPlace = 1;
            this.ParaContrast.Description = "コントラストをどの程度ジッターするか。\r\nコントラスト係数は指定された範囲からサンプリングされます。\r\n負でない数値である必要があります。\r\n　　　デフォルト: " +
    "(0.8, 1.2)";
            this.ParaContrast.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.ParaContrast.Location = new System.Drawing.Point(3, 51);
            this.ParaContrast.MaxValue = null;
            this.ParaContrast.MaxVersion = null;
            this.ParaContrast.MinimumSize = new System.Drawing.Size(124, 21);
            this.ParaContrast.MinValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.ParaContrast.MinVersion = null;
            this.ParaContrast.Name = "ParaContrast";
            this.ParaContrast.Required = false;
            this.ParaContrast.Size = new System.Drawing.Size(124, 42);
            this.ParaContrast.TabIndex = 1;
            this.ParaContrast.Title = "コントラスト";
            this.ParaContrast.Value = "(0.8,1.2)";
            this.ParaContrast.ValueType = FilterBase.Parts.PartsFunc.VALUE_TYPE.TYPE_FLOAT;
            this.ParaContrast.ParameterChange += new FilterBase.Parts.ParameterChangeEventHandler(this.Param_ParameterChange);
            // 
            // ParaSaturation
            // 
            this.ParaSaturation.ArgumentName = "saturation";
            this.ParaSaturation.AutoSize = true;
            this.ParaSaturation.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ParaSaturation.DecimalPlace = 1;
            this.ParaSaturation.Description = "彩度をどの程度ジッターするか。\r\n彩度係数は指定された範囲からサンプリングされます。\r\n負でない数値である必要があります。\r\n　　デフォルト: (0.8, 1.2" +
    ")";
            this.ParaSaturation.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.ParaSaturation.Location = new System.Drawing.Point(3, 99);
            this.ParaSaturation.MaxValue = null;
            this.ParaSaturation.MaxVersion = null;
            this.ParaSaturation.MinimumSize = new System.Drawing.Size(124, 21);
            this.ParaSaturation.MinValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.ParaSaturation.MinVersion = null;
            this.ParaSaturation.Name = "ParaSaturation";
            this.ParaSaturation.Required = false;
            this.ParaSaturation.Size = new System.Drawing.Size(124, 42);
            this.ParaSaturation.TabIndex = 2;
            this.ParaSaturation.Title = "彩度";
            this.ParaSaturation.Value = "(0.8,1.2)";
            this.ParaSaturation.ValueType = FilterBase.Parts.PartsFunc.VALUE_TYPE.TYPE_FLOAT;
            this.ParaSaturation.ParameterChange += new FilterBase.Parts.ParameterChangeEventHandler(this.Param_ParameterChange);
            // 
            // ParaHue
            // 
            this.ParaHue.ArgumentName = "hue";
            this.ParaHue.AutoSize = true;
            this.ParaHue.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ParaHue.DecimalPlace = 1;
            this.ParaHue.Description = "色相をどれだけジッタするか。\r\n色相係数は指定された範囲からサンプリングされます。\r\n値は [-0.5, 0.5] の範囲内である必要があります。\r\n　　　デフォ" +
    "ルト: (-0.5, 0.5)";
            this.ParaHue.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.ParaHue.Location = new System.Drawing.Point(3, 147);
            this.ParaHue.MaxValue = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.ParaHue.MaxVersion = null;
            this.ParaHue.MinimumSize = new System.Drawing.Size(124, 21);
            this.ParaHue.MinValue = new decimal(new int[] {
            5,
            0,
            0,
            -2147418112});
            this.ParaHue.MinVersion = null;
            this.ParaHue.Name = "ParaHue";
            this.ParaHue.Required = false;
            this.ParaHue.Size = new System.Drawing.Size(124, 42);
            this.ParaHue.TabIndex = 3;
            this.ParaHue.Title = "色相";
            this.ParaHue.Value = "(-0.5,0.5)";
            this.ParaHue.ValueType = FilterBase.Parts.PartsFunc.VALUE_TYPE.TYPE_FLOAT;
            this.ParaHue.ParameterChange += new FilterBase.Parts.ParameterChangeEventHandler(this.Param_ParameterChange);
            // 
            // ColorJitter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.FLPParam);
            this.Name = "ColorJitter";
            this.Size = new System.Drawing.Size(128, 242);
            this.Target = FilterBase.BaseFilterControl.TRANSFORM_TARGET.IMAGE;
            this.Controls.SetChildIndex(this.FLPParam, 0);
            this.FLPParam.ResumeLayout(false);
            this.FLPParam.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ParaBrightness)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaContrast)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaSaturation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaHue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel FLPParam;
        private FilterBase.Parts.InputMaxMin ParaBrightness;
        private FilterBase.Parts.InputMaxMin ParaContrast;
        private FilterBase.Parts.InputMaxMin ParaSaturation;
        private FilterBase.Parts.InputMaxMin ParaHue;
    }
}
