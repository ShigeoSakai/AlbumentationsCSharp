namespace FilterBase.Parts
{
	partial class Input3Tuple
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
			this.LbTuple1 = new SSTools.GrowLabel();
			this.NUDTuple1 = new System.Windows.Forms.NumericUpDown();
			this.NUDTuple2 = new System.Windows.Forms.NumericUpDown();
			this.LbTuple2 = new SSTools.GrowLabel();
			this.NUDTuple3 = new System.Windows.Forms.NumericUpDown();
			this.LbTuple3 = new SSTools.GrowLabel();
			((System.ComponentModel.ISupportInitialize)(this.NUDTuple1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.NUDTuple2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.NUDTuple3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
			this.SuspendLayout();
			// 
			// LbTuple1
			// 
			this.LbTuple1.Location = new System.Drawing.Point(7, 41);
			this.LbTuple1.MaxTextWidth = 124;
			this.LbTuple1.Name = "LbTuple1";
			this.LbTuple1.Size = new System.Drawing.Size(18, 12);
			this.LbTuple1.TabIndex = 12;
			this.LbTuple1.Text = "T1";
			this.LbTuple1.SizeChanged += new System.EventHandler(this.LbTuple1_SizeChanged);
			// 
			// NUDTuple1
			// 
			this.NUDTuple1.Location = new System.Drawing.Point(47, 39);
			this.NUDTuple1.Name = "NUDTuple1";
			this.NUDTuple1.Size = new System.Drawing.Size(74, 19);
			this.NUDTuple1.TabIndex = 13;
			this.NUDTuple1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.NUDTuple1.ValueChanged += new System.EventHandler(this.NUD_ValueChanged);
			// 
			// NUDTuple2
			// 
			this.NUDTuple2.Location = new System.Drawing.Point(47, 59);
			this.NUDTuple2.Name = "NUDTuple2";
			this.NUDTuple2.Size = new System.Drawing.Size(74, 19);
			this.NUDTuple2.TabIndex = 15;
			this.NUDTuple2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.NUDTuple2.ValueChanged += new System.EventHandler(this.NUD_ValueChanged);
			// 
			// LbTuple2
			// 
			this.LbTuple2.Location = new System.Drawing.Point(7, 61);
			this.LbTuple2.MaxTextWidth = 124;
			this.LbTuple2.Name = "LbTuple2";
			this.LbTuple2.Size = new System.Drawing.Size(18, 12);
			this.LbTuple2.TabIndex = 14;
			this.LbTuple2.Text = "T1";
			this.LbTuple2.SizeChanged += new System.EventHandler(this.LbTuple1_SizeChanged);
			// 
			// NUDTuple3
			// 
			this.NUDTuple3.Location = new System.Drawing.Point(47, 79);
			this.NUDTuple3.Name = "NUDTuple3";
			this.NUDTuple3.Size = new System.Drawing.Size(74, 19);
			this.NUDTuple3.TabIndex = 17;
			this.NUDTuple3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.NUDTuple3.ValueChanged += new System.EventHandler(this.NUD_ValueChanged);
			// 
			// LbTuple3
			// 
			this.LbTuple3.Location = new System.Drawing.Point(7, 81);
			this.LbTuple3.MaxTextWidth = 124;
			this.LbTuple3.Name = "LbTuple3";
			this.LbTuple3.Size = new System.Drawing.Size(18, 12);
			this.LbTuple3.TabIndex = 16;
			this.LbTuple3.Text = "T1";
			this.LbTuple3.SizeChanged += new System.EventHandler(this.LbTuple1_SizeChanged);
			// 
			// Input3Tuple
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.Controls.Add(this.NUDTuple3);
			this.Controls.Add(this.LbTuple3);
			this.Controls.Add(this.NUDTuple2);
			this.Controls.Add(this.LbTuple2);
			this.Controls.Add(this.NUDTuple1);
			this.Controls.Add(this.LbTuple1);
			this.Name = "Input3Tuple";
			this.Size = new System.Drawing.Size(124, 101);
			this.Controls.SetChildIndex(this.LbTitle, 0);
			this.Controls.SetChildIndex(this.CbValid, 0);
			this.Controls.SetChildIndex(this.LbTuple1, 0);
			this.Controls.SetChildIndex(this.NUDTuple1, 0);
			this.Controls.SetChildIndex(this.LbTuple2, 0);
			this.Controls.SetChildIndex(this.NUDTuple2, 0);
			this.Controls.SetChildIndex(this.LbTuple3, 0);
			this.Controls.SetChildIndex(this.NUDTuple3, 0);
			((System.ComponentModel.ISupportInitialize)(this.NUDTuple1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.NUDTuple2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.NUDTuple3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private SSTools.GrowLabel LbTuple1;
		private System.Windows.Forms.NumericUpDown NUDTuple1;
		private System.Windows.Forms.NumericUpDown NUDTuple2;
		private SSTools.GrowLabel LbTuple2;
		private System.Windows.Forms.NumericUpDown NUDTuple3;
		private SSTools.GrowLabel LbTuple3;
	}
}
