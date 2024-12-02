namespace Filter.DropOut
{
    partial class CoarseDropout
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
            this.ParaNumHolesRange = new FilterBase.Parts.InputMaxMin();
            this.ParaHoleWidthRange = new FilterBase.Parts.InputMaxMinWithType();
            this.ParaHoleHeightRange = new FilterBase.Parts.InputMaxMinWithType();
            this.ParaFillValue = new FilterBase.Parts.ColorSelectorParts();
            this.ParaMaskFillValue = new FilterBase.Parts.ColorSelectorParts();
            this.FLPParam.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ParaNumHolesRange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaHoleWidthRange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaHoleHeightRange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaFillValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaMaskFillValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // FLPParam
            // 
            this.FLPParam.AutoSize = true;
            this.FLPParam.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.FLPParam.Controls.Add(this.ParaNumHolesRange);
            this.FLPParam.Controls.Add(this.ParaHoleWidthRange);
            this.FLPParam.Controls.Add(this.ParaHoleHeightRange);
            this.FLPParam.Controls.Add(this.ParaFillValue);
            this.FLPParam.Controls.Add(this.ParaMaskFillValue);
            this.FLPParam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FLPParam.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.FLPParam.Location = new System.Drawing.Point(0, 25);
            this.FLPParam.Name = "FLPParam";
            this.FLPParam.Size = new System.Drawing.Size(128, 281);
            this.FLPParam.TabIndex = 5;
            // 
            // ParaNumHolesRange
            // 
            this.ParaNumHolesRange.ArgumentName = "num_holes_range";
            this.ParaNumHolesRange.AutoSize = true;
            this.ParaNumHolesRange.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ParaNumHolesRange.DecimalPlace = 0;
            this.ParaNumHolesRange.Description = "削除する長方形領域の数の範囲 (最小,最大)。\r\nデフォルト: (1, 1)";
            this.ParaNumHolesRange.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ParaNumHolesRange.InvalidValue = "";
            this.ParaNumHolesRange.Location = new System.Drawing.Point(3, 3);
            this.ParaNumHolesRange.MaxValue = null;
            this.ParaNumHolesRange.MaxVersion = null;
            this.ParaNumHolesRange.MinimumSize = new System.Drawing.Size(124, 21);
            this.ParaNumHolesRange.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ParaNumHolesRange.MinVersion = null;
            this.ParaNumHolesRange.Name = "ParaNumHolesRange";
            this.ParaNumHolesRange.Required = false;
            this.ParaNumHolesRange.Size = new System.Drawing.Size(124, 39);
            this.ParaNumHolesRange.TabIndex = 0;
            this.ParaNumHolesRange.Title = "穴の数の範囲";
            this.ParaNumHolesRange.UseLargeValue = false;
            this.ParaNumHolesRange.UseValid = false;
            this.ParaNumHolesRange.Value = "(1,1)";
            this.ParaNumHolesRange.ValueType = FilterBase.Parts.PartsFunc.VALUE_TYPE.TYPE_INT;
            this.ParaNumHolesRange.ParameterChange += new FilterBase.Parts.ParameterChangeEventHandler(this.Param_ParameterChange);
            // 
            // ParaHoleWidthRange
            // 
            this.ParaHoleWidthRange.ArgumentName = "hole_width_range";
            this.ParaHoleWidthRange.AutoSize = true;
            this.ParaHoleWidthRange.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ParaHoleWidthRange.DecimalPlace = 2;
            this.ParaHoleWidthRange.Description = "ドロップアウト領域の幅の範囲 (最小,最大)。\r\nint の場合は絶対ピクセル値を指定します。\r\nfloat の場合は画像幅の割合として解釈されます。\r\nデフォル" +
    "ト: (8, 8)";
            this.ParaHoleWidthRange.FloatIncrement = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.ParaHoleWidthRange.FloatMaxValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ParaHoleWidthRange.FloatMinValue = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.ParaHoleWidthRange.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ParaHoleWidthRange.IntIncrement = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ParaHoleWidthRange.IntMaxValue = null;
            this.ParaHoleWidthRange.IntMinValue = 1;
            this.ParaHoleWidthRange.InvalidValue = "";
            this.ParaHoleWidthRange.Location = new System.Drawing.Point(3, 48);
            this.ParaHoleWidthRange.MaxValue = null;
            this.ParaHoleWidthRange.MaxVersion = null;
            this.ParaHoleWidthRange.MinimumSize = new System.Drawing.Size(124, 21);
            this.ParaHoleWidthRange.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ParaHoleWidthRange.MinVersion = null;
            this.ParaHoleWidthRange.Name = "ParaHoleWidthRange";
            this.ParaHoleWidthRange.Required = false;
            this.ParaHoleWidthRange.Size = new System.Drawing.Size(124, 51);
            this.ParaHoleWidthRange.TabIndex = 2;
            this.ParaHoleWidthRange.Title = "ドロップアウト幅";
            this.ParaHoleWidthRange.UseLargeValue = false;
            this.ParaHoleWidthRange.UseValid = false;
            this.ParaHoleWidthRange.Value = "(8,8)";
            this.ParaHoleWidthRange.ValueType = FilterBase.Parts.PartsFunc.VALUE_TYPE.TYPE_INT;
            this.ParaHoleWidthRange.ParameterChange += new FilterBase.Parts.ParameterChangeEventHandler(this.Param_ParameterChange);
            // 
            // ParaHoleHeightRange
            // 
            this.ParaHoleHeightRange.ArgumentName = "hole_height_range ";
            this.ParaHoleHeightRange.AutoSize = true;
            this.ParaHoleHeightRange.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ParaHoleHeightRange.DecimalPlace = 2;
            this.ParaHoleHeightRange.Description = "ドロップアウト領域の高さの範囲 (最小,最大)。\r\nint の場合は絶対ピクセル値を指定します。\r\nfloat の場合は画像の高さの割合として解釈されます。\r\nデ" +
    "フォルト: (8, 8)";
            this.ParaHoleHeightRange.FloatIncrement = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.ParaHoleHeightRange.FloatMaxValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ParaHoleHeightRange.FloatMinValue = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.ParaHoleHeightRange.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ParaHoleHeightRange.IntIncrement = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ParaHoleHeightRange.IntMaxValue = null;
            this.ParaHoleHeightRange.IntMinValue = 1;
            this.ParaHoleHeightRange.InvalidValue = "";
            this.ParaHoleHeightRange.Location = new System.Drawing.Point(3, 105);
            this.ParaHoleHeightRange.MaxValue = null;
            this.ParaHoleHeightRange.MaxVersion = null;
            this.ParaHoleHeightRange.MinimumSize = new System.Drawing.Size(124, 21);
            this.ParaHoleHeightRange.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ParaHoleHeightRange.MinVersion = null;
            this.ParaHoleHeightRange.Name = "ParaHoleHeightRange";
            this.ParaHoleHeightRange.Required = false;
            this.ParaHoleHeightRange.Size = new System.Drawing.Size(124, 51);
            this.ParaHoleHeightRange.TabIndex = 1;
            this.ParaHoleHeightRange.Title = "ドロップアウト高さ";
            this.ParaHoleHeightRange.UseLargeValue = false;
            this.ParaHoleHeightRange.UseValid = false;
            this.ParaHoleHeightRange.Value = "(8,8)";
            this.ParaHoleHeightRange.ValueType = FilterBase.Parts.PartsFunc.VALUE_TYPE.TYPE_INT;
            this.ParaHoleHeightRange.ParameterChange += new FilterBase.Parts.ParameterChangeEventHandler(this.Param_ParameterChange);
            // 
            // ParaFillValue
            // 
            this.ParaFillValue.ArgumentName = "fill_value";
            this.ParaFillValue.AutoSize = true;
            this.ParaFillValue.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ParaFillValue.Color = System.Drawing.Color.Black;
            this.ParaFillValue.Description = "ドロップされたピクセルの値。次の値を指定できます:\r\n- int または float: すべてのチャネルがこの値で埋められます。\r\n- タプル: 各チャネルの値の" +
    "タプル。\r\n- \'random\': ランダムな値で埋められます。";
            this.ParaFillValue.InvalidValue = "";
            this.ParaFillValue.IsColor = true;
            this.ParaFillValue.Location = new System.Drawing.Point(3, 162);
            this.ParaFillValue.MaxVersion = null;
            this.ParaFillValue.MinimumSize = new System.Drawing.Size(124, 21);
            this.ParaFillValue.MinVersion = null;
            this.ParaFillValue.Name = "ParaFillValue";
            this.ParaFillValue.Required = false;
            this.ParaFillValue.Size = new System.Drawing.Size(124, 44);
            this.ParaFillValue.TabIndex = 3;
            this.ParaFillValue.Title = "ドロップアウト色";
            this.ParaFillValue.UseValid = false;
            this.ParaFillValue.ParameterChange += new FilterBase.Parts.ParameterChangeEventHandler(this.Param_ParameterChange);
            // 
            // ParaMaskFillValue
            // 
            this.ParaMaskFillValue.ArgumentName = "mask_fill_value";
            this.ParaMaskFillValue.AutoSize = true;
            this.ParaMaskFillValue.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ParaMaskFillValue.Color = System.Drawing.Color.Black;
            this.ParaMaskFillValue.Description = "マスク内のドロップアウト領域の塗りつぶし値。\r\nなしの場合、画像のドロップアウトに対応するマスク領域は変更されません。\r\nデフォルト: なし";
            this.ParaMaskFillValue.InvalidValue = "";
            this.ParaMaskFillValue.IsColor = true;
            this.ParaMaskFillValue.Location = new System.Drawing.Point(3, 212);
            this.ParaMaskFillValue.MaxVersion = null;
            this.ParaMaskFillValue.MinimumSize = new System.Drawing.Size(124, 21);
            this.ParaMaskFillValue.MinVersion = null;
            this.ParaMaskFillValue.Name = "ParaMaskFillValue";
            this.ParaMaskFillValue.Required = false;
            this.ParaMaskFillValue.Size = new System.Drawing.Size(124, 66);
            this.ParaMaskFillValue.TabIndex = 4;
            this.ParaMaskFillValue.Title = "マスク色";
            this.ParaMaskFillValue.UseValid = true;
            this.ParaMaskFillValue.ParameterChange += new FilterBase.Parts.ParameterChangeEventHandler(this.Param_ParameterChange);
            // 
            // CoarseDropout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.FLPParam);
            this.Name = "CoarseDropout";
            this.Size = new System.Drawing.Size(128, 331);
            this.Controls.SetChildIndex(this.FLPParam, 0);
            this.FLPParam.ResumeLayout(false);
            this.FLPParam.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ParaNumHolesRange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaHoleWidthRange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaHoleHeightRange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaFillValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaMaskFillValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel FLPParam;
        private FilterBase.Parts.InputMaxMin ParaNumHolesRange;
        private FilterBase.Parts.InputMaxMinWithType ParaHoleHeightRange;
        private FilterBase.Parts.InputMaxMinWithType ParaHoleWidthRange;
        private FilterBase.Parts.ColorSelectorParts ParaFillValue;
        private FilterBase.Parts.ColorSelectorParts ParaMaskFillValue;
    }
}
