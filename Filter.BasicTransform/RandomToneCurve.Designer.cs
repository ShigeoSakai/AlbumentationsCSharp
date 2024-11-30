namespace Filter.BasicTransform
{
    partial class RandomToneCurve
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
            this.ParaScale = new FilterBase.Parts.InputTrackBar();
            this.ParaPerChannel = new FilterBase.Parts.CheckBoxParts();
            this.FLPParam.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ParaScale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // FLPParam
            // 
            this.FLPParam.AutoSize = true;
            this.FLPParam.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.FLPParam.Controls.Add(this.ParaScale);
            this.FLPParam.Controls.Add(this.ParaPerChannel);
            this.FLPParam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FLPParam.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.FLPParam.Location = new System.Drawing.Point(0, 25);
            this.FLPParam.Name = "FLPParam";
            this.FLPParam.Size = new System.Drawing.Size(128, 98);
            this.FLPParam.TabIndex = 5;
            // 
            // ParaScale
            // 
            this.ParaScale.ArgumentName = "scale";
            this.ParaScale.AutoSize = true;
            this.ParaScale.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ParaScale.DecimalPlace = 1;
            this.ParaScale.Description = "画像の曲線を変更する 2 つの制御点を移動するためにランダムな距離をサンプリングするために使用される正規分布の標準偏差。\r\n値は [0, 1] の範囲でなければな" +
    "りません。\r\n値が大きいほど、画像の変化はより劇的になります。\r\n　　　デフォルト: 0.1";
            this.ParaScale.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.ParaScale.Location = new System.Drawing.Point(3, 3);
            this.ParaScale.MaxValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ParaScale.MaxVersion = null;
            this.ParaScale.MinimumSize = new System.Drawing.Size(124, 21);
            this.ParaScale.MinValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.ParaScale.MinVersion = null;
            this.ParaScale.Name = "ParaScale";
            this.ParaScale.Required = false;
            this.ParaScale.Size = new System.Drawing.Size(124, 65);
            this.ParaScale.TabIndex = 0;
            this.ParaScale.Title = "スケール";
            this.ParaScale.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.ParaScale.ParameterChange += new FilterBase.Parts.ParameterChangeEventHandler(this.Param_ParameterChange);
            // 
            // ParaPerChannel
            // 
            this.ParaPerChannel.ArgumentName = "per_channel";
            this.ParaPerChannel.AutoSize = true;
            this.ParaPerChannel.CheckedValue = "";
            this.ParaPerChannel.Description = "True の場合、トーン カーブは入力画像の各チャネルに個別に適用され、色の歪みが生じる可能性があります。\r\nFalse の場合、同じカーブがすべてのチャネルに適" +
    "用され、元の色の関係が保持されます。\r\n　　　デフォルト: False";
            this.ParaPerChannel.IndeterminateValue = "";
            this.ParaPerChannel.Location = new System.Drawing.Point(3, 74);
            this.ParaPerChannel.Margin = new System.Windows.Forms.Padding(3, 3, 1, 3);
            this.ParaPerChannel.MaxVersion = null;
            this.ParaPerChannel.MinimumSize = new System.Drawing.Size(122, 21);
            this.ParaPerChannel.MinVersion = "1.4.11";
            this.ParaPerChannel.Name = "ParaPerChannel";
            this.ParaPerChannel.Size = new System.Drawing.Size(122, 21);
            this.ParaPerChannel.TabIndex = 1;
            this.ParaPerChannel.Text = "CH毎に適用する";
            this.ParaPerChannel.Title = "CH毎に適用する";
            this.HelpToolTip.SetToolTip(this.ParaPerChannel, "True の場合、トーン カーブは入力画像の各チャネルに個別に適用され、色の歪みが生じる可能性があります。\r\nFalse の場合、同じカーブがすべてのチャネルに適" +
        "用され、元の色の関係が保持されます。\r\n　　　デフォルト: False");
            this.ParaPerChannel.UncheckedValue = "";
            this.ParaPerChannel.UseVisualStyleBackColor = true;
            this.ParaPerChannel.Value = "Unchecked";
            this.ParaPerChannel.ParameterChange += new FilterBase.Parts.ParameterChangeEventHandler(this.Param_ParameterChange);
            // 
            // RandomToneCurve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.FLPParam);
            this.Name = "RandomToneCurve";
            this.Size = new System.Drawing.Size(128, 148);
            this.Target = FilterBase.BaseFilterControl.TRANSFORM_TARGET.IMAGE;
            this.Controls.SetChildIndex(this.FLPParam, 0);
            this.FLPParam.ResumeLayout(false);
            this.FLPParam.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ParaScale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel FLPParam;
        private FilterBase.Parts.InputTrackBar ParaScale;
        private FilterBase.Parts.CheckBoxParts ParaPerChannel;
    }
}
