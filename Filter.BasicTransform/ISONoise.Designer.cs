namespace Filter.BasicTransform
{
    partial class ISONoise
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
            this.ParaColorShift = new FilterBase.Parts.InputMaxMin();
            this.ParaIntensity = new FilterBase.Parts.InputMaxMin();
            this.FLPParam.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ParaColorShift)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaIntensity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // FLPParam
            // 
            this.FLPParam.AutoSize = true;
            this.FLPParam.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.FLPParam.Controls.Add(this.ParaColorShift);
            this.FLPParam.Controls.Add(this.ParaIntensity);
            this.FLPParam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FLPParam.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.FLPParam.Location = new System.Drawing.Point(0, 25);
            this.FLPParam.Name = "FLPParam";
            this.FLPParam.Size = new System.Drawing.Size(128, 90);
            this.FLPParam.TabIndex = 5;
            // 
            // ParaColorShift
            // 
            this.ParaColorShift.ArgumentName = "color_shift";
            this.ParaColorShift.AutoSize = true;
            this.ParaColorShift.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ParaColorShift.DecimalPlace = 2;
            this.ParaColorShift.Description = "色相を変更する範囲。\r\n値は [0, 1] の範囲でなければなりません。\r\n1 は完全な 360° の色相回転を表します。\r\n            デフォルト:" +
    " (0.01, 0.05)";
            this.ParaColorShift.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.ParaColorShift.InvalidValue = "";
            this.ParaColorShift.Location = new System.Drawing.Point(3, 3);
            this.ParaColorShift.MaxValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ParaColorShift.MaxVersion = null;
            this.ParaColorShift.MinimumSize = new System.Drawing.Size(124, 21);
            this.ParaColorShift.MinValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.ParaColorShift.MinVersion = null;
            this.ParaColorShift.Name = "ParaColorShift";
            this.ParaColorShift.Required = false;
            this.ParaColorShift.Size = new System.Drawing.Size(124, 39);
            this.ParaColorShift.TabIndex = 0;
            this.ParaColorShift.Title = "カラーシフト";
            this.ParaColorShift.UseLargeValue = false;
            this.ParaColorShift.UseValid = false;
            this.ParaColorShift.Value = "(0.01,0.05)";
            this.ParaColorShift.ValueType = FilterBase.Parts.PartsFunc.VALUE_TYPE.TYPE_FLOAT;
            this.ParaColorShift.ParameterChange += new FilterBase.Parts.ParameterChangeEventHandler(this.Param_ParameterChange);
            // 
            // ParaIntensity
            // 
            this.ParaIntensity.ArgumentName = "intensity";
            this.ParaIntensity.AutoSize = true;
            this.ParaIntensity.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ParaIntensity.DecimalPlace = 1;
            this.ParaIntensity.Description = "ノイズ強度の範囲。\r\n値を大きくすると、色ノイズと輝度ノイズの両方の強度が増加します。\r\n            デフォルト: (0.1, 0.5)";
            this.ParaIntensity.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.ParaIntensity.InvalidValue = "";
            this.ParaIntensity.Location = new System.Drawing.Point(3, 48);
            this.ParaIntensity.MaxValue = null;
            this.ParaIntensity.MaxVersion = null;
            this.ParaIntensity.MinimumSize = new System.Drawing.Size(124, 21);
            this.ParaIntensity.MinValue = null;
            this.ParaIntensity.MinVersion = null;
            this.ParaIntensity.Name = "ParaIntensity";
            this.ParaIntensity.Required = false;
            this.ParaIntensity.Size = new System.Drawing.Size(124, 39);
            this.ParaIntensity.TabIndex = 1;
            this.ParaIntensity.Title = "強度";
            this.ParaIntensity.UseLargeValue = false;
            this.ParaIntensity.UseValid = false;
            this.ParaIntensity.Value = "(0.1,0.5)";
            this.ParaIntensity.ValueType = FilterBase.Parts.PartsFunc.VALUE_TYPE.TYPE_FLOAT;
            this.ParaIntensity.ParameterChange += new FilterBase.Parts.ParameterChangeEventHandler(this.Param_ParameterChange);
            // 
            // ISONoise
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.FLPParam);
            this.Name = "ISONoise";
            this.Size = new System.Drawing.Size(128, 140);
            this.Target = FilterBase.BaseFilterControl.TRANSFORM_TARGET.IMAGE;
            this.Controls.SetChildIndex(this.FLPParam, 0);
            this.FLPParam.ResumeLayout(false);
            this.FLPParam.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ParaColorShift)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaIntensity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel FLPParam;
        private FilterBase.Parts.InputMaxMin ParaColorShift;
        private FilterBase.Parts.InputMaxMin ParaIntensity;
    }
}
