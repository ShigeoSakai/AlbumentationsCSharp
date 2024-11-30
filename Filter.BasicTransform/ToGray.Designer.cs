namespace Filter.BasicTransform
{
    partial class ToGray
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ToGray));
            this.FLPParam = new System.Windows.Forms.FlowLayoutPanel();
            this.ParaNumOutputChannels = new FilterBase.Parts.InputValueUpDown();
            this.ParaMethod = new FilterBase.Parts.ComboBoxWithLabelParts();
            this.FLPParam.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ParaNumOutputChannels)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaMethod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // FLPParam
            // 
            this.FLPParam.AutoSize = true;
            this.FLPParam.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.FLPParam.Controls.Add(this.ParaNumOutputChannels);
            this.FLPParam.Controls.Add(this.ParaMethod);
            this.FLPParam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FLPParam.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.FLPParam.Location = new System.Drawing.Point(0, 25);
            this.FLPParam.Name = "FLPParam";
            this.FLPParam.Size = new System.Drawing.Size(128, 71);
            this.FLPParam.TabIndex = 5;
            // 
            // ParaNumOutputChannels
            // 
            this.ParaNumOutputChannels.ArgumentName = "num_output_channels";
            this.ParaNumOutputChannels.AutoSize = true;
            this.ParaNumOutputChannels.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ParaNumOutputChannels.ControlLayout = FilterBase.Parts.InputValue.LAYOUT.Horizontal;
            this.ParaNumOutputChannels.DecimalPlace = 0;
            this.ParaNumOutputChannels.Description = "出力画像のチャンネル数。\r\n1 より大きい場合、グレースケール チャンネルが複製されます。\r\n　　　　デフォルト: 3。";
            this.ParaNumOutputChannels.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ParaNumOutputChannels.Location = new System.Drawing.Point(3, 3);
            this.ParaNumOutputChannels.MaxValue = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.ParaNumOutputChannels.MaxVersion = null;
            this.ParaNumOutputChannels.MinimumSize = new System.Drawing.Size(124, 21);
            this.ParaNumOutputChannels.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ParaNumOutputChannels.MinVersion = "1.4.15";
            this.ParaNumOutputChannels.Name = "ParaNumOutputChannels";
            this.ParaNumOutputChannels.Required = false;
            this.ParaNumOutputChannels.Size = new System.Drawing.Size(124, 21);
            this.ParaNumOutputChannels.TabIndex = 0;
            this.ParaNumOutputChannels.Title = "出力CH数";
            this.ParaNumOutputChannels.Unit = "";
            this.ParaNumOutputChannels.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.ParaNumOutputChannels.ValueType = FilterBase.Parts.InputValue.VALUE_TYPE.INT;
            this.ParaNumOutputChannels.ParameterChange += new FilterBase.Parts.ParameterChangeEventHandler(this.Param_ParameterChange);
            // 
            // ParaMethod
            // 
            this.ParaMethod.ArgumentName = "method";
            this.ParaMethod.AutoSize = true;
            this.ParaMethod.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ParaMethod.DefaultValue = "";
            this.ParaMethod.Description = resources.GetString("ParaMethod.Description");
            this.ParaMethod.ItemType = "System.String";
            this.ParaMethod.Location = new System.Drawing.Point(3, 30);
            this.ParaMethod.MaxVersion = null;
            this.ParaMethod.MinimumSize = new System.Drawing.Size(124, 21);
            this.ParaMethod.MinVersion = "1.4.15";
            this.ParaMethod.Name = "ParaMethod";
            this.ParaMethod.Required = false;
            this.ParaMethod.Size = new System.Drawing.Size(124, 38);
            this.ParaMethod.TabIndex = 1;
            this.ParaMethod.Title = "変換方法";
            this.ParaMethod.Value = null;
            this.ParaMethod.ParameterChange += new FilterBase.Parts.ParameterChangeEventHandler(this.Param_ParameterChange);
            // 
            // ToGray
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.FLPParam);
            this.Name = "ToGray";
            this.Size = new System.Drawing.Size(128, 121);
            this.Target = FilterBase.BaseFilterControl.TRANSFORM_TARGET.IMAGE;
            this.Controls.SetChildIndex(this.FLPParam, 0);
            this.FLPParam.ResumeLayout(false);
            this.FLPParam.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ParaNumOutputChannels)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaMethod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel FLPParam;
        private FilterBase.Parts.InputValueUpDown ParaNumOutputChannels;
        private FilterBase.Parts.ComboBoxWithLabelParts ParaMethod;
    }
}
