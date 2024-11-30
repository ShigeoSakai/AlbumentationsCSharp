namespace Filter.BasicTransform
{
    partial class GaussNoise
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
            this.ParaVarLimit = new FilterBase.Parts.InputMaxMin();
            this.ParaMean = new FilterBase.Parts.InputValue();
            this.ParaPerChannel = new FilterBase.Parts.CheckBoxParts();
            this.ParaNoiseScaleFactor = new FilterBase.Parts.InputTrackBar();
            this.FLPParam.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ParaVarLimit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaMean)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaNoiseScaleFactor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // FLPParam
            // 
            this.FLPParam.AutoSize = true;
            this.FLPParam.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.FLPParam.Controls.Add(this.ParaVarLimit);
            this.FLPParam.Controls.Add(this.ParaMean);
            this.FLPParam.Controls.Add(this.ParaPerChannel);
            this.FLPParam.Controls.Add(this.ParaNoiseScaleFactor);
            this.FLPParam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FLPParam.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.FLPParam.Location = new System.Drawing.Point(0, 25);
            this.FLPParam.Name = "FLPParam";
            this.FLPParam.Size = new System.Drawing.Size(128, 187);
            this.FLPParam.TabIndex = 5;
            // 
            // ParaVarLimit
            // 
            this.ParaVarLimit.ArgumentName = "var_limit";
            this.ParaVarLimit.AutoSize = true;
            this.ParaVarLimit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ParaVarLimit.DecimalPlace = 1;
            this.ParaVarLimit.Description = "ノイズの分散範囲。\r\nデフォルト: (10.0, 50.0)";
            this.ParaVarLimit.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.ParaVarLimit.Location = new System.Drawing.Point(3, 3);
            this.ParaVarLimit.MaxValue = null;
            this.ParaVarLimit.MaxVersion = null;
            this.ParaVarLimit.MinimumSize = new System.Drawing.Size(124, 21);
            this.ParaVarLimit.MinValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.ParaVarLimit.MinVersion = null;
            this.ParaVarLimit.Name = "ParaVarLimit";
            this.ParaVarLimit.Required = false;
            this.ParaVarLimit.Size = new System.Drawing.Size(124, 42);
            this.ParaVarLimit.TabIndex = 0;
            this.ParaVarLimit.Title = "ノイズの分散範囲";
            this.ParaVarLimit.Value = "(10.0,50.0)";
            this.ParaVarLimit.ValueType = FilterBase.Parts.PartsFunc.VALUE_TYPE.TYPE_FLOAT;
            this.ParaVarLimit.ParameterChange += new FilterBase.Parts.ParameterChangeEventHandler(this.ParaKernel_ParameterChange);
            // 
            // ParaMean
            // 
            this.ParaMean.ArgumentName = "mean";
            this.ParaMean.AutoSize = true;
            this.ParaMean.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ParaMean.ControlLayout = FilterBase.Parts.InputValue.LAYOUT.Vertical;
            this.ParaMean.DecimalPlace = 1;
            this.ParaMean.Description = "ノイズの平均。\r\nデフォルト: 0";
            this.ParaMean.Location = new System.Drawing.Point(3, 51);
            this.ParaMean.MaxValue = null;
            this.ParaMean.MaxVersion = null;
            this.ParaMean.MinimumSize = new System.Drawing.Size(124, 21);
            this.ParaMean.MinValue = null;
            this.ParaMean.MinVersion = null;
            this.ParaMean.Name = "ParaMean";
            this.ParaMean.Required = false;
            this.ParaMean.Size = new System.Drawing.Size(124, 35);
            this.ParaMean.TabIndex = 1;
            this.ParaMean.Title = "ノイズの平均";
            this.ParaMean.Unit = "";
            this.ParaMean.Value = new decimal(new int[] {
            0,
            0,
            0,
            65536});
            this.ParaMean.ValueType = FilterBase.Parts.InputValue.VALUE_TYPE.FLOAT;
            this.ParaMean.ParameterChange += new FilterBase.Parts.ParameterChangeEventHandler(this.ParaKernel_ParameterChange);
            // 
            // ParaPerChannel
            // 
            this.ParaPerChannel.ArgumentName = "per_channel";
            this.ParaPerChannel.AutoSize = true;
            this.ParaPerChannel.Checked = true;
            this.ParaPerChannel.CheckedValue = "";
            this.ParaPerChannel.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ParaPerChannel.Description = "True の場合、ノイズは各チャネルごとに個別にサンプリングされます。\r\nそれ以外の場合、ノイズはすべてのチャネルに対して 1 回サンプリングされます。\r\n　　　" +
    "デフォルト: True。";
            this.ParaPerChannel.IndeterminateValue = "";
            this.ParaPerChannel.Location = new System.Drawing.Point(3, 92);
            this.ParaPerChannel.Margin = new System.Windows.Forms.Padding(3, 3, 1, 3);
            this.ParaPerChannel.MaxVersion = null;
            this.ParaPerChannel.MinimumSize = new System.Drawing.Size(122, 21);
            this.ParaPerChannel.MinVersion = null;
            this.ParaPerChannel.Name = "ParaPerChannel";
            this.ParaPerChannel.Size = new System.Drawing.Size(122, 21);
            this.ParaPerChannel.TabIndex = 2;
            this.ParaPerChannel.Text = "CH別にサンプリング";
            this.ParaPerChannel.Title = "CH別にサンプリング";
            this.HelpToolTip.SetToolTip(this.ParaPerChannel, "True の場合、ノイズは各チャネルごとに個別にサンプリングされます。\r\nそれ以外の場合、ノイズはすべてのチャネルに対して 1 回サンプリングされます。\r\n　　　" +
        "デフォルト: True。");
            this.ParaPerChannel.UncheckedValue = "";
            this.ParaPerChannel.UseVisualStyleBackColor = true;
            this.ParaPerChannel.Value = "";
            this.ParaPerChannel.ParameterChange += new FilterBase.Parts.ParameterChangeEventHandler(this.ParaKernel_ParameterChange);
            // 
            // ParaNoiseScaleFactor
            // 
            this.ParaNoiseScaleFactor.ArgumentName = "noise_scale_factor";
            this.ParaNoiseScaleFactor.AutoSize = true;
            this.ParaNoiseScaleFactor.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ParaNoiseScaleFactor.DecimalPlace = 1;
            this.ParaNoiseScaleFactor.Description = "ノイズ生成のスケーリング係数。\r\n値は (0, 1] の範囲である必要があります。\r\n 1に設定すると、ノイズは各ピクセルごとに個別にサンプリングされます。\r\n " +
    "1より小さい場合は、ノイズはより小さなサイズでサンプリングされます。\r\n 画像の形状に合わせてサイズが変更されます。\r\n値が小さいほど、変換が速くなります。\r\n" +
    "　　　　　デフォルト: 1.0。";
            this.ParaNoiseScaleFactor.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.ParaNoiseScaleFactor.Location = new System.Drawing.Point(3, 119);
            this.ParaNoiseScaleFactor.MaxValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ParaNoiseScaleFactor.MaxVersion = null;
            this.ParaNoiseScaleFactor.MinimumSize = new System.Drawing.Size(124, 21);
            this.ParaNoiseScaleFactor.MinValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.ParaNoiseScaleFactor.MinVersion = "1.4.9";
            this.ParaNoiseScaleFactor.Name = "ParaNoiseScaleFactor";
            this.ParaNoiseScaleFactor.Required = false;
            this.ParaNoiseScaleFactor.Size = new System.Drawing.Size(124, 65);
            this.ParaNoiseScaleFactor.TabIndex = 4;
            this.ParaNoiseScaleFactor.Title = "スケーリング係数";
            this.ParaNoiseScaleFactor.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ParaNoiseScaleFactor.ParameterChange += new FilterBase.Parts.ParameterChangeEventHandler(this.ParaKernel_ParameterChange);
            // 
            // GaussNoise
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.FLPParam);
            this.Name = "GaussNoise";
            this.Size = new System.Drawing.Size(128, 237);
            this.Target = FilterBase.BaseFilterControl.TRANSFORM_TARGET.IMAGE;
            this.Controls.SetChildIndex(this.FLPParam, 0);
            this.FLPParam.ResumeLayout(false);
            this.FLPParam.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ParaVarLimit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaMean)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaNoiseScaleFactor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel FLPParam;
        private FilterBase.Parts.InputMaxMin ParaVarLimit;
        private FilterBase.Parts.InputValue ParaMean;
        private FilterBase.Parts.CheckBoxParts ParaPerChannel;
        private FilterBase.Parts.InputTrackBar ParaNoiseScaleFactor;
    }
}
