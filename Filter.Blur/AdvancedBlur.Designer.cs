namespace Filter.Blur
{
    partial class AdvancedBlur
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
            this.ParaBlurLimit = new FilterBase.Parts.InputKernelSize();
            this.ParaSigmaXLimit = new FilterBase.Parts.InputMaxMin();
            this.ParaSigmaYLimit = new FilterBase.Parts.InputMaxMin();
            this.ParaRotateLimit = new FilterBase.Parts.InputMaxMin();
            this.ParaBetaLimit = new FilterBase.Parts.InputMaxMin();
            this.ParaNoiseLimit = new FilterBase.Parts.InputMaxMin();
            this.FLPParam.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ParaBlurLimit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaSigmaXLimit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaSigmaYLimit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaRotateLimit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaBetaLimit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaNoiseLimit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // FLPParam
            // 
            this.FLPParam.AutoSize = true;
            this.FLPParam.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.FLPParam.Controls.Add(this.ParaBlurLimit);
            this.FLPParam.Controls.Add(this.ParaSigmaXLimit);
            this.FLPParam.Controls.Add(this.ParaSigmaYLimit);
            this.FLPParam.Controls.Add(this.ParaRotateLimit);
            this.FLPParam.Controls.Add(this.ParaBetaLimit);
            this.FLPParam.Controls.Add(this.ParaNoiseLimit);
            this.FLPParam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FLPParam.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.FLPParam.Location = new System.Drawing.Point(0, 25);
            this.FLPParam.Name = "FLPParam";
            this.FLPParam.Size = new System.Drawing.Size(128, 287);
            this.FLPParam.TabIndex = 5;
            // 
            // ParaBlurLimit
            // 
            this.ParaBlurLimit.ArgumentName = "blur_limit";
            this.ParaBlurLimit.AutoSize = true;
            this.ParaBlurLimit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ParaBlurLimit.DecimalPlace = 0;
            this.ParaBlurLimit.Description = "ぼかしカーネルのサイズを制御します。単一の int を指定した場合、カーネル サイズは 3 とその値の間でランダムに選択されます。\r\n奇数で 3 以上である必要が" +
    "あります。値が大きいほど、ぼかし効果が強くなります。\r\n　　　デフォルト: (3, 7)";
            this.ParaBlurLimit.FirstMaxIsSecondValue = true;
            this.ParaBlurLimit.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.ParaBlurLimit.Location = new System.Drawing.Point(3, 3);
            this.ParaBlurLimit.MaxValue = "";
            this.ParaBlurLimit.MaxVersion = null;
            this.ParaBlurLimit.MinimumSize = new System.Drawing.Size(124, 21);
            this.ParaBlurLimit.MinValue = "(3,3)";
            this.ParaBlurLimit.MinVersion = null;
            this.ParaBlurLimit.Name = "ParaBlurLimit";
            this.ParaBlurLimit.Required = false;
            this.ParaBlurLimit.Size = new System.Drawing.Size(124, 41);
            this.ParaBlurLimit.TabIndex = 0;
            this.ParaBlurLimit.Title = "カーネルサイズ";
            this.ParaBlurLimit.Value = "(3,7)";
            this.ParaBlurLimit.ValueType = FilterBase.Parts.PartsFunc.VALUE_TYPE.TYPE_INT_ODD;
            this.ParaBlurLimit.ParameterChange += new FilterBase.Parts.ParameterChangeEventHandler(this.Param_ParameterChange);
            // 
            // ParaSigmaXLimit
            // 
            this.ParaSigmaXLimit.ArgumentName = "sigma_x_limit";
            this.ParaSigmaXLimit.AutoSize = true;
            this.ParaSigmaXLimit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ParaSigmaXLimit.DecimalPlace = 1;
            this.ParaSigmaXLimit.Description = "X方向のぼかしの広がりを制御します。\r\n値が大きいほどぼかしの強度が増します。\r\n　　デフォルト: (0.2,1.0)";
            this.ParaSigmaXLimit.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.ParaSigmaXLimit.Location = new System.Drawing.Point(3, 50);
            this.ParaSigmaXLimit.MaxValue = null;
            this.ParaSigmaXLimit.MaxVersion = null;
            this.ParaSigmaXLimit.MinimumSize = new System.Drawing.Size(124, 21);
            this.ParaSigmaXLimit.MinValue = null;
            this.ParaSigmaXLimit.MinVersion = null;
            this.ParaSigmaXLimit.Name = "ParaSigmaXLimit";
            this.ParaSigmaXLimit.Required = false;
            this.ParaSigmaXLimit.Size = new System.Drawing.Size(124, 42);
            this.ParaSigmaXLimit.TabIndex = 1;
            this.ParaSigmaXLimit.Title = "X方向のぼかし";
            this.ParaSigmaXLimit.Value = "(0.2,1.0)";
            this.ParaSigmaXLimit.ValueType = FilterBase.Parts.PartsFunc.VALUE_TYPE.TYPE_FLOAT;
            this.ParaSigmaXLimit.ParameterChange += new FilterBase.Parts.ParameterChangeEventHandler(this.Param_ParameterChange);
            // 
            // ParaSigmaYLimit
            // 
            this.ParaSigmaYLimit.ArgumentName = "sigma_y_limit";
            this.ParaSigmaYLimit.AutoSize = true;
            this.ParaSigmaYLimit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ParaSigmaYLimit.DecimalPlace = 1;
            this.ParaSigmaYLimit.Description = "Y方向のぼかしの広がりを制御します。\r\n値が大きいほどぼかしの強度が増します。\r\n　　デフォルト: (0.2,1.0)";
            this.ParaSigmaYLimit.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.ParaSigmaYLimit.Location = new System.Drawing.Point(3, 98);
            this.ParaSigmaYLimit.MaxValue = null;
            this.ParaSigmaYLimit.MaxVersion = null;
            this.ParaSigmaYLimit.MinimumSize = new System.Drawing.Size(124, 21);
            this.ParaSigmaYLimit.MinValue = null;
            this.ParaSigmaYLimit.MinVersion = null;
            this.ParaSigmaYLimit.Name = "ParaSigmaYLimit";
            this.ParaSigmaYLimit.Required = false;
            this.ParaSigmaYLimit.Size = new System.Drawing.Size(124, 42);
            this.ParaSigmaYLimit.TabIndex = 2;
            this.ParaSigmaYLimit.Title = "Y方向のぼかし";
            this.ParaSigmaYLimit.Value = "(0.2,1.0)";
            this.ParaSigmaYLimit.ValueType = FilterBase.Parts.PartsFunc.VALUE_TYPE.TYPE_FLOAT;
            this.ParaSigmaYLimit.ParameterChange += new FilterBase.Parts.ParameterChangeEventHandler(this.Param_ParameterChange);
            // 
            // ParaRotateLimit
            // 
            this.ParaRotateLimit.ArgumentName = "rotate_limit";
            this.ParaRotateLimit.AutoSize = true;
            this.ParaRotateLimit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ParaRotateLimit.DecimalPlace = 0;
            this.ParaRotateLimit.Description = "カーネルを回転する角度の範囲 (度単位)。\r\nこの回転により、斜めのぼかし方向が可能になります。\r\n　　デフォルト: (-90,90)";
            this.ParaRotateLimit.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ParaRotateLimit.Location = new System.Drawing.Point(3, 146);
            this.ParaRotateLimit.MaxValue = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.ParaRotateLimit.MaxVersion = null;
            this.ParaRotateLimit.MinimumSize = new System.Drawing.Size(124, 21);
            this.ParaRotateLimit.MinValue = new decimal(new int[] {
            180,
            0,
            0,
            -2147483648});
            this.ParaRotateLimit.MinVersion = null;
            this.ParaRotateLimit.Name = "ParaRotateLimit";
            this.ParaRotateLimit.Required = false;
            this.ParaRotateLimit.Size = new System.Drawing.Size(124, 42);
            this.ParaRotateLimit.TabIndex = 3;
            this.ParaRotateLimit.Title = "カーネル回転角度";
            this.ParaRotateLimit.Value = "(-90,90)";
            this.ParaRotateLimit.ValueType = FilterBase.Parts.PartsFunc.VALUE_TYPE.TYPE_INT;
            this.ParaRotateLimit.ParameterChange += new FilterBase.Parts.ParameterChangeEventHandler(this.Param_ParameterChange);
            // 
            // ParaBetaLimit
            // 
            this.ParaBetaLimit.ArgumentName = "beta_limit";
            this.ParaBetaLimit.AutoSize = true;
            this.ParaBetaLimit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ParaBetaLimit.DecimalPlace = 1;
            this.ParaBetaLimit.Description = "一般化ガウス分布の形状パラメータ。\r\n- beta = 1 は標準ガウス分布になります\r\n- beta < 1 はより重い尾部を作成し、より均一なボックスのような" +
    "ぼかしになります\r\n- beta > 1 はより軽い尾部を作成し、より尖った、焦点の合ったぼかしになります\r\n　　デフォルト: (0.5,8.0)";
            this.ParaBetaLimit.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.ParaBetaLimit.Location = new System.Drawing.Point(3, 194);
            this.ParaBetaLimit.MaxValue = null;
            this.ParaBetaLimit.MaxVersion = null;
            this.ParaBetaLimit.MinimumSize = new System.Drawing.Size(124, 21);
            this.ParaBetaLimit.MinValue = null;
            this.ParaBetaLimit.MinVersion = null;
            this.ParaBetaLimit.Name = "ParaBetaLimit";
            this.ParaBetaLimit.Required = false;
            this.ParaBetaLimit.Size = new System.Drawing.Size(124, 42);
            this.ParaBetaLimit.TabIndex = 4;
            this.ParaBetaLimit.Title = "ガウス分布の形状";
            this.ParaBetaLimit.Value = "(0.5,8.0)";
            this.ParaBetaLimit.ValueType = FilterBase.Parts.PartsFunc.VALUE_TYPE.TYPE_FLOAT;
            this.ParaBetaLimit.ParameterChange += new FilterBase.Parts.ParameterChangeEventHandler(this.Param_ParameterChange);
            // 
            // ParaNoiseLimit
            // 
            this.ParaNoiseLimit.ArgumentName = "noise_limit";
            this.ParaNoiseLimit.AutoSize = true;
            this.ParaNoiseLimit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ParaNoiseLimit.DecimalPlace = 2;
            this.ParaNoiseLimit.Description = "カーネルに適用される乗法ノイズの強度を制御します。\r\n1.0 付近の値は元のカーネルをほぼそのまま維持しますが、\r\n1.0 から離れた値ではより多くのバリエーショ" +
    "ンが導入されます。\r\n　　デフォルト: (0.75,1.25)";
            this.ParaNoiseLimit.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.ParaNoiseLimit.Location = new System.Drawing.Point(3, 242);
            this.ParaNoiseLimit.MaxValue = null;
            this.ParaNoiseLimit.MaxVersion = null;
            this.ParaNoiseLimit.MinimumSize = new System.Drawing.Size(124, 21);
            this.ParaNoiseLimit.MinValue = null;
            this.ParaNoiseLimit.MinVersion = null;
            this.ParaNoiseLimit.Name = "ParaNoiseLimit";
            this.ParaNoiseLimit.Required = false;
            this.ParaNoiseLimit.Size = new System.Drawing.Size(124, 42);
            this.ParaNoiseLimit.TabIndex = 5;
            this.ParaNoiseLimit.Title = "ノイズ強度";
            this.ParaNoiseLimit.Value = "(0.75,1.25)";
            this.ParaNoiseLimit.ValueType = FilterBase.Parts.PartsFunc.VALUE_TYPE.TYPE_FLOAT;
            this.ParaNoiseLimit.ParameterChange += new FilterBase.Parts.ParameterChangeEventHandler(this.Param_ParameterChange);
            // 
            // AdvancedBlur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.FLPParam);
            this.Name = "AdvancedBlur";
            this.Size = new System.Drawing.Size(128, 337);
            this.Target = FilterBase.BaseFilterControl.TRANSFORM_TARGET.IMAGE;
            this.Controls.SetChildIndex(this.FLPParam, 0);
            this.FLPParam.ResumeLayout(false);
            this.FLPParam.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ParaBlurLimit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaSigmaXLimit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaSigmaYLimit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaRotateLimit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaBetaLimit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaNoiseLimit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel FLPParam;
        private FilterBase.Parts.InputKernelSize ParaBlurLimit;
        private FilterBase.Parts.InputMaxMin ParaSigmaXLimit;
        private FilterBase.Parts.InputMaxMin ParaSigmaYLimit;
        private FilterBase.Parts.InputMaxMin ParaRotateLimit;
        private FilterBase.Parts.InputMaxMin ParaBetaLimit;
        private FilterBase.Parts.InputMaxMin ParaNoiseLimit;
    }
}
