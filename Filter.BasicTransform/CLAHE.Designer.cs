namespace Filter.BasicTransform
{
    partial class CLAHE
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
            this.ParaClipLimit = new FilterBase.Parts.InputMaxMin();
            this.ParaTileGridSize = new FilterBase.Parts.InputTuple();
            this.FLPParam.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ParaClipLimit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaTileGridSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // FLPParam
            // 
            this.FLPParam.AutoSize = true;
            this.FLPParam.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.FLPParam.Controls.Add(this.ParaClipLimit);
            this.FLPParam.Controls.Add(this.ParaTileGridSize);
            this.FLPParam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FLPParam.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.FLPParam.Location = new System.Drawing.Point(0, 25);
            this.FLPParam.Name = "FLPParam";
            this.FLPParam.Size = new System.Drawing.Size(128, 95);
            this.FLPParam.TabIndex = 5;
            // 
            // ParaClipLimit
            // 
            this.ParaClipLimit.ArgumentName = "clip_limit";
            this.ParaClipLimit.AutoSize = true;
            this.ParaClipLimit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ParaClipLimit.DecimalPlace = 1;
            this.ParaClipLimit.Description = "コントラスト強調の制限を制御します。\r\n- 2 つの浮動小数点数のタプルを指定した場合、ランダム選択の範囲を定義します。\r\n値を大きくするとコントラスト強調が強化" +
    "されますが、ノイズも増加する可能性があります。\r\n　　デフォルト: (1, 4)";
            this.ParaClipLimit.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.ParaClipLimit.Location = new System.Drawing.Point(3, 3);
            this.ParaClipLimit.MaxValue = null;
            this.ParaClipLimit.MaxVersion = null;
            this.ParaClipLimit.MinimumSize = new System.Drawing.Size(124, 21);
            this.ParaClipLimit.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ParaClipLimit.MinVersion = null;
            this.ParaClipLimit.Name = "ParaClipLimit";
            this.ParaClipLimit.Required = false;
            this.ParaClipLimit.Size = new System.Drawing.Size(124, 42);
            this.ParaClipLimit.TabIndex = 0;
            this.ParaClipLimit.Title = "コントラスト強調の制限";
            this.ParaClipLimit.Value = "(1.0,4.0)";
            this.ParaClipLimit.ValueType = FilterBase.Parts.PartsFunc.VALUE_TYPE.TYPE_FLOAT;
            this.ParaClipLimit.ParameterChange += new FilterBase.Parts.ParameterChangeEventHandler(this.Param_ParameterChange);
            // 
            // ParaTileGridSize
            // 
            this.ParaTileGridSize.ArgumentName = "tile_grid_size";
            this.ParaTileGridSize.AutoSize = true;
            this.ParaTileGridSize.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ParaTileGridSize.DecimalPlace = 0;
            this.ParaTileGridSize.Description = "行方向と列方向のタイルの数を定義します。\r\n形式は (行、列) です。\r\nタイルのサイズが小さいほど、局所的な強調効果が得られ、\r\nサイズが大きいほど、全体的なヒ" +
    "ストグラム均等化に近い結果が得られます。\r\n　　デフォルト: (8, 8)";
            this.ParaTileGridSize.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ParaTileGridSize.Location = new System.Drawing.Point(3, 51);
            this.ParaTileGridSize.MaxValue = "";
            this.ParaTileGridSize.MaxVersion = null;
            this.ParaTileGridSize.MinimumSize = new System.Drawing.Size(124, 21);
            this.ParaTileGridSize.MinValue = "(1,1)";
            this.ParaTileGridSize.MinVersion = null;
            this.ParaTileGridSize.Name = "ParaTileGridSize";
            this.ParaTileGridSize.Required = false;
            this.ParaTileGridSize.Size = new System.Drawing.Size(124, 41);
            this.ParaTileGridSize.TabIndex = 1;
            this.ParaTileGridSize.Title = "タイルの数";
            this.ParaTileGridSize.Value = "(8,8)";
            this.ParaTileGridSize.ValueType = FilterBase.Parts.PartsFunc.VALUE_TYPE.TYPE_INT;
            this.ParaTileGridSize.ParameterChange += new FilterBase.Parts.ParameterChangeEventHandler(this.Param_ParameterChange);
            // 
            // CLAHE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.FLPParam);
            this.Name = "CLAHE";
            this.Size = new System.Drawing.Size(128, 145);
            this.Target = FilterBase.BaseFilterControl.TRANSFORM_TARGET.IMAGE;
            this.Controls.SetChildIndex(this.FLPParam, 0);
            this.FLPParam.ResumeLayout(false);
            this.FLPParam.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ParaClipLimit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaTileGridSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel FLPParam;
        private FilterBase.Parts.InputMaxMin ParaClipLimit;
        private FilterBase.Parts.InputTuple ParaTileGridSize;
    }
}
