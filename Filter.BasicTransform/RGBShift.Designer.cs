namespace Filter.BasicTransform
{
    partial class RGBShift
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
            this.ParaRShiftLimit = new FilterBase.Parts.InputMaxMin();
            this.ParaGShiftLimit = new FilterBase.Parts.InputMaxMin();
            this.ParaBShiftLimit = new FilterBase.Parts.InputMaxMin();
            this.FLPParam.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ParaRShiftLimit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaGShiftLimit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaBShiftLimit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // FLPParam
            // 
            this.FLPParam.AutoSize = true;
            this.FLPParam.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.FLPParam.Controls.Add(this.ParaRShiftLimit);
            this.FLPParam.Controls.Add(this.ParaGShiftLimit);
            this.FLPParam.Controls.Add(this.ParaBShiftLimit);
            this.FLPParam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FLPParam.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.FLPParam.Location = new System.Drawing.Point(0, 25);
            this.FLPParam.Name = "FLPParam";
            this.FLPParam.Size = new System.Drawing.Size(128, 144);
            this.FLPParam.TabIndex = 5;
            // 
            // ParaRShiftLimit
            // 
            this.ParaRShiftLimit.ArgumentName = "r_shift_limit";
            this.ParaRShiftLimit.AutoSize = true;
            this.ParaRShiftLimit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ParaRShiftLimit.DecimalPlace = 0;
            this.ParaRShiftLimit.Description = "Rチャンネルの値を変更する範囲。\r\nデフォルト: (-20, 20)。";
            this.ParaRShiftLimit.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ParaRShiftLimit.Location = new System.Drawing.Point(3, 3);
            this.ParaRShiftLimit.MaxValue = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.ParaRShiftLimit.MaxVersion = null;
            this.ParaRShiftLimit.MinimumSize = new System.Drawing.Size(124, 21);
            this.ParaRShiftLimit.MinValue = new decimal(new int[] {
            255,
            0,
            0,
            -2147483648});
            this.ParaRShiftLimit.MinVersion = null;
            this.ParaRShiftLimit.Name = "ParaRShiftLimit";
            this.ParaRShiftLimit.Required = false;
            this.ParaRShiftLimit.Size = new System.Drawing.Size(124, 42);
            this.ParaRShiftLimit.TabIndex = 0;
            this.ParaRShiftLimit.Title = "R変更範囲";
            this.ParaRShiftLimit.Value = "(-20,20)";
            this.ParaRShiftLimit.ValueType = FilterBase.Parts.PartsFunc.VALUE_TYPE.TYPE_INT;
            this.ParaRShiftLimit.ParameterChange += new FilterBase.Parts.ParameterChangeEventHandler(this.Param_ParameterChange);
            // 
            // ParaGShiftLimit
            // 
            this.ParaGShiftLimit.ArgumentName = "g_shift_limit";
            this.ParaGShiftLimit.AutoSize = true;
            this.ParaGShiftLimit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ParaGShiftLimit.DecimalPlace = 0;
            this.ParaGShiftLimit.Description = "Gチャンネルの値を変更する範囲。\r\nデフォルト: (-20, 20)。";
            this.ParaGShiftLimit.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ParaGShiftLimit.Location = new System.Drawing.Point(3, 51);
            this.ParaGShiftLimit.MaxValue = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.ParaGShiftLimit.MaxVersion = null;
            this.ParaGShiftLimit.MinimumSize = new System.Drawing.Size(124, 21);
            this.ParaGShiftLimit.MinValue = new decimal(new int[] {
            255,
            0,
            0,
            -2147483648});
            this.ParaGShiftLimit.MinVersion = null;
            this.ParaGShiftLimit.Name = "ParaGShiftLimit";
            this.ParaGShiftLimit.Required = false;
            this.ParaGShiftLimit.Size = new System.Drawing.Size(124, 42);
            this.ParaGShiftLimit.TabIndex = 1;
            this.ParaGShiftLimit.Title = "G変更範囲";
            this.ParaGShiftLimit.Value = "(-20,20)";
            this.ParaGShiftLimit.ValueType = FilterBase.Parts.PartsFunc.VALUE_TYPE.TYPE_INT;
            this.ParaGShiftLimit.ParameterChange += new FilterBase.Parts.ParameterChangeEventHandler(this.Param_ParameterChange);
            // 
            // ParaBShiftLimit
            // 
            this.ParaBShiftLimit.ArgumentName = "b_shift_limit";
            this.ParaBShiftLimit.AutoSize = true;
            this.ParaBShiftLimit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ParaBShiftLimit.DecimalPlace = 0;
            this.ParaBShiftLimit.Description = "Bチャンネルの値を変更する範囲。\r\nデフォルト: (-20, 20)。";
            this.ParaBShiftLimit.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ParaBShiftLimit.Location = new System.Drawing.Point(3, 99);
            this.ParaBShiftLimit.MaxValue = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.ParaBShiftLimit.MaxVersion = null;
            this.ParaBShiftLimit.MinimumSize = new System.Drawing.Size(124, 21);
            this.ParaBShiftLimit.MinValue = new decimal(new int[] {
            255,
            0,
            0,
            -2147483648});
            this.ParaBShiftLimit.MinVersion = null;
            this.ParaBShiftLimit.Name = "ParaBShiftLimit";
            this.ParaBShiftLimit.Required = false;
            this.ParaBShiftLimit.Size = new System.Drawing.Size(124, 42);
            this.ParaBShiftLimit.TabIndex = 2;
            this.ParaBShiftLimit.Title = "B変更範囲";
            this.ParaBShiftLimit.Value = "(-20,20)";
            this.ParaBShiftLimit.ValueType = FilterBase.Parts.PartsFunc.VALUE_TYPE.TYPE_INT;
            this.ParaBShiftLimit.ParameterChange += new FilterBase.Parts.ParameterChangeEventHandler(this.Param_ParameterChange);
            // 
            // RGBShift
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.FLPParam);
            this.Name = "RGBShift";
            this.Size = new System.Drawing.Size(128, 194);
            this.Target = FilterBase.BaseFilterControl.TRANSFORM_TARGET.IMAGE;
            this.Controls.SetChildIndex(this.FLPParam, 0);
            this.FLPParam.ResumeLayout(false);
            this.FLPParam.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ParaRShiftLimit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaGShiftLimit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaBShiftLimit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel FLPParam;
        private FilterBase.Parts.InputMaxMin ParaRShiftLimit;
        private FilterBase.Parts.InputMaxMin ParaGShiftLimit;
        private FilterBase.Parts.InputMaxMin ParaBShiftLimit;
    }
}
