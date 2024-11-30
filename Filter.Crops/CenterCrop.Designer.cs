namespace Filter.Crops
{
    partial class CenterCrop
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

        #region コンポーネント デザイナーで生成されたコード

        /// <summary> 
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を 
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.FLPParts = new System.Windows.Forms.FlowLayoutPanel();
            this.PartsWIdth = new FilterBase.Parts.InputValue();
            this.ParaHeight = new FilterBase.Parts.InputValue();
            this.ParaPadIfNeeded = new FilterBase.Parts.CheckBoxParts();
            this.ParaPadMode = new FilterBase.Parts.ComboBoxWithLabelParts();
            this.ParaPadCval = new FilterBase.Parts.ColorSelectorParts();
            this.ParaPadMaskCval = new FilterBase.Parts.ColorSelectorParts();
            this.ParaPadPosition = new FilterBase.Parts.ComboBoxWithLabelParts();
            this.FLPParts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PartsWIdth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaPadMode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaPadCval)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaPadMaskCval)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaPadPosition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // FLPParts
            // 
            this.FLPParts.AutoSize = true;
            this.FLPParts.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.FLPParts.Controls.Add(this.PartsWIdth);
            this.FLPParts.Controls.Add(this.ParaHeight);
            this.FLPParts.Controls.Add(this.ParaPadIfNeeded);
            this.FLPParts.Controls.Add(this.ParaPadMode);
            this.FLPParts.Controls.Add(this.ParaPadCval);
            this.FLPParts.Controls.Add(this.ParaPadMaskCval);
            this.FLPParts.Controls.Add(this.ParaPadPosition);
            this.FLPParts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FLPParts.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.FLPParts.Location = new System.Drawing.Point(0, 25);
            this.FLPParts.Name = "FLPParts";
            this.FLPParts.Size = new System.Drawing.Size(128, 299);
            this.FLPParts.TabIndex = 23;
            // 
            // PartsWIdth
            // 
            this.PartsWIdth.ArgumentName = "width";
            this.PartsWIdth.AutoSize = true;
            this.PartsWIdth.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PartsWIdth.ControlLayout = FilterBase.Parts.InputValue.LAYOUT.Horizontal;
            this.PartsWIdth.DecimalPlace = 0;
            this.PartsWIdth.Description = "切り抜き部分の高さ。0 より大きい必要があります。";
            this.PartsWIdth.Location = new System.Drawing.Point(1, 3);
            this.PartsWIdth.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.PartsWIdth.MaxValue = null;
            this.PartsWIdth.MaxVersion = null;
            this.PartsWIdth.MinimumSize = new System.Drawing.Size(124, 20);
            this.PartsWIdth.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.PartsWIdth.MinVersion = null;
            this.PartsWIdth.Name = "PartsWIdth";
            this.PartsWIdth.Required = true;
            this.PartsWIdth.Size = new System.Drawing.Size(124, 21);
            this.PartsWIdth.TabIndex = 0;
            this.PartsWIdth.Title = "　幅";
            this.PartsWIdth.Unit = "";
            this.PartsWIdth.Value = new decimal(new int[] {
            512,
            0,
            0,
            0});
            this.PartsWIdth.ValueType = FilterBase.Parts.InputValue.VALUE_TYPE.INT;
            this.PartsWIdth.ParameterChange += new FilterBase.Parts.ParameterChangeEventHandler(this.Ctrl_ParameterChange);
            // 
            // ParaHeight
            // 
            this.ParaHeight.ArgumentName = "height";
            this.ParaHeight.AutoSize = true;
            this.ParaHeight.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ParaHeight.ControlLayout = FilterBase.Parts.InputValue.LAYOUT.Horizontal;
            this.ParaHeight.DecimalPlace = 0;
            this.ParaHeight.Description = "切り抜きの幅。0 より大きい必要があります。";
            this.ParaHeight.Location = new System.Drawing.Point(1, 30);
            this.ParaHeight.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.ParaHeight.MaxValue = null;
            this.ParaHeight.MaxVersion = null;
            this.ParaHeight.MinimumSize = new System.Drawing.Size(124, 20);
            this.ParaHeight.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ParaHeight.MinVersion = null;
            this.ParaHeight.Name = "ParaHeight";
            this.ParaHeight.Required = true;
            this.ParaHeight.Size = new System.Drawing.Size(124, 21);
            this.ParaHeight.TabIndex = 1;
            this.ParaHeight.Title = "高さ";
            this.ParaHeight.Unit = "";
            this.ParaHeight.Value = new decimal(new int[] {
            512,
            0,
            0,
            0});
            this.ParaHeight.ValueType = FilterBase.Parts.InputValue.VALUE_TYPE.INT;
            this.ParaHeight.ParameterChange += new FilterBase.Parts.ParameterChangeEventHandler(this.Ctrl_ParameterChange);
            // 
            // ParaPadIfNeeded
            // 
            this.ParaPadIfNeeded.ArgumentName = "pad_if_needed";
            this.ParaPadIfNeeded.Checked = true;
            this.ParaPadIfNeeded.CheckedValue = "";
            this.ParaPadIfNeeded.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ParaPadIfNeeded.Description = "切り抜きサイズが画像サイズを超える場合にパディングするかどうか。\r\nデフォルト: False。";
            this.ParaPadIfNeeded.IndeterminateValue = "";
            this.ParaPadIfNeeded.Location = new System.Drawing.Point(1, 57);
            this.ParaPadIfNeeded.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.ParaPadIfNeeded.MaxVersion = null;
            this.ParaPadIfNeeded.MinimumSize = new System.Drawing.Size(122, 21);
            this.ParaPadIfNeeded.MinVersion = "1.4.21";
            this.ParaPadIfNeeded.Name = "ParaPadIfNeeded";
            this.ParaPadIfNeeded.Size = new System.Drawing.Size(122, 43);
            this.ParaPadIfNeeded.TabIndex = 18;
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
            this.ParaPadMode.ItemType = "BorderTypes";
            this.ParaPadMode.Location = new System.Drawing.Point(1, 106);
            this.ParaPadMode.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.ParaPadMode.MaxVersion = null;
            this.ParaPadMode.MinimumSize = new System.Drawing.Size(124, 21);
            this.ParaPadMode.MinVersion = "1.4.21";
            this.ParaPadMode.Name = "ParaPadMode";
            this.ParaPadMode.Required = false;
            this.ParaPadMode.Size = new System.Drawing.Size(124, 38);
            this.ParaPadMode.TabIndex = 14;
            this.ParaPadMode.Title = "パディングモード";
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
            this.ParaPadCval.IsColor = true;
            this.ParaPadCval.Location = new System.Drawing.Point(1, 150);
            this.ParaPadCval.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.ParaPadCval.MaxVersion = null;
            this.ParaPadCval.MinimumSize = new System.Drawing.Size(124, 21);
            this.ParaPadCval.MinVersion = "1.4.21";
            this.ParaPadCval.Name = "ParaPadCval";
            this.ParaPadCval.Required = false;
            this.ParaPadCval.Size = new System.Drawing.Size(124, 48);
            this.ParaPadCval.TabIndex = 15;
            this.ParaPadCval.Title = "Pad色";
            this.ParaPadCval.ParameterChange += new FilterBase.Parts.ParameterChangeEventHandler(this.Ctrl_ParameterChange);
            // 
            // ParaPadMaskCval
            // 
            this.ParaPadMaskCval.ArgumentName = "pad_cval_mask";
            this.ParaPadMaskCval.AutoSize = true;
            this.ParaPadMaskCval.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ParaPadMaskCval.Color = System.Drawing.Color.Black;
            this.ParaPadMaskCval.Description = "パディングモード が cv2.BORDER_CONSTANT の場合のマスクのパディング値。\r\nデフォルト: 0。";
            this.ParaPadMaskCval.IsColor = true;
            this.ParaPadMaskCval.Location = new System.Drawing.Point(1, 204);
            this.ParaPadMaskCval.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.ParaPadMaskCval.MaxVersion = null;
            this.ParaPadMaskCval.MinimumSize = new System.Drawing.Size(124, 21);
            this.ParaPadMaskCval.MinVersion = "1.4.21";
            this.ParaPadMaskCval.Name = "ParaPadMaskCval";
            this.ParaPadMaskCval.Required = false;
            this.ParaPadMaskCval.Size = new System.Drawing.Size(124, 48);
            this.ParaPadMaskCval.TabIndex = 16;
            this.ParaPadMaskCval.Title = "Padマスク色";
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
            this.ParaPadPosition.ItemType = "System.String";
            this.ParaPadPosition.Location = new System.Drawing.Point(1, 258);
            this.ParaPadPosition.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.ParaPadPosition.MaxVersion = null;
            this.ParaPadPosition.MinimumSize = new System.Drawing.Size(124, 21);
            this.ParaPadPosition.MinVersion = "1.4.21";
            this.ParaPadPosition.Name = "ParaPadPosition";
            this.ParaPadPosition.Required = false;
            this.ParaPadPosition.Size = new System.Drawing.Size(124, 38);
            this.ParaPadPosition.TabIndex = 17;
            this.ParaPadPosition.Title = "Pad位置";
            this.ParaPadPosition.Value = null;
            this.ParaPadPosition.ParameterChange += new FilterBase.Parts.ParameterChangeEventHandler(this.Ctrl_ParameterChange);
            // 
            // CenterCrop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.FLPParts);
            this.MaximumSize = new System.Drawing.Size(128, 600);
            this.Name = "CenterCrop";
            this.Size = new System.Drawing.Size(128, 349);
            this.Controls.SetChildIndex(this.FLPParts, 0);
            this.FLPParts.ResumeLayout(false);
            this.FLPParts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PartsWIdth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaPadMode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaPadCval)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaPadMaskCval)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaPadPosition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel FLPParts;
        private FilterBase.Parts.InputValue PartsWIdth;
        private FilterBase.Parts.InputValue ParaHeight;
        private FilterBase.Parts.ComboBoxWithLabelParts ParaPadMode;
        private FilterBase.Parts.ColorSelectorParts ParaPadCval;
        private FilterBase.Parts.ColorSelectorParts ParaPadMaskCval;
        private FilterBase.Parts.ComboBoxWithLabelParts ParaPadPosition;
        private FilterBase.Parts.CheckBoxParts ParaPadIfNeeded;
    }
}
