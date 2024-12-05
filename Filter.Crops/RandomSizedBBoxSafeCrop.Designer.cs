namespace Filter.Crops
{
	partial class RandomSizedBBoxSafeCrop
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
			this.ParaInterpolation = new FilterBase.Parts.ComboBoxWithLabelParts();
			this.ParaMaskInterpolation = new FilterBase.Parts.ComboBoxWithLabelParts();
			this.ParaWidth = new FilterBase.Parts.InputValueUpDown();
			this.ParaHeight = new FilterBase.Parts.InputValueUpDown();
			this.ParaErosionRate = new FilterBase.Parts.InputTrackBar();
			this.FLPParam.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.ParaInterpolation)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ParaMaskInterpolation)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ParaWidth)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ParaHeight)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ParaErosionRate)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
			this.SuspendLayout();
			// 
			// FLPParam
			// 
			this.FLPParam.AutoSize = true;
			this.FLPParam.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.FLPParam.Controls.Add(this.ParaWidth);
			this.FLPParam.Controls.Add(this.ParaHeight);
			this.FLPParam.Controls.Add(this.ParaErosionRate);
			this.FLPParam.Controls.Add(this.ParaInterpolation);
			this.FLPParam.Controls.Add(this.ParaMaskInterpolation);
			this.FLPParam.Dock = System.Windows.Forms.DockStyle.Fill;
			this.FLPParam.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
			this.FLPParam.Location = new System.Drawing.Point(0, 24);
			this.FLPParam.Name = "FLPParam";
			this.FLPParam.Size = new System.Drawing.Size(128, 241);
			this.FLPParam.TabIndex = 5;
			// 
			// ParaInterpolation
			// 
			this.ParaInterpolation.ArgumentName = "interpolation";
			this.ParaInterpolation.AutoSize = true;
			this.ParaInterpolation.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ParaInterpolation.DefaultValue = "LINEAR";
			this.ParaInterpolation.Description = "補間アルゴリズムを指定するために使用されるフラグ。次のいずれかになります:\r\ncv2.INTER_NEAREST、cv2.INTER_LINEAR、cv2.INT" +
    "ER_CUBIC、cv2.INTER_AREA、cv2.INTER_LANCZOS4。\r\nデフォルト: cv2.INTER_LINEAR。";
			this.ParaInterpolation.InvalidValue = "";
			this.ParaInterpolation.ItemType = "InterpolationFlags";
			this.ParaInterpolation.Location = new System.Drawing.Point(3, 156);
			this.ParaInterpolation.MaxVersion = null;
			this.ParaInterpolation.MinimumSize = new System.Drawing.Size(124, 21);
			this.ParaInterpolation.MinVersion = null;
			this.ParaInterpolation.Name = "ParaInterpolation";
			this.ParaInterpolation.Required = false;
			this.ParaInterpolation.Size = new System.Drawing.Size(124, 38);
			this.ParaInterpolation.TabIndex = 10;
			this.ParaInterpolation.Title = "補間方法";
			this.ParaInterpolation.UseValid = false;
			this.ParaInterpolation.Valid = true;
			this.ParaInterpolation.Value = null;
			this.ParaInterpolation.ParameterChange += new FilterBase.Parts.ParameterChangeEventHandler(this.Param_ParameterChange);
			// 
			// ParaMaskInterpolation
			// 
			this.ParaMaskInterpolation.ArgumentName = "mask_interpolation";
			this.ParaMaskInterpolation.AutoSize = true;
			this.ParaMaskInterpolation.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ParaMaskInterpolation.DefaultValue = "NEAREST";
			this.ParaMaskInterpolation.Description = "マスクの補間アルゴリズムを指定するために使用されるフラグ。\r\n次のいずれかである必要があります: cv2.INTER_NEAREST、cv2.INTER_LINE" +
    "AR、cv2.INTER_CUBIC、cv2.INTER_AREA、cv2.INTER_LANCZOS4。\r\nデフォルト: cv2.INTER_NEAREST。" +
    "";
			this.ParaMaskInterpolation.InvalidValue = "";
			this.ParaMaskInterpolation.ItemType = "InterpolationFlags";
			this.ParaMaskInterpolation.Location = new System.Drawing.Point(3, 200);
			this.ParaMaskInterpolation.MaxVersion = null;
			this.ParaMaskInterpolation.MinimumSize = new System.Drawing.Size(124, 21);
			this.ParaMaskInterpolation.MinVersion = null;
			this.ParaMaskInterpolation.Name = "ParaMaskInterpolation";
			this.ParaMaskInterpolation.Required = false;
			this.ParaMaskInterpolation.Size = new System.Drawing.Size(124, 38);
			this.ParaMaskInterpolation.TabIndex = 11;
			this.ParaMaskInterpolation.Title = "マスク補間方法";
			this.ParaMaskInterpolation.UseValid = false;
			this.ParaMaskInterpolation.Valid = true;
			this.ParaMaskInterpolation.Value = null;
			this.ParaMaskInterpolation.ParameterChange += new FilterBase.Parts.ParameterChangeEventHandler(this.Param_ParameterChange);
			// 
			// ParaWidth
			// 
			this.ParaWidth.ArgumentName = "width";
			this.ParaWidth.AutoSize = true;
			this.ParaWidth.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ParaWidth.ControlLayout = FilterBase.Parts.InputValue.LAYOUT.Vertical;
			this.ParaWidth.DecimalPlace = 0;
			this.ParaWidth.Description = "サイズ変更後の出力画像の幅。";
			this.ParaWidth.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.ParaWidth.InvalidValue = "";
			this.ParaWidth.Location = new System.Drawing.Point(3, 3);
			this.ParaWidth.MaxValue = new decimal(new int[] {
            1920,
            0,
            0,
            0});
			this.ParaWidth.MaxVersion = null;
			this.ParaWidth.MinimumSize = new System.Drawing.Size(124, 21);
			this.ParaWidth.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.ParaWidth.MinVersion = null;
			this.ParaWidth.Name = "ParaWidth";
			this.ParaWidth.Required = false;
			this.ParaWidth.Size = new System.Drawing.Size(124, 35);
			this.ParaWidth.TabIndex = 15;
			this.ParaWidth.Title = "出力画像幅";
			this.ParaWidth.Unit = "";
			this.ParaWidth.UseValid = false;
			this.ParaWidth.Valid = true;
			this.ParaWidth.Value = new decimal(new int[] {
            512,
            0,
            0,
            0});
			this.ParaWidth.ValueType = FilterBase.Parts.InputValue.VALUE_TYPE.INT;
			this.ParaWidth.ParameterChange += new FilterBase.Parts.ParameterChangeEventHandler(this.Param_ParameterChange);
			// 
			// ParaHeight
			// 
			this.ParaHeight.ArgumentName = "height";
			this.ParaHeight.AutoSize = true;
			this.ParaHeight.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ParaHeight.ControlLayout = FilterBase.Parts.InputValue.LAYOUT.Vertical;
			this.ParaHeight.DecimalPlace = 0;
			this.ParaHeight.Description = "サイズ変更後の出力画像の高さ。";
			this.ParaHeight.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.ParaHeight.InvalidValue = "";
			this.ParaHeight.Location = new System.Drawing.Point(3, 44);
			this.ParaHeight.MaxValue = new decimal(new int[] {
            1920,
            0,
            0,
            0});
			this.ParaHeight.MaxVersion = null;
			this.ParaHeight.MinimumSize = new System.Drawing.Size(124, 21);
			this.ParaHeight.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.ParaHeight.MinVersion = null;
			this.ParaHeight.Name = "ParaHeight";
			this.ParaHeight.Required = false;
			this.ParaHeight.Size = new System.Drawing.Size(124, 35);
			this.ParaHeight.TabIndex = 16;
			this.ParaHeight.Title = "出力画像高さ";
			this.ParaHeight.Unit = "";
			this.ParaHeight.UseValid = false;
			this.ParaHeight.Valid = true;
			this.ParaHeight.Value = new decimal(new int[] {
            512,
            0,
            0,
            0});
			this.ParaHeight.ValueType = FilterBase.Parts.InputValue.VALUE_TYPE.INT;
			this.ParaHeight.ParameterChange += new FilterBase.Parts.ParameterChangeEventHandler(this.Param_ParameterChange);
			// 
			// ParaErosionRate
			// 
			this.ParaErosionRate.ArgumentName = "erosion_rate";
			this.ParaErosionRate.AutoSize = true;
			this.ParaErosionRate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ParaErosionRate.DecimalPlace = 2;
			this.ParaErosionRate.Description = "0.0 から 1.0 の間の値で、元の画像サイズの割合として切り抜きの最小許容サイズを決定します。\r\nたとえば、erosion_rate が 0.2 の場合、切り" +
    "抜きは元の画像の高さと幅の少なくとも 80% になります。\r\n　　　デフォルト: 0.0 (最小サイズなし)。";
			this.ParaErosionRate.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
			this.ParaErosionRate.InvalidValue = "";
			this.ParaErosionRate.Location = new System.Drawing.Point(3, 85);
			this.ParaErosionRate.MaxValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.ParaErosionRate.MaxVersion = null;
			this.ParaErosionRate.MinimumSize = new System.Drawing.Size(124, 21);
			this.ParaErosionRate.MinValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
			this.ParaErosionRate.MinVersion = null;
			this.ParaErosionRate.Name = "ParaErosionRate";
			this.ParaErosionRate.Required = false;
			this.ParaErosionRate.Size = new System.Drawing.Size(124, 65);
			this.ParaErosionRate.TabIndex = 17;
			this.ParaErosionRate.Title = "許容サイズ";
			this.ParaErosionRate.UseValid = false;
			this.ParaErosionRate.Valid = true;
			this.ParaErosionRate.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
			this.ParaErosionRate.ParameterChange += new FilterBase.Parts.ParameterChangeEventHandler(this.Param_ParameterChange);
			// 
			// RandomSizedBBoxSafeCrop
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.Controls.Add(this.FLPParam);
			this.Name = "RandomSizedBBoxSafeCrop";
			this.Require = ((FilterBase.BaseFilterControl.TRANSFORM_TARGET)((FilterBase.BaseFilterControl.TRANSFORM_TARGET.IMAGE | FilterBase.BaseFilterControl.TRANSFORM_TARGET.BBOX)));
			this.Size = new System.Drawing.Size(128, 290);
			this.Controls.SetChildIndex(this.FLPParam, 0);
			this.FLPParam.ResumeLayout(false);
			this.FLPParam.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.ParaInterpolation)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ParaMaskInterpolation)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ParaWidth)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ParaHeight)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ParaErosionRate)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.FlowLayoutPanel FLPParam;
		private FilterBase.Parts.ComboBoxWithLabelParts ParaInterpolation;
		private FilterBase.Parts.ComboBoxWithLabelParts ParaMaskInterpolation;
		private FilterBase.Parts.InputValueUpDown ParaWidth;
		private FilterBase.Parts.InputValueUpDown ParaHeight;
		private FilterBase.Parts.InputTrackBar ParaErosionRate;
	}
}
