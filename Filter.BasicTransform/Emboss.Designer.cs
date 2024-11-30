namespace Filter.BasicTransform
{
    partial class Emboss
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
            this.ParamAlpha = new FilterBase.Parts.InputMaxMin();
            this.ParaStrength = new FilterBase.Parts.InputMaxMin();
            this.FLPParam.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ParamAlpha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaStrength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // FLPParam
            // 
            this.FLPParam.AutoSize = true;
            this.FLPParam.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.FLPParam.Controls.Add(this.ParamAlpha);
            this.FLPParam.Controls.Add(this.ParaStrength);
            this.FLPParam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FLPParam.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.FLPParam.Location = new System.Drawing.Point(0, 25);
            this.FLPParam.Name = "FLPParam";
            this.FLPParam.Size = new System.Drawing.Size(128, 96);
            this.FLPParam.TabIndex = 5;
            // 
            // ParamAlpha
            // 
            this.ParamAlpha.ArgumentName = "alpha";
            this.ParamAlpha.AutoSize = true;
            this.ParamAlpha.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ParamAlpha.DecimalPlace = 1;
            this.ParamAlpha.Description = "エンボス画像の可視性を選択する範囲。\r\n  0 の場合は元の画像のみが表示され、1.0 の場合はエンボス加工されたバージョンの画像のみが表示されます。\r\n  値は" +
    "[0, 1]の範囲になければなりません。\r\n  各画像に対して、アルファはこの範囲からランダムに選択されます。\r\n  　　　　デフォルト: (0.2, 0.5)" +
    "";
            this.ParamAlpha.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.ParamAlpha.Location = new System.Drawing.Point(3, 3);
            this.ParamAlpha.MaxValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ParamAlpha.MaxVersion = null;
            this.ParamAlpha.MinimumSize = new System.Drawing.Size(124, 21);
            this.ParamAlpha.MinValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.ParamAlpha.MinVersion = null;
            this.ParamAlpha.Name = "ParamAlpha";
            this.ParamAlpha.Required = false;
            this.ParamAlpha.Size = new System.Drawing.Size(124, 42);
            this.ParamAlpha.TabIndex = 0;
            this.ParamAlpha.Title = "α値";
            this.ParamAlpha.Value = "(0.2,0.5)";
            this.ParamAlpha.ValueType = FilterBase.Parts.PartsFunc.VALUE_TYPE.TYPE_FLOAT;
            this.ParamAlpha.ParameterChange += new FilterBase.Parts.ParameterChangeEventHandler(this.Param_ParameterChange);
            // 
            // ParaStrength
            // 
            this.ParaStrength.ArgumentName = "strength";
            this.ParaStrength.AutoSize = true;
            this.ParaStrength.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ParaStrength.DecimalPlace = 1;
            this.ParaStrength.Description = "エンボス効果の強さを選択する範囲。\r\n 値が高いほど、3D 効果が顕著になります。\r\n 値は負でない必要があります。\r\n 画像ごとにこの範囲から強度がランダムに選" +
    "択されます。\r\n　　　　 デフォルト: (0.2, 0.7)";
            this.ParaStrength.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.ParaStrength.Location = new System.Drawing.Point(3, 51);
            this.ParaStrength.MaxValue = null;
            this.ParaStrength.MaxVersion = null;
            this.ParaStrength.MinimumSize = new System.Drawing.Size(124, 21);
            this.ParaStrength.MinValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.ParaStrength.MinVersion = null;
            this.ParaStrength.Name = "ParaStrength";
            this.ParaStrength.Required = false;
            this.ParaStrength.Size = new System.Drawing.Size(124, 42);
            this.ParaStrength.TabIndex = 1;
            this.ParaStrength.Title = "強さ";
            this.ParaStrength.Value = "(0.2,0.7)";
            this.ParaStrength.ValueType = FilterBase.Parts.PartsFunc.VALUE_TYPE.TYPE_FLOAT;
            this.ParaStrength.ParameterChange += new FilterBase.Parts.ParameterChangeEventHandler(this.Param_ParameterChange);
            // 
            // Emboss
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.FLPParam);
            this.Name = "Emboss";
            this.Size = new System.Drawing.Size(128, 146);
            this.Target = FilterBase.BaseFilterControl.TRANSFORM_TARGET.IMAGE;
            this.Controls.SetChildIndex(this.FLPParam, 0);
            this.FLPParam.ResumeLayout(false);
            this.FLPParam.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ParamAlpha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaStrength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel FLPParam;
        private FilterBase.Parts.InputMaxMin ParamAlpha;
        private FilterBase.Parts.InputMaxMin ParaStrength;
    }
}
