namespace Filter.BasicTransform
{
    partial class MultiplicativeNoise
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
            this.ParaMultiplier = new FilterBase.Parts.InputMaxMin();
            this.ParaPerChannel = new FilterBase.Parts.CheckBoxParts();
            this.ParaElementwise = new FilterBase.Parts.CheckBoxParts();
            this.FLPParam.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ParaMultiplier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // FLPParam
            // 
            this.FLPParam.AutoSize = true;
            this.FLPParam.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.FLPParam.Controls.Add(this.ParaMultiplier);
            this.FLPParam.Controls.Add(this.ParaPerChannel);
            this.FLPParam.Controls.Add(this.ParaElementwise);
            this.FLPParam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FLPParam.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.FLPParam.Location = new System.Drawing.Point(0, 25);
            this.FLPParam.Name = "FLPParam";
            this.FLPParam.Size = new System.Drawing.Size(128, 127);
            this.FLPParam.TabIndex = 5;
            // 
            // ParaMultiplier
            // 
            this.ParaMultiplier.ArgumentName = "multiplier";
            this.ParaMultiplier.AutoSize = true;
            this.ParaMultiplier.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ParaMultiplier.DecimalPlace = 1;
            this.ParaMultiplier.Description = "ランダム乗数の範囲。\r\n乗数がサンプリングされる範囲を定義します。\r\n　　デフォルト: (0.9, 1.1)";
            this.ParaMultiplier.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.ParaMultiplier.Location = new System.Drawing.Point(3, 3);
            this.ParaMultiplier.MaxValue = null;
            this.ParaMultiplier.MaxVersion = null;
            this.ParaMultiplier.MinimumSize = new System.Drawing.Size(124, 21);
            this.ParaMultiplier.MinValue = null;
            this.ParaMultiplier.MinVersion = null;
            this.ParaMultiplier.Name = "ParaMultiplier";
            this.ParaMultiplier.Required = false;
            this.ParaMultiplier.Size = new System.Drawing.Size(124, 42);
            this.ParaMultiplier.TabIndex = 0;
            this.ParaMultiplier.Title = "ランダム乗数の範囲";
            this.ParaMultiplier.Value = "(0.9,1.1)";
            this.ParaMultiplier.ValueType = FilterBase.Parts.PartsFunc.VALUE_TYPE.TYPE_FLOAT;
            this.ParaMultiplier.ParameterChange += new FilterBase.Parts.ParameterChangeEventHandler(this.Param_ParameterChange);
            // 
            // ParaPerChannel
            // 
            this.ParaPerChannel.ArgumentName = "per_channel";
            this.ParaPerChannel.CheckedValue = "";
            this.ParaPerChannel.Description = "True の場合、各チャネルに異なるランダム乗数を使用します。\r\nFalse の場合、すべてのチャネルに同じ乗数を使用します。\r\nこれを False に設定すると" +
    "、若干速くなります。\r\n　　　デフォルト: False";
            this.ParaPerChannel.IndeterminateValue = "";
            this.ParaPerChannel.Location = new System.Drawing.Point(3, 51);
            this.ParaPerChannel.Margin = new System.Windows.Forms.Padding(3, 3, 1, 3);
            this.ParaPerChannel.MaxVersion = null;
            this.ParaPerChannel.MinimumSize = new System.Drawing.Size(122, 21);
            this.ParaPerChannel.MinVersion = null;
            this.ParaPerChannel.Name = "ParaPerChannel";
            this.ParaPerChannel.Size = new System.Drawing.Size(122, 34);
            this.ParaPerChannel.TabIndex = 1;
            this.ParaPerChannel.Text = "CH毎に異なる乗数を使用する";
            this.ParaPerChannel.Title = "CH毎に異なる乗数を使用する";
            this.ParaPerChannel.UncheckedValue = "";
            this.ParaPerChannel.UseVisualStyleBackColor = true;
            this.ParaPerChannel.Value = "Unchecked";
            this.ParaPerChannel.ParameterChange += new FilterBase.Parts.ParameterChangeEventHandler(this.Param_ParameterChange);
            // 
            // ParaElementwise
            // 
            this.ParaElementwise.ArgumentName = "elementwise";
            this.ParaElementwise.CheckedValue = "";
            this.ParaElementwise.Description = "True の場合、各ピクセルに固有の乗数を生成します。\r\nFalse の場合、単一の乗数を生成します (per_channel=True の場合はチャネルごとに " +
    "1 つ)。\r\n　　デフォルト: False";
            this.ParaElementwise.IndeterminateValue = "";
            this.ParaElementwise.Location = new System.Drawing.Point(3, 91);
            this.ParaElementwise.Margin = new System.Windows.Forms.Padding(3, 3, 1, 3);
            this.ParaElementwise.MaxVersion = null;
            this.ParaElementwise.MinimumSize = new System.Drawing.Size(122, 21);
            this.ParaElementwise.MinVersion = null;
            this.ParaElementwise.Name = "ParaElementwise";
            this.ParaElementwise.Size = new System.Drawing.Size(122, 33);
            this.ParaElementwise.TabIndex = 2;
            this.ParaElementwise.Text = "各ピクセルに固有の乗数を使用";
            this.ParaElementwise.Title = "各ピクセルに固有の乗数を使用";
            this.ParaElementwise.UncheckedValue = "";
            this.ParaElementwise.UseVisualStyleBackColor = true;
            this.ParaElementwise.Value = "Unchecked";
            this.ParaElementwise.ParameterChange += new FilterBase.Parts.ParameterChangeEventHandler(this.Param_ParameterChange);
            // 
            // MultiplicativeNoise
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.FLPParam);
            this.Name = "MultiplicativeNoise";
            this.Size = new System.Drawing.Size(128, 177);
            this.Target = FilterBase.BaseFilterControl.TRANSFORM_TARGET.IMAGE;
            this.Controls.SetChildIndex(this.FLPParam, 0);
            this.FLPParam.ResumeLayout(false);
            this.FLPParam.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ParaMultiplier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel FLPParam;
        private FilterBase.Parts.InputMaxMin ParaMultiplier;
        private FilterBase.Parts.CheckBoxParts ParaPerChannel;
        private FilterBase.Parts.CheckBoxParts ParaElementwise;
    }
}
