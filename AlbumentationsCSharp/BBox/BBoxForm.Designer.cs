namespace AlbumentationsCSharp
{
    partial class BBoxForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PanelTop = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.CbBBoxFormat = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtOK = new System.Windows.Forms.Button();
            this.BtCancel = new System.Windows.Forms.Button();
            this.DGVBBox = new System.Windows.Forms.DataGridView();
            this.ColumnClassName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnX1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnY1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnXWidth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnYHeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PanelTop.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVBBox)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelTop
            // 
            this.PanelTop.AutoSize = true;
            this.PanelTop.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PanelTop.Controls.Add(this.CbBBoxFormat);
            this.PanelTop.Controls.Add(this.label1);
            this.PanelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTop.Location = new System.Drawing.Point(0, 0);
            this.PanelTop.Name = "PanelTop";
            this.PanelTop.Size = new System.Drawing.Size(548, 26);
            this.PanelTop.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(3, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "形式:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CbBBoxFormat
            // 
            this.CbBBoxFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbBBoxFormat.FormattingEnabled = true;
            this.CbBBoxFormat.Location = new System.Drawing.Point(53, 3);
            this.CbBBoxFormat.Name = "CbBBoxFormat";
            this.CbBBoxFormat.Size = new System.Drawing.Size(184, 20);
            this.CbBBoxFormat.TabIndex = 1;
            this.CbBBoxFormat.SelectionChangeCommitted += new System.EventHandler(this.CbBBoxFormat_SelectionChangeCommitted);
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.BtCancel);
            this.panel1.Controls.Add(this.BtOK);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 418);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(548, 32);
            this.panel1.TabIndex = 1;
            // 
            // BtOK
            // 
            this.BtOK.Location = new System.Drawing.Point(133, 6);
            this.BtOK.Name = "BtOK";
            this.BtOK.Size = new System.Drawing.Size(75, 23);
            this.BtOK.TabIndex = 0;
            this.BtOK.Text = "OK";
            this.BtOK.UseVisualStyleBackColor = true;
            this.BtOK.Click += new System.EventHandler(this.BtOK_Click);
            // 
            // BtCancel
            // 
            this.BtCancel.Location = new System.Drawing.Point(308, 6);
            this.BtCancel.Name = "BtCancel";
            this.BtCancel.Size = new System.Drawing.Size(75, 23);
            this.BtCancel.TabIndex = 1;
            this.BtCancel.Text = "Cancel";
            this.BtCancel.UseVisualStyleBackColor = true;
            this.BtCancel.Click += new System.EventHandler(this.BtCancel_Click);
            // 
            // DGVBBox
            // 
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVBBox.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.DGVBBox.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVBBox.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnClassName,
            this.ColumnX1,
            this.ColumnY1,
            this.ColumnXWidth,
            this.ColumnYHeight});
            this.DGVBBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVBBox.Location = new System.Drawing.Point(0, 26);
            this.DGVBBox.Name = "DGVBBox";
            this.DGVBBox.RowTemplate.Height = 21;
            this.DGVBBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DGVBBox.Size = new System.Drawing.Size(548, 392);
            this.DGVBBox.TabIndex = 2;
            // 
            // ColumnClassName
            // 
            this.ColumnClassName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ColumnClassName.HeaderText = "クラス名";
            this.ColumnClassName.Name = "ColumnClassName";
            this.ColumnClassName.Width = 67;
            // 
            // ColumnX1
            // 
            this.ColumnX1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.ColumnX1.DefaultCellStyle = dataGridViewCellStyle17;
            this.ColumnX1.FillWeight = 25F;
            this.ColumnX1.HeaderText = "X座標";
            this.ColumnX1.Name = "ColumnX1";
            // 
            // ColumnY1
            // 
            this.ColumnY1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.ColumnY1.DefaultCellStyle = dataGridViewCellStyle18;
            this.ColumnY1.FillWeight = 25F;
            this.ColumnY1.HeaderText = "Y座標";
            this.ColumnY1.Name = "ColumnY1";
            // 
            // ColumnXWidth
            // 
            this.ColumnXWidth.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.ColumnXWidth.DefaultCellStyle = dataGridViewCellStyle19;
            this.ColumnXWidth.FillWeight = 25F;
            this.ColumnXWidth.HeaderText = "X2座標/幅";
            this.ColumnXWidth.Name = "ColumnXWidth";
            // 
            // ColumnYHeight
            // 
            this.ColumnYHeight.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.ColumnYHeight.DefaultCellStyle = dataGridViewCellStyle20;
            this.ColumnYHeight.FillWeight = 25F;
            this.ColumnYHeight.HeaderText = "Y2座標/高さ";
            this.ColumnYHeight.Name = "ColumnYHeight";
            // 
            // BBoxForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 450);
            this.Controls.Add(this.DGVBBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PanelTop);
            this.Name = "BBoxForm";
            this.Text = "BBox編集";
            this.PanelTop.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVBBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PanelTop;
        private System.Windows.Forms.ComboBox CbBBoxFormat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtCancel;
        private System.Windows.Forms.Button BtOK;
        private System.Windows.Forms.DataGridView DGVBBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnClassName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnX1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnY1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnXWidth;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnYHeight;
    }
}