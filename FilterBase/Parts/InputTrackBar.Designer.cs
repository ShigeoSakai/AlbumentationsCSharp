namespace FilterBase.Parts
{
    partial class InputTrackBar
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
            this.ValueTrackBar = new SSTools.LabeledTrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.ValueTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // LbTitle
            // 
            this.LbTitle.AutoSize = false;
            // 
            // ValueTrackBar
            // 
            this.ValueTrackBar.AutoSize = true;
            this.ValueTrackBar.DescriptionFont = new System.Drawing.Font("MS UI Gothic", 9F);
            this.ValueTrackBar.DescriptionMax = "max";
            this.ValueTrackBar.DescriptionMin = "min";
            this.ValueTrackBar.DisplayLabel = false;
            this.ValueTrackBar.LabelFormat = null;
            this.ValueTrackBar.LargeChange = 5;
            this.ValueTrackBar.Location = new System.Drawing.Point(3, 37);
            this.ValueTrackBar.Maximum = 100;
            this.ValueTrackBar.Minimum = 0;
            this.ValueTrackBar.MinimumSize = new System.Drawing.Size(118, 45);
            this.ValueTrackBar.Name = "ValueTrackBar";
            this.ValueTrackBar.ShowDescription = true;
            this.ValueTrackBar.Size = new System.Drawing.Size(118, 45);
            this.ValueTrackBar.SmallChange = 1;
            this.ValueTrackBar.TabIndex = 1;
            this.ValueTrackBar.Text = "labeledTrackBar1";
            this.ValueTrackBar.TickFrequency = 10;
            this.ValueTrackBar.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.ValueTrackBar.Value = 0;
            this.ValueTrackBar.ValueChanged += new System.EventHandler(this.ValueTrackBar_ValueChanged);
            // 
            // InputTrackBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.Controls.Add(this.ValueTrackBar);
            this.Name = "InputTrackBar";
            this.Size = new System.Drawing.Size(124, 85);
            this.Controls.SetChildIndex(this.CbValid, 0);
            this.Controls.SetChildIndex(this.LbTitle, 0);
            this.Controls.SetChildIndex(this.ValueTrackBar, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ValueTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SSTools.LabeledTrackBar ValueTrackBar;
    }
}
