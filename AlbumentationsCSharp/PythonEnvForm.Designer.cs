namespace AlbumentationsCSharp
{
    partial class PythonEnvForm
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtBaseFolderSelect = new SSTools.FolderSelectButton();
            this.TbBaseFolder = new System.Windows.Forms.TextBox();
            this.GbAnaconda = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtGetCondaEnv = new System.Windows.Forms.Button();
            this.BtAnacondaPathSelect = new SSTools.FolderSelectButton();
            this.TbAnacondaPath = new System.Windows.Forms.TextBox();
            this.CbAnacondaEnv = new System.Windows.Forms.ComboBox();
            this.BtCancel = new System.Windows.Forms.Button();
            this.BtOK = new System.Windows.Forms.Button();
            this.GbDirect = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.BtPythonPathSelect = new SSTools.FolderSelectButton();
            this.TbPythonPath = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CbPythonSelect = new System.Windows.Forms.ComboBox();
            this.FLPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.GbvEnv = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.BtGetvEnv = new System.Windows.Forms.Button();
            this.BtvEnvPathSelect = new SSTools.FolderSelectButton();
            this.TbvEnvPath = new System.Windows.Forms.TextBox();
            this.CbvEnvName = new System.Windows.Forms.ComboBox();
            this.groupBox2.SuspendLayout();
            this.GbAnaconda.SuspendLayout();
            this.GbDirect.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.FLPanel.SuspendLayout();
            this.GbvEnv.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.groupBox2, 3);
            this.groupBox2.Controls.Add(this.BtBaseFolderSelect);
            this.groupBox2.Controls.Add(this.TbBaseFolder);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 277);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(0);
            this.groupBox2.Size = new System.Drawing.Size(512, 52);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "実行ディレクトリ";
            // 
            // BtBaseFolderSelect
            // 
            this.BtBaseFolderSelect.AutoSize = true;
            this.BtBaseFolderSelect.LinkControl = this.TbBaseFolder;
            this.BtBaseFolderSelect.Location = new System.Drawing.Point(470, 16);
            this.BtBaseFolderSelect.Name = "BtBaseFolderSelect";
            this.BtBaseFolderSelect.SendClickControl = null;
            this.BtBaseFolderSelect.Size = new System.Drawing.Size(33, 23);
            this.BtBaseFolderSelect.TabIndex = 1;
            this.BtBaseFolderSelect.Text = "...";
            this.BtBaseFolderSelect.UserCustomDialog = true;
            this.BtBaseFolderSelect.UseVisualStyleBackColor = true;
            // 
            // TbBaseFolder
            // 
            this.TbBaseFolder.Location = new System.Drawing.Point(6, 18);
            this.TbBaseFolder.Name = "TbBaseFolder";
            this.TbBaseFolder.Size = new System.Drawing.Size(458, 19);
            this.TbBaseFolder.TabIndex = 0;
            // 
            // GbAnaconda
            // 
            this.GbAnaconda.Controls.Add(this.label1);
            this.GbAnaconda.Controls.Add(this.label2);
            this.GbAnaconda.Controls.Add(this.BtGetCondaEnv);
            this.GbAnaconda.Controls.Add(this.BtAnacondaPathSelect);
            this.GbAnaconda.Controls.Add(this.TbAnacondaPath);
            this.GbAnaconda.Controls.Add(this.CbAnacondaEnv);
            this.GbAnaconda.Location = new System.Drawing.Point(3, 3);
            this.GbAnaconda.Name = "GbAnaconda";
            this.GbAnaconda.Size = new System.Drawing.Size(509, 87);
            this.GbAnaconda.TabIndex = 3;
            this.GbAnaconda.TabStop = false;
            this.GbAnaconda.Text = "Anaconda";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(15, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "環境名:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(183, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Anacondaパス:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // BtGetCondaEnv
            // 
            this.BtGetCondaEnv.Location = new System.Drawing.Point(101, 61);
            this.BtGetCondaEnv.Name = "BtGetCondaEnv";
            this.BtGetCondaEnv.Size = new System.Drawing.Size(76, 23);
            this.BtGetCondaEnv.TabIndex = 4;
            this.BtGetCondaEnv.Text = "一覧取得";
            this.BtGetCondaEnv.UseVisualStyleBackColor = true;
            this.BtGetCondaEnv.Click += new System.EventHandler(this.BtGetCondaEnv_Click);
            // 
            // BtAnacondaPathSelect
            // 
            this.BtAnacondaPathSelect.AutoSize = true;
            this.BtAnacondaPathSelect.LinkControl = this.TbAnacondaPath;
            this.BtAnacondaPathSelect.Location = new System.Drawing.Point(470, 36);
            this.BtAnacondaPathSelect.Name = "BtAnacondaPathSelect";
            this.BtAnacondaPathSelect.SendClickControl = null;
            this.BtAnacondaPathSelect.ShowNewFolderButton = false;
            this.BtAnacondaPathSelect.Size = new System.Drawing.Size(33, 23);
            this.BtAnacondaPathSelect.TabIndex = 3;
            this.BtAnacondaPathSelect.Text = "...";
            this.BtAnacondaPathSelect.UserCustomDialog = true;
            this.BtAnacondaPathSelect.UseVisualStyleBackColor = true;
            // 
            // TbAnacondaPath
            // 
            this.TbAnacondaPath.Location = new System.Drawing.Point(183, 38);
            this.TbAnacondaPath.Name = "TbAnacondaPath";
            this.TbAnacondaPath.Size = new System.Drawing.Size(281, 19);
            this.TbAnacondaPath.TabIndex = 2;
            // 
            // CbAnacondaEnv
            // 
            this.CbAnacondaEnv.FormattingEnabled = true;
            this.CbAnacondaEnv.Location = new System.Drawing.Point(17, 38);
            this.CbAnacondaEnv.Name = "CbAnacondaEnv";
            this.CbAnacondaEnv.Size = new System.Drawing.Size(160, 20);
            this.CbAnacondaEnv.TabIndex = 1;
            // 
            // BtCancel
            // 
            this.BtCancel.Dock = System.Windows.Forms.DockStyle.Left;
            this.BtCancel.Location = new System.Drawing.Point(347, 335);
            this.BtCancel.Name = "BtCancel";
            this.BtCancel.Size = new System.Drawing.Size(75, 24);
            this.BtCancel.TabIndex = 8;
            this.BtCancel.Text = "Cancel";
            this.BtCancel.UseVisualStyleBackColor = true;
            this.BtCancel.Click += new System.EventHandler(this.BtCancel_Click);
            // 
            // BtOK
            // 
            this.BtOK.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtOK.Location = new System.Drawing.Point(94, 335);
            this.BtOK.Name = "BtOK";
            this.BtOK.Size = new System.Drawing.Size(75, 24);
            this.BtOK.TabIndex = 7;
            this.BtOK.Text = "OK";
            this.BtOK.UseVisualStyleBackColor = true;
            this.BtOK.Click += new System.EventHandler(this.BtOK_Click);
            // 
            // GbDirect
            // 
            this.GbDirect.Controls.Add(this.label6);
            this.GbDirect.Controls.Add(this.BtPythonPathSelect);
            this.GbDirect.Controls.Add(this.TbPythonPath);
            this.FLPanel.SetFlowBreak(this.GbDirect, true);
            this.GbDirect.Location = new System.Drawing.Point(3, 189);
            this.GbDirect.Name = "GbDirect";
            this.GbDirect.Size = new System.Drawing.Size(509, 56);
            this.GbDirect.TabIndex = 7;
            this.GbDirect.TabStop = false;
            this.GbDirect.Text = "Pythonを直接実行";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(6, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 23);
            this.label6.TabIndex = 4;
            this.label6.Text = "パス:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // BtPythonPathSelect
            // 
            this.BtPythonPathSelect.AutoSize = true;
            this.BtPythonPathSelect.LinkControl = this.TbPythonPath;
            this.BtPythonPathSelect.Location = new System.Drawing.Point(470, 16);
            this.BtPythonPathSelect.Name = "BtPythonPathSelect";
            this.BtPythonPathSelect.SendClickControl = null;
            this.BtPythonPathSelect.ShowNewFolderButton = false;
            this.BtPythonPathSelect.Size = new System.Drawing.Size(33, 23);
            this.BtPythonPathSelect.TabIndex = 1;
            this.BtPythonPathSelect.Text = "...";
            this.BtPythonPathSelect.UserCustomDialog = true;
            this.BtPythonPathSelect.UseVisualStyleBackColor = true;
            // 
            // TbPythonPath
            // 
            this.TbPythonPath.Location = new System.Drawing.Point(61, 18);
            this.TbPythonPath.Name = "TbPythonPath";
            this.TbPythonPath.Size = new System.Drawing.Size(403, 19);
            this.TbPythonPath.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.Controls.Add(this.BtOK, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.BtCancel, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.FLPanel, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 58F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(518, 362);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.panel1, 3);
            this.panel1.Controls.Add(this.CbPythonSelect);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(518, 26);
            this.panel1.TabIndex = 9;
            // 
            // CbPythonSelect
            // 
            this.CbPythonSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbPythonSelect.FormattingEnabled = true;
            this.CbPythonSelect.Location = new System.Drawing.Point(9, 3);
            this.CbPythonSelect.Name = "CbPythonSelect";
            this.CbPythonSelect.Size = new System.Drawing.Size(160, 20);
            this.CbPythonSelect.TabIndex = 0;
            this.CbPythonSelect.SelectedIndexChanged += new System.EventHandler(this.CbPythonSelect_SelectedIndexChanged);
            // 
            // FLPanel
            // 
            this.FLPanel.AutoSize = true;
            this.FLPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.SetColumnSpan(this.FLPanel, 3);
            this.FLPanel.Controls.Add(this.GbAnaconda);
            this.FLPanel.Controls.Add(this.GbvEnv);
            this.FLPanel.Controls.Add(this.GbDirect);
            this.FLPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FLPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.FLPanel.Location = new System.Drawing.Point(0, 26);
            this.FLPanel.Margin = new System.Windows.Forms.Padding(0);
            this.FLPanel.MaximumSize = new System.Drawing.Size(518, 248);
            this.FLPanel.Name = "FLPanel";
            this.FLPanel.Size = new System.Drawing.Size(518, 248);
            this.FLPanel.TabIndex = 10;
            // 
            // GbvEnv
            // 
            this.GbvEnv.Controls.Add(this.label4);
            this.GbvEnv.Controls.Add(this.label5);
            this.GbvEnv.Controls.Add(this.BtGetvEnv);
            this.GbvEnv.Controls.Add(this.BtvEnvPathSelect);
            this.GbvEnv.Controls.Add(this.TbvEnvPath);
            this.GbvEnv.Controls.Add(this.CbvEnvName);
            this.GbvEnv.Location = new System.Drawing.Point(3, 96);
            this.GbvEnv.Name = "GbvEnv";
            this.GbvEnv.Size = new System.Drawing.Size(509, 87);
            this.GbvEnv.TabIndex = 7;
            this.GbvEnv.TabStop = false;
            this.GbvEnv.Text = "Python仮想環境";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(15, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "環境名:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(183, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "仮想環境パス:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // BtGetvEnv
            // 
            this.BtGetvEnv.Location = new System.Drawing.Point(101, 61);
            this.BtGetvEnv.Name = "BtGetvEnv";
            this.BtGetvEnv.Size = new System.Drawing.Size(76, 23);
            this.BtGetvEnv.TabIndex = 4;
            this.BtGetvEnv.Text = "一覧取得";
            this.BtGetvEnv.UseVisualStyleBackColor = true;
            this.BtGetvEnv.Click += new System.EventHandler(this.BtGetvEnv_Click);
            // 
            // BtvEnvPathSelect
            // 
            this.BtvEnvPathSelect.AutoSize = true;
            this.BtvEnvPathSelect.LinkControl = this.TbvEnvPath;
            this.BtvEnvPathSelect.Location = new System.Drawing.Point(470, 36);
            this.BtvEnvPathSelect.Name = "BtvEnvPathSelect";
            this.BtvEnvPathSelect.SendClickControl = null;
            this.BtvEnvPathSelect.ShowNewFolderButton = false;
            this.BtvEnvPathSelect.Size = new System.Drawing.Size(33, 23);
            this.BtvEnvPathSelect.TabIndex = 3;
            this.BtvEnvPathSelect.Text = "...";
            this.BtvEnvPathSelect.UserCustomDialog = true;
            this.BtvEnvPathSelect.UseVisualStyleBackColor = true;
            // 
            // TbvEnvPath
            // 
            this.TbvEnvPath.Location = new System.Drawing.Point(183, 38);
            this.TbvEnvPath.Name = "TbvEnvPath";
            this.TbvEnvPath.Size = new System.Drawing.Size(281, 19);
            this.TbvEnvPath.TabIndex = 2;
            // 
            // CbvEnvName
            // 
            this.CbvEnvName.FormattingEnabled = true;
            this.CbvEnvName.Location = new System.Drawing.Point(17, 38);
            this.CbvEnvName.Name = "CbvEnvName";
            this.CbvEnvName.Size = new System.Drawing.Size(160, 20);
            this.CbvEnvName.TabIndex = 1;
            // 
            // PythonEnvForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(518, 362);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximumSize = new System.Drawing.Size(534, 401);
            this.Name = "PythonEnvForm";
            this.Text = "Python環境設定";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.GbAnaconda.ResumeLayout(false);
            this.GbAnaconda.PerformLayout();
            this.GbDirect.ResumeLayout(false);
            this.GbDirect.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.FLPanel.ResumeLayout(false);
            this.GbvEnv.ResumeLayout(false);
            this.GbvEnv.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private SSTools.FolderSelectButton BtBaseFolderSelect;
        private System.Windows.Forms.TextBox TbBaseFolder;
        private System.Windows.Forms.GroupBox GbAnaconda;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtGetCondaEnv;
        private SSTools.FolderSelectButton BtAnacondaPathSelect;
        private System.Windows.Forms.TextBox TbAnacondaPath;
        private System.Windows.Forms.ComboBox CbAnacondaEnv;
        private System.Windows.Forms.Button BtCancel;
        private System.Windows.Forms.Button BtOK;
        private System.Windows.Forms.GroupBox GbDirect;
        private SSTools.FolderSelectButton BtPythonPathSelect;
        private System.Windows.Forms.TextBox TbPythonPath;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel FLPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox GbvEnv;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtGetvEnv;
        private SSTools.FolderSelectButton BtvEnvPathSelect;
        private System.Windows.Forms.TextBox TbvEnvPath;
        private System.Windows.Forms.ComboBox CbvEnvName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox CbPythonSelect;
    }
}