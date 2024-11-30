namespace Filter.Geometric
{
    partial class ElasticTransform
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
            this.ParaAlpha = new FilterBase.Parts.InputValueUpDown();
            this.ParaSigma = new FilterBase.Parts.InputValueUpDown();
            this.ParaInterpolation = new FilterBase.Parts.ComboBoxWithLabelParts();
            this.ParaBorderMode = new FilterBase.Parts.ComboBoxWithLabelParts();
            this.ParaValue = new FilterBase.Parts.ColorSelectorParts();
            this.ParaMaskValue = new FilterBase.Parts.ColorSelectorParts();
            this.ParaApproximate = new FilterBase.Parts.CheckBoxParts();
            this.ParaSameDxdy = new FilterBase.Parts.CheckBoxParts();
            this.ParaMaskInterpolation = new FilterBase.Parts.ComboBoxWithLabelParts();
            this.ParaNoiseDistribution = new FilterBase.Parts.ComboBoxWithLabelParts();
            this.FLPParam.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ParaAlpha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaSigma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaInterpolation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaBorderMode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaMaskValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaMaskInterpolation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaNoiseDistribution)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // FLPParam
            // 
            this.FLPParam.AutoSize = true;
            this.FLPParam.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.FLPParam.Controls.Add(this.ParaAlpha);
            this.FLPParam.Controls.Add(this.ParaSigma);
            this.FLPParam.Controls.Add(this.ParaInterpolation);
            this.FLPParam.Controls.Add(this.ParaBorderMode);
            this.FLPParam.Controls.Add(this.ParaValue);
            this.FLPParam.Controls.Add(this.ParaMaskValue);
            this.FLPParam.Controls.Add(this.ParaApproximate);
            this.FLPParam.Controls.Add(this.ParaSameDxdy);
            this.FLPParam.Controls.Add(this.ParaMaskInterpolation);
            this.FLPParam.Controls.Add(this.ParaNoiseDistribution);
            this.FLPParam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FLPParam.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.FLPParam.Location = new System.Drawing.Point(0, 25);
            this.FLPParam.Name = "FLPParam";
            this.FLPParam.Size = new System.Drawing.Size(128, 426);
            this.FLPParam.TabIndex = 5;
            // 
            // ParaAlpha
            // 
            this.ParaAlpha.ArgumentName = "alpha";
            this.ParaAlpha.AutoSize = true;
            this.ParaAlpha.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ParaAlpha.ControlLayout = FilterBase.Parts.InputValue.LAYOUT.Horizontal;
            this.ParaAlpha.DecimalPlace = 1;
            this.ParaAlpha.Description = "ランダム変位フィールドのスケーリング係数。値が大きいほど、歪みが顕著になります。\r\nデフォルト: 1.0";
            this.ParaAlpha.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.ParaAlpha.Location = new System.Drawing.Point(3, 3);
            this.ParaAlpha.MaxValue = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.ParaAlpha.MaxVersion = null;
            this.ParaAlpha.MinimumSize = new System.Drawing.Size(124, 21);
            this.ParaAlpha.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.ParaAlpha.MinVersion = null;
            this.ParaAlpha.Name = "ParaAlpha";
            this.ParaAlpha.Required = false;
            this.ParaAlpha.Size = new System.Drawing.Size(124, 21);
            this.ParaAlpha.TabIndex = 0;
            this.ParaAlpha.Title = "α";
            this.ParaAlpha.Unit = "";
            this.ParaAlpha.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ParaAlpha.ValueType = FilterBase.Parts.InputValue.VALUE_TYPE.FLOAT;
            this.ParaAlpha.ParameterChange += new FilterBase.Parts.ParameterChangeEventHandler(this.Param_ParameterChange);
            // 
            // ParaSigma
            // 
            this.ParaSigma.ArgumentName = "sigma";
            this.ParaSigma.AutoSize = true;
            this.ParaSigma.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ParaSigma.ControlLayout = FilterBase.Parts.InputValue.LAYOUT.Horizontal;
            this.ParaSigma.DecimalPlace = 1;
            this.ParaSigma.Description = "変位フィールドを滑らかにするために使用されるガウス フィルタの標準偏差。\r\n値が高いほど、より滑らかで全体的な歪みが生じます。\r\n既定値: 50.0";
            this.ParaSigma.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.ParaSigma.Location = new System.Drawing.Point(3, 30);
            this.ParaSigma.MaxValue = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.ParaSigma.MaxVersion = null;
            this.ParaSigma.MinimumSize = new System.Drawing.Size(124, 21);
            this.ParaSigma.MinValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.ParaSigma.MinVersion = null;
            this.ParaSigma.Name = "ParaSigma";
            this.ParaSigma.Required = false;
            this.ParaSigma.Size = new System.Drawing.Size(124, 21);
            this.ParaSigma.TabIndex = 1;
            this.ParaSigma.Title = "Σ";
            this.ParaSigma.Unit = "";
            this.ParaSigma.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.ParaSigma.ValueType = FilterBase.Parts.InputValue.VALUE_TYPE.FLOAT;
            this.ParaSigma.ParameterChange += new FilterBase.Parts.ParameterChangeEventHandler(this.Param_ParameterChange);
            // 
            // ParaInterpolation
            // 
            this.ParaInterpolation.ArgumentName = "interpolation";
            this.ParaInterpolation.AutoSize = true;
            this.ParaInterpolation.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ParaInterpolation.DefaultValue = "LINEAR";
            this.ParaInterpolation.Description = "画像変換に使用する補間方法。\r\nOpenCV 補間タイプの 1 つである必要があります。\r\nデフォルト: cv2.INTER_LINEAR";
            this.ParaInterpolation.ItemType = "InterpolationFlags";
            this.ParaInterpolation.Location = new System.Drawing.Point(3, 57);
            this.ParaInterpolation.MaxVersion = null;
            this.ParaInterpolation.MinimumSize = new System.Drawing.Size(124, 21);
            this.ParaInterpolation.MinVersion = null;
            this.ParaInterpolation.Name = "ParaInterpolation";
            this.ParaInterpolation.Required = false;
            this.ParaInterpolation.Size = new System.Drawing.Size(124, 38);
            this.ParaInterpolation.TabIndex = 6;
            this.ParaInterpolation.Title = "補間方法";
            this.ParaInterpolation.Value = null;
            this.ParaInterpolation.ParameterChange += new FilterBase.Parts.ParameterChangeEventHandler(this.Param_ParameterChange);
            // 
            // ParaBorderMode
            // 
            this.ParaBorderMode.ArgumentName = "border_mode";
            this.ParaBorderMode.AutoSize = true;
            this.ParaBorderMode.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ParaBorderMode.DefaultValue = "REFLECT_101";
            this.ParaBorderMode.Description = "ピクセル外挿方法を指定するために使用されるフラグ。次のいずれかになります:\r\ncv2.BORDER_CONSTANT、cv2.BORDER_REPLICATE、c" +
    "v2.BORDER_REFLECT、cv2.BORDER_WRAP、cv2.BORDER_REFLECT_101。\r\nデフォルト: cv2.BORDER_REF" +
    "LECT_101";
            this.ParaBorderMode.ItemType = "BorderTypes";
            this.ParaBorderMode.Location = new System.Drawing.Point(3, 101);
            this.ParaBorderMode.MaxVersion = null;
            this.ParaBorderMode.MinimumSize = new System.Drawing.Size(124, 21);
            this.ParaBorderMode.MinVersion = null;
            this.ParaBorderMode.Name = "ParaBorderMode";
            this.ParaBorderMode.Required = false;
            this.ParaBorderMode.Size = new System.Drawing.Size(124, 38);
            this.ParaBorderMode.TabIndex = 8;
            this.ParaBorderMode.Title = "ピクセル外挿方法";
            this.ParaBorderMode.Value = null;
            this.ParaBorderMode.SelectedIndexChanged += new FilterBase.Parts.ComboBoxWithLabelParts.ComboBoxSelectEventHandler(this.ParaBorderMode_SelectedIndexChanged);
            this.ParaBorderMode.ParameterChange += new FilterBase.Parts.ParameterChangeEventHandler(this.Param_ParameterChange);
            // 
            // ParaValue
            // 
            this.ParaValue.ArgumentName = "value";
            this.ParaValue.AutoSize = true;
            this.ParaValue.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ParaValue.Color = System.Drawing.Color.Black;
            this.ParaValue.Description = "border_mode が cv2.BORDER_CONSTANT の場合のパディング値。";
            this.ParaValue.IsColor = true;
            this.ParaValue.Location = new System.Drawing.Point(3, 145);
            this.ParaValue.MaxVersion = null;
            this.ParaValue.MinimumSize = new System.Drawing.Size(124, 21);
            this.ParaValue.MinVersion = null;
            this.ParaValue.Name = "ParaValue";
            this.ParaValue.Required = false;
            this.ParaValue.Size = new System.Drawing.Size(124, 48);
            this.ParaValue.TabIndex = 9;
            this.ParaValue.Title = "パディング色";
            this.ParaValue.ParameterChange += new FilterBase.Parts.ParameterChangeEventHandler(this.Param_ParameterChange);
            // 
            // ParaMaskValue
            // 
            this.ParaMaskValue.ArgumentName = "mask_value";
            this.ParaMaskValue.AutoSize = true;
            this.ParaMaskValue.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ParaMaskValue.Color = System.Drawing.Color.Black;
            this.ParaMaskValue.Description = "border_mode が cv2.BORDER_CONSTANT の場合のパディング値がマスクに適用されます。";
            this.ParaMaskValue.IsColor = true;
            this.ParaMaskValue.Location = new System.Drawing.Point(3, 199);
            this.ParaMaskValue.MaxVersion = null;
            this.ParaMaskValue.MinimumSize = new System.Drawing.Size(124, 21);
            this.ParaMaskValue.MinVersion = null;
            this.ParaMaskValue.Name = "ParaMaskValue";
            this.ParaMaskValue.Required = false;
            this.ParaMaskValue.Size = new System.Drawing.Size(124, 48);
            this.ParaMaskValue.TabIndex = 10;
            this.ParaMaskValue.Title = "Maskパディング色";
            this.ParaMaskValue.ParameterChange += new FilterBase.Parts.ParameterChangeEventHandler(this.Param_ParameterChange);
            // 
            // ParaApproximate
            // 
            this.ParaApproximate.ArgumentName = "approximate";
            this.ParaApproximate.CheckedValue = "";
            this.ParaApproximate.Description = "弾性変換の近似バージョンを使用するかどうか。\r\nTrue の場合、ガウス平滑化に固定カーネル サイズを使用します。\r\n　　これは高速ですが、シグマ値が大きい場合は" +
    "精度が低下する可能性があります。\r\nデフォルト: False";
            this.ParaApproximate.IndeterminateValue = "";
            this.ParaApproximate.Location = new System.Drawing.Point(3, 253);
            this.ParaApproximate.Margin = new System.Windows.Forms.Padding(3, 3, 1, 3);
            this.ParaApproximate.MaxVersion = null;
            this.ParaApproximate.MinimumSize = new System.Drawing.Size(122, 21);
            this.ParaApproximate.MinVersion = null;
            this.ParaApproximate.Name = "ParaApproximate";
            this.ParaApproximate.Size = new System.Drawing.Size(122, 35);
            this.ParaApproximate.TabIndex = 11;
            this.ParaApproximate.Text = "弾性変換の近似バージョンを使用";
            this.ParaApproximate.Title = "弾性変換の近似バージョンを使用";
            this.HelpToolTip.SetToolTip(this.ParaApproximate, "弾性変換の近似バージョンを使用するかどうか。\r\nTrue の場合、ガウス平滑化に固定カーネル サイズを使用します。\r\n　　これは高速ですが、シグマ値が大きい場合は" +
        "精度が低下する可能性があります。\r\nデフォルト: False");
            this.ParaApproximate.UncheckedValue = "";
            this.ParaApproximate.UseVisualStyleBackColor = true;
            this.ParaApproximate.Value = "Unchecked";
            this.ParaApproximate.ParameterChange += new FilterBase.Parts.ParameterChangeEventHandler(this.Param_ParameterChange);
            // 
            // ParaSameDxdy
            // 
            this.ParaSameDxdy.ArgumentName = "same_dxdy";
            this.ParaSameDxdy.CheckedValue = "";
            this.ParaSameDxdy.Description = "x方向と y方向の両方に同じランダム変位フィールドを使用するかどうか。\r\n歪みの多様性は減りますが、変換を高速化できます。\r\nデフォルト: False";
            this.ParaSameDxdy.IndeterminateValue = "";
            this.ParaSameDxdy.Location = new System.Drawing.Point(3, 294);
            this.ParaSameDxdy.Margin = new System.Windows.Forms.Padding(3, 3, 1, 3);
            this.ParaSameDxdy.MaxVersion = null;
            this.ParaSameDxdy.MinimumSize = new System.Drawing.Size(122, 21);
            this.ParaSameDxdy.MinVersion = null;
            this.ParaSameDxdy.Name = "ParaSameDxdy";
            this.ParaSameDxdy.Size = new System.Drawing.Size(122, 41);
            this.ParaSameDxdy.TabIndex = 12;
            this.ParaSameDxdy.Text = "x,yの両方に同じランダム変位フィールドを使用";
            this.ParaSameDxdy.Title = "x,yの両方に同じランダム変位フィールドを使用";
            this.HelpToolTip.SetToolTip(this.ParaSameDxdy, "x方向と y方向の両方に同じランダム変位フィールドを使用するかどうか。\r\n歪みの多様性は減りますが、変換を高速化できます。\r\nデフォルト: False");
            this.ParaSameDxdy.UncheckedValue = "";
            this.ParaSameDxdy.UseVisualStyleBackColor = true;
            this.ParaSameDxdy.Value = "Unchecked";
            this.ParaSameDxdy.ParameterChange += new FilterBase.Parts.ParameterChangeEventHandler(this.Param_ParameterChange);
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
            this.ParaMaskInterpolation.Location = new System.Drawing.Point(3, 341);
            this.ParaMaskInterpolation.MaxVersion = null;
            this.ParaMaskInterpolation.MinimumSize = new System.Drawing.Size(124, 21);
            this.ParaMaskInterpolation.MinVersion = null;
            this.ParaMaskInterpolation.Name = "ParaMaskInterpolation";
            this.ParaMaskInterpolation.Required = false;
            this.ParaMaskInterpolation.Size = new System.Drawing.Size(124, 38);
            this.ParaMaskInterpolation.TabIndex = 7;
            this.ParaMaskInterpolation.Title = "マスク補間方法";
            this.ParaMaskInterpolation.Value = null;
            this.ParaMaskInterpolation.ParameterChange += new FilterBase.Parts.ParameterChangeEventHandler(this.Param_ParameterChange);
            // 
            // ParaNoiseDistribution
            // 
            this.ParaNoiseDistribution.ArgumentName = "noise_distribution";
            this.ParaNoiseDistribution.AutoSize = true;
            this.ParaNoiseDistribution.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ParaNoiseDistribution.DefaultValue = "";
            this.ParaNoiseDistribution.Description = "変位フィールドを生成するために使用される分布。\r\n「ガウス」は正規分布を使用してフィールドを生成します（より自然な変形）。\r\n「均一」は均一分布を使用してフィール" +
    "ドを生成します（より機械的な変形）。\r\nデフォルト: 「ガウス」。";
            this.ParaNoiseDistribution.ItemType = "System.String";
            this.ParaNoiseDistribution.Location = new System.Drawing.Point(3, 385);
            this.ParaNoiseDistribution.MaxVersion = null;
            this.ParaNoiseDistribution.MinimumSize = new System.Drawing.Size(124, 21);
            this.ParaNoiseDistribution.MinVersion = "1.4.22";
            this.ParaNoiseDistribution.Name = "ParaNoiseDistribution";
            this.ParaNoiseDistribution.Required = false;
            this.ParaNoiseDistribution.Size = new System.Drawing.Size(124, 38);
            this.ParaNoiseDistribution.TabIndex = 13;
            this.ParaNoiseDistribution.Title = "ノイズ分布";
            this.ParaNoiseDistribution.Value = null;
            this.ParaNoiseDistribution.ParameterChange += new FilterBase.Parts.ParameterChangeEventHandler(this.Param_ParameterChange);
            // 
            // ElasticTransform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.FLPParam);
            this.Name = "ElasticTransform";
            this.Size = new System.Drawing.Size(128, 476);
            this.Controls.SetChildIndex(this.FLPParam, 0);
            this.FLPParam.ResumeLayout(false);
            this.FLPParam.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ParaAlpha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaSigma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaInterpolation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaBorderMode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaMaskValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaMaskInterpolation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaNoiseDistribution)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel FLPParam;
        private FilterBase.Parts.InputValueUpDown ParaAlpha;
        private FilterBase.Parts.InputValueUpDown ParaSigma;
        private FilterBase.Parts.ComboBoxWithLabelParts ParaInterpolation;
        private FilterBase.Parts.ComboBoxWithLabelParts ParaMaskInterpolation;
        private FilterBase.Parts.ComboBoxWithLabelParts ParaBorderMode;
        private FilterBase.Parts.ColorSelectorParts ParaValue;
        private FilterBase.Parts.ColorSelectorParts ParaMaskValue;
        private FilterBase.Parts.CheckBoxParts ParaApproximate;
        private FilterBase.Parts.CheckBoxParts ParaSameDxdy;
        private FilterBase.Parts.ComboBoxWithLabelParts ParaNoiseDistribution;
    }
}
