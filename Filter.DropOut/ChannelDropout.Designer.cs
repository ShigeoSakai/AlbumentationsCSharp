namespace Filter.DropOut
{
    partial class ChannelDropout
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
            this.ParaChannelDropRange = new FilterBase.Parts.InputMaxMin();
            this.ParaFillValue = new FilterBase.Parts.InputValueWithType();
            this.FLPParam.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ParaChannelDropRange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaFillValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // FLPParam
            // 
            this.FLPParam.AutoSize = true;
            this.FLPParam.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.FLPParam.Controls.Add(this.ParaChannelDropRange);
            this.FLPParam.Controls.Add(this.ParaFillValue);
            this.FLPParam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FLPParam.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.FLPParam.Location = new System.Drawing.Point(0, 25);
            this.FLPParam.Name = "FLPParam";
            this.FLPParam.Size = new System.Drawing.Size(128, 106);
            this.FLPParam.TabIndex = 5;
            // 
            // ParaChannelDropRange
            // 
            this.ParaChannelDropRange.ArgumentName = "channel_drop_range";
            this.ParaChannelDropRange.AutoSize = true;
            this.ParaChannelDropRange.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ParaChannelDropRange.DecimalPlace = 0;
            this.ParaChannelDropRange.Description = "削除するチャネルの数を選択する範囲。\r\n実際の数は、[最小、最大]の範囲からランダムに選択されます。\r\n　　デフォルト: (1, 1)";
            this.ParaChannelDropRange.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ParaChannelDropRange.Location = new System.Drawing.Point(3, 3);
            this.ParaChannelDropRange.MaxValue = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.ParaChannelDropRange.MaxVersion = null;
            this.ParaChannelDropRange.MinimumSize = new System.Drawing.Size(124, 21);
            this.ParaChannelDropRange.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ParaChannelDropRange.MinVersion = null;
            this.ParaChannelDropRange.Name = "ParaChannelDropRange";
            this.ParaChannelDropRange.Required = false;
            this.ParaChannelDropRange.Size = new System.Drawing.Size(124, 54);
            this.ParaChannelDropRange.TabIndex = 0;
            this.ParaChannelDropRange.Title = "削除するチャネルの数の範囲";
            this.ParaChannelDropRange.Value = "(1,1)";
            this.ParaChannelDropRange.ValueType = FilterBase.Parts.PartsFunc.VALUE_TYPE.TYPE_INT;
            this.ParaChannelDropRange.ParameterChange += new FilterBase.Parts.ParameterChangeEventHandler(this.Param_ParameterChange);
            // 
            // ParaFillValue
            // 
            this.ParaFillValue.ArgumentName = "fill_value";
            this.ParaFillValue.ControlLayout = FilterBase.Parts.InputValue.LAYOUT.Vertical;
            this.ParaFillValue.DecimalPlace = 0;
            this.ParaFillValue.Description = "ドロップされたチャネルを埋めるために使用されるピクセル値。\r\n　　デフォルト: 0";
            this.ParaFillValue.FloatMaxValue = 1F;
            this.ParaFillValue.FloatMinValue = 0F;
            this.ParaFillValue.IntMaxValue = 255;
            this.ParaFillValue.IntMinValue = 0;
            this.ParaFillValue.Location = new System.Drawing.Point(3, 63);
            this.ParaFillValue.MaxValue = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.ParaFillValue.MaxVersion = null;
            this.ParaFillValue.MinimumSize = new System.Drawing.Size(124, 21);
            this.ParaFillValue.MinValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.ParaFillValue.MinVersion = null;
            this.ParaFillValue.Name = "ParaFillValue";
            this.ParaFillValue.Required = false;
            this.ParaFillValue.Size = new System.Drawing.Size(124, 40);
            this.ParaFillValue.TabIndex = 1;
            this.ParaFillValue.Title = "Fill値";
            this.ParaFillValue.Unit = "";
            this.ParaFillValue.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.ParaFillValue.ValueType = FilterBase.Parts.InputValue.VALUE_TYPE.INT;
            this.ParaFillValue.ParameterChange += new FilterBase.Parts.ParameterChangeEventHandler(this.Param_ParameterChange);
            // 
            // ChannelDropout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.FLPParam);
            this.Name = "ChannelDropout";
            this.Size = new System.Drawing.Size(128, 156);
            this.Target = FilterBase.BaseFilterControl.TRANSFORM_TARGET.IMAGE;
            this.Controls.SetChildIndex(this.FLPParam, 0);
            this.FLPParam.ResumeLayout(false);
            this.FLPParam.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ParaChannelDropRange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaFillValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel FLPParam;
        private FilterBase.Parts.InputMaxMin ParaChannelDropRange;
        private FilterBase.Parts.InputValueWithType ParaFillValue;
    }
}
