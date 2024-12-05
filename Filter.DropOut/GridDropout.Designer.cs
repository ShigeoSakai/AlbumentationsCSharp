namespace Filter.DropOut
{
    partial class GridDropout
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
            this.ParaRatio = new FilterBase.Parts.InputTrackBar();
            this.ParaHolesNumberXy = new FilterBase.Parts.InputTuple();
            this.ParaUnitSizeRange = new FilterBase.Parts.InputMaxMin();
            this.ParaRandomOffset = new FilterBase.Parts.CheckBoxParts();
            this.ParaFillValue = new FilterBase.Parts.ColorSelectorParts();
            this.ParaMaskFillValue = new FilterBase.Parts.ColorSelectorParts();
            this.ParaShiftXy = new FilterBase.Parts.InputTuple();
            this.FLPParam.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ParaRatio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaHolesNumberXy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaUnitSizeRange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaFillValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaMaskFillValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaShiftXy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // FLPParam
            // 
            this.FLPParam.AutoSize = true;
            this.FLPParam.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.FLPParam.Controls.Add(this.ParaRatio);
            this.FLPParam.Controls.Add(this.ParaHolesNumberXy);
            this.FLPParam.Controls.Add(this.ParaUnitSizeRange);
            this.FLPParam.Controls.Add(this.ParaRandomOffset);
            this.FLPParam.Controls.Add(this.ParaFillValue);
            this.FLPParam.Controls.Add(this.ParaMaskFillValue);
            this.FLPParam.Controls.Add(this.ParaShiftXy);
            this.FLPParam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FLPParam.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.FLPParam.Location = new System.Drawing.Point(0, 25);
            this.FLPParam.Name = "FLPParam";
            this.FLPParam.Size = new System.Drawing.Size(128, 423);
            this.FLPParam.TabIndex = 5;
            // 
            // ParaRatio
            // 
            this.ParaRatio.ArgumentName = "ratio";
            this.ParaRatio.AutoSize = true;
            this.ParaRatio.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ParaRatio.DecimalPlace = 2;
            this.ParaRatio.Description = "マスクホールとユニットサイズの比率（水平方向と垂直方向で同じ）。\r\n0 から 1 の間でなければなりません。\r\n　　　デフォルト: 0.5。";
            this.ParaRatio.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.ParaRatio.InvalidValue = "";
            this.ParaRatio.Location = new System.Drawing.Point(3, 3);
            this.ParaRatio.MaxValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ParaRatio.MaxVersion = null;
            this.ParaRatio.MinimumSize = new System.Drawing.Size(124, 21);
            this.ParaRatio.MinValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.ParaRatio.MinVersion = null;
            this.ParaRatio.Name = "ParaRatio";
            this.ParaRatio.Required = false;
            this.ParaRatio.Size = new System.Drawing.Size(124, 65);
            this.ParaRatio.TabIndex = 9;
            this.ParaRatio.Title = "比率";
            this.ParaRatio.UseValid = false;
            this.ParaRatio.Valid = true;
            this.ParaRatio.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.ParaRatio.ParameterChange += new FilterBase.Parts.ParameterChangeEventHandler(this.Param_ParameterChange);
            // 
            // ParaHolesNumberXy
            // 
            this.ParaHolesNumberXy.ArgumentName = "holes_number_xy";
            this.ParaHolesNumberXy.AutoSize = true;
            this.ParaHolesNumberXy.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ParaHolesNumberXy.DecimalPlace = 0;
            this.ParaHolesNumberXy.Description = "x 方向と y 方向のグリッド単位の数。\r\n最初の値は 1 から画像の幅//2 まで、\r\n2 番目の値は 1 から画像の高さ//2 までです。";
            this.ParaHolesNumberXy.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ParaHolesNumberXy.InvalidValue = "";
            this.ParaHolesNumberXy.Location = new System.Drawing.Point(3, 74);
            this.ParaHolesNumberXy.MaxValue = "";
            this.ParaHolesNumberXy.MaxVersion = null;
            this.ParaHolesNumberXy.MinimumSize = new System.Drawing.Size(124, 21);
            this.ParaHolesNumberXy.MinValue = "(1,1)";
            this.ParaHolesNumberXy.MinVersion = null;
            this.ParaHolesNumberXy.Name = "ParaHolesNumberXy";
            this.ParaHolesNumberXy.Required = false;
            this.ParaHolesNumberXy.Size = new System.Drawing.Size(124, 73);
            this.ParaHolesNumberXy.TabIndex = 11;
            this.ParaHolesNumberXy.Title = "x方向とy方向のグリッド単位の数";
            this.ParaHolesNumberXy.UseValid = true;
            this.ParaHolesNumberXy.Valid = true;
            this.ParaHolesNumberXy.Value = "(1,1)";
            this.ParaHolesNumberXy.ValueType = FilterBase.Parts.PartsFunc.VALUE_TYPE.TYPE_INT;
            this.ParaHolesNumberXy.ParameterChange += new FilterBase.Parts.ParameterChangeEventHandler(this.Param_ParameterChange);
            // 
            // ParaUnitSizeRange
            // 
            this.ParaUnitSizeRange.ArgumentName = "unit_size_range";
            this.ParaUnitSizeRange.AutoSize = true;
            this.ParaUnitSizeRange.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ParaUnitSizeRange.DecimalPlace = 0;
            this.ParaUnitSizeRange.Description = "グリッド サイズをサンプリングする範囲。\r\n　　　デフォルト: なし。\r\n2 から画像の短辺までの範囲でなければなりません。\r\nなしの場合、グリッド サイズは画像" +
    "のサイズに基づいて計算されます。";
            this.ParaUnitSizeRange.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ParaUnitSizeRange.InvalidValue = "";
            this.ParaUnitSizeRange.Location = new System.Drawing.Point(3, 153);
            this.ParaUnitSizeRange.MaxValue = null;
            this.ParaUnitSizeRange.MaxVersion = null;
            this.ParaUnitSizeRange.MinimumSize = new System.Drawing.Size(124, 21);
            this.ParaUnitSizeRange.MinValue = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.ParaUnitSizeRange.MinVersion = null;
            this.ParaUnitSizeRange.Name = "ParaUnitSizeRange";
            this.ParaUnitSizeRange.Required = false;
            this.ParaUnitSizeRange.Size = new System.Drawing.Size(124, 73);
            this.ParaUnitSizeRange.TabIndex = 10;
            this.ParaUnitSizeRange.Title = "グリッド サイズをサンプリングする範囲";
            this.ParaUnitSizeRange.UseLargeValue = false;
            this.ParaUnitSizeRange.UseValid = true;
            this.ParaUnitSizeRange.Valid = true;
            this.ParaUnitSizeRange.Value = "(2,2)";
            this.ParaUnitSizeRange.ValueType = FilterBase.Parts.PartsFunc.VALUE_TYPE.TYPE_INT;
            this.ParaUnitSizeRange.ParameterChange += new FilterBase.Parts.ParameterChangeEventHandler(this.Param_ParameterChange);
            // 
            // ParaRandomOffset
            // 
            this.ParaRandomOffset.ArgumentName = "random_offset";
            this.ParaRandomOffset.AutoSize = true;
            this.ParaRandomOffset.CheckedValue = "";
            this.ParaRandomOffset.Description = "グリッドを 0 から (グリッド単位サイズ - 穴サイズ) の間で\r\nランダムにオフセットするかどうか。\r\nTrue の場合、入力された shift_xy は無視" +
    "され、\r\n　　　　ランダムに設定されます。\r\n　　デフォルト: True。";
            this.ParaRandomOffset.IndeterminateValue = "";
            this.ParaRandomOffset.Location = new System.Drawing.Point(3, 232);
            this.ParaRandomOffset.Margin = new System.Windows.Forms.Padding(3, 3, 1, 3);
            this.ParaRandomOffset.MaxVersion = null;
            this.ParaRandomOffset.MinimumSize = new System.Drawing.Size(122, 21);
            this.ParaRandomOffset.MinVersion = null;
            this.ParaRandomOffset.Name = "ParaRandomOffset";
            this.ParaRandomOffset.Size = new System.Drawing.Size(122, 21);
            this.ParaRandomOffset.TabIndex = 12;
            this.ParaRandomOffset.Text = "ランダムオフセット";
            this.ParaRandomOffset.Title = "ランダムオフセット";
            this.HelpToolTip.SetToolTip(this.ParaRandomOffset, "グリッドを 0 から (グリッド単位サイズ - 穴サイズ) の間で\r\nランダムにオフセットするかどうか。\r\nTrue の場合、入力された shift_xy は無視" +
        "され、\r\n　　　　ランダムに設定されます。\r\n　　デフォルト: True。");
            this.ParaRandomOffset.UncheckedValue = "";
            this.ParaRandomOffset.UseVisualStyleBackColor = true;
            this.ParaRandomOffset.Value = "";
            this.ParaRandomOffset.ParameterChange += new FilterBase.Parts.ParameterChangeEventHandler(this.Param_ParameterChange);
            this.ParaRandomOffset.CheckedChanged += new System.EventHandler(this.ParaRandomOffset_CheckedChanged);
            // 
            // ParaFillValue
            // 
            this.ParaFillValue.ArgumentName = "fill_value";
            this.ParaFillValue.AutoSize = true;
            this.ParaFillValue.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ParaFillValue.Color = System.Drawing.Color.Black;
            this.ParaFillValue.Description = "ドロップされたピクセルの値。次の値を指定できます:\r\n- int または float: すべてのチャネルがこの値で埋められます。\r\n- タプル: 各チャネルの値の" +
    "タプル。\r\n- \'random\': ランダムな値で埋められます。\r\n　　　デフォルト: 0。";
            this.ParaFillValue.InvalidValue = "";
            this.ParaFillValue.IsColor = true;
            this.ParaFillValue.Location = new System.Drawing.Point(3, 259);
            this.ParaFillValue.MaxVersion = null;
            this.ParaFillValue.MinimumSize = new System.Drawing.Size(124, 21);
            this.ParaFillValue.MinVersion = null;
            this.ParaFillValue.Name = "ParaFillValue";
            this.ParaFillValue.Required = false;
            this.ParaFillValue.Size = new System.Drawing.Size(124, 44);
            this.ParaFillValue.TabIndex = 7;
            this.ParaFillValue.Title = "ドロップアウト色";
            this.ParaFillValue.UseValid = false;
            this.ParaFillValue.Valid = true;
            this.ParaFillValue.ParameterChange += new FilterBase.Parts.ParameterChangeEventHandler(this.Param_ParameterChange);
            // 
            // ParaMaskFillValue
            // 
            this.ParaMaskFillValue.ArgumentName = "mask_fill_value";
            this.ParaMaskFillValue.AutoSize = true;
            this.ParaMaskFillValue.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ParaMaskFillValue.Color = System.Drawing.Color.Black;
            this.ParaMaskFillValue.Description = "マスク内のドロップされたピクセルの値。\r\nなしの場合、マスクは変更されません。\r\n　　　デフォルト: なし。";
            this.ParaMaskFillValue.InvalidValue = "";
            this.ParaMaskFillValue.IsColor = true;
            this.ParaMaskFillValue.Location = new System.Drawing.Point(3, 309);
            this.ParaMaskFillValue.MaxVersion = null;
            this.ParaMaskFillValue.MinimumSize = new System.Drawing.Size(124, 21);
            this.ParaMaskFillValue.MinVersion = null;
            this.ParaMaskFillValue.Name = "ParaMaskFillValue";
            this.ParaMaskFillValue.Required = false;
            this.ParaMaskFillValue.Size = new System.Drawing.Size(124, 66);
            this.ParaMaskFillValue.TabIndex = 8;
            this.ParaMaskFillValue.Title = "マスク色";
            this.ParaMaskFillValue.UseValid = true;
            this.ParaMaskFillValue.Valid = false;
            this.ParaMaskFillValue.ParameterChange += new FilterBase.Parts.ParameterChangeEventHandler(this.Param_ParameterChange);
            // 
            // ParaShiftXy
            // 
            this.ParaShiftXy.ArgumentName = "shift_xy";
            this.ParaShiftXy.AutoSize = true;
            this.ParaShiftXy.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ParaShiftXy.DecimalPlace = 0;
            this.ParaShiftXy.Description = "グリッドのオフセットは、(0,0) 座標から x 方向と y 方向で始まります。\r\nrandom_offset が False の場合にのみ使用されます。\r\n　　" +
    "　　デフォルト: (0, 0)。";
            this.ParaShiftXy.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ParaShiftXy.InvalidValue = "";
            this.ParaShiftXy.Location = new System.Drawing.Point(3, 381);
            this.ParaShiftXy.MaxValue = "";
            this.ParaShiftXy.MaxVersion = null;
            this.ParaShiftXy.MinimumSize = new System.Drawing.Size(124, 21);
            this.ParaShiftXy.MinValue = "(0,0)";
            this.ParaShiftXy.MinVersion = null;
            this.ParaShiftXy.Name = "ParaShiftXy";
            this.ParaShiftXy.Required = false;
            this.ParaShiftXy.Size = new System.Drawing.Size(124, 39);
            this.ParaShiftXy.TabIndex = 13;
            this.ParaShiftXy.Title = "シフト量";
            this.ParaShiftXy.UseValid = false;
            this.ParaShiftXy.Valid = true;
            this.ParaShiftXy.Value = "(0,0)";
            this.ParaShiftXy.ValueType = FilterBase.Parts.PartsFunc.VALUE_TYPE.TYPE_INT;
            this.ParaShiftXy.ParameterChange += new FilterBase.Parts.ParameterChangeEventHandler(this.Param_ParameterChange);
            // 
            // GridDropout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.FLPParam);
            this.Name = "GridDropout";
            this.Size = new System.Drawing.Size(128, 473);
            this.Controls.SetChildIndex(this.FLPParam, 0);
            this.FLPParam.ResumeLayout(false);
            this.FLPParam.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ParaRatio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaHolesNumberXy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaUnitSizeRange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaFillValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaMaskFillValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaShiftXy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel FLPParam;
        private FilterBase.Parts.ColorSelectorParts ParaFillValue;
        private FilterBase.Parts.ColorSelectorParts ParaMaskFillValue;
        private FilterBase.Parts.InputTrackBar ParaRatio;
        private FilterBase.Parts.InputMaxMin ParaUnitSizeRange;
        private FilterBase.Parts.InputTuple ParaHolesNumberXy;
        private FilterBase.Parts.CheckBoxParts ParaRandomOffset;
        private FilterBase.Parts.InputTuple ParaShiftXy;
    }
}
