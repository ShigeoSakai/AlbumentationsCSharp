namespace Filter.Geometric
{
    partial class GridElasticDeform
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
            this.ParaNumGridXy = new FilterBase.Parts.InputTuple();
            this.ParaMagnitude = new FilterBase.Parts.InputValueUpDown();
            this.ParaInterpolation = new FilterBase.Parts.ComboBoxWithLabelParts();
            this.ParaMaskInterpolation = new FilterBase.Parts.ComboBoxWithLabelParts();
            this.FLPParam.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ParaNumGridXy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaMagnitude)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaInterpolation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaMaskInterpolation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // FLPParam
            // 
            this.FLPParam.AutoSize = true;
            this.FLPParam.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.FLPParam.Controls.Add(this.ParaNumGridXy);
            this.FLPParam.Controls.Add(this.ParaMagnitude);
            this.FLPParam.Controls.Add(this.ParaInterpolation);
            this.FLPParam.Controls.Add(this.ParaMaskInterpolation);
            this.FLPParam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FLPParam.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.FLPParam.Location = new System.Drawing.Point(0, 25);
            this.FLPParam.Name = "FLPParam";
            this.FLPParam.Size = new System.Drawing.Size(128, 176);
            this.FLPParam.TabIndex = 5;
            // 
            // ParaNumGridXy
            // 
            this.ParaNumGridXy.ArgumentName = "num_grid_xy";
            this.ParaNumGridXy.AutoSize = true;
            this.ParaNumGridXy.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ParaNumGridXy.DecimalPlace = 0;
            this.ParaNumGridXy.Description = "幅と高さに沿ったグリッド セルの数。\r\n(grid_width、grid_height) として指定します。\r\n各値は 1 より大きい必要があります。";
            this.ParaNumGridXy.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ParaNumGridXy.Location = new System.Drawing.Point(3, 3);
            this.ParaNumGridXy.MaxValue = "";
            this.ParaNumGridXy.MaxVersion = null;
            this.ParaNumGridXy.MinimumSize = new System.Drawing.Size(124, 21);
            this.ParaNumGridXy.MinValue = "(1,1)";
            this.ParaNumGridXy.MinVersion = null;
            this.ParaNumGridXy.Name = "ParaNumGridXy";
            this.ParaNumGridXy.Required = false;
            this.ParaNumGridXy.Size = new System.Drawing.Size(124, 41);
            this.ParaNumGridXy.TabIndex = 0;
            this.ParaNumGridXy.Title = "グリッドセル数";
            this.ParaNumGridXy.Value = "(8,8)";
            this.ParaNumGridXy.ValueType = FilterBase.Parts.PartsFunc.VALUE_TYPE.TYPE_INT;
            this.ParaNumGridXy.ParameterChange += new FilterBase.Parts.ParameterChangeEventHandler(this.Param_ParameterChange);
            // 
            // ParaMagnitude
            // 
            this.ParaMagnitude.ArgumentName = "magnitude";
            this.ParaMagnitude.AutoSize = true;
            this.ParaMagnitude.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ParaMagnitude.ControlLayout = FilterBase.Parts.InputValue.LAYOUT.Horizontal;
            this.ParaMagnitude.DecimalPlace = 0;
            this.ParaMagnitude.Description = "歪みのピクセル単位の最大変位。\r\n0 より大きい必要があります。";
            this.ParaMagnitude.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ParaMagnitude.Location = new System.Drawing.Point(3, 50);
            this.ParaMagnitude.MaxValue = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.ParaMagnitude.MaxVersion = null;
            this.ParaMagnitude.MinimumSize = new System.Drawing.Size(124, 21);
            this.ParaMagnitude.MinValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.ParaMagnitude.MinVersion = null;
            this.ParaMagnitude.Name = "ParaMagnitude";
            this.ParaMagnitude.Required = false;
            this.ParaMagnitude.Size = new System.Drawing.Size(124, 35);
            this.ParaMagnitude.TabIndex = 1;
            this.ParaMagnitude.Title = "歪みの最大変位";
            this.ParaMagnitude.Unit = "";
            this.ParaMagnitude.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.ParaMagnitude.ValueType = FilterBase.Parts.InputValue.VALUE_TYPE.INT;
            this.ParaMagnitude.ParameterChange += new FilterBase.Parts.ParameterChangeEventHandler(this.Param_ParameterChange);
            // 
            // ParaInterpolation
            // 
            this.ParaInterpolation.ArgumentName = "interpolation";
            this.ParaInterpolation.AutoSize = true;
            this.ParaInterpolation.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ParaInterpolation.DefaultValue = "LINEAR";
            this.ParaInterpolation.Description = "補間アルゴリズムを指定するために使用されるフラグ。次のいずれかになります:\r\ncv2.INTER_NEAREST、cv2.INTER_LINEAR、cv2.INT" +
    "ER_CUBIC、cv2.INTER_AREA、cv2.INTER_LANCZOS4。\r\nデフォルト: cv2.INTER_LINEAR。";
            this.ParaInterpolation.ItemType = "InterpolationFlags";
            this.ParaInterpolation.Location = new System.Drawing.Point(3, 91);
            this.ParaInterpolation.MaxVersion = null;
            this.ParaInterpolation.MinimumSize = new System.Drawing.Size(124, 21);
            this.ParaInterpolation.MinVersion = null;
            this.ParaInterpolation.Name = "ParaInterpolation";
            this.ParaInterpolation.Required = false;
            this.ParaInterpolation.Size = new System.Drawing.Size(124, 38);
            this.ParaInterpolation.TabIndex = 4;
            this.ParaInterpolation.Title = "補間方法";
            this.ParaInterpolation.Value = null;
            this.ParaInterpolation.ParameterChange += new FilterBase.Parts.ParameterChangeEventHandler(this.Param_ParameterChange);
            // 
            // ParaMaskInterpolation
            // 
            this.ParaMaskInterpolation.ArgumentName = "mask_interpolation";
            this.ParaMaskInterpolation.AutoSize = true;
            this.ParaMaskInterpolation.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ParaMaskInterpolation.DefaultValue = "NEAREST";
            this.ParaMaskInterpolation.Description = "マスクの補間アルゴリズムを指定するために使用されるフラグ。\r\n次のいずれかである必要があります: cv2.INTER_NEAREST、cv2.INTER_LINE" +
    "AR、cv2.INTER_CUBIC、cv2.INTER_AREA、cv2.INTER_LANCZOS4。\r\nデフォルト: cv2.INTER_NEAREST。" +
    "";
            this.ParaMaskInterpolation.ItemType = "InterpolationFlags";
            this.ParaMaskInterpolation.Location = new System.Drawing.Point(3, 135);
            this.ParaMaskInterpolation.MaxVersion = null;
            this.ParaMaskInterpolation.MinimumSize = new System.Drawing.Size(124, 21);
            this.ParaMaskInterpolation.MinVersion = null;
            this.ParaMaskInterpolation.Name = "ParaMaskInterpolation";
            this.ParaMaskInterpolation.Required = false;
            this.ParaMaskInterpolation.Size = new System.Drawing.Size(124, 38);
            this.ParaMaskInterpolation.TabIndex = 5;
            this.ParaMaskInterpolation.Title = "マスク補間方法";
            this.ParaMaskInterpolation.Value = null;
            this.ParaMaskInterpolation.ParameterChange += new FilterBase.Parts.ParameterChangeEventHandler(this.Param_ParameterChange);
            // 
            // GridElasticDeform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.FLPParam);
            this.Name = "GridElasticDeform";
            this.Size = new System.Drawing.Size(128, 226);
            this.Controls.SetChildIndex(this.FLPParam, 0);
            this.FLPParam.ResumeLayout(false);
            this.FLPParam.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ParaNumGridXy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaMagnitude)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaInterpolation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaMaskInterpolation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel FLPParam;
        private FilterBase.Parts.InputTuple ParaNumGridXy;
        private FilterBase.Parts.InputValueUpDown ParaMagnitude;
        private FilterBase.Parts.ComboBoxWithLabelParts ParaInterpolation;
        private FilterBase.Parts.ComboBoxWithLabelParts ParaMaskInterpolation;
    }
}
