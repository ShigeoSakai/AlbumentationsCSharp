namespace Filter.BasicTransform
{
    partial class RandomGridShuffle
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
            this.ParaGrid = new FilterBase.Parts.InputTuple();
            this.FLPParam.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ParaGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // FLPParam
            // 
            this.FLPParam.AutoSize = true;
            this.FLPParam.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.FLPParam.Controls.Add(this.ParaGrid);
            this.FLPParam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FLPParam.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.FLPParam.Location = new System.Drawing.Point(0, 25);
            this.FLPParam.Name = "FLPParam";
            this.FLPParam.Size = new System.Drawing.Size(128, 47);
            this.FLPParam.TabIndex = 5;
            // 
            // ParaGrid
            // 
            this.ParaGrid.ArgumentName = "grid";
            this.ParaGrid.AutoSize = true;
            this.ParaGrid.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ParaGrid.DecimalPlace = 0;
            this.ParaGrid.Description = "画像をセルに分割するためのグリッドのサイズ。\r\n各セルはランダムにシャッフルされます。\r\nたとえば、(3, 3) は画像を 3x3 のグリッドに分割し、9 つのセ" +
    "ルがシャッフルされます。\r\n　　デフォルト: (3, 3)";
            this.ParaGrid.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ParaGrid.Location = new System.Drawing.Point(3, 3);
            this.ParaGrid.MaxValue = "";
            this.ParaGrid.MaxVersion = null;
            this.ParaGrid.MinimumSize = new System.Drawing.Size(124, 21);
            this.ParaGrid.MinValue = "";
            this.ParaGrid.MinVersion = null;
            this.ParaGrid.Name = "ParaGrid";
            this.ParaGrid.Required = false;
            this.ParaGrid.Size = new System.Drawing.Size(124, 41);
            this.ParaGrid.TabIndex = 0;
            this.ParaGrid.Title = "グリッドサイズ";
            this.ParaGrid.Value = "(3,3)";
            this.ParaGrid.ValueType = FilterBase.Parts.PartsFunc.VALUE_TYPE.TYPE_INT;
            this.ParaGrid.ParameterChange += new FilterBase.Parts.ParameterChangeEventHandler(this.Param_ParameterChange);
            // 
            // RandomGridShuffle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.FLPParam);
            this.Name = "RandomGridShuffle";
            this.Size = new System.Drawing.Size(128, 97);
            this.Controls.SetChildIndex(this.FLPParam, 0);
            this.FLPParam.ResumeLayout(false);
            this.FLPParam.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ParaGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel FLPParam;
        private FilterBase.Parts.InputTuple ParaGrid;
    }
}
