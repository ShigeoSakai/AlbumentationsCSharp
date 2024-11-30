namespace FilterCrops
{
    partial class RandomResizedCrop
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
            this.ParaSize = new FilterBase.Parts.InputTuple();
            this.ParaRatio = new FilterBase.Parts.InputMaxMin();
            this.ParaScale = new FilterBase.Parts.InputMaxMin();
            this.FLPParam.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ParaInterpolation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaMaskInterpolation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaRatio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaScale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // FLPParam
            // 
            this.FLPParam.AutoSize = true;
            this.FLPParam.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.FLPParam.Controls.Add(this.ParaSize);
            this.FLPParam.Controls.Add(this.ParaScale);
            this.FLPParam.Controls.Add(this.ParaRatio);
            this.FLPParam.Controls.Add(this.ParaInterpolation);
            this.FLPParam.Controls.Add(this.ParaMaskInterpolation);
            this.FLPParam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FLPParam.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.FLPParam.Location = new System.Drawing.Point(0, 25);
            this.FLPParam.Name = "FLPParam";
            this.FLPParam.Size = new System.Drawing.Size(128, 225);
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
            this.ParaInterpolation.ItemType = "InterpolationFlags";
            this.ParaInterpolation.Location = new System.Drawing.Point(3, 140);
            this.ParaInterpolation.MaxVersion = null;
            this.ParaInterpolation.MinimumSize = new System.Drawing.Size(124, 21);
            this.ParaInterpolation.MinVersion = null;
            this.ParaInterpolation.Name = "ParaInterpolation";
            this.ParaInterpolation.Required = false;
            this.ParaInterpolation.Size = new System.Drawing.Size(124, 38);
            this.ParaInterpolation.TabIndex = 4;
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
            this.ParaMaskInterpolation.Location = new System.Drawing.Point(3, 184);
            this.ParaMaskInterpolation.MaxVersion = null;
            this.ParaMaskInterpolation.MinimumSize = new System.Drawing.Size(124, 21);
            this.ParaMaskInterpolation.MinVersion = null;
            this.ParaMaskInterpolation.Name = "ParaMaskInterpolation";
            this.ParaMaskInterpolation.Required = false;
            this.ParaMaskInterpolation.Size = new System.Drawing.Size(124, 38);
            this.ParaMaskInterpolation.TabIndex = 5;
            this.ParaMaskInterpolation.Title = "マスク補間方法";
            this.ParaMaskInterpolation.Value = null;
            this.ParaMaskInterpolation.ParameterChange += new FilterBase.Parts.ParameterChangeEventHandler(this.Param_ParameterChange);
            // 
            // ParaSize
            // 
            this.ParaSize.ArgumentName = "size";
            this.ParaSize.AutoSize = true;
            this.ParaSize.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ParaSize.DecimalPlace = 0;
            this.ParaSize.Description = "出力画像の目標サイズ、\r\nつまり切り取りとサイズ変更後の (高さ、幅)。";
            this.ParaSize.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ParaSize.Location = new System.Drawing.Point(3, 3);
            this.ParaSize.MaxValue = "(10000,10000)";
            this.ParaSize.MaxVersion = null;
            this.ParaSize.MinimumSize = new System.Drawing.Size(124, 21);
            this.ParaSize.MinValue = "(1,1)";
            this.ParaSize.MinVersion = null;
            this.ParaSize.Name = "ParaSize";
            this.ParaSize.Required = false;
            this.ParaSize.Size = new System.Drawing.Size(124, 41);
            this.ParaSize.TabIndex = 6;
            this.ParaSize.Title = "サイズ";
            this.ParaSize.Value = "(512,320)";
            this.ParaSize.ValueType = FilterBase.Parts.PartsFunc.VALUE_TYPE.TYPE_INT;
            this.ParaSize.ParameterChange += new FilterBase.Parts.ParameterChangeEventHandler(this.Param_ParameterChange);
            // 
            // ParaRatio
            // 
            this.ParaRatio.ArgumentName = "ratio";
            this.ParaRatio.AutoSize = true;
            this.ParaRatio.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ParaRatio.DecimalPlace = 2;
            this.ParaRatio.Description = "ランダム クロップのアスペクト比の範囲。\r\n\r\nたとえば、(0.75, 1.3333) は、3:4 から 4:3 までのクロップ アスペクト比を許可します。\r\n\r" +
    "\n　　デフォルト: (0.75, 1.3333333333333333)";
            this.ParaRatio.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.ParaRatio.InvalidValue = "";
            this.ParaRatio.Location = new System.Drawing.Point(3, 95);
            this.ParaRatio.MaxValue = null;
            this.ParaRatio.MaxVersion = null;
            this.ParaRatio.MinimumSize = new System.Drawing.Size(124, 21);
            this.ParaRatio.MinValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.ParaRatio.MinVersion = null;
            this.ParaRatio.Name = "ParaRatio";
            this.ParaRatio.Required = false;
            this.ParaRatio.Size = new System.Drawing.Size(124, 39);
            this.ParaRatio.TabIndex = 8;
            this.ParaRatio.Title = "アスペクト比の範囲";
            this.ParaRatio.UseLargeValue = false;
            this.ParaRatio.UseValid = false;
            this.ParaRatio.Value = "(0.75,1.33)";
            this.ParaRatio.ValueType = FilterBase.Parts.PartsFunc.VALUE_TYPE.TYPE_FLOAT;
            this.ParaRatio.ParameterChange += new FilterBase.Parts.ParameterChangeEventHandler(this.Param_ParameterChange);
            // 
            // ParaScale
            // 
            this.ParaScale.ArgumentName = "scale";
            this.ParaScale.AutoSize = true;
            this.ParaScale.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ParaScale.DecimalPlace = 2;
            this.ParaScale.Description = "入力サイズに対する切り抜きのランダム サイズの範囲。\r\nたとえば、(0.08, 1.0) は、切り抜きサイズが入力サイズの 8% から 100% の間になることを" +
    "意味します。\r\n　　デフォルト: (0.08, 1.0)\r\n";
            this.ParaScale.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.ParaScale.InvalidValue = "";
            this.ParaScale.Location = new System.Drawing.Point(3, 50);
            this.ParaScale.MaxValue = null;
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
            this.ParaScale.Size = new System.Drawing.Size(124, 39);
            this.ParaScale.TabIndex = 9;
            this.ParaScale.Title = "スケール範囲";
            this.ParaScale.UseLargeValue = false;
            this.ParaScale.UseValid = false;
            this.ParaScale.Value = "(0.08,1.00)";
            this.ParaScale.ValueType = FilterBase.Parts.PartsFunc.VALUE_TYPE.TYPE_FLOAT;
            this.ParaScale.ParameterChange += new FilterBase.Parts.ParameterChangeEventHandler(this.Param_ParameterChange);
            // 
            // RandomResizedCrop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.FLPParam);
            this.Name = "RandomResizedCrop";
            this.Size = new System.Drawing.Size(128, 275);
            this.Controls.SetChildIndex(this.FLPParam, 0);
            this.FLPParam.ResumeLayout(false);
            this.FLPParam.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ParaInterpolation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaMaskInterpolation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaRatio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaScale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel FLPParam;
        private FilterBase.Parts.InputTuple ParaSize;
        private FilterBase.Parts.ComboBoxWithLabelParts ParaInterpolation;
        private FilterBase.Parts.ComboBoxWithLabelParts ParaMaskInterpolation;
        private FilterBase.Parts.InputMaxMin ParaRatio;
        private FilterBase.Parts.InputMaxMin ParaScale;
    }
}
