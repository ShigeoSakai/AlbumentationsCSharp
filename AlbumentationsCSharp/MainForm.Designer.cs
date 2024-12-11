namespace AlbumentationsCSharp
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.MainToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.ToolStripMenuItemHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemHelpAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemPythonConfig = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemPython = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripMenuItemShowPythonCommand = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemSetFromPythonCommand = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripMenuItemFile = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStripMain = new System.Windows.Forms.MenuStrip();
            this.PanelParam = new System.Windows.Forms.Panel();
            this.CbCategory = new System.Windows.Forms.ComboBox();
            this.CbAlbumentations = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CbImmediate = new System.Windows.Forms.CheckBox();
            this.PbOrigImage = new SSTools.ZoomPictureBox();
            this.PictBoxMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ToolStripMenuItemImageCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.BtAddList = new System.Windows.Forms.Button();
            this.BtExec = new System.Windows.Forms.Button();
            this.CbShowMask = new System.Windows.Forms.CheckBox();
            this.BtMaskImageOpen = new System.Windows.Forms.Button();
            this.BtMaskImageSelect = new SSTools.FileSelectButton();
            this.TbMaskImage = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtImageOpen = new System.Windows.Forms.Button();
            this.BtImageFileSelect = new SSTools.FileSelectButton();
            this.TbImageFile = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PbResultImage = new SSTools.ZoomPictureBox();
            this.PanelFile = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.RbGray = new System.Windows.Forms.RadioButton();
            this.RbColor = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RbFloat = new System.Windows.Forms.RadioButton();
            this.Rb8Bit = new System.Windows.Forms.RadioButton();
            this.CbKeyPointType = new System.Windows.Forms.ComboBox();
            this.BtNewKeyPoint = new System.Windows.Forms.Button();
            this.BtNewBox = new System.Windows.Forms.Button();
            this.BtKeyPointEdit = new System.Windows.Forms.Button();
            this.BtKeyPointOpen = new System.Windows.Forms.Button();
            this.BtKeyPointSelect = new SSTools.FileSelectButton();
            this.TbKeyPoint = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BtBBoxEdit = new System.Windows.Forms.Button();
            this.CbBBoxType = new System.Windows.Forms.ComboBox();
            this.BtBBoxFileOpen = new System.Windows.Forms.Button();
            this.BtBBoxFileSelect = new SSTools.FileSelectButton();
            this.TbBBoxFile = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CbShowKeyPointLabel = new System.Windows.Forms.CheckBox();
            this.CbShowKeyPoints = new System.Windows.Forms.CheckBox();
            this.CbShowBBox = new System.Windows.Forms.CheckBox();
            this.PanelExec = new System.Windows.Forms.Panel();
            this.TBLMain = new System.Windows.Forms.TableLayoutPanel();
            this.PanelResultControl = new System.Windows.Forms.Panel();
            this.CbShowResultImage = new System.Windows.Forms.CheckBox();
            this.CbResultShowKeyPointsLabel = new System.Windows.Forms.CheckBox();
            this.CbShowResultMask = new System.Windows.Forms.CheckBox();
            this.CbShowResultKeyPoints = new System.Windows.Forms.CheckBox();
            this.CbShowResultBBox = new System.Windows.Forms.CheckBox();
            this.PanelOrigControl = new System.Windows.Forms.Panel();
            this.CbShowImage = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.MenuStripMain.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbOrigImage)).BeginInit();
            this.PictBoxMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbResultImage)).BeginInit();
            this.PanelFile.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.PanelExec.SuspendLayout();
            this.TBLMain.SuspendLayout();
            this.PanelResultControl.SuspendLayout();
            this.PanelOrigControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainToolTip
            // 
            this.MainToolTip.IsBalloon = true;
            // 
            // ToolStripMenuItemHelp
            // 
            this.ToolStripMenuItemHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemHelpAbout});
            this.ToolStripMenuItemHelp.Name = "ToolStripMenuItemHelp";
            this.ToolStripMenuItemHelp.Size = new System.Drawing.Size(65, 20);
            this.ToolStripMenuItemHelp.Text = "ヘルプ(&H)";
            // 
            // ToolStripMenuItemHelpAbout
            // 
            this.ToolStripMenuItemHelpAbout.Name = "ToolStripMenuItemHelpAbout";
            this.ToolStripMenuItemHelpAbout.Size = new System.Drawing.Size(132, 22);
            this.ToolStripMenuItemHelpAbout.Text = "About(&A)...";
            // 
            // ToolStripMenuItemPythonConfig
            // 
            this.ToolStripMenuItemPythonConfig.Name = "ToolStripMenuItemPythonConfig";
            this.ToolStripMenuItemPythonConfig.Size = new System.Drawing.Size(151, 22);
            this.ToolStripMenuItemPythonConfig.Text = "設定を開く(&O)";
            this.ToolStripMenuItemPythonConfig.Click += new System.EventHandler(this.ToolStripMenuItemPythonConfig_Click);
            // 
            // ToolStripMenuItemPython
            // 
            this.ToolStripMenuItemPython.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemPythonConfig,
            this.toolStripSeparator2,
            this.ToolStripMenuItemShowPythonCommand,
            this.ToolStripMenuItemSetFromPythonCommand});
            this.ToolStripMenuItemPython.Name = "ToolStripMenuItemPython";
            this.ToolStripMenuItemPython.Size = new System.Drawing.Size(72, 20);
            this.ToolStripMenuItemPython.Text = "Python(&P)";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(148, 6);
            // 
            // ToolStripMenuItemShowPythonCommand
            // 
            this.ToolStripMenuItemShowPythonCommand.Name = "ToolStripMenuItemShowPythonCommand";
            this.ToolStripMenuItemShowPythonCommand.Size = new System.Drawing.Size(151, 22);
            this.ToolStripMenuItemShowPythonCommand.Text = "コマンドを表示";
            // 
            // ToolStripMenuItemSetFromPythonCommand
            // 
            this.ToolStripMenuItemSetFromPythonCommand.Name = "ToolStripMenuItemSetFromPythonCommand";
            this.ToolStripMenuItemSetFromPythonCommand.Size = new System.Drawing.Size(151, 22);
            this.ToolStripMenuItemSetFromPythonCommand.Text = "コマンドから設定";
            // 
            // ToolStripMenuItemFileExit
            // 
            this.ToolStripMenuItemFileExit.Name = "ToolStripMenuItemFileExit";
            this.ToolStripMenuItemFileExit.Size = new System.Drawing.Size(113, 22);
            this.ToolStripMenuItemFileExit.Text = "終了(&X)";
            this.ToolStripMenuItemFileExit.Click += new System.EventHandler(this.ToolStripMenuItemFileExit_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(110, 6);
            // 
            // ToolStripMenuItemFile
            // 
            this.ToolStripMenuItemFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.ToolStripMenuItemFileExit});
            this.ToolStripMenuItemFile.Name = "ToolStripMenuItemFile";
            this.ToolStripMenuItemFile.Size = new System.Drawing.Size(67, 20);
            this.ToolStripMenuItemFile.Text = "ファイル(&F)";
            // 
            // MenuStripMain
            // 
            this.MenuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemFile,
            this.ToolStripMenuItemPython,
            this.ToolStripMenuItemHelp});
            this.MenuStripMain.Location = new System.Drawing.Point(0, 0);
            this.MenuStripMain.Name = "MenuStripMain";
            this.MenuStripMain.Size = new System.Drawing.Size(1072, 24);
            this.MenuStripMain.TabIndex = 3;
            this.MenuStripMain.Text = "menuStrip1";
            // 
            // PanelParam
            // 
            this.PanelParam.AutoScroll = true;
            this.PanelParam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelParam.Location = new System.Drawing.Point(398, 188);
            this.PanelParam.Margin = new System.Windows.Forms.Padding(0);
            this.PanelParam.Name = "PanelParam";
            this.PanelParam.Size = new System.Drawing.Size(145, 291);
            this.PanelParam.TabIndex = 1;
            // 
            // CbCategory
            // 
            this.CbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbCategory.FormattingEnabled = true;
            this.CbCategory.Location = new System.Drawing.Point(3, 6);
            this.CbCategory.Name = "CbCategory";
            this.CbCategory.Size = new System.Drawing.Size(133, 20);
            this.CbCategory.TabIndex = 0;
            this.CbCategory.SelectedIndexChanged += new System.EventHandler(this.CbCategory_SelectedIndexChanged);
            // 
            // CbAlbumentations
            // 
            this.CbAlbumentations.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbAlbumentations.FormattingEnabled = true;
            this.CbAlbumentations.Location = new System.Drawing.Point(4, 32);
            this.CbAlbumentations.Name = "CbAlbumentations";
            this.CbAlbumentations.Size = new System.Drawing.Size(132, 20);
            this.CbAlbumentations.TabIndex = 1;
            this.CbAlbumentations.SelectedIndexChanged += new System.EventHandler(this.CbAlbumentations_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.CbCategory);
            this.panel1.Controls.Add(this.CbAlbumentations);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(398, 133);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.TBLMain.SetRowSpan(this.panel1, 2);
            this.panel1.Size = new System.Drawing.Size(145, 55);
            this.panel1.TabIndex = 5;
            // 
            // CbImmediate
            // 
            this.CbImmediate.Checked = true;
            this.CbImmediate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CbImmediate.Location = new System.Drawing.Point(5, 3);
            this.CbImmediate.Name = "CbImmediate";
            this.CbImmediate.Size = new System.Drawing.Size(120, 24);
            this.CbImmediate.TabIndex = 0;
            this.CbImmediate.Text = "変更になったら実行";
            this.CbImmediate.UseVisualStyleBackColor = true;
            // 
            // PbOrigImage
            // 
            this.PbOrigImage.AreaSelectColor = System.Drawing.Color.YellowGreen;
            this.PbOrigImage.AutoImageDispose = true;
            this.PbOrigImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PbOrigImage.ContextMenuStrip = this.PictBoxMenuStrip;
            this.PbOrigImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PbOrigImage.Image = null;
            this.PbOrigImage.Location = new System.Drawing.Point(0, 174);
            this.PbOrigImage.Margin = new System.Windows.Forms.Padding(0);
            this.PbOrigImage.MaskAlfa = 0.5F;
            this.PbOrigImage.MaskImage = null;
            this.PbOrigImage.MaskShow = true;
            this.PbOrigImage.Name = "PbOrigImage";
            this.PbOrigImage.PictureBoxMode = SSTools.ZoomPictureBox.PictureBoxDrawMode.NORMAL;
            this.TBLMain.SetRowSpan(this.PbOrigImage, 3);
            this.PbOrigImage.ShapeShow = true;
            this.PbOrigImage.ShowImage = true;
            this.PbOrigImage.Size = new System.Drawing.Size(398, 385);
            this.PbOrigImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbOrigImage.TabIndex = 1;
            this.PbOrigImage.TabStop = false;
            this.PbOrigImage.XRatio = 1F;
            this.PbOrigImage.YRatio = 1F;
            // 
            // PictBoxMenuStrip
            // 
            this.PictBoxMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemImageCopy});
            this.PictBoxMenuStrip.Name = "PictBoxMenuStrip";
            this.PictBoxMenuStrip.Size = new System.Drawing.Size(148, 26);
            // 
            // ToolStripMenuItemImageCopy
            // 
            this.ToolStripMenuItemImageCopy.Name = "ToolStripMenuItemImageCopy";
            this.ToolStripMenuItemImageCopy.Size = new System.Drawing.Size(147, 22);
            this.ToolStripMenuItemImageCopy.Text = "画像をコピー(&C)";
            this.ToolStripMenuItemImageCopy.Click += new System.EventHandler(this.ToolStripMenuItemImageCopy_Click);
            // 
            // BtAddList
            // 
            this.BtAddList.Location = new System.Drawing.Point(27, 54);
            this.BtAddList.Name = "BtAddList";
            this.BtAddList.Size = new System.Drawing.Size(75, 23);
            this.BtAddList.TabIndex = 2;
            this.BtAddList.Text = "リスト追加";
            this.BtAddList.UseVisualStyleBackColor = true;
            // 
            // BtExec
            // 
            this.BtExec.Location = new System.Drawing.Point(27, 29);
            this.BtExec.Name = "BtExec";
            this.BtExec.Size = new System.Drawing.Size(75, 23);
            this.BtExec.TabIndex = 1;
            this.BtExec.Text = "適用";
            this.BtExec.UseVisualStyleBackColor = true;
            this.BtExec.Click += new System.EventHandler(this.BtExec_Click);
            // 
            // CbShowMask
            // 
            this.CbShowMask.Appearance = System.Windows.Forms.Appearance.Button;
            this.CbShowMask.Checked = true;
            this.CbShowMask.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CbShowMask.Location = new System.Drawing.Point(72, 3);
            this.CbShowMask.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.CbShowMask.Name = "CbShowMask";
            this.CbShowMask.Size = new System.Drawing.Size(66, 35);
            this.CbShowMask.TabIndex = 1;
            this.CbShowMask.Text = "マスク";
            this.CbShowMask.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CbShowMask.UseVisualStyleBackColor = true;
            this.CbShowMask.CheckedChanged += new System.EventHandler(this.CbShowMask_CheckedChanged);
            // 
            // BtMaskImageOpen
            // 
            this.BtMaskImageOpen.Location = new System.Drawing.Point(828, 61);
            this.BtMaskImageOpen.Name = "BtMaskImageOpen";
            this.BtMaskImageOpen.Size = new System.Drawing.Size(66, 23);
            this.BtMaskImageOpen.TabIndex = 5;
            this.BtMaskImageOpen.Text = "開く";
            this.BtMaskImageOpen.UseVisualStyleBackColor = true;
            this.BtMaskImageOpen.Click += new System.EventHandler(this.BtMaskImageOpen_Click);
            // 
            // BtMaskImageSelect
            // 
            this.BtMaskImageSelect.AutoSize = true;
            this.BtMaskImageSelect.Filter = "画像ファイル|*.bmp;*.png;*.jpg;*.jpeg;*.tif;*.tiff;*.gif;*.svg;*.webp|ビットマップファイル|*.bmp|" +
    "PNGファイル|*.png|JPEGファイル|*.jpg;*.jpeg|TIFFファイル|*.tif;*.tiff|GIFファイル|*.gif|SVGファイル|" +
    "*.svg|WebPファイル|*.webp|全てのファイル|*.*";
            this.BtMaskImageSelect.LinkControl = this.TbMaskImage;
            this.BtMaskImageSelect.Location = new System.Drawing.Point(790, 61);
            this.BtMaskImageSelect.Name = "BtMaskImageSelect";
            this.BtMaskImageSelect.Preset = SSTools.FileSelectButton.FILTER_PRESET.NONE;
            this.BtMaskImageSelect.SendClickControl = this.BtMaskImageOpen;
            this.BtMaskImageSelect.ShowHelp = false;
            this.BtMaskImageSelect.Size = new System.Drawing.Size(32, 23);
            this.BtMaskImageSelect.SupportMultiDottedExtensions = false;
            this.BtMaskImageSelect.TabIndex = 4;
            this.BtMaskImageSelect.Text = "...";
            this.BtMaskImageSelect.Title = "マスク画像を選択";
            this.BtMaskImageSelect.UserCustomDialog = true;
            this.BtMaskImageSelect.UseVisualStyleBackColor = true;
            // 
            // TbMaskImage
            // 
            this.TbMaskImage.Location = new System.Drawing.Point(94, 63);
            this.TbMaskImage.Name = "TbMaskImage";
            this.TbMaskImage.Size = new System.Drawing.Size(690, 19);
            this.TbMaskImage.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(3, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "マスク画像:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // BtImageOpen
            // 
            this.BtImageOpen.Location = new System.Drawing.Point(718, 24);
            this.BtImageOpen.Name = "BtImageOpen";
            this.BtImageOpen.Size = new System.Drawing.Size(66, 23);
            this.BtImageOpen.TabIndex = 2;
            this.BtImageOpen.Text = "開く";
            this.BtImageOpen.UseVisualStyleBackColor = true;
            this.BtImageOpen.Click += new System.EventHandler(this.BtImageOpen_Click);
            // 
            // BtImageFileSelect
            // 
            this.BtImageFileSelect.AutoSize = true;
            this.BtImageFileSelect.Filter = "画像ファイル|*.bmp;*.png;*.jpg;*.jpeg;*.tif;*.tiff;*.gif;*.svg;*.webp|ビットマップファイル|*.bmp|" +
    "PNGファイル|*.png|JPEGファイル|*.jpg;*.jpeg|TIFFファイル|*.tif;*.tiff|GIFファイル|*.gif|SVGファイル|" +
    "*.svg|WebPファイル|*.webp|全てのファイル|*.*";
            this.BtImageFileSelect.LinkControl = this.TbImageFile;
            this.BtImageFileSelect.Location = new System.Drawing.Point(680, 24);
            this.BtImageFileSelect.Name = "BtImageFileSelect";
            this.BtImageFileSelect.Preset = SSTools.FileSelectButton.FILTER_PRESET.NONE;
            this.BtImageFileSelect.SendClickControl = this.BtImageOpen;
            this.BtImageFileSelect.ShowHelp = false;
            this.BtImageFileSelect.Size = new System.Drawing.Size(32, 23);
            this.BtImageFileSelect.SupportMultiDottedExtensions = false;
            this.BtImageFileSelect.TabIndex = 1;
            this.BtImageFileSelect.Text = "...";
            this.BtImageFileSelect.Title = "画像ファイルを選択";
            this.BtImageFileSelect.UserCustomDialog = true;
            this.BtImageFileSelect.UseVisualStyleBackColor = true;
            // 
            // TbImageFile
            // 
            this.TbImageFile.Location = new System.Drawing.Point(94, 26);
            this.TbImageFile.Name = "TbImageFile";
            this.TbImageFile.Size = new System.Drawing.Size(580, 19);
            this.TbImageFile.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(3, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "画像ファイル:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PbResultImage
            // 
            this.PbResultImage.AreaSelectColor = System.Drawing.Color.YellowGreen;
            this.PbResultImage.AutoImageDispose = true;
            this.PbResultImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PbResultImage.ContextMenuStrip = this.PictBoxMenuStrip;
            this.PbResultImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PbResultImage.Image = null;
            this.PbResultImage.Location = new System.Drawing.Point(543, 174);
            this.PbResultImage.Margin = new System.Windows.Forms.Padding(0);
            this.PbResultImage.MaskAlfa = 0.5F;
            this.PbResultImage.MaskImage = null;
            this.PbResultImage.MaskShow = true;
            this.PbResultImage.Name = "PbResultImage";
            this.PbResultImage.PictureBoxMode = SSTools.ZoomPictureBox.PictureBoxDrawMode.NORMAL;
            this.TBLMain.SetRowSpan(this.PbResultImage, 3);
            this.PbResultImage.ShapeShow = true;
            this.PbResultImage.ShowImage = true;
            this.PbResultImage.Size = new System.Drawing.Size(398, 385);
            this.PbResultImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbResultImage.TabIndex = 2;
            this.PbResultImage.TabStop = false;
            this.PbResultImage.XRatio = 1F;
            this.PbResultImage.YRatio = 1F;
            // 
            // PanelFile
            // 
            this.PanelFile.AutoSize = true;
            this.TBLMain.SetColumnSpan(this.PanelFile, 4);
            this.PanelFile.Controls.Add(this.button1);
            this.PanelFile.Controls.Add(this.groupBox2);
            this.PanelFile.Controls.Add(this.groupBox1);
            this.PanelFile.Controls.Add(this.CbKeyPointType);
            this.PanelFile.Controls.Add(this.BtNewKeyPoint);
            this.PanelFile.Controls.Add(this.BtNewBox);
            this.PanelFile.Controls.Add(this.BtKeyPointEdit);
            this.PanelFile.Controls.Add(this.BtKeyPointOpen);
            this.PanelFile.Controls.Add(this.BtKeyPointSelect);
            this.PanelFile.Controls.Add(this.TbKeyPoint);
            this.PanelFile.Controls.Add(this.label4);
            this.PanelFile.Controls.Add(this.BtBBoxEdit);
            this.PanelFile.Controls.Add(this.CbBBoxType);
            this.PanelFile.Controls.Add(this.BtBBoxFileOpen);
            this.PanelFile.Controls.Add(this.BtBBoxFileSelect);
            this.PanelFile.Controls.Add(this.TbBBoxFile);
            this.PanelFile.Controls.Add(this.label3);
            this.PanelFile.Controls.Add(this.BtMaskImageOpen);
            this.PanelFile.Controls.Add(this.BtMaskImageSelect);
            this.PanelFile.Controls.Add(this.TbMaskImage);
            this.PanelFile.Controls.Add(this.label2);
            this.PanelFile.Controls.Add(this.BtImageOpen);
            this.PanelFile.Controls.Add(this.BtImageFileSelect);
            this.PanelFile.Controls.Add(this.TbImageFile);
            this.PanelFile.Controls.Add(this.label1);
            this.PanelFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelFile.Location = new System.Drawing.Point(0, 0);
            this.PanelFile.Margin = new System.Windows.Forms.Padding(0);
            this.PanelFile.Name = "PanelFile";
            this.PanelFile.Size = new System.Drawing.Size(1072, 133);
            this.PanelFile.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSize = true;
            this.groupBox2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox2.Controls.Add(this.RbGray);
            this.groupBox2.Controls.Add(this.RbColor);
            this.groupBox2.Location = new System.Drawing.Point(896, 11);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(1, 3, 1, 0);
            this.groupBox2.Size = new System.Drawing.Size(109, 46);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "色";
            // 
            // RbGray
            // 
            this.RbGray.AutoSize = true;
            this.RbGray.Location = new System.Drawing.Point(60, 18);
            this.RbGray.Margin = new System.Windows.Forms.Padding(1, 1, 1, 0);
            this.RbGray.Name = "RbGray";
            this.RbGray.Size = new System.Drawing.Size(47, 16);
            this.RbGray.TabIndex = 1;
            this.RbGray.Text = "Gray";
            this.RbGray.UseVisualStyleBackColor = true;
            // 
            // RbColor
            // 
            this.RbColor.AutoSize = true;
            this.RbColor.Checked = true;
            this.RbColor.Location = new System.Drawing.Point(4, 18);
            this.RbColor.Margin = new System.Windows.Forms.Padding(1, 1, 1, 0);
            this.RbColor.Name = "RbColor";
            this.RbColor.Size = new System.Drawing.Size(50, 16);
            this.RbColor.TabIndex = 0;
            this.RbColor.TabStop = true;
            this.RbColor.Text = "Color";
            this.RbColor.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.Controls.Add(this.RbFloat);
            this.groupBox1.Controls.Add(this.Rb8Bit);
            this.groupBox1.Location = new System.Drawing.Point(790, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(1, 3, 1, 0);
            this.groupBox1.Size = new System.Drawing.Size(100, 46);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "データ形式";
            // 
            // RbFloat
            // 
            this.RbFloat.AutoSize = true;
            this.RbFloat.Location = new System.Drawing.Point(52, 18);
            this.RbFloat.Margin = new System.Windows.Forms.Padding(1, 1, 1, 0);
            this.RbFloat.Name = "RbFloat";
            this.RbFloat.Size = new System.Drawing.Size(46, 16);
            this.RbFloat.TabIndex = 1;
            this.RbFloat.Text = "float";
            this.RbFloat.UseVisualStyleBackColor = true;
            // 
            // Rb8Bit
            // 
            this.Rb8Bit.AutoSize = true;
            this.Rb8Bit.Checked = true;
            this.Rb8Bit.Location = new System.Drawing.Point(4, 18);
            this.Rb8Bit.Margin = new System.Windows.Forms.Padding(1, 1, 1, 0);
            this.Rb8Bit.Name = "Rb8Bit";
            this.Rb8Bit.Size = new System.Drawing.Size(42, 16);
            this.Rb8Bit.TabIndex = 0;
            this.Rb8Bit.TabStop = true;
            this.Rb8Bit.Text = "8bit";
            this.Rb8Bit.UseVisualStyleBackColor = true;
            // 
            // CbKeyPointType
            // 
            this.CbKeyPointType.FormattingEnabled = true;
            this.CbKeyPointType.Location = new System.Drawing.Point(94, 109);
            this.CbKeyPointType.Name = "CbKeyPointType";
            this.CbKeyPointType.Size = new System.Drawing.Size(113, 20);
            this.CbKeyPointType.TabIndex = 12;
            // 
            // BtNewKeyPoint
            // 
            this.BtNewKeyPoint.Location = new System.Drawing.Point(857, 107);
            this.BtNewKeyPoint.Name = "BtNewKeyPoint";
            this.BtNewKeyPoint.Size = new System.Drawing.Size(64, 23);
            this.BtNewKeyPoint.TabIndex = 17;
            this.BtNewKeyPoint.Text = "新規";
            this.BtNewKeyPoint.UseVisualStyleBackColor = true;
            // 
            // BtNewBox
            // 
            this.BtNewBox.Location = new System.Drawing.Point(857, 84);
            this.BtNewBox.Name = "BtNewBox";
            this.BtNewBox.Size = new System.Drawing.Size(64, 23);
            this.BtNewBox.TabIndex = 11;
            this.BtNewBox.Text = "新規";
            this.BtNewBox.UseVisualStyleBackColor = true;
            this.BtNewBox.Click += new System.EventHandler(this.BtNewBox_Click);
            // 
            // BtKeyPointEdit
            // 
            this.BtKeyPointEdit.Location = new System.Drawing.Point(790, 107);
            this.BtKeyPointEdit.Name = "BtKeyPointEdit";
            this.BtKeyPointEdit.Size = new System.Drawing.Size(64, 23);
            this.BtKeyPointEdit.TabIndex = 16;
            this.BtKeyPointEdit.Text = "編集";
            this.BtKeyPointEdit.UseVisualStyleBackColor = true;
            // 
            // BtKeyPointOpen
            // 
            this.BtKeyPointOpen.Location = new System.Drawing.Point(718, 107);
            this.BtKeyPointOpen.Name = "BtKeyPointOpen";
            this.BtKeyPointOpen.Size = new System.Drawing.Size(66, 23);
            this.BtKeyPointOpen.TabIndex = 15;
            this.BtKeyPointOpen.Text = "開く";
            this.BtKeyPointOpen.UseVisualStyleBackColor = true;
            this.BtKeyPointOpen.Click += new System.EventHandler(this.BtKeyPointOpen_Click);
            // 
            // BtKeyPointSelect
            // 
            this.BtKeyPointSelect.AutoSize = true;
            this.BtKeyPointSelect.Filter = "テキストファイル|*.txt;*.csv;*.log;*.ini|プレーンテキストファイル|*.txt|CSVファイル|*.csv|ログファイル|*.log|IN" +
    "Iファイル|*.ini|全てのファイル|*.*";
            this.BtKeyPointSelect.LinkControl = this.TbKeyPoint;
            this.BtKeyPointSelect.Location = new System.Drawing.Point(680, 107);
            this.BtKeyPointSelect.Name = "BtKeyPointSelect";
            this.BtKeyPointSelect.Preset = SSTools.FileSelectButton.FILTER_PRESET.NONE;
            this.BtKeyPointSelect.SendClickControl = this.BtKeyPointOpen;
            this.BtKeyPointSelect.ShowHelp = false;
            this.BtKeyPointSelect.Size = new System.Drawing.Size(32, 23);
            this.BtKeyPointSelect.SupportMultiDottedExtensions = false;
            this.BtKeyPointSelect.TabIndex = 14;
            this.BtKeyPointSelect.Text = "...";
            this.BtKeyPointSelect.Title = "KeyPointsファイルを選択";
            this.BtKeyPointSelect.UserCustomDialog = true;
            this.BtKeyPointSelect.UseVisualStyleBackColor = true;
            // 
            // TbKeyPoint
            // 
            this.TbKeyPoint.Location = new System.Drawing.Point(213, 109);
            this.TbKeyPoint.Name = "TbKeyPoint";
            this.TbKeyPoint.Size = new System.Drawing.Size(461, 19);
            this.TbKeyPoint.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(3, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 23);
            this.label4.TabIndex = 16;
            this.label4.Text = "KeyPoint:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // BtBBoxEdit
            // 
            this.BtBBoxEdit.Location = new System.Drawing.Point(790, 84);
            this.BtBBoxEdit.Name = "BtBBoxEdit";
            this.BtBBoxEdit.Size = new System.Drawing.Size(64, 23);
            this.BtBBoxEdit.TabIndex = 10;
            this.BtBBoxEdit.Text = "編集";
            this.BtBBoxEdit.UseVisualStyleBackColor = true;
            this.BtBBoxEdit.Click += new System.EventHandler(this.BtBBoxEdit_Click);
            // 
            // CbBBoxType
            // 
            this.CbBBoxType.FormattingEnabled = true;
            this.CbBBoxType.Location = new System.Drawing.Point(94, 86);
            this.CbBBoxType.Name = "CbBBoxType";
            this.CbBBoxType.Size = new System.Drawing.Size(113, 20);
            this.CbBBoxType.TabIndex = 6;
            // 
            // BtBBoxFileOpen
            // 
            this.BtBBoxFileOpen.Location = new System.Drawing.Point(718, 84);
            this.BtBBoxFileOpen.Name = "BtBBoxFileOpen";
            this.BtBBoxFileOpen.Size = new System.Drawing.Size(66, 23);
            this.BtBBoxFileOpen.TabIndex = 9;
            this.BtBBoxFileOpen.Text = "開く";
            this.BtBBoxFileOpen.UseVisualStyleBackColor = true;
            this.BtBBoxFileOpen.Click += new System.EventHandler(this.BtBBoxFileOpen_Click);
            // 
            // BtBBoxFileSelect
            // 
            this.BtBBoxFileSelect.AutoSize = true;
            this.BtBBoxFileSelect.Filter = "テキストファイル|*.txt;*.csv;*.log;*.ini|プレーンテキストファイル|*.txt|CSVファイル|*.csv|ログファイル|*.log|IN" +
    "Iファイル|*.ini|全てのファイル|*.*";
            this.BtBBoxFileSelect.LinkControl = this.TbBBoxFile;
            this.BtBBoxFileSelect.Location = new System.Drawing.Point(680, 84);
            this.BtBBoxFileSelect.Name = "BtBBoxFileSelect";
            this.BtBBoxFileSelect.Preset = SSTools.FileSelectButton.FILTER_PRESET.NONE;
            this.BtBBoxFileSelect.SendClickControl = this.BtBBoxFileOpen;
            this.BtBBoxFileSelect.ShowHelp = false;
            this.BtBBoxFileSelect.Size = new System.Drawing.Size(32, 23);
            this.BtBBoxFileSelect.SupportMultiDottedExtensions = false;
            this.BtBBoxFileSelect.TabIndex = 8;
            this.BtBBoxFileSelect.Text = "...";
            this.BtBBoxFileSelect.Title = "BBOXファイルを選択";
            this.BtBBoxFileSelect.UserCustomDialog = true;
            this.BtBBoxFileSelect.UseVisualStyleBackColor = true;
            // 
            // TbBBoxFile
            // 
            this.TbBBoxFile.Location = new System.Drawing.Point(213, 86);
            this.TbBBoxFile.Name = "TbBBoxFile";
            this.TbBBoxFile.Size = new System.Drawing.Size(461, 19);
            this.TbBBoxFile.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(3, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 23);
            this.label3.TabIndex = 9;
            this.label3.Text = "BBox:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CbShowKeyPointLabel
            // 
            this.CbShowKeyPointLabel.Appearance = System.Windows.Forms.Appearance.Button;
            this.CbShowKeyPointLabel.Checked = true;
            this.CbShowKeyPointLabel.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CbShowKeyPointLabel.Location = new System.Drawing.Point(276, 3);
            this.CbShowKeyPointLabel.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.CbShowKeyPointLabel.Name = "CbShowKeyPointLabel";
            this.CbShowKeyPointLabel.Size = new System.Drawing.Size(66, 35);
            this.CbShowKeyPointLabel.TabIndex = 4;
            this.CbShowKeyPointLabel.Text = "KeyPoint\r\nラベル";
            this.CbShowKeyPointLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CbShowKeyPointLabel.UseVisualStyleBackColor = true;
            this.CbShowKeyPointLabel.CheckedChanged += new System.EventHandler(this.CbShowKeyPointLabel_CheckedChanged);
            // 
            // CbShowKeyPoints
            // 
            this.CbShowKeyPoints.Appearance = System.Windows.Forms.Appearance.Button;
            this.CbShowKeyPoints.Checked = true;
            this.CbShowKeyPoints.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CbShowKeyPoints.Location = new System.Drawing.Point(208, 3);
            this.CbShowKeyPoints.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.CbShowKeyPoints.Name = "CbShowKeyPoints";
            this.CbShowKeyPoints.Size = new System.Drawing.Size(66, 35);
            this.CbShowKeyPoints.TabIndex = 3;
            this.CbShowKeyPoints.Text = "KeyPoint";
            this.CbShowKeyPoints.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CbShowKeyPoints.UseVisualStyleBackColor = true;
            this.CbShowKeyPoints.CheckedChanged += new System.EventHandler(this.CbShowKeyPoints_CheckedChanged);
            // 
            // CbShowBBox
            // 
            this.CbShowBBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.CbShowBBox.Checked = true;
            this.CbShowBBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CbShowBBox.Location = new System.Drawing.Point(140, 3);
            this.CbShowBBox.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.CbShowBBox.Name = "CbShowBBox";
            this.CbShowBBox.Size = new System.Drawing.Size(66, 35);
            this.CbShowBBox.TabIndex = 2;
            this.CbShowBBox.Text = "BBOX";
            this.CbShowBBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CbShowBBox.UseVisualStyleBackColor = true;
            this.CbShowBBox.CheckedChanged += new System.EventHandler(this.CbShowBBox_CheckedChanged);
            // 
            // PanelExec
            // 
            this.PanelExec.Controls.Add(this.CbImmediate);
            this.PanelExec.Controls.Add(this.BtAddList);
            this.PanelExec.Controls.Add(this.BtExec);
            this.PanelExec.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelExec.Location = new System.Drawing.Point(398, 479);
            this.PanelExec.Margin = new System.Windows.Forms.Padding(0);
            this.PanelExec.Name = "PanelExec";
            this.PanelExec.Size = new System.Drawing.Size(145, 80);
            this.PanelExec.TabIndex = 4;
            // 
            // TBLMain
            // 
            this.TBLMain.ColumnCount = 4;
            this.TBLMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TBLMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 145F));
            this.TBLMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TBLMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 131F));
            this.TBLMain.Controls.Add(this.PanelResultControl, 2, 1);
            this.TBLMain.Controls.Add(this.PbResultImage, 2, 2);
            this.TBLMain.Controls.Add(this.PanelFile, 0, 0);
            this.TBLMain.Controls.Add(this.PbOrigImage, 0, 2);
            this.TBLMain.Controls.Add(this.PanelExec, 1, 4);
            this.TBLMain.Controls.Add(this.panel1, 1, 1);
            this.TBLMain.Controls.Add(this.PanelParam, 1, 3);
            this.TBLMain.Controls.Add(this.PanelOrigControl, 0, 1);
            this.TBLMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TBLMain.Location = new System.Drawing.Point(0, 24);
            this.TBLMain.Name = "TBLMain";
            this.TBLMain.RowCount = 5;
            this.TBLMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TBLMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TBLMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TBLMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TBLMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.TBLMain.Size = new System.Drawing.Size(1072, 559);
            this.TBLMain.TabIndex = 2;
            // 
            // PanelResultControl
            // 
            this.PanelResultControl.AutoSize = true;
            this.PanelResultControl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PanelResultControl.Controls.Add(this.CbShowResultImage);
            this.PanelResultControl.Controls.Add(this.CbResultShowKeyPointsLabel);
            this.PanelResultControl.Controls.Add(this.CbShowResultMask);
            this.PanelResultControl.Controls.Add(this.CbShowResultKeyPoints);
            this.PanelResultControl.Controls.Add(this.CbShowResultBBox);
            this.PanelResultControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelResultControl.Location = new System.Drawing.Point(543, 133);
            this.PanelResultControl.Margin = new System.Windows.Forms.Padding(0);
            this.PanelResultControl.Name = "PanelResultControl";
            this.PanelResultControl.Size = new System.Drawing.Size(398, 41);
            this.PanelResultControl.TabIndex = 8;
            // 
            // CbShowResultImage
            // 
            this.CbShowResultImage.Appearance = System.Windows.Forms.Appearance.Button;
            this.CbShowResultImage.Checked = true;
            this.CbShowResultImage.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CbShowResultImage.Location = new System.Drawing.Point(6, 3);
            this.CbShowResultImage.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.CbShowResultImage.Name = "CbShowResultImage";
            this.CbShowResultImage.Size = new System.Drawing.Size(66, 35);
            this.CbShowResultImage.TabIndex = 0;
            this.CbShowResultImage.Text = "画像";
            this.CbShowResultImage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CbShowResultImage.UseVisualStyleBackColor = true;
            this.CbShowResultImage.CheckedChanged += new System.EventHandler(this.CbShowResultImage_CheckedChanged);
            // 
            // CbResultShowKeyPointsLabel
            // 
            this.CbResultShowKeyPointsLabel.Appearance = System.Windows.Forms.Appearance.Button;
            this.CbResultShowKeyPointsLabel.Checked = true;
            this.CbResultShowKeyPointsLabel.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CbResultShowKeyPointsLabel.Location = new System.Drawing.Point(278, 3);
            this.CbResultShowKeyPointsLabel.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.CbResultShowKeyPointsLabel.Name = "CbResultShowKeyPointsLabel";
            this.CbResultShowKeyPointsLabel.Size = new System.Drawing.Size(66, 35);
            this.CbResultShowKeyPointsLabel.TabIndex = 4;
            this.CbResultShowKeyPointsLabel.Text = "KeyPoint\r\nラベル";
            this.CbResultShowKeyPointsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CbResultShowKeyPointsLabel.UseVisualStyleBackColor = true;
            this.CbResultShowKeyPointsLabel.CheckedChanged += new System.EventHandler(this.CbResultShowKeyPointsLabel_CheckedChanged);
            // 
            // CbShowResultMask
            // 
            this.CbShowResultMask.Appearance = System.Windows.Forms.Appearance.Button;
            this.CbShowResultMask.Checked = true;
            this.CbShowResultMask.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CbShowResultMask.Location = new System.Drawing.Point(74, 3);
            this.CbShowResultMask.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.CbShowResultMask.Name = "CbShowResultMask";
            this.CbShowResultMask.Size = new System.Drawing.Size(66, 35);
            this.CbShowResultMask.TabIndex = 1;
            this.CbShowResultMask.Text = "マスク";
            this.CbShowResultMask.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CbShowResultMask.UseVisualStyleBackColor = true;
            this.CbShowResultMask.CheckedChanged += new System.EventHandler(this.CbShowResultMask_CheckedChanged);
            // 
            // CbShowResultKeyPoints
            // 
            this.CbShowResultKeyPoints.Appearance = System.Windows.Forms.Appearance.Button;
            this.CbShowResultKeyPoints.Checked = true;
            this.CbShowResultKeyPoints.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CbShowResultKeyPoints.Location = new System.Drawing.Point(210, 3);
            this.CbShowResultKeyPoints.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.CbShowResultKeyPoints.Name = "CbShowResultKeyPoints";
            this.CbShowResultKeyPoints.Size = new System.Drawing.Size(66, 35);
            this.CbShowResultKeyPoints.TabIndex = 3;
            this.CbShowResultKeyPoints.Text = "KeyPoint";
            this.CbShowResultKeyPoints.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CbShowResultKeyPoints.UseVisualStyleBackColor = true;
            this.CbShowResultKeyPoints.CheckedChanged += new System.EventHandler(this.CbShowResultKeyPoints_CheckedChanged);
            // 
            // CbShowResultBBox
            // 
            this.CbShowResultBBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.CbShowResultBBox.Checked = true;
            this.CbShowResultBBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CbShowResultBBox.Location = new System.Drawing.Point(142, 3);
            this.CbShowResultBBox.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.CbShowResultBBox.Name = "CbShowResultBBox";
            this.CbShowResultBBox.Size = new System.Drawing.Size(66, 35);
            this.CbShowResultBBox.TabIndex = 2;
            this.CbShowResultBBox.Text = "BBOX";
            this.CbShowResultBBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CbShowResultBBox.UseVisualStyleBackColor = true;
            this.CbShowResultBBox.CheckedChanged += new System.EventHandler(this.CbShowResultBBox_CheckedChanged);
            // 
            // PanelOrigControl
            // 
            this.PanelOrigControl.AutoSize = true;
            this.PanelOrigControl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PanelOrigControl.Controls.Add(this.CbShowImage);
            this.PanelOrigControl.Controls.Add(this.CbShowKeyPointLabel);
            this.PanelOrigControl.Controls.Add(this.CbShowMask);
            this.PanelOrigControl.Controls.Add(this.CbShowKeyPoints);
            this.PanelOrigControl.Controls.Add(this.CbShowBBox);
            this.PanelOrigControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelOrigControl.Location = new System.Drawing.Point(0, 133);
            this.PanelOrigControl.Margin = new System.Windows.Forms.Padding(0);
            this.PanelOrigControl.Name = "PanelOrigControl";
            this.PanelOrigControl.Size = new System.Drawing.Size(398, 41);
            this.PanelOrigControl.TabIndex = 7;
            // 
            // CbShowImage
            // 
            this.CbShowImage.Appearance = System.Windows.Forms.Appearance.Button;
            this.CbShowImage.Checked = true;
            this.CbShowImage.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CbShowImage.Location = new System.Drawing.Point(4, 3);
            this.CbShowImage.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.CbShowImage.Name = "CbShowImage";
            this.CbShowImage.Size = new System.Drawing.Size(66, 35);
            this.CbShowImage.TabIndex = 0;
            this.CbShowImage.Text = "画像";
            this.CbShowImage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CbShowImage.UseVisualStyleBackColor = true;
            this.CbShowImage.CheckedChanged += new System.EventHandler(this.CbShowImage_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(976, 86);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 20;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 583);
            this.Controls.Add(this.TBLMain);
            this.Controls.Add(this.MenuStripMain);
            this.Name = "MainForm";
            this.Text = "Albumentationsやっっちゃう";
            this.MenuStripMain.ResumeLayout(false);
            this.MenuStripMain.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PbOrigImage)).EndInit();
            this.PictBoxMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PbResultImage)).EndInit();
            this.PanelFile.ResumeLayout(false);
            this.PanelFile.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.PanelExec.ResumeLayout(false);
            this.TBLMain.ResumeLayout(false);
            this.TBLMain.PerformLayout();
            this.PanelResultControl.ResumeLayout(false);
            this.PanelOrigControl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolTip MainToolTip;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemHelp;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemHelpAbout;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemPythonConfig;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemPython;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemFileExit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemFile;
        private System.Windows.Forms.MenuStrip MenuStripMain;
        private System.Windows.Forms.Panel PanelParam;
        private System.Windows.Forms.ComboBox CbCategory;
        private System.Windows.Forms.ComboBox CbAlbumentations;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox CbImmediate;
        private SSTools.ZoomPictureBox PbOrigImage;
        private System.Windows.Forms.TableLayoutPanel TBLMain;
        private SSTools.ZoomPictureBox PbResultImage;
        private System.Windows.Forms.Panel PanelFile;
        private System.Windows.Forms.CheckBox CbShowMask;
        private System.Windows.Forms.Button BtMaskImageOpen;
        private SSTools.FileSelectButton BtMaskImageSelect;
        private System.Windows.Forms.TextBox TbMaskImage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtImageOpen;
        private SSTools.FileSelectButton BtImageFileSelect;
        private System.Windows.Forms.TextBox TbImageFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel PanelExec;
        private System.Windows.Forms.Button BtAddList;
        private System.Windows.Forms.Button BtExec;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtBBoxEdit;
        private System.Windows.Forms.ComboBox CbBBoxType;
        private System.Windows.Forms.Button BtBBoxFileOpen;
        private SSTools.FileSelectButton BtBBoxFileSelect;
        private System.Windows.Forms.TextBox TbBBoxFile;
        private System.Windows.Forms.CheckBox CbShowBBox;
        private System.Windows.Forms.Button BtKeyPointEdit;
        private System.Windows.Forms.Button BtKeyPointOpen;
        private SSTools.FileSelectButton BtKeyPointSelect;
        private System.Windows.Forms.TextBox TbKeyPoint;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtNewKeyPoint;
        private System.Windows.Forms.Button BtNewBox;
        private System.Windows.Forms.ComboBox CbKeyPointType;
        private System.Windows.Forms.CheckBox CbShowKeyPointLabel;
        private System.Windows.Forms.CheckBox CbShowKeyPoints;
		private System.Windows.Forms.ContextMenuStrip PictBoxMenuStrip;
		private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemImageCopy;
        private System.Windows.Forms.Panel PanelOrigControl;
        private System.Windows.Forms.Panel PanelResultControl;
        private System.Windows.Forms.CheckBox CbResultShowKeyPointsLabel;
        private System.Windows.Forms.CheckBox CbShowResultMask;
        private System.Windows.Forms.CheckBox CbShowResultKeyPoints;
        private System.Windows.Forms.CheckBox CbShowResultBBox;
        private System.Windows.Forms.CheckBox CbShowImage;
        private System.Windows.Forms.CheckBox CbShowResultImage;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemShowPythonCommand;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemSetFromPythonCommand;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RbFloat;
        private System.Windows.Forms.RadioButton Rb8Bit;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton RbGray;
        private System.Windows.Forms.RadioButton RbColor;
        private System.Windows.Forms.Button button1;
    }
}

