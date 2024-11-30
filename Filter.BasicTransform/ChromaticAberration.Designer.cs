namespace Filter.BasicTransform
{
    partial class ChromaticAberration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChromaticAberration));
            this.FLPParam = new System.Windows.Forms.FlowLayoutPanel();
            this.ParaPrimaryDistortionLlimit = new FilterBase.Parts.InputMaxMin();
            this.ParaSecondaryDistortionLimit = new FilterBase.Parts.InputMaxMin();
            this.ParaMode = new FilterBase.Parts.ComboBoxWithLabelParts();
            this.ParaInterpolation = new FilterBase.Parts.ComboBoxWithLabelParts();
            this.FLPParam.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ParaPrimaryDistortionLlimit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaSecondaryDistortionLimit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaMode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaInterpolation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // FLPParam
            // 
            this.FLPParam.AutoSize = true;
            this.FLPParam.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.FLPParam.Controls.Add(this.ParaPrimaryDistortionLlimit);
            this.FLPParam.Controls.Add(this.ParaSecondaryDistortionLimit);
            this.FLPParam.Controls.Add(this.ParaMode);
            this.FLPParam.Controls.Add(this.ParaInterpolation);
            this.FLPParam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FLPParam.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.FLPParam.Location = new System.Drawing.Point(0, 25);
            this.FLPParam.Name = "FLPParam";
            this.FLPParam.Size = new System.Drawing.Size(128, 184);
            this.FLPParam.TabIndex = 5;
            // 
            // ParaPrimaryDistortionLlimit
            // 
            this.ParaPrimaryDistortionLlimit.ArgumentName = "primary_distortion_limit";
            this.ParaPrimaryDistortionLlimit.AutoSize = true;
            this.ParaPrimaryDistortionLlimit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ParaPrimaryDistortionLlimit.DecimalPlace = 2;
            this.ParaPrimaryDistortionLlimit.Description = "一次放射状歪み係数の範囲囲。\r\nこのパラメータは、画像中央の歪みを制御します。\r\n- 正の値を指定すると、糸巻き型歪み (エッジが内側に曲がります) になります。" +
    "\r\n- 負の値を指定すると、樽型歪み (エッジが外側に曲がります) になります。\r\n　デフォルト: (-0.02、0.02)。";
            this.ParaPrimaryDistortionLlimit.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.ParaPrimaryDistortionLlimit.Location = new System.Drawing.Point(3, 3);
            this.ParaPrimaryDistortionLlimit.MaxValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ParaPrimaryDistortionLlimit.MaxVersion = null;
            this.ParaPrimaryDistortionLlimit.MinimumSize = new System.Drawing.Size(124, 21);
            this.ParaPrimaryDistortionLlimit.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.ParaPrimaryDistortionLlimit.MinVersion = null;
            this.ParaPrimaryDistortionLlimit.Name = "ParaPrimaryDistortionLlimit";
            this.ParaPrimaryDistortionLlimit.Required = false;
            this.ParaPrimaryDistortionLlimit.Size = new System.Drawing.Size(124, 42);
            this.ParaPrimaryDistortionLlimit.TabIndex = 0;
            this.ParaPrimaryDistortionLlimit.Title = "一次歪み係数の範囲";
            this.ParaPrimaryDistortionLlimit.Value = "(-0.02,0.02)";
            this.ParaPrimaryDistortionLlimit.ValueType = FilterBase.Parts.PartsFunc.VALUE_TYPE.TYPE_FLOAT;
            this.ParaPrimaryDistortionLlimit.ParameterChange += new FilterBase.Parts.ParameterChangeEventHandler(this.Param_ParameterChange);
            // 
            // ParaSecondaryDistortionLimit
            // 
            this.ParaSecondaryDistortionLimit.ArgumentName = "secondary_distortion_limit";
            this.ParaSecondaryDistortionLimit.AutoSize = true;
            this.ParaSecondaryDistortionLimit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ParaSecondaryDistortionLimit.DecimalPlace = 2;
            this.ParaSecondaryDistortionLimit.Description = "二次放射状歪み係数の範囲。\r\nこのパラメータは画像の角の歪みを制御します:\r\n- 正の値は糸巻き型歪みを強めます\r\n- 負の値は樽型歪みを強めます\r\n　　デフォル" +
    "ト: (-0.05, 0.05)。";
            this.ParaSecondaryDistortionLimit.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.ParaSecondaryDistortionLimit.Location = new System.Drawing.Point(3, 51);
            this.ParaSecondaryDistortionLimit.MaxValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ParaSecondaryDistortionLimit.MaxVersion = null;
            this.ParaSecondaryDistortionLimit.MinimumSize = new System.Drawing.Size(124, 21);
            this.ParaSecondaryDistortionLimit.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.ParaSecondaryDistortionLimit.MinVersion = null;
            this.ParaSecondaryDistortionLimit.Name = "ParaSecondaryDistortionLimit";
            this.ParaSecondaryDistortionLimit.Required = false;
            this.ParaSecondaryDistortionLimit.Size = new System.Drawing.Size(124, 42);
            this.ParaSecondaryDistortionLimit.TabIndex = 1;
            this.ParaSecondaryDistortionLimit.Title = "二次歪み係数範囲";
            this.ParaSecondaryDistortionLimit.Value = "(-0.05,0.05)";
            this.ParaSecondaryDistortionLimit.ValueType = FilterBase.Parts.PartsFunc.VALUE_TYPE.TYPE_FLOAT;
            this.ParaSecondaryDistortionLimit.ParameterChange += new FilterBase.Parts.ParameterChangeEventHandler(this.Param_ParameterChange);
            // 
            // ParaMode
            // 
            this.ParaMode.ArgumentName = "mode";
            this.ParaMode.AutoSize = true;
            this.ParaMode.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ParaMode.DefaultValue = "";
            this.ParaMode.Description = resources.GetString("ParaMode.Description");
            this.ParaMode.ItemType = "System.String";
            this.ParaMode.Location = new System.Drawing.Point(3, 99);
            this.ParaMode.MaxVersion = null;
            this.ParaMode.MinimumSize = new System.Drawing.Size(124, 21);
            this.ParaMode.MinVersion = null;
            this.ParaMode.Name = "ParaMode";
            this.ParaMode.Required = false;
            this.ParaMode.Size = new System.Drawing.Size(124, 38);
            this.ParaMode.TabIndex = 2;
            this.ParaMode.Title = "色ずれ方法";
            this.ParaMode.Value = null;
            this.ParaMode.ParameterChange += new FilterBase.Parts.ParameterChangeEventHandler(this.Param_ParameterChange);
            // 
            // ParaInterpolation
            // 
            this.ParaInterpolation.ArgumentName = "interpolation";
            this.ParaInterpolation.AutoSize = true;
            this.ParaInterpolation.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ParaInterpolation.DefaultValue = "LINEAR";
            this.ParaInterpolation.Description = "補間アルゴリズムを指定するフラグ。次のいずれかになります:\r\ncv2.INTER_NEAREST、cv2.INTER_LINEAR、cv2.INTER_CUBIC" +
    "、cv2.INTER_AREA、cv2.INTER_LANCZOS4。\r\n　　デフォルト: cv2.INTER_LINEAR。";
            this.ParaInterpolation.ItemType = "InterpolationFlags";
            this.ParaInterpolation.Location = new System.Drawing.Point(3, 143);
            this.ParaInterpolation.MaxVersion = null;
            this.ParaInterpolation.MinimumSize = new System.Drawing.Size(124, 21);
            this.ParaInterpolation.MinVersion = null;
            this.ParaInterpolation.Name = "ParaInterpolation";
            this.ParaInterpolation.Required = false;
            this.ParaInterpolation.Size = new System.Drawing.Size(124, 38);
            this.ParaInterpolation.TabIndex = 3;
            this.ParaInterpolation.Title = "補間方法";
            this.ParaInterpolation.Value = null;
            this.ParaInterpolation.ParameterChange += new FilterBase.Parts.ParameterChangeEventHandler(this.Param_ParameterChange);
            // 
            // ChromaticAberration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.FLPParam);
            this.MinVersion = "1.4.2";
            this.Name = "ChromaticAberration";
            this.Size = new System.Drawing.Size(128, 234);
            this.Target = FilterBase.BaseFilterControl.TRANSFORM_TARGET.IMAGE;
            this.Controls.SetChildIndex(this.FLPParam, 0);
            this.FLPParam.ResumeLayout(false);
            this.FLPParam.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ParaPrimaryDistortionLlimit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaSecondaryDistortionLimit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaMode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaInterpolation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel FLPParam;
        private FilterBase.Parts.InputMaxMin ParaPrimaryDistortionLlimit;
        private FilterBase.Parts.InputMaxMin ParaSecondaryDistortionLimit;
        private FilterBase.Parts.ComboBoxWithLabelParts ParaMode;
        private FilterBase.Parts.ComboBoxWithLabelParts ParaInterpolation;
    }
}
