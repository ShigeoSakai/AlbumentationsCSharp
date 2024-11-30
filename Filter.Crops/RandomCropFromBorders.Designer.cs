namespace Filter.Crops
{
    partial class RandomCropFromBorders
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
            this.ParaCropLeft = new FilterBase.Parts.InputTrackBar();
            this.ParaCropRight = new FilterBase.Parts.InputTrackBar();
            this.ParaCropTop = new FilterBase.Parts.InputTrackBar();
            this.ParaCropBottom = new FilterBase.Parts.InputTrackBar();
            this.FLPParam.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ParaCropLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaCropRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaCropTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaCropBottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // FLPParam
            // 
            this.FLPParam.AutoSize = true;
            this.FLPParam.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.FLPParam.Controls.Add(this.ParaCropLeft);
            this.FLPParam.Controls.Add(this.ParaCropRight);
            this.FLPParam.Controls.Add(this.ParaCropTop);
            this.FLPParam.Controls.Add(this.ParaCropBottom);
            this.FLPParam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FLPParam.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.FLPParam.Location = new System.Drawing.Point(0, 25);
            this.FLPParam.Name = "FLPParam";
            this.FLPParam.Size = new System.Drawing.Size(128, 284);
            this.FLPParam.TabIndex = 5;
            // 
            // ParaCropLeft
            // 
            this.ParaCropLeft.ArgumentName = "crop_left";
            this.ParaCropLeft.AutoSize = true;
            this.ParaCropLeft.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ParaCropLeft.DecimalPlace = 1;
            this.ParaCropLeft.Description = "左側から切り取る幅の最大割合。\r\n範囲は [0.0, 1.0] である必要があります。\r\n　　デフォルト: 0.1";
            this.ParaCropLeft.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.ParaCropLeft.Location = new System.Drawing.Point(3, 3);
            this.ParaCropLeft.MaxValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ParaCropLeft.MaxVersion = null;
            this.ParaCropLeft.MinimumSize = new System.Drawing.Size(124, 21);
            this.ParaCropLeft.MinValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.ParaCropLeft.MinVersion = null;
            this.ParaCropLeft.Name = "ParaCropLeft";
            this.ParaCropLeft.Required = false;
            this.ParaCropLeft.Size = new System.Drawing.Size(124, 65);
            this.ParaCropLeft.TabIndex = 0;
            this.ParaCropLeft.Title = "左側から切り取る幅";
            this.ParaCropLeft.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.ParaCropLeft.ParameterChange += new FilterBase.Parts.ParameterChangeEventHandler(this.Param_ParameterChange);
            // 
            // ParaCropRight
            // 
            this.ParaCropRight.ArgumentName = "crop_right";
            this.ParaCropRight.AutoSize = true;
            this.ParaCropRight.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ParaCropRight.DecimalPlace = 1;
            this.ParaCropRight.Description = "右側から切り取る幅の最大割合。\r\n範囲は [0.0, 1.0] である必要があります。\r\n　　デフォルト: 0.1";
            this.ParaCropRight.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.ParaCropRight.Location = new System.Drawing.Point(3, 74);
            this.ParaCropRight.MaxValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ParaCropRight.MaxVersion = null;
            this.ParaCropRight.MinimumSize = new System.Drawing.Size(124, 21);
            this.ParaCropRight.MinValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.ParaCropRight.MinVersion = null;
            this.ParaCropRight.Name = "ParaCropRight";
            this.ParaCropRight.Required = false;
            this.ParaCropRight.Size = new System.Drawing.Size(124, 65);
            this.ParaCropRight.TabIndex = 1;
            this.ParaCropRight.Title = "右側から切り取る幅";
            this.ParaCropRight.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.ParaCropRight.ParameterChange += new FilterBase.Parts.ParameterChangeEventHandler(this.Param_ParameterChange);
            // 
            // ParaCropTop
            // 
            this.ParaCropTop.ArgumentName = "crop_top";
            this.ParaCropTop.AutoSize = true;
            this.ParaCropTop.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ParaCropTop.DecimalPlace = 1;
            this.ParaCropTop.Description = "上から切り取る高さの最大割合。\r\n範囲は [0.0, 1.0] である必要があります。\r\n　　デフォルト: 0.1";
            this.ParaCropTop.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.ParaCropTop.Location = new System.Drawing.Point(3, 145);
            this.ParaCropTop.MaxValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ParaCropTop.MaxVersion = null;
            this.ParaCropTop.MinimumSize = new System.Drawing.Size(124, 21);
            this.ParaCropTop.MinValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.ParaCropTop.MinVersion = null;
            this.ParaCropTop.Name = "ParaCropTop";
            this.ParaCropTop.Required = false;
            this.ParaCropTop.Size = new System.Drawing.Size(124, 65);
            this.ParaCropTop.TabIndex = 2;
            this.ParaCropTop.Title = "上から切り取る高さ";
            this.ParaCropTop.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.ParaCropTop.ParameterChange += new FilterBase.Parts.ParameterChangeEventHandler(this.Param_ParameterChange);
            // 
            // ParaCropBottom
            // 
            this.ParaCropBottom.ArgumentName = "crop_bottom";
            this.ParaCropBottom.AutoSize = true;
            this.ParaCropBottom.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ParaCropBottom.DecimalPlace = 1;
            this.ParaCropBottom.Description = "下から切り取る高さの最大割合。\r\n範囲は [0.0, 1.0] である必要があります。\r\nデフォルト: 0.1";
            this.ParaCropBottom.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.ParaCropBottom.Location = new System.Drawing.Point(3, 216);
            this.ParaCropBottom.MaxValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ParaCropBottom.MaxVersion = null;
            this.ParaCropBottom.MinimumSize = new System.Drawing.Size(124, 21);
            this.ParaCropBottom.MinValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.ParaCropBottom.MinVersion = null;
            this.ParaCropBottom.Name = "ParaCropBottom";
            this.ParaCropBottom.Required = false;
            this.ParaCropBottom.Size = new System.Drawing.Size(124, 65);
            this.ParaCropBottom.TabIndex = 3;
            this.ParaCropBottom.Title = "下から切り取る高さ";
            this.ParaCropBottom.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.ParaCropBottom.ParameterChange += new FilterBase.Parts.ParameterChangeEventHandler(this.Param_ParameterChange);
            // 
            // RandomCropFromBorders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.FLPParam);
            this.Name = "RandomCropFromBorders";
            this.Size = new System.Drawing.Size(128, 334);
            this.Controls.SetChildIndex(this.FLPParam, 0);
            this.FLPParam.ResumeLayout(false);
            this.FLPParam.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ParaCropLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaCropRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaCropTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaCropBottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel FLPParam;
        private FilterBase.Parts.InputTrackBar ParaCropLeft;
        private FilterBase.Parts.InputTrackBar ParaCropRight;
        private FilterBase.Parts.InputTrackBar ParaCropTop;
        private FilterBase.Parts.InputTrackBar ParaCropBottom;
    }
}
