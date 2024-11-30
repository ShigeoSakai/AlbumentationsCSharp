namespace Filter.BasicTransform
{
    partial class PlanckianJitter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlanckianJitter));
            this.FLPParam = new System.Windows.Forms.FlowLayoutPanel();
            this.ParaMode = new FilterBase.Parts.ComboBoxWithLabelParts();
            this.ParaTemperatureLimit = new FilterBase.Parts.InputMaxMin();
            this.ParaSamplingMethod = new FilterBase.Parts.ComboBoxWithLabelParts();
            this.FLPParam.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ParaMode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaTemperatureLimit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaSamplingMethod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // FLPParam
            // 
            this.FLPParam.AutoSize = true;
            this.FLPParam.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.FLPParam.Controls.Add(this.ParaMode);
            this.FLPParam.Controls.Add(this.ParaTemperatureLimit);
            this.FLPParam.Controls.Add(this.ParaSamplingMethod);
            this.FLPParam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FLPParam.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.FLPParam.Location = new System.Drawing.Point(0, 25);
            this.FLPParam.Name = "FLPParam";
            this.FLPParam.Size = new System.Drawing.Size(128, 136);
            this.FLPParam.TabIndex = 5;
            // 
            // ParaMode
            // 
            this.ParaMode.ArgumentName = "mode";
            this.ParaMode.AutoSize = true;
            this.ParaMode.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ParaMode.DefaultValue = "";
            this.ParaMode.Description = "変換のモード。\r\n- \"blackbody\": 黒体放射の色の変化をシミュレートします。\r\n- \"cied\": 色温度のシミュレーションに CIE D 光源シリー" +
    "ズを使用します。\r\n　　デフォルト: \"blackbody\"";
            this.ParaMode.ItemType = "System.String";
            this.ParaMode.Location = new System.Drawing.Point(3, 3);
            this.ParaMode.MaxVersion = null;
            this.ParaMode.MinimumSize = new System.Drawing.Size(124, 21);
            this.ParaMode.MinVersion = null;
            this.ParaMode.Name = "ParaMode";
            this.ParaMode.Required = false;
            this.ParaMode.Size = new System.Drawing.Size(124, 38);
            this.ParaMode.TabIndex = 0;
            this.ParaMode.Title = "モデル";
            this.ParaMode.Value = null;
            this.ParaMode.SelectedIndexChanged += new FilterBase.Parts.ComboBoxWithLabelParts.ComboBoxSelectEventHandler(this.ParaMode_SelectedIndexChanged);
            this.ParaMode.ParameterChange += new FilterBase.Parts.ParameterChangeEventHandler(this.Param_ParameterChange);
            // 
            // ParaTemperatureLimit
            // 
            this.ParaTemperatureLimit.ArgumentName = "temperature_limit";
            this.ParaTemperatureLimit.AutoSize = true;
            this.ParaTemperatureLimit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ParaTemperatureLimit.DecimalPlace = 0;
            this.ParaTemperatureLimit.Description = resources.GetString("ParaTemperatureLimit.Description");
            this.ParaTemperatureLimit.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.ParaTemperatureLimit.Location = new System.Drawing.Point(3, 47);
            this.ParaTemperatureLimit.MaxValue = null;
            this.ParaTemperatureLimit.MaxVersion = null;
            this.ParaTemperatureLimit.MinimumSize = new System.Drawing.Size(124, 21);
            this.ParaTemperatureLimit.MinValue = null;
            this.ParaTemperatureLimit.MinVersion = null;
            this.ParaTemperatureLimit.Name = "ParaTemperatureLimit";
            this.ParaTemperatureLimit.Required = false;
            this.ParaTemperatureLimit.Size = new System.Drawing.Size(124, 42);
            this.ParaTemperatureLimit.TabIndex = 1;
            this.ParaTemperatureLimit.Title = "色温度の範囲 (K)";
            this.ParaTemperatureLimit.Value = "(0,0)";
            this.ParaTemperatureLimit.ValueType = FilterBase.Parts.PartsFunc.VALUE_TYPE.TYPE_INT;
            this.ParaTemperatureLimit.ParameterChange += new FilterBase.Parts.ParameterChangeEventHandler(this.Param_ParameterChange);
            // 
            // ParaSamplingMethod
            // 
            this.ParaSamplingMethod.ArgumentName = "sampling_method ";
            this.ParaSamplingMethod.AutoSize = true;
            this.ParaSamplingMethod.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ParaSamplingMethod.DefaultValue = "";
            this.ParaSamplingMethod.Description = "温度をサンプリングする方法。\r\n- \"uniform\": 指定された範囲にわたって均一にサンプリングします。\r\n- \"gaussian\": 6500K (おおよそ" +
    "の日光) を中心としたガウス分布からサンプリングします。\r\n　　　デフォルト: \"uniform\"";
            this.ParaSamplingMethod.ItemType = "System.String";
            this.ParaSamplingMethod.Location = new System.Drawing.Point(3, 95);
            this.ParaSamplingMethod.MaxVersion = null;
            this.ParaSamplingMethod.MinimumSize = new System.Drawing.Size(124, 21);
            this.ParaSamplingMethod.MinVersion = null;
            this.ParaSamplingMethod.Name = "ParaSamplingMethod";
            this.ParaSamplingMethod.Required = false;
            this.ParaSamplingMethod.Size = new System.Drawing.Size(124, 38);
            this.ParaSamplingMethod.TabIndex = 2;
            this.ParaSamplingMethod.Title = "温度サンプリング方法";
            this.ParaSamplingMethod.Value = null;
            this.ParaSamplingMethod.ParameterChange += new FilterBase.Parts.ParameterChangeEventHandler(this.Param_ParameterChange);
            // 
            // PlanckianJitter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.FLPParam);
            this.MinVersion = "1.4.9";
            this.Name = "PlanckianJitter";
            this.Size = new System.Drawing.Size(128, 186);
            this.Target = FilterBase.BaseFilterControl.TRANSFORM_TARGET.IMAGE;
            this.Controls.SetChildIndex(this.FLPParam, 0);
            this.FLPParam.ResumeLayout(false);
            this.FLPParam.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ParaMode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaTemperatureLimit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParaSamplingMethod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel FLPParam;
        private FilterBase.Parts.ComboBoxWithLabelParts ParaMode;
        private FilterBase.Parts.InputMaxMin ParaTemperatureLimit;
        private FilterBase.Parts.ComboBoxWithLabelParts ParaSamplingMethod;
    }
}
