namespace Filter.BasicTransform
{
	partial class Normalize
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Normalize));
			this.FLPParam = new System.Windows.Forms.FlowLayoutPanel();
			this.ParaMean = new FilterBase.Parts.Input3Tuple();
			this.ParaStd = new FilterBase.Parts.Input3Tuple();
			this.ParaMaxPixelValue = new FilterBase.Parts.InputValueUpDown();
			this.ParaNormalization = new FilterBase.Parts.ComboBoxWithLabelParts();
			this.FLPParam.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.ParaMean)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ParaStd)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ParaMaxPixelValue)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ParaNormalization)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
			this.SuspendLayout();
			// 
			// FLPParam
			// 
			this.FLPParam.AutoSize = true;
			this.FLPParam.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.FLPParam.Controls.Add(this.ParaMean);
			this.FLPParam.Controls.Add(this.ParaStd);
			this.FLPParam.Controls.Add(this.ParaMaxPixelValue);
			this.FLPParam.Controls.Add(this.ParaNormalization);
			this.FLPParam.Dock = System.Windows.Forms.DockStyle.Fill;
			this.FLPParam.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
			this.FLPParam.Location = new System.Drawing.Point(0, 24);
			this.FLPParam.Name = "FLPParam";
			this.FLPParam.Size = new System.Drawing.Size(128, 297);
			this.FLPParam.TabIndex = 5;
			// 
			// ParaMean
			// 
			this.ParaMean.ArgumentName = "mean";
			this.ParaMean.AutoSize = true;
			this.ParaMean.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ParaMean.ControlLayout = FilterBase.Parts.InputValue.LAYOUT.Horizontal;
			this.ParaMean.DecimalPlace = 3;
			this.ParaMean.Description = "標準正規化の平均値。\r\n「標準」正規化の場合、デフォルト値は ImageNet 平均値 (0.485、0.456、0.406) です。";
			this.ParaMean.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
			this.ParaMean.InvalidValue = "";
			this.ParaMean.Label1 = "R";
			this.ParaMean.Label2 = "G";
			this.ParaMean.Label3 = "B";
			this.ParaMean.Location = new System.Drawing.Point(3, 3);
			this.ParaMean.MaxValue = "";
			this.ParaMean.MaxVersion = null;
			this.ParaMean.MinimumSize = new System.Drawing.Size(124, 21);
			this.ParaMean.MinValue = "";
			this.ParaMean.MinVersion = null;
			this.ParaMean.Name = "ParaMean";
			this.ParaMean.Required = false;
			this.ParaMean.Size = new System.Drawing.Size(124, 89);
			this.ParaMean.TabIndex = 0;
			this.ParaMean.Title = "平均値";
			this.ParaMean.UseValid = false;
			this.ParaMean.Valid = true;
			this.ParaMean.Value = "(0.485,0.456,0.456)";
			this.ParaMean.ValueType = FilterBase.Parts.PartsFunc.VALUE_TYPE.TYPE_FLOAT;
			this.ParaMean.ParameterChange += new FilterBase.Parts.ParameterChangeEventHandler(this.Param_ParameterChange);
			// 
			// ParaStd
			// 
			this.ParaStd.ArgumentName = "std";
			this.ParaStd.AutoSize = true;
			this.ParaStd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ParaStd.ControlLayout = FilterBase.Parts.InputValue.LAYOUT.Horizontal;
			this.ParaStd.DecimalPlace = 3;
			this.ParaStd.Description = "標準正規化の標準偏差値。\r\n「標準」正規化の場合、デフォルト値は ImageNet 標準偏差 :(0.229、0.224、0.225) です。";
			this.ParaStd.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
			this.ParaStd.InvalidValue = "";
			this.ParaStd.Label1 = "R";
			this.ParaStd.Label2 = "G";
			this.ParaStd.Label3 = "B";
			this.ParaStd.Location = new System.Drawing.Point(3, 98);
			this.ParaStd.MaxValue = "";
			this.ParaStd.MaxVersion = null;
			this.ParaStd.MinimumSize = new System.Drawing.Size(124, 21);
			this.ParaStd.MinValue = "";
			this.ParaStd.MinVersion = null;
			this.ParaStd.Name = "ParaStd";
			this.ParaStd.Required = false;
			this.ParaStd.Size = new System.Drawing.Size(124, 89);
			this.ParaStd.TabIndex = 1;
			this.ParaStd.Title = "標準偏差値";
			this.ParaStd.UseValid = false;
			this.ParaStd.Valid = true;
			this.ParaStd.Value = "(0.229,0.224,0.224)";
			this.ParaStd.ValueType = FilterBase.Parts.PartsFunc.VALUE_TYPE.TYPE_FLOAT;
			this.ParaStd.ParameterChange += new FilterBase.Parts.ParameterChangeEventHandler(this.Param_ParameterChange);
			// 
			// ParaMaxPixelValue
			// 
			this.ParaMaxPixelValue.ArgumentName = "max_pixel_value";
			this.ParaMaxPixelValue.AutoSize = true;
			this.ParaMaxPixelValue.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ParaMaxPixelValue.ControlLayout = FilterBase.Parts.InputValue.LAYOUT.Vertical;
			this.ParaMaxPixelValue.DecimalPlace = 2;
			this.ParaMaxPixelValue.Description = "標準正規化でのスケーリングに使用される、最大可能ピクセル値。\r\nデフォルトは 255.0 です。";
			this.ParaMaxPixelValue.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
			this.ParaMaxPixelValue.InvalidValue = "";
			this.ParaMaxPixelValue.Location = new System.Drawing.Point(3, 193);
			this.ParaMaxPixelValue.MaxValue = new decimal(new int[] {
            255,
            0,
            0,
            0});
			this.ParaMaxPixelValue.MaxVersion = null;
			this.ParaMaxPixelValue.MinimumSize = new System.Drawing.Size(124, 21);
			this.ParaMaxPixelValue.MinValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
			this.ParaMaxPixelValue.MinVersion = null;
			this.ParaMaxPixelValue.Name = "ParaMaxPixelValue";
			this.ParaMaxPixelValue.Required = false;
			this.ParaMaxPixelValue.Size = new System.Drawing.Size(124, 57);
			this.ParaMaxPixelValue.TabIndex = 2;
			this.ParaMaxPixelValue.Title = "最大可能ピクセル値";
			this.ParaMaxPixelValue.Unit = "";
			this.ParaMaxPixelValue.UseValid = true;
			this.ParaMaxPixelValue.Valid = true;
			this.ParaMaxPixelValue.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
			this.ParaMaxPixelValue.ValueType = FilterBase.Parts.InputValue.VALUE_TYPE.FLOAT;
			this.ParaMaxPixelValue.ParameterChange += new FilterBase.Parts.ParameterChangeEventHandler(this.Param_ParameterChange);
			// 
			// ParaNormalization
			// 
			this.ParaNormalization.ArgumentName = "normalization";
			this.ParaNormalization.AutoSize = true;
			this.ParaNormalization.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ParaNormalization.DefaultValue = "";
			this.ParaNormalization.Description = resources.GetString("ParaNormalization.Description");
			this.ParaNormalization.InvalidValue = "";
			this.ParaNormalization.ItemType = "System.String";
			this.ParaNormalization.Location = new System.Drawing.Point(3, 256);
			this.ParaNormalization.MaxVersion = null;
			this.ParaNormalization.MinimumSize = new System.Drawing.Size(124, 21);
			this.ParaNormalization.MinVersion = null;
			this.ParaNormalization.Name = "ParaNormalization";
			this.ParaNormalization.Required = false;
			this.ParaNormalization.Size = new System.Drawing.Size(124, 38);
			this.ParaNormalization.TabIndex = 3;
			this.ParaNormalization.Title = "正規化手法";
			this.ParaNormalization.UseValid = false;
			this.ParaNormalization.Valid = true;
			this.ParaNormalization.Value = null;
			this.ParaNormalization.ParameterChange += new FilterBase.Parts.ParameterChangeEventHandler(this.Param_ParameterChange);
			// 
			// Normalize
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.Controls.Add(this.FLPParam);
			this.Name = "Normalize";
			this.Size = new System.Drawing.Size(128, 346);
			this.Target = FilterBase.BaseFilterControl.TRANSFORM_TARGET.IMAGE;
			this.Controls.SetChildIndex(this.FLPParam, 0);
			this.FLPParam.ResumeLayout(false);
			this.FLPParam.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.ParaMean)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ParaStd)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ParaMaxPixelValue)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ParaNormalization)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.FlowLayoutPanel FLPParam;
		private FilterBase.Parts.Input3Tuple ParaMean;
		private FilterBase.Parts.Input3Tuple ParaStd;
		private FilterBase.Parts.InputValueUpDown ParaMaxPixelValue;
		private FilterBase.Parts.ComboBoxWithLabelParts ParaNormalization;
	}
}
