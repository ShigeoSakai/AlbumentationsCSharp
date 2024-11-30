namespace Filter.Blur
{
    partial class Defocus
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
            this.ParaRadius = new FilterBase.Parts.InputMaxMin();
            this.ParaAliasBlur = new FilterBase.Parts.InputMaxMin();
            this.FLPParam.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ParaRadius)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaAliasBlur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // FLPParam
            // 
            this.FLPParam.AutoSize = true;
            this.FLPParam.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.FLPParam.Controls.Add(this.ParaRadius);
            this.FLPParam.Controls.Add(this.ParaAliasBlur);
            this.FLPParam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FLPParam.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.FLPParam.Location = new System.Drawing.Point(0, 25);
            this.FLPParam.Name = "FLPParam";
            this.FLPParam.Size = new System.Drawing.Size(128, 108);
            this.FLPParam.TabIndex = 5;
            // 
            // ParaRadius
            // 
            this.ParaRadius.ArgumentName = "radius";
            this.ParaRadius.AutoSize = true;
            this.ParaRadius.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ParaRadius.DecimalPlace = 0;
            this.ParaRadius.Description = "デフォーカス ブラーの半径の範囲。\r\n 単一の int が指定された場合、範囲は [1, radius] になります。\r\n 値が大きいほど、ブラー効果が強くなりま" +
    "す。\r\n            既定値: (3, 10) ";
            this.ParaRadius.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ParaRadius.Location = new System.Drawing.Point(3, 3);
            this.ParaRadius.MaxValue = null;
            this.ParaRadius.MaxVersion = null;
            this.ParaRadius.MinimumSize = new System.Drawing.Size(124, 21);
            this.ParaRadius.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ParaRadius.MinVersion = null;
            this.ParaRadius.Name = "ParaRadius";
            this.ParaRadius.Required = false;
            this.ParaRadius.Size = new System.Drawing.Size(124, 42);
            this.ParaRadius.TabIndex = 0;
            this.ParaRadius.Title = "半径";
            this.ParaRadius.Value = "(3,10)";
            this.ParaRadius.ValueType = FilterBase.Parts.PartsFunc.VALUE_TYPE.TYPE_INT;
            this.ParaRadius.ParameterChange += new FilterBase.Parts.ParameterChangeEventHandler(this.Param_ParameterChange);
            // 
            // ParaAliasBlur
            // 
            this.ParaAliasBlur.ArgumentName = "alias_blur";
            this.ParaAliasBlur.AutoSize = true;
            this.ParaAliasBlur.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ParaAliasBlur.DecimalPlace = 1;
            this.ParaAliasBlur.Description = "メインの焦点ずれぼかしの後に適用されるガウスぼかしの標準偏差の範囲。\r\nこれはエイリアシング アーティファクトを減らすのに役立ちます。\r\n値が大きいほど、より滑ら" +
    "かでエイリアシング効果が大きくなります。\r\n　　　　デフォルト: (0.1, 0.5)";
            this.ParaAliasBlur.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.ParaAliasBlur.Location = new System.Drawing.Point(3, 51);
            this.ParaAliasBlur.MaxValue = null;
            this.ParaAliasBlur.MaxVersion = null;
            this.ParaAliasBlur.MinimumSize = new System.Drawing.Size(124, 21);
            this.ParaAliasBlur.MinValue = null;
            this.ParaAliasBlur.MinVersion = null;
            this.ParaAliasBlur.Name = "ParaAliasBlur";
            this.ParaAliasBlur.Required = false;
            this.ParaAliasBlur.Size = new System.Drawing.Size(124, 54);
            this.ParaAliasBlur.TabIndex = 1;
            this.ParaAliasBlur.Title = "ガウスぼかしの標準偏差の範囲";
            this.ParaAliasBlur.Value = "(0.1,0.5)";
            this.ParaAliasBlur.ValueType = FilterBase.Parts.PartsFunc.VALUE_TYPE.TYPE_FLOAT;
            this.ParaAliasBlur.ParameterChange += new FilterBase.Parts.ParameterChangeEventHandler(this.Param_ParameterChange);
            // 
            // Defocus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.FLPParam);
            this.Name = "Defocus";
            this.Size = new System.Drawing.Size(128, 158);
            this.Target = FilterBase.BaseFilterControl.TRANSFORM_TARGET.IMAGE;
            this.Controls.SetChildIndex(this.FLPParam, 0);
            this.FLPParam.ResumeLayout(false);
            this.FLPParam.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ParaRadius)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaAliasBlur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel FLPParam;
        private FilterBase.Parts.InputMaxMin ParaRadius;
        private FilterBase.Parts.InputMaxMin ParaAliasBlur;
    }
}
