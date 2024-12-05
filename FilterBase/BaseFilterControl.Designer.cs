namespace FilterBase
{
    partial class BaseFilterControl
    {
        /// <summary> 
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;


        #region コンポーネント デザイナーで生成されたコード

        /// <summary> 
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を 
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.LbProbability = new System.Windows.Forms.Label();
            this.NUDProbability = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.PanelTitle = new System.Windows.Forms.Panel();
            this.LbLine = new System.Windows.Forms.Label();
            this.LbTitle = new SSTools.GrowLabel();
            this.PanelProbability = new System.Windows.Forms.Panel();
            this.HelpToolTip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.NUDProbability)).BeginInit();
            this.PanelTitle.SuspendLayout();
            this.PanelProbability.SuspendLayout();
            this.SuspendLayout();
            // 
            // LbProbability
            // 
            this.LbProbability.Location = new System.Drawing.Point(3, 0);
            this.LbProbability.Name = "LbProbability";
            this.LbProbability.Size = new System.Drawing.Size(44, 23);
            this.LbProbability.TabIndex = 0;
            this.LbProbability.Text = "確率:";
            this.LbProbability.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // NUDProbability
            // 
            this.NUDProbability.Location = new System.Drawing.Point(53, 3);
            this.NUDProbability.Name = "NUDProbability";
            this.NUDProbability.Size = new System.Drawing.Size(47, 19);
            this.NUDProbability.TabIndex = 1;
            this.NUDProbability.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.HelpToolTip.SetToolTip(this.NUDProbability, "変換を適用する確率。\r\n範囲は [0, 1] である必要があります。\r\n            デフォルト: 0.5");
            this.NUDProbability.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(106, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "%";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PanelTitle
            // 
            this.PanelTitle.AutoSize = true;
            this.PanelTitle.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PanelTitle.Controls.Add(this.LbLine);
            this.PanelTitle.Controls.Add(this.LbTitle);
            this.PanelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTitle.Location = new System.Drawing.Point(0, 0);
            this.PanelTitle.Margin = new System.Windows.Forms.Padding(0);
            this.PanelTitle.MinimumSize = new System.Drawing.Size(128, 24);
            this.PanelTitle.Name = "PanelTitle";
            this.PanelTitle.Size = new System.Drawing.Size(128, 24);
            this.PanelTitle.TabIndex = 3;
            // 
            // LbLine
            // 
            this.LbLine.BackColor = System.Drawing.Color.Black;
            this.LbLine.Location = new System.Drawing.Point(0, 22);
            this.LbLine.Margin = new System.Windows.Forms.Padding(0);
            this.LbLine.Name = "LbLine";
            this.LbLine.Size = new System.Drawing.Size(128, 2);
            this.LbLine.TabIndex = 1;
            // 
            // LbTitle
            // 
            this.LbTitle.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.LbTitle.Location = new System.Drawing.Point(3, 3);
            this.LbTitle.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.LbTitle.MaxTextWidth = 122;
            this.LbTitle.Name = "LbTitle";
            this.LbTitle.Size = new System.Drawing.Size(41, 16);
            this.LbTitle.TabIndex = 0;
            this.LbTitle.Text = "Title";
            this.LbTitle.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.LbTitle.SizeChanged += new System.EventHandler(this.LbTitle_SizeChanged);
            // 
            // PanelProbability
            // 
            this.PanelProbability.AutoSize = true;
            this.PanelProbability.Controls.Add(this.LbProbability);
            this.PanelProbability.Controls.Add(this.NUDProbability);
            this.PanelProbability.Controls.Add(this.label1);
            this.PanelProbability.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelProbability.Location = new System.Drawing.Point(0, 25);
            this.PanelProbability.Margin = new System.Windows.Forms.Padding(0);
            this.PanelProbability.Name = "PanelProbability";
            this.PanelProbability.Size = new System.Drawing.Size(128, 25);
            this.PanelProbability.TabIndex = 4;
            // 
            // HelpToolTip
            // 
            this.HelpToolTip.IsBalloon = true;
            this.HelpToolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.HelpToolTip.ToolTipTitle = "ヒント";
            // 
            // BaseFilterControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.PanelProbability);
            this.Controls.Add(this.PanelTitle);
            this.MaximumSize = new System.Drawing.Size(128, 0);
            this.MinimumSize = new System.Drawing.Size(128, 50);
            this.Name = "BaseFilterControl";
            this.Size = new System.Drawing.Size(128, 50);
            ((System.ComponentModel.ISupportInitialize)(this.NUDProbability)).EndInit();
            this.PanelTitle.ResumeLayout(false);
            this.PanelProbability.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LbProbability;
        private System.Windows.Forms.NumericUpDown NUDProbability;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel PanelTitle;
        private System.Windows.Forms.Label LbLine;
        private System.Windows.Forms.Panel PanelProbability;
        protected System.Windows.Forms.ToolTip HelpToolTip;
        private SSTools.GrowLabel LbTitle;
    }
}
