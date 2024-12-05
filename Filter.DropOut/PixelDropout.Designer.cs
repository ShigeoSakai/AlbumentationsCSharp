namespace Filter.DropOut
{
    partial class PixelDropout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PixelDropout));
            this.FLPParam = new System.Windows.Forms.FlowLayoutPanel();
            this.ParaDopoutProb = new FilterBase.Parts.InputTrackBar();
            this.ParaPerChannel = new FilterBase.Parts.CheckBoxParts();
            this.ParaDropValue = new FilterBase.Parts.InputValueUpDown();
            this.ParaMaskDropValue = new FilterBase.Parts.InputValueUpDown();
            this.FLPParam.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ParaDopoutProb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaDropValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaMaskDropValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // FLPParam
            // 
            this.FLPParam.AutoSize = true;
            this.FLPParam.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.FLPParam.Controls.Add(this.ParaDopoutProb);
            this.FLPParam.Controls.Add(this.ParaPerChannel);
            this.FLPParam.Controls.Add(this.ParaDropValue);
            this.FLPParam.Controls.Add(this.ParaMaskDropValue);
            this.FLPParam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FLPParam.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.FLPParam.Location = new System.Drawing.Point(0, 25);
            this.FLPParam.Name = "FLPParam";
            this.FLPParam.Size = new System.Drawing.Size(128, 236);
            this.FLPParam.TabIndex = 5;
            // 
            // ParaDopoutProb
            // 
            this.ParaDopoutProb.ArgumentName = "dropout_prob";
            this.ParaDopoutProb.AutoSize = true;
            this.ParaDopoutProb.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ParaDopoutProb.DecimalPlace = 2;
            this.ParaDopoutProb.Description = "各ピクセルをドロップアウトする確率。\r\n範囲は [0, 1] である必要があります。\r\n　　　デフォルト: 0.01";
            this.ParaDopoutProb.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.ParaDopoutProb.InvalidValue = "";
            this.ParaDopoutProb.Location = new System.Drawing.Point(3, 3);
            this.ParaDopoutProb.MaxValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ParaDopoutProb.MaxVersion = null;
            this.ParaDopoutProb.MinimumSize = new System.Drawing.Size(124, 21);
            this.ParaDopoutProb.MinValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.ParaDopoutProb.MinVersion = null;
            this.ParaDopoutProb.Name = "ParaDopoutProb";
            this.ParaDopoutProb.Required = false;
            this.ParaDopoutProb.Size = new System.Drawing.Size(124, 77);
            this.ParaDopoutProb.TabIndex = 8;
            this.ParaDopoutProb.Title = "ピクセルをドロップアウトする確率";
            this.ParaDopoutProb.UseValid = false;
            this.ParaDopoutProb.Valid = true;
            this.ParaDopoutProb.Value = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.ParaDopoutProb.ParameterChange += new FilterBase.Parts.ParameterChangeEventHandler(this.Param_ParameterChange);
            // 
            // ParaPerChannel
            // 
            this.ParaPerChannel.ArgumentName = "per_channel";
            this.ParaPerChannel.AutoSize = true;
            this.ParaPerChannel.CheckedValue = "";
            this.ParaPerChannel.Description = "True の場合、ドロップアウト マスクは各チャネルごとに個別に生成されます。\r\nFalse の場合、同じドロップアウト マスクがすべてのチャネルに適用されます。" +
    "\r\n　　　デフォルト: False";
            this.ParaPerChannel.IndeterminateValue = "";
            this.ParaPerChannel.Location = new System.Drawing.Point(3, 86);
            this.ParaPerChannel.Margin = new System.Windows.Forms.Padding(3, 3, 1, 3);
            this.ParaPerChannel.MaxVersion = null;
            this.ParaPerChannel.MinimumSize = new System.Drawing.Size(122, 21);
            this.ParaPerChannel.MinVersion = "1.4.11";
            this.ParaPerChannel.Name = "ParaPerChannel";
            this.ParaPerChannel.Size = new System.Drawing.Size(122, 21);
            this.ParaPerChannel.TabIndex = 7;
            this.ParaPerChannel.Text = "CH毎にマスク生成";
            this.ParaPerChannel.Title = "CH毎にマスク生成";
            this.HelpToolTip.SetToolTip(this.ParaPerChannel, "True の場合、ドロップアウト マスクは各チャネルごとに個別に生成されます。\r\nFalse の場合、同じドロップアウト マスクがすべてのチャネルに適用されます。" +
        "\r\n　　　デフォルト: False");
            this.ParaPerChannel.UncheckedValue = "";
            this.ParaPerChannel.UseVisualStyleBackColor = true;
            this.ParaPerChannel.Value = "Unchecked";
            this.ParaPerChannel.ParameterChange += new FilterBase.Parts.ParameterChangeEventHandler(this.Param_ParameterChange);
            this.ParaPerChannel.CheckedChanged += new System.EventHandler(this.ParaPerChannel_CheckedChanged);
            // 
            // ParaDropValue
            // 
            this.ParaDropValue.ArgumentName = "drop_value";
            this.ParaDropValue.AutoSize = true;
            this.ParaDropValue.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ParaDropValue.ControlLayout = FilterBase.Parts.InputValue.LAYOUT.Vertical;
            this.ParaDropValue.DecimalPlace = 2;
            this.ParaDropValue.Description = resources.GetString("ParaDropValue.Description");
            this.ParaDropValue.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.ParaDropValue.InvalidValue = "";
            this.ParaDropValue.Location = new System.Drawing.Point(3, 113);
            this.ParaDropValue.MaxValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ParaDropValue.MaxVersion = null;
            this.ParaDropValue.MinimumSize = new System.Drawing.Size(124, 21);
            this.ParaDropValue.MinValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.ParaDropValue.MinVersion = null;
            this.ParaDropValue.Name = "ParaDropValue";
            this.ParaDropValue.Required = false;
            this.ParaDropValue.Size = new System.Drawing.Size(124, 57);
            this.ParaDropValue.TabIndex = 9;
            this.ParaDropValue.Title = "ドロップアウトピクセル値";
            this.ParaDropValue.Unit = "";
            this.ParaDropValue.UseValid = true;
            this.ParaDropValue.Valid = false;
            this.ParaDropValue.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.ParaDropValue.ValueType = FilterBase.Parts.InputValue.VALUE_TYPE.FLOAT;
            this.ParaDropValue.ParameterChange += new FilterBase.Parts.ParameterChangeEventHandler(this.Param_ParameterChange);
            // 
            // ParaMaskDropValue
            // 
            this.ParaMaskDropValue.ArgumentName = "mask_drop_value";
            this.ParaMaskDropValue.AutoSize = true;
            this.ParaMaskDropValue.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ParaMaskDropValue.ControlLayout = FilterBase.Parts.InputValue.LAYOUT.Vertical;
            this.ParaMaskDropValue.DecimalPlace = 2;
            this.ParaMaskDropValue.Description = "マスク内のドロップされたピクセルに割り当てる値。\r\nNone の場合、マスクは変更されません。\r\n単一の数値の場合、その値はマスク内のすべてのドロップされたピクセ" +
    "ルに使用されます。\r\nシーケンスの場合、マスクのチャネルごとに 1 つの値を含める必要があります。\r\n注: per_channel=False の場合にのみ適用" +
    "されます。\r\n　　　デフォルト: None";
            this.ParaMaskDropValue.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.ParaMaskDropValue.InvalidValue = "";
            this.ParaMaskDropValue.Location = new System.Drawing.Point(3, 176);
            this.ParaMaskDropValue.MaxValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ParaMaskDropValue.MaxVersion = null;
            this.ParaMaskDropValue.MinimumSize = new System.Drawing.Size(124, 21);
            this.ParaMaskDropValue.MinValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.ParaMaskDropValue.MinVersion = null;
            this.ParaMaskDropValue.Name = "ParaMaskDropValue";
            this.ParaMaskDropValue.Required = false;
            this.ParaMaskDropValue.Size = new System.Drawing.Size(124, 57);
            this.ParaMaskDropValue.TabIndex = 10;
            this.ParaMaskDropValue.Title = "ドロップアウトマスク値";
            this.ParaMaskDropValue.Unit = "";
            this.ParaMaskDropValue.UseValid = true;
            this.ParaMaskDropValue.Valid = false;
            this.ParaMaskDropValue.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.ParaMaskDropValue.ValueType = FilterBase.Parts.InputValue.VALUE_TYPE.FLOAT;
            this.ParaMaskDropValue.ParameterChange += new FilterBase.Parts.ParameterChangeEventHandler(this.Param_ParameterChange);
            // 
            // PixelDropout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.FLPParam);
            this.Name = "PixelDropout";
            this.Size = new System.Drawing.Size(128, 286);
            this.Controls.SetChildIndex(this.FLPParam, 0);
            this.FLPParam.ResumeLayout(false);
            this.FLPParam.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ParaDopoutProb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaDropValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaMaskDropValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel FLPParam;
        private FilterBase.Parts.CheckBoxParts ParaPerChannel;
        private FilterBase.Parts.InputTrackBar ParaDopoutProb;
        private FilterBase.Parts.InputValueUpDown ParaDropValue;
        private FilterBase.Parts.InputValueUpDown ParaMaskDropValue;
    }
}
