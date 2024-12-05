namespace Filter.Crops
{
    partial class Crop
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
            this.ParaXMin = new FilterBase.Parts.InputValueUpDown();
            this.ParaYMin = new FilterBase.Parts.InputValueUpDown();
            this.ParaXMax = new FilterBase.Parts.InputValueUpDown();
            this.ParaYMax = new FilterBase.Parts.InputValueUpDown();
            this.ParaPadIfNeeded = new FilterBase.Parts.CheckBoxParts();
            this.ParaPadMode = new FilterBase.Parts.ComboBoxWithLabelParts();
            this.ParaPadCval = new FilterBase.Parts.ColorSelectorParts();
            this.ParaPadMaskCval = new FilterBase.Parts.ColorSelectorParts();
            this.ParaPadPosition = new FilterBase.Parts.ComboBoxWithLabelParts();
            this.FLPParam.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ParaXMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaYMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaXMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaYMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaPadMode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaPadCval)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaPadMaskCval)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaPadPosition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // FLPParam
            // 
            this.FLPParam.AutoSize = true;
            this.FLPParam.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.FLPParam.Controls.Add(this.ParaXMin);
            this.FLPParam.Controls.Add(this.ParaYMin);
            this.FLPParam.Controls.Add(this.ParaXMax);
            this.FLPParam.Controls.Add(this.ParaYMax);
            this.FLPParam.Controls.Add(this.ParaPadIfNeeded);
            this.FLPParam.Controls.Add(this.ParaPadMode);
            this.FLPParam.Controls.Add(this.ParaPadCval);
            this.FLPParam.Controls.Add(this.ParaPadMaskCval);
            this.FLPParam.Controls.Add(this.ParaPadPosition);
            this.FLPParam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FLPParam.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.FLPParam.Location = new System.Drawing.Point(0, 24);
            this.FLPParam.Name = "FLPParam";
            this.FLPParam.Size = new System.Drawing.Size(128, 401);
            this.FLPParam.TabIndex = 5;
            // 
            // ParaXMin
            // 
            this.ParaXMin.ArgumentName = "x_min";
            this.ParaXMin.AutoSize = true;
            this.ParaXMin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ParaXMin.ControlLayout = FilterBase.Parts.InputValue.LAYOUT.Vertical;
            this.ParaXMin.DecimalPlace = 0;
            this.ParaXMin.Description = "トリミング領域 (左端) の最小 x 座標。\r\n0 以上である必要があります。\r\n　　デフォルト: 0。";
            this.ParaXMin.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ParaXMin.InvalidValue = "";
            this.ParaXMin.Location = new System.Drawing.Point(3, 3);
            this.ParaXMin.MaxValue = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.ParaXMin.MaxVersion = null;
            this.ParaXMin.MinimumSize = new System.Drawing.Size(124, 21);
            this.ParaXMin.MinValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.ParaXMin.MinVersion = null;
            this.ParaXMin.Name = "ParaXMin";
            this.ParaXMin.Required = false;
            this.ParaXMin.Size = new System.Drawing.Size(124, 35);
            this.ParaXMin.TabIndex = 0;
            this.ParaXMin.Title = "左端X座標";
            this.ParaXMin.Unit = "";
            this.ParaXMin.UseValid = false;
            this.ParaXMin.Valid = true;
            this.ParaXMin.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.ParaXMin.ValueType = FilterBase.Parts.InputValue.VALUE_TYPE.INT;
            this.ParaXMin.ParameterChange += new FilterBase.Parts.ParameterChangeEventHandler(this.Ctrl_ParameterChange);
            // 
            // ParaYMin
            // 
            this.ParaYMin.ArgumentName = "y_min";
            this.ParaYMin.AutoSize = true;
            this.ParaYMin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ParaYMin.ControlLayout = FilterBase.Parts.InputValue.LAYOUT.Vertical;
            this.ParaYMin.DecimalPlace = 0;
            this.ParaYMin.Description = "トリミング領域 (上端) の最小 y 座標。\r\n0 以上である必要があります。\r\n　　　デフォルト: 0。";
            this.ParaYMin.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ParaYMin.InvalidValue = "";
            this.ParaYMin.Location = new System.Drawing.Point(3, 44);
            this.ParaYMin.MaxValue = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.ParaYMin.MaxVersion = null;
            this.ParaYMin.MinimumSize = new System.Drawing.Size(124, 21);
            this.ParaYMin.MinValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.ParaYMin.MinVersion = null;
            this.ParaYMin.Name = "ParaYMin";
            this.ParaYMin.Required = false;
            this.ParaYMin.Size = new System.Drawing.Size(124, 35);
            this.ParaYMin.TabIndex = 1;
            this.ParaYMin.Title = "上端Y座標";
            this.ParaYMin.Unit = "";
            this.ParaYMin.UseValid = false;
            this.ParaYMin.Valid = true;
            this.ParaYMin.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.ParaYMin.ValueType = FilterBase.Parts.InputValue.VALUE_TYPE.INT;
            this.ParaYMin.ParameterChange += new FilterBase.Parts.ParameterChangeEventHandler(this.Ctrl_ParameterChange);
            // 
            // ParaXMax
            // 
            this.ParaXMax.ArgumentName = "x_max";
            this.ParaXMax.AutoSize = true;
            this.ParaXMax.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ParaXMax.ControlLayout = FilterBase.Parts.InputValue.LAYOUT.Vertical;
            this.ParaXMax.DecimalPlace = 0;
            this.ParaXMax.Description = "切り抜き領域の最大 x 座標 (右端)。\r\nx_min より大きい必要があります。\r\n　　デフォルト: 1024。";
            this.ParaXMax.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ParaXMax.InvalidValue = "";
            this.ParaXMax.Location = new System.Drawing.Point(3, 85);
            this.ParaXMax.MaxValue = new decimal(new int[] {
            1920,
            0,
            0,
            0});
            this.ParaXMax.MaxVersion = null;
            this.ParaXMax.MinimumSize = new System.Drawing.Size(124, 21);
            this.ParaXMax.MinValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.ParaXMax.MinVersion = null;
            this.ParaXMax.Name = "ParaXMax";
            this.ParaXMax.Required = false;
            this.ParaXMax.Size = new System.Drawing.Size(124, 35);
            this.ParaXMax.TabIndex = 2;
            this.ParaXMax.Title = "右端X座標";
            this.ParaXMax.Unit = "";
            this.ParaXMax.UseValid = false;
            this.ParaXMax.Valid = true;
            this.ParaXMax.Value = new decimal(new int[] {
            1024,
            0,
            0,
            0});
            this.ParaXMax.ValueType = FilterBase.Parts.InputValue.VALUE_TYPE.INT;
            this.ParaXMax.ParameterChange += new FilterBase.Parts.ParameterChangeEventHandler(this.Ctrl_ParameterChange);
            // 
            // ParaYMax
            // 
            this.ParaYMax.ArgumentName = "y_max";
            this.ParaYMax.AutoSize = true;
            this.ParaYMax.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ParaYMax.ControlLayout = FilterBase.Parts.InputValue.LAYOUT.Vertical;
            this.ParaYMax.DecimalPlace = 0;
            this.ParaYMax.Description = "切り抜き領域 (下端) の最大 y 座標。\r\ny_min より大きい必要があります。\r\n　　　デフォルト: 1024。";
            this.ParaYMax.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ParaYMax.InvalidValue = "";
            this.ParaYMax.Location = new System.Drawing.Point(3, 126);
            this.ParaYMax.MaxValue = new decimal(new int[] {
            1920,
            0,
            0,
            0});
            this.ParaYMax.MaxVersion = null;
            this.ParaYMax.MinimumSize = new System.Drawing.Size(124, 21);
            this.ParaYMax.MinValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.ParaYMax.MinVersion = null;
            this.ParaYMax.Name = "ParaYMax";
            this.ParaYMax.Required = false;
            this.ParaYMax.Size = new System.Drawing.Size(124, 35);
            this.ParaYMax.TabIndex = 3;
            this.ParaYMax.Title = "下端Y座標";
            this.ParaYMax.Unit = "";
            this.ParaYMax.UseValid = false;
            this.ParaYMax.Valid = true;
            this.ParaYMax.Value = new decimal(new int[] {
            1024,
            0,
            0,
            0});
            this.ParaYMax.ValueType = FilterBase.Parts.InputValue.VALUE_TYPE.INT;
            this.ParaYMax.ParameterChange += new FilterBase.Parts.ParameterChangeEventHandler(this.Ctrl_ParameterChange);
            // 
            // ParaPadIfNeeded
            // 
            this.ParaPadIfNeeded.ArgumentName = "pad_if_needed";
            this.ParaPadIfNeeded.Checked = true;
            this.ParaPadIfNeeded.CheckedValue = "";
            this.ParaPadIfNeeded.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ParaPadIfNeeded.Description = "切り抜きサイズが画像サイズを超える場合にパディングするかどうか。\r\nデフォルト: False。";
            this.ParaPadIfNeeded.IndeterminateValue = "";
            this.ParaPadIfNeeded.Location = new System.Drawing.Point(1, 167);
            this.ParaPadIfNeeded.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.ParaPadIfNeeded.MaxVersion = null;
            this.ParaPadIfNeeded.MinimumSize = new System.Drawing.Size(122, 21);
            this.ParaPadIfNeeded.MinVersion = "1.4.21";
            this.ParaPadIfNeeded.Name = "ParaPadIfNeeded";
            this.ParaPadIfNeeded.Size = new System.Drawing.Size(122, 43);
            this.ParaPadIfNeeded.TabIndex = 19;
            this.ParaPadIfNeeded.Text = "切り抜きサイズが画像サイズを超える場合にパディングする";
            this.ParaPadIfNeeded.Title = "切り抜きサイズが画像サイズを超える場合にパディングする";
            this.HelpToolTip.SetToolTip(this.ParaPadIfNeeded, "切り抜きサイズが画像サイズを超える場合にパディングするかどうか。\r\nデフォルト: False。");
            this.ParaPadIfNeeded.UncheckedValue = "";
            this.ParaPadIfNeeded.UseVisualStyleBackColor = true;
            this.ParaPadIfNeeded.Value = "";
            this.ParaPadIfNeeded.ParameterChange += new FilterBase.Parts.ParameterChangeEventHandler(this.Ctrl_ParameterChange);
            // 
            // ParaPadMode
            // 
            this.ParaPadMode.ArgumentName = "pad_mode ";
            this.ParaPadMode.AutoSize = true;
            this.ParaPadMode.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ParaPadMode.DefaultValue = "BORDER_CONSTANT";
            this.ParaPadMode.Description = "パディングに使用される OpenCV 境界モード。\r\nデフォルト: cv2.BORDER_CONSTANT。";
            this.ParaPadMode.InvalidValue = "";
            this.ParaPadMode.ItemType = "BorderTypes";
            this.ParaPadMode.Location = new System.Drawing.Point(1, 216);
            this.ParaPadMode.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.ParaPadMode.MaxVersion = null;
            this.ParaPadMode.MinimumSize = new System.Drawing.Size(124, 21);
            this.ParaPadMode.MinVersion = "1.4.21";
            this.ParaPadMode.Name = "ParaPadMode";
            this.ParaPadMode.Required = false;
            this.ParaPadMode.Size = new System.Drawing.Size(124, 38);
            this.ParaPadMode.TabIndex = 20;
            this.ParaPadMode.Title = "パディングモード";
            this.ParaPadMode.UseValid = false;
            this.ParaPadMode.Valid = true;
            this.ParaPadMode.Value = null;
            this.ParaPadMode.SelectionChangeCommitted += new FilterBase.Parts.ComboBoxWithLabelParts.ComboBoxSelectEventHandler(this.ParaPadMode_SelectionChangeCommitted);
            this.ParaPadMode.ParameterChange += new FilterBase.Parts.ParameterChangeEventHandler(this.Ctrl_ParameterChange);
            // 
            // ParaPadCval
            // 
            this.ParaPadCval.ArgumentName = "pad_cval";
            this.ParaPadCval.AutoSize = true;
            this.ParaPadCval.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ParaPadCval.Color = System.Drawing.Color.Black;
            this.ParaPadCval.Description = "パディングモード が cv2.BORDER_CONSTANT の場合の画像のパディング値。\r\nデフォルト: 0。";
            this.ParaPadCval.InvalidValue = "";
            this.ParaPadCval.IsColor = true;
            this.ParaPadCval.Location = new System.Drawing.Point(1, 260);
            this.ParaPadCval.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.ParaPadCval.MaxVersion = null;
            this.ParaPadCval.MinimumSize = new System.Drawing.Size(124, 21);
            this.ParaPadCval.MinVersion = "1.4.21";
            this.ParaPadCval.Name = "ParaPadCval";
            this.ParaPadCval.Required = false;
            this.ParaPadCval.Size = new System.Drawing.Size(124, 44);
            this.ParaPadCval.TabIndex = 21;
            this.ParaPadCval.Title = "Pad色";
            this.ParaPadCval.UseValid = false;
            this.ParaPadCval.Valid = true;
            this.ParaPadCval.ParameterChange += new FilterBase.Parts.ParameterChangeEventHandler(this.Ctrl_ParameterChange);
            // 
            // ParaPadMaskCval
            // 
            this.ParaPadMaskCval.ArgumentName = "pad_cval_mask";
            this.ParaPadMaskCval.AutoSize = true;
            this.ParaPadMaskCval.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ParaPadMaskCval.Color = System.Drawing.Color.Black;
            this.ParaPadMaskCval.Description = "パディングモード が cv2.BORDER_CONSTANT の場合のマスクのパディング値。\r\nデフォルト: 0。";
            this.ParaPadMaskCval.InvalidValue = "";
            this.ParaPadMaskCval.IsColor = true;
            this.ParaPadMaskCval.Location = new System.Drawing.Point(1, 310);
            this.ParaPadMaskCval.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.ParaPadMaskCval.MaxVersion = null;
            this.ParaPadMaskCval.MinimumSize = new System.Drawing.Size(124, 21);
            this.ParaPadMaskCval.MinVersion = "1.4.21";
            this.ParaPadMaskCval.Name = "ParaPadMaskCval";
            this.ParaPadMaskCval.Required = false;
            this.ParaPadMaskCval.Size = new System.Drawing.Size(124, 44);
            this.ParaPadMaskCval.TabIndex = 22;
            this.ParaPadMaskCval.Title = "Padマスク色";
            this.ParaPadMaskCval.UseValid = false;
            this.ParaPadMaskCval.Valid = true;
            this.ParaPadMaskCval.ParameterChange += new FilterBase.Parts.ParameterChangeEventHandler(this.Ctrl_ParameterChange);
            // 
            // ParaPadPosition
            // 
            this.ParaPadPosition.ArgumentName = "pad_position";
            this.ParaPadPosition.AutoSize = true;
            this.ParaPadPosition.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ParaPadPosition.DefaultValue = "center";
            this.ParaPadPosition.Description = "パディングの位置 \r\n(\'center\'、\'top_left\'、\'top_right\'、\'bottom_left\'、 \'bottom_right\'、\'random" +
    "\'）。\r\nデフォルト: \'center\'。";
            this.ParaPadPosition.InvalidValue = "";
            this.ParaPadPosition.ItemType = "System.String";
            this.ParaPadPosition.Location = new System.Drawing.Point(1, 360);
            this.ParaPadPosition.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.ParaPadPosition.MaxVersion = null;
            this.ParaPadPosition.MinimumSize = new System.Drawing.Size(124, 21);
            this.ParaPadPosition.MinVersion = "1.4.21";
            this.ParaPadPosition.Name = "ParaPadPosition";
            this.ParaPadPosition.Required = false;
            this.ParaPadPosition.Size = new System.Drawing.Size(124, 38);
            this.ParaPadPosition.TabIndex = 23;
            this.ParaPadPosition.Title = "Pad位置";
            this.ParaPadPosition.UseValid = false;
            this.ParaPadPosition.Valid = true;
            this.ParaPadPosition.Value = null;
            this.ParaPadPosition.ParameterChange += new FilterBase.Parts.ParameterChangeEventHandler(this.Ctrl_ParameterChange);
            // 
            // Crop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.FLPParam);
            this.Name = "Crop";
            this.Size = new System.Drawing.Size(128, 450);
            this.Controls.SetChildIndex(this.FLPParam, 0);
            this.FLPParam.ResumeLayout(false);
            this.FLPParam.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ParaXMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaYMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaXMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaYMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaPadMode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaPadCval)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaPadMaskCval)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaPadPosition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel FLPParam;
        private FilterBase.Parts.InputValueUpDown ParaXMin;
        private FilterBase.Parts.InputValueUpDown ParaYMin;
        private FilterBase.Parts.InputValueUpDown ParaXMax;
        private FilterBase.Parts.InputValueUpDown ParaYMax;
        private FilterBase.Parts.CheckBoxParts ParaPadIfNeeded;
        private FilterBase.Parts.ComboBoxWithLabelParts ParaPadMode;
        private FilterBase.Parts.ColorSelectorParts ParaPadCval;
        private FilterBase.Parts.ColorSelectorParts ParaPadMaskCval;
        private FilterBase.Parts.ComboBoxWithLabelParts ParaPadPosition;
    }
}
