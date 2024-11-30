namespace Filter.Crops
{
    partial class RandomSizedCrop
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
            this.ParaMinMaxHeight = new FilterBase.Parts.InputMaxMin();
            this.ParaSize = new FilterBase.Parts.InputMaxMin();
            this.ParaInterpolation = new FilterBase.Parts.ComboBoxWithLabelParts();
            this.ParaMaskInterpolation = new FilterBase.Parts.ComboBoxWithLabelParts();
            this.FLPParam.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ParaMinMaxHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaInterpolation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaMaskInterpolation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // FLPParam
            // 
            this.FLPParam.AutoSize = true;
            this.FLPParam.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.FLPParam.Controls.Add(this.ParaMinMaxHeight);
            this.FLPParam.Controls.Add(this.ParaSize);
            this.FLPParam.Controls.Add(this.ParaInterpolation);
            this.FLPParam.Controls.Add(this.ParaMaskInterpolation);
            this.FLPParam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FLPParam.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.FLPParam.Location = new System.Drawing.Point(0, 25);
            this.FLPParam.Name = "FLPParam";
            this.FLPParam.Size = new System.Drawing.Size(128, 178);
            this.FLPParam.TabIndex = 5;
            // 
            // ParaMinMaxHeight
            // 
            this.ParaMinMaxHeight.ArgumentName = "min_max_height";
            this.ParaMinMaxHeight.AutoSize = true;
            this.ParaMinMaxHeight.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ParaMinMaxHeight.DecimalPlace = 0;
            this.ParaMinMaxHeight.Description = "切り抜き部分の最小および最大の高さ（ピクセル単位）。";
            this.ParaMinMaxHeight.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ParaMinMaxHeight.InvalidValue = "";
            this.ParaMinMaxHeight.Location = new System.Drawing.Point(3, 3);
            this.ParaMinMaxHeight.MaxValue = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.ParaMinMaxHeight.MaxVersion = null;
            this.ParaMinMaxHeight.MinimumSize = new System.Drawing.Size(124, 21);
            this.ParaMinMaxHeight.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ParaMinMaxHeight.MinVersion = null;
            this.ParaMinMaxHeight.Name = "ParaMinMaxHeight";
            this.ParaMinMaxHeight.Required = false;
            this.ParaMinMaxHeight.Size = new System.Drawing.Size(124, 39);
            this.ParaMinMaxHeight.TabIndex = 0;
            this.ParaMinMaxHeight.Title = "切り抜き高さ範囲";
            this.ParaMinMaxHeight.UseLargeValue = false;
            this.ParaMinMaxHeight.UseValid = false;
            this.ParaMinMaxHeight.Value = "(512,512)";
            this.ParaMinMaxHeight.ValueType = FilterBase.Parts.PartsFunc.VALUE_TYPE.TYPE_INT;
            this.ParaMinMaxHeight.ParameterChange += new FilterBase.Parts.ParameterChangeEventHandler(this.Param_ParameterChange);
            // 
            // ParaSize
            // 
            this.ParaSize.ArgumentName = "size";
            this.ParaSize.AutoSize = true;
            this.ParaSize.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ParaSize.DecimalPlace = 0;
            this.ParaSize.Description = "出力画像の目標サイズ、\r\nつまり切り抜きとサイズ変更後の (高さ、幅)。";
            this.ParaSize.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ParaSize.InvalidValue = "";
            this.ParaSize.Location = new System.Drawing.Point(3, 48);
            this.ParaSize.MaxValue = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.ParaSize.MaxVersion = null;
            this.ParaSize.MinimumSize = new System.Drawing.Size(124, 21);
            this.ParaSize.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ParaSize.MinVersion = null;
            this.ParaSize.Name = "ParaSize";
            this.ParaSize.Required = false;
            this.ParaSize.Size = new System.Drawing.Size(124, 39);
            this.ParaSize.TabIndex = 1;
            this.ParaSize.Title = "出力画像の目標サイズ";
            this.ParaSize.UseLargeValue = false;
            this.ParaSize.UseValid = false;
            this.ParaSize.Value = "(512,512)";
            this.ParaSize.ValueType = FilterBase.Parts.PartsFunc.VALUE_TYPE.TYPE_INT;
            this.ParaSize.ParameterChange += new FilterBase.Parts.ParameterChangeEventHandler(this.Param_ParameterChange);
            // 
            // ParaInterpolation
            // 
            this.ParaInterpolation.ArgumentName = "interpolation";
            this.ParaInterpolation.AutoSize = true;
            this.ParaInterpolation.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ParaInterpolation.DefaultValue = "LINEAR";
            this.ParaInterpolation.Description = "補間アルゴリズムを指定するために使用されるフラグ。次のいずれかになります:\r\ncv2.INTER_NEAREST、cv2.INTER_LINEAR、cv2.INT" +
    "ER_CUBIC、cv2.INTER_AREA、cv2.INTER_LANCZOS4。\r\nデフォルト: cv2.INTER_LINEAR。";
            this.ParaInterpolation.ItemType = "InterpolationFlags";
            this.ParaInterpolation.Location = new System.Drawing.Point(3, 93);
            this.ParaInterpolation.MaxVersion = null;
            this.ParaInterpolation.MinimumSize = new System.Drawing.Size(124, 21);
            this.ParaInterpolation.MinVersion = null;
            this.ParaInterpolation.Name = "ParaInterpolation";
            this.ParaInterpolation.Required = false;
            this.ParaInterpolation.Size = new System.Drawing.Size(124, 38);
            this.ParaInterpolation.TabIndex = 2;
            this.ParaInterpolation.Title = "補間方法";
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
            this.ParaMaskInterpolation.ItemType = "InterpolationFlags";
            this.ParaMaskInterpolation.Location = new System.Drawing.Point(3, 137);
            this.ParaMaskInterpolation.MaxVersion = null;
            this.ParaMaskInterpolation.MinimumSize = new System.Drawing.Size(124, 21);
            this.ParaMaskInterpolation.MinVersion = null;
            this.ParaMaskInterpolation.Name = "ParaMaskInterpolation";
            this.ParaMaskInterpolation.Required = false;
            this.ParaMaskInterpolation.Size = new System.Drawing.Size(124, 38);
            this.ParaMaskInterpolation.TabIndex = 3;
            this.ParaMaskInterpolation.Title = "マスク補間方法";
            this.ParaMaskInterpolation.Value = null;
            this.ParaMaskInterpolation.ParameterChange += new FilterBase.Parts.ParameterChangeEventHandler(this.Param_ParameterChange);
            // 
            // RandomSizedCrop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.FLPParam);
            this.Name = "RandomSizedCrop";
            this.Size = new System.Drawing.Size(128, 228);
            this.Controls.SetChildIndex(this.FLPParam, 0);
            this.FLPParam.ResumeLayout(false);
            this.FLPParam.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ParaMinMaxHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaInterpolation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaMaskInterpolation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel FLPParam;
        private FilterBase.Parts.InputMaxMin ParaMinMaxHeight;
        private FilterBase.Parts.InputMaxMin ParaSize;
        private FilterBase.Parts.ComboBoxWithLabelParts ParaInterpolation;
        private FilterBase.Parts.ComboBoxWithLabelParts ParaMaskInterpolation;
    }
}
