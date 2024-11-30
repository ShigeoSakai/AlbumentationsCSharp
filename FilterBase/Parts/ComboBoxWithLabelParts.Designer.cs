namespace FilterBase.Parts
{
    partial class ComboBoxWithLabelParts
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
            this.CbComboBox = new FilterBase.Parts.ComboBoxParts();
            ((System.ComponentModel.ISupportInitialize)(this.CbComboBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // CbComboBox
            // 
            this.CbComboBox.ArgumentName = null;
            this.CbComboBox.DefaultValue = "";
            this.CbComboBox.Description = "";
            this.CbComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbComboBox.FormattingEnabled = true;
            this.CbComboBox.ItemType = "System.String";
            this.CbComboBox.Location = new System.Drawing.Point(0, 38);
            this.CbComboBox.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.CbComboBox.MaxVersion = null;
            this.CbComboBox.MinVersion = null;
            this.CbComboBox.Name = "CbComboBox";
            this.CbComboBox.Size = new System.Drawing.Size(122, 20);
            this.CbComboBox.TabIndex = 1;
            this.CbComboBox.Value = null;
            this.CbComboBox.ParameterChange += new FilterBase.Parts.ParameterChangeEventHandler(this.CbComboBox_ParameterChange);
            this.CbComboBox.ComboSelectedIndexChanged += new FilterBase.Parts.ComboBoxParts.SelectChangeEventHander(this.CbComboBox_ComboSelectedIndexChanged);
            this.CbComboBox.ComboSelectionChangeCommitted += new FilterBase.Parts.ComboBoxParts.SelectChangeEventHander(this.CbComboBox_ComboSelectionChangeCommitted);
            // 
            // ComboBoxWithLabelParts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.Controls.Add(this.CbComboBox);
            this.Name = "ComboBoxWithLabelParts";
            this.Size = new System.Drawing.Size(124, 60);
            this.Controls.SetChildIndex(this.CbValid, 0);
            this.Controls.SetChildIndex(this.LbTitle, 0);
            this.Controls.SetChildIndex(this.CbComboBox, 0);
            ((System.ComponentModel.ISupportInitialize)(this.CbComboBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBoxParts CbComboBox;
    }
}
