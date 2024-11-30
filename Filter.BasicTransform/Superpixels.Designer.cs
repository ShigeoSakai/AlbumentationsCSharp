namespace Filter.BasicTransform
{
    partial class Superpixels
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Superpixels));
            this.FLPParam = new System.Windows.Forms.FlowLayoutPanel();
            this.ParaPReplace = new FilterBase.Parts.InputMaxMin();
            this.ParaNSegments = new FilterBase.Parts.InputMaxMin();
            this.ParaMaxSize = new FilterBase.Parts.InputValueUpDown();
            this.ParaInterpolation = new FilterBase.Parts.ComboBoxWithLabelParts();
            this.FLPParam.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ParaPReplace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaNSegments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaMaxSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaInterpolation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // FLPParam
            // 
            this.FLPParam.AutoSize = true;
            this.FLPParam.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.FLPParam.Controls.Add(this.ParaPReplace);
            this.FLPParam.Controls.Add(this.ParaNSegments);
            this.FLPParam.Controls.Add(this.ParaMaxSize);
            this.FLPParam.Controls.Add(this.ParaInterpolation);
            this.FLPParam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FLPParam.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.FLPParam.Location = new System.Drawing.Point(0, 25);
            this.FLPParam.Name = "FLPParam";
            this.FLPParam.Size = new System.Drawing.Size(128, 181);
            this.FLPParam.TabIndex = 5;
            // 
            // ParaPReplace
            // 
            this.ParaPReplace.ArgumentName = "p_replace";
            this.ParaPReplace.AutoSize = true;
            this.ParaPReplace.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ParaPReplace.DecimalPlace = 1;
            this.ParaPReplace.Description = resources.GetString("ParaPReplace.Description");
            this.ParaPReplace.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.ParaPReplace.Location = new System.Drawing.Point(3, 3);
            this.ParaPReplace.MaxValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ParaPReplace.MaxVersion = null;
            this.ParaPReplace.MinimumSize = new System.Drawing.Size(124, 21);
            this.ParaPReplace.MinValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.ParaPReplace.MinVersion = null;
            this.ParaPReplace.Name = "ParaPReplace";
            this.ParaPReplace.Required = false;
            this.ParaPReplace.Size = new System.Drawing.Size(124, 42);
            this.ParaPReplace.TabIndex = 0;
            this.ParaPReplace.Title = "置き換え確率範囲";
            this.ParaPReplace.Value = "(0.1,0.3)";
            this.ParaPReplace.ValueType = FilterBase.Parts.PartsFunc.VALUE_TYPE.TYPE_FLOAT;
            this.ParaPReplace.ParameterChange += new FilterBase.Parts.ParameterChangeEventHandler(this.Param_ParameterChange);
            // 
            // ParaNSegments
            // 
            this.ParaNSegments.ArgumentName = "n_segments";
            this.ParaNSegments.AutoSize = true;
            this.ParaNSegments.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ParaNSegments.DecimalPlace = 0;
            this.ParaNSegments.Description = "生成するスーパーピクセルの大まかな目標数。\r\nアルゴリズムはこの数から外れる場合があります。\r\n値が小さいほど、スーパーピクセルは粗くなります。\r\n値が大きいほど" +
    "計算負荷が高くなり、速度が低下します。\r\nタプル ``(a, b)`` の場合、離散区間 ``[a..b]`` の値が画像ごとにサンプリングされます。\r\n　　　" +
    "デフォルト: (15, 120)";
            this.ParaNSegments.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ParaNSegments.Location = new System.Drawing.Point(3, 51);
            this.ParaNSegments.MaxValue = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.ParaNSegments.MaxVersion = null;
            this.ParaNSegments.MinimumSize = new System.Drawing.Size(124, 21);
            this.ParaNSegments.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ParaNSegments.MinVersion = null;
            this.ParaNSegments.Name = "ParaNSegments";
            this.ParaNSegments.Required = false;
            this.ParaNSegments.Size = new System.Drawing.Size(124, 42);
            this.ParaNSegments.TabIndex = 1;
            this.ParaNSegments.Title = "離散区間";
            this.ParaNSegments.Value = "(15,120)";
            this.ParaNSegments.ValueType = FilterBase.Parts.PartsFunc.VALUE_TYPE.TYPE_INT;
            this.ParaNSegments.ParameterChange += new FilterBase.Parts.ParameterChangeEventHandler(this.Param_ParameterChange);
            // 
            // ParaMaxSize
            // 
            this.ParaMaxSize.ArgumentName = "max_size";
            this.ParaMaxSize.AutoSize = true;
            this.ParaMaxSize.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ParaMaxSize.ControlLayout = FilterBase.Parts.InputValue.LAYOUT.Vertical;
            this.ParaMaxSize.DecimalPlace = 0;
            this.ParaMaxSize.Description = resources.GetString("ParaMaxSize.Description");
            this.ParaMaxSize.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ParaMaxSize.Location = new System.Drawing.Point(3, 99);
            this.ParaMaxSize.MaxValue = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.ParaMaxSize.MaxVersion = null;
            this.ParaMaxSize.MinimumSize = new System.Drawing.Size(124, 21);
            this.ParaMaxSize.MinValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.ParaMaxSize.MinVersion = null;
            this.ParaMaxSize.Name = "ParaMaxSize";
            this.ParaMaxSize.Required = false;
            this.ParaMaxSize.Size = new System.Drawing.Size(124, 35);
            this.ParaMaxSize.TabIndex = 2;
            this.ParaMaxSize.Title = "最大画像サイズ";
            this.ParaMaxSize.Unit = "";
            this.ParaMaxSize.Value = new decimal(new int[] {
            128,
            0,
            0,
            0});
            this.ParaMaxSize.ValueType = FilterBase.Parts.InputValue.VALUE_TYPE.INT;
            this.ParaMaxSize.ParameterChange += new FilterBase.Parts.ParameterChangeEventHandler(this.Param_ParameterChange);
            // 
            // ParaInterpolation
            // 
            this.ParaInterpolation.ArgumentName = "interpolation";
            this.ParaInterpolation.AutoSize = true;
            this.ParaInterpolation.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ParaInterpolation.DefaultValue = "LINEAR";
            this.ParaInterpolation.Description = "補間アルゴリズムを指定するために使用されるフラグ。次のいずれかになります:\r\ncv2.INTER_NEAREST、cv2.INTER_LINEAR、cv2.INT" +
    "ER_CUBIC、cv2.INTER_AREA、cv2.INTER_LANCZOS4。\r\n　　デフォルト: cv2.INTER_LINEAR。";
            this.ParaInterpolation.ItemType = "InterpolationFlags";
            this.ParaInterpolation.Location = new System.Drawing.Point(3, 140);
            this.ParaInterpolation.MaxVersion = null;
            this.ParaInterpolation.MinimumSize = new System.Drawing.Size(124, 21);
            this.ParaInterpolation.MinVersion = null;
            this.ParaInterpolation.Name = "ParaInterpolation";
            this.ParaInterpolation.Required = false;
            this.ParaInterpolation.Size = new System.Drawing.Size(124, 38);
            this.ParaInterpolation.TabIndex = 3;
            this.ParaInterpolation.Title = "補間方法";
            this.ParaInterpolation.Value = null;
            this.ParaInterpolation.ParameterChange += new FilterBase.Parts.ParameterChangeEventHandler(this.Param_ParameterChange);
            // 
            // Superpixels
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.FLPParam);
            this.Name = "Superpixels";
            this.Size = new System.Drawing.Size(128, 231);
            this.Target = FilterBase.BaseFilterControl.TRANSFORM_TARGET.IMAGE;
            this.Controls.SetChildIndex(this.FLPParam, 0);
            this.FLPParam.ResumeLayout(false);
            this.FLPParam.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ParaPReplace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaNSegments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaMaxSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaInterpolation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel FLPParam;
        private FilterBase.Parts.InputMaxMin ParaPReplace;
        private FilterBase.Parts.InputMaxMin ParaNSegments;
        private FilterBase.Parts.InputValueUpDown ParaMaxSize;
        private FilterBase.Parts.ComboBoxWithLabelParts ParaInterpolation;
    }
}
