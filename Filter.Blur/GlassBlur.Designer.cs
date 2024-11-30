namespace Filter.Blur
{
    partial class GlassBlur
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
            this.ParaSigma = new FilterBase.Parts.InputValueUpDown();
            this.ParaMaxDelta = new FilterBase.Parts.InputValueUpDown();
            this.ParaIterations = new FilterBase.Parts.InputValueUpDown();
            this.ParaMode = new FilterBase.Parts.ComboBoxWithLabelParts();
            this.FLPParam.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ParaSigma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaMaxDelta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaIterations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaMode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // FLPParam
            // 
            this.FLPParam.AutoSize = true;
            this.FLPParam.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.FLPParam.Controls.Add(this.ParaSigma);
            this.FLPParam.Controls.Add(this.ParaMaxDelta);
            this.FLPParam.Controls.Add(this.ParaIterations);
            this.FLPParam.Controls.Add(this.ParaMode);
            this.FLPParam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FLPParam.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.FLPParam.Location = new System.Drawing.Point(0, 25);
            this.FLPParam.Name = "FLPParam";
            this.FLPParam.Size = new System.Drawing.Size(128, 125);
            this.FLPParam.TabIndex = 5;
            // 
            // ParaSigma
            // 
            this.ParaSigma.ArgumentName = "sigma";
            this.ParaSigma.AutoSize = true;
            this.ParaSigma.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ParaSigma.ControlLayout = FilterBase.Parts.InputValue.LAYOUT.Horizontal;
            this.ParaSigma.DecimalPlace = 1;
            this.ParaSigma.Description = "プロセスで使用されるガウスカーネルの標準偏差。\r\n値が大きいほど、ぼかし効果が増します。負でない値にする必要があります。\r\nデフォルト: 0.7";
            this.ParaSigma.Location = new System.Drawing.Point(3, 3);
            this.ParaSigma.MaxValue = null;
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
            this.ParaSigma.TabIndex = 0;
            this.ParaSigma.Title = "Σ";
            this.ParaSigma.Unit = "";
            this.ParaSigma.Value = new decimal(new int[] {
            7,
            0,
            0,
            65536});
            this.ParaSigma.ValueType = FilterBase.Parts.InputValue.VALUE_TYPE.FLOAT;
            this.ParaSigma.ParameterChange += new FilterBase.Parts.ParameterChangeEventHandler(this.Param_ParameterChange);
            // 
            // ParaMaxDelta
            // 
            this.ParaMaxDelta.ArgumentName = "max_delta";
            this.ParaMaxDelta.AutoSize = true;
            this.ParaMaxDelta.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ParaMaxDelta.ControlLayout = FilterBase.Parts.InputValue.LAYOUT.Horizontal;
            this.ParaMaxDelta.DecimalPlace = 0;
            this.ParaMaxDelta.Description = "シャッフルするピクセルの最大距離。\r\nピクセルを移動できる距離を決定します。値が大きいほど歪みが大きくなります。\r\n正の整数である必要があります。\r\n　　　デフォ" +
    "ルト: 4";
            this.ParaMaxDelta.Location = new System.Drawing.Point(3, 30);
            this.ParaMaxDelta.MaxValue = null;
            this.ParaMaxDelta.MaxVersion = null;
            this.ParaMaxDelta.MinimumSize = new System.Drawing.Size(124, 21);
            this.ParaMaxDelta.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ParaMaxDelta.MinVersion = null;
            this.ParaMaxDelta.Name = "ParaMaxDelta";
            this.ParaMaxDelta.Required = false;
            this.ParaMaxDelta.Size = new System.Drawing.Size(124, 21);
            this.ParaMaxDelta.TabIndex = 1;
            this.ParaMaxDelta.Title = "Δmax";
            this.ParaMaxDelta.Unit = "";
            this.ParaMaxDelta.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.ParaMaxDelta.ValueType = FilterBase.Parts.InputValue.VALUE_TYPE.INT;
            this.ParaMaxDelta.ParameterChange += new FilterBase.Parts.ParameterChangeEventHandler(this.Param_ParameterChange);
            // 
            // ParaIterations
            // 
            this.ParaIterations.ArgumentName = "iterations";
            this.ParaIterations.AutoSize = true;
            this.ParaIterations.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ParaIterations.ControlLayout = FilterBase.Parts.InputValue.LAYOUT.Horizontal;
            this.ParaIterations.DecimalPlace = 0;
            this.ParaIterations.Description = "ガラスのぼかし効果を適用する回数。\r\n繰り返し回数が多いほど効果は強くなりますが、計算時間も長くなります。\r\n正の整数にする必要があります。\r\n　　デフォルト: " +
    "2";
            this.ParaIterations.Location = new System.Drawing.Point(3, 57);
            this.ParaIterations.MaxValue = null;
            this.ParaIterations.MaxVersion = null;
            this.ParaIterations.MinimumSize = new System.Drawing.Size(124, 21);
            this.ParaIterations.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ParaIterations.MinVersion = null;
            this.ParaIterations.Name = "ParaIterations";
            this.ParaIterations.Required = false;
            this.ParaIterations.Size = new System.Drawing.Size(124, 21);
            this.ParaIterations.TabIndex = 2;
            this.ParaIterations.Title = "回数";
            this.ParaIterations.Unit = "回";
            this.ParaIterations.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.ParaIterations.ValueType = FilterBase.Parts.InputValue.VALUE_TYPE.INT;
            this.ParaIterations.ParameterChange += new FilterBase.Parts.ParameterChangeEventHandler(this.Param_ParameterChange);
            // 
            // ParaMode
            // 
            this.ParaMode.ArgumentName = "mode";
            this.ParaMode.AutoSize = true;
            this.ParaMode.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ParaMode.DefaultValue = "";
            this.ParaMode.Description = "計算モード。\r\nオプションは次のとおりです:\r\n- 「高速」: 高速ですが、精度が低くなる可能性があります。\r\n- 「正確」: 低速ですが、精度が高い方法を使用し" +
    "ます。\r\nデフォルト: 「高速」";
            this.ParaMode.ItemType = "System.String";
            this.ParaMode.Location = new System.Drawing.Point(3, 84);
            this.ParaMode.MaxVersion = null;
            this.ParaMode.MinimumSize = new System.Drawing.Size(124, 21);
            this.ParaMode.MinVersion = null;
            this.ParaMode.Name = "ParaMode";
            this.ParaMode.Required = false;
            this.ParaMode.Size = new System.Drawing.Size(124, 38);
            this.ParaMode.TabIndex = 3;
            this.ParaMode.Title = "モード";
            this.ParaMode.Value = null;
            this.ParaMode.ParameterChange += new FilterBase.Parts.ParameterChangeEventHandler(this.Param_ParameterChange);
            // 
            // GlassBlur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.FLPParam);
            this.Name = "GlassBlur";
            this.Size = new System.Drawing.Size(128, 175);
            this.Target = FilterBase.BaseFilterControl.TRANSFORM_TARGET.IMAGE;
            this.Controls.SetChildIndex(this.FLPParam, 0);
            this.FLPParam.ResumeLayout(false);
            this.FLPParam.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ParaSigma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaMaxDelta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaIterations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaMode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel FLPParam;
        private FilterBase.Parts.InputValueUpDown ParaSigma;
        private FilterBase.Parts.InputValueUpDown ParaMaxDelta;
        private FilterBase.Parts.InputValueUpDown ParaIterations;
        private FilterBase.Parts.ComboBoxWithLabelParts ParaMode;
    }
}
