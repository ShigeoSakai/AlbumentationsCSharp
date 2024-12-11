namespace Filter.BasicTransform
{
    partial class ToFloat
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
            this.ParaMaxValue = new FilterBase.Parts.InputValue();
            this.FLPParam.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ParaMaxValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // FLPParam
            // 
            this.FLPParam.AutoSize = true;
            this.FLPParam.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.FLPParam.Controls.Add(this.ParaMaxValue);
            this.FLPParam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FLPParam.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.FLPParam.Location = new System.Drawing.Point(0, 24);
            this.FLPParam.Name = "FLPParam";
            this.FLPParam.Size = new System.Drawing.Size(128, 49);
            this.FLPParam.TabIndex = 5;
            // 
            // ParaMaxValue
            // 
            this.ParaMaxValue.ArgumentName = "max_value";
            this.ParaMaxValue.AutoSize = true;
            this.ParaMaxValue.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ParaMaxValue.ControlLayout = FilterBase.Parts.InputValue.LAYOUT.Horizontal;
            this.ParaMaxValue.DecimalPlace = 0;
            this.ParaMaxValue.Description = "入力可能な最大値。\r\nNone の場合、変換は入力画像のデータ型を調べて最大値を推測しようとします:\r\n　- uint8: 255\r\n　- uint16: 655" +
    "35\r\n　- uint32: 4294967295\r\n　- float32: 1.0\r\n　　　デフォルト: None。";
            this.ParaMaxValue.InvalidValue = "";
            this.ParaMaxValue.Location = new System.Drawing.Point(3, 3);
            this.ParaMaxValue.MaxValue = null;
            this.ParaMaxValue.MaxVersion = null;
            this.ParaMaxValue.MinimumSize = new System.Drawing.Size(124, 21);
            this.ParaMaxValue.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ParaMaxValue.MinVersion = null;
            this.ParaMaxValue.Name = "ParaMaxValue";
            this.ParaMaxValue.Required = false;
            this.ParaMaxValue.Size = new System.Drawing.Size(124, 43);
            this.ParaMaxValue.TabIndex = 0;
            this.ParaMaxValue.Title = "最大値";
            this.ParaMaxValue.Unit = "";
            this.ParaMaxValue.UseValid = true;
            this.ParaMaxValue.Valid = false;
            this.ParaMaxValue.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.ParaMaxValue.ValueType = FilterBase.Parts.InputValue.VALUE_TYPE.INT;
            this.ParaMaxValue.ParameterChange += new FilterBase.Parts.ParameterChangeEventHandler(this.Param_ParameterChange);
            // 
            // ToFloat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.FLPParam);
            this.Name = "ToFloat";
            this.Size = new System.Drawing.Size(128, 98);
            this.Controls.SetChildIndex(this.FLPParam, 0);
            this.FLPParam.ResumeLayout(false);
            this.FLPParam.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ParaMaxValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel FLPParam;
        private FilterBase.Parts.InputValue ParaMaxValue;
    }
}
