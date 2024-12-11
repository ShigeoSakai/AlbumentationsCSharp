namespace AlbumentationsCSharp.Composition
{
    partial class TextInputForm
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
            this.PanelBottom = new System.Windows.Forms.Panel();
            this.BtOk = new System.Windows.Forms.Button();
            this.TbInput = new System.Windows.Forms.TextBox();
            this.PanelBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelBottom
            // 
            this.PanelBottom.AutoSize = true;
            this.PanelBottom.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PanelBottom.Controls.Add(this.BtOk);
            this.PanelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelBottom.Location = new System.Drawing.Point(0, 254);
            this.PanelBottom.Name = "PanelBottom";
            this.PanelBottom.Size = new System.Drawing.Size(535, 29);
            this.PanelBottom.TabIndex = 0;
            // 
            // BtOk
            // 
            this.BtOk.Location = new System.Drawing.Point(220, 3);
            this.BtOk.Name = "BtOk";
            this.BtOk.Size = new System.Drawing.Size(75, 23);
            this.BtOk.TabIndex = 0;
            this.BtOk.Text = "OK";
            this.BtOk.UseVisualStyleBackColor = true;
            this.BtOk.Click += new System.EventHandler(this.BtOk_Click);
            // 
            // TbInput
            // 
            this.TbInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TbInput.Location = new System.Drawing.Point(0, 0);
            this.TbInput.Multiline = true;
            this.TbInput.Name = "TbInput";
            this.TbInput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TbInput.Size = new System.Drawing.Size(535, 254);
            this.TbInput.TabIndex = 1;
            // 
            // TextInputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 283);
            this.Controls.Add(this.TbInput);
            this.Controls.Add(this.PanelBottom);
            this.Name = "TextInputForm";
            this.Text = "テキスト入力";
            this.PanelBottom.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PanelBottom;
        private System.Windows.Forms.Button BtOk;
        private System.Windows.Forms.TextBox TbInput;
    }
}