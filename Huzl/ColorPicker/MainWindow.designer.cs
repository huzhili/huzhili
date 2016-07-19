namespace ColorPicker
{
    partial class MainWindow
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.txtR = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtG = new System.Windows.Forms.TextBox();
            this.txtRGB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.chkTopMost = new System.Windows.Forms.CheckBox();
            this.chkHex = new System.Windows.Forms.CheckBox();
            this.btnCopyR = new System.Windows.Forms.Button();
            this.btnCopyG = new System.Windows.Forms.Button();
            this.btnCopyB = new System.Windows.Forms.Button();
            this.btnCopyRGB = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(235, 120);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnStart
            // 
            this.btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStart.Location = new System.Drawing.Point(55, 261);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(168, 23);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "&Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // txtR
            // 
            this.txtR.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtR.Location = new System.Drawing.Point(55, 153);
            this.txtR.Name = "txtR";
            this.txtR.Size = new System.Drawing.Size(123, 21);
            this.txtR.TabIndex = 2;
            this.txtR.MouseHover += new System.EventHandler(this.txtBox_MouseHover);
            // 
            // txtB
            // 
            this.txtB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtB.Location = new System.Drawing.Point(55, 207);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(123, 21);
            this.txtB.TabIndex = 2;
            this.txtB.MouseHover += new System.EventHandler(this.txtBox_MouseHover);
            // 
            // txtG
            // 
            this.txtG.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtG.Location = new System.Drawing.Point(55, 180);
            this.txtG.Name = "txtG";
            this.txtG.Size = new System.Drawing.Size(123, 21);
            this.txtG.TabIndex = 2;
            this.txtG.MouseHover += new System.EventHandler(this.txtBox_MouseHover);
            // 
            // txtRGB
            // 
            this.txtRGB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRGB.Location = new System.Drawing.Point(55, 234);
            this.txtRGB.Name = "txtRGB";
            this.txtRGB.Size = new System.Drawing.Size(123, 21);
            this.txtRGB.TabIndex = 2;
            this.txtRGB.MouseHover += new System.EventHandler(this.txtBox_MouseHover);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "R：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "G：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "B：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "RGB：";
            // 
            // chkTopMost
            // 
            this.chkTopMost.AutoSize = true;
            this.chkTopMost.Checked = true;
            this.chkTopMost.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkTopMost.Location = new System.Drawing.Point(55, 130);
            this.chkTopMost.Name = "chkTopMost";
            this.chkTopMost.Size = new System.Drawing.Size(72, 16);
            this.chkTopMost.TabIndex = 4;
            this.chkTopMost.Text = "Top Most";
            this.chkTopMost.UseVisualStyleBackColor = true;
            this.chkTopMost.CheckedChanged += new System.EventHandler(this.chkTopMost_CheckedChanged);
            // 
            // chkHex
            // 
            this.chkHex.AutoSize = true;
            this.chkHex.Checked = true;
            this.chkHex.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkHex.Location = new System.Drawing.Point(136, 130);
            this.chkHex.Name = "chkHex";
            this.chkHex.Size = new System.Drawing.Size(42, 16);
            this.chkHex.TabIndex = 4;
            this.chkHex.Text = "Hex";
            this.chkHex.UseVisualStyleBackColor = true;
            this.chkHex.CheckedChanged += new System.EventHandler(this.chkHex_CheckedChanged);
            // 
            // btnCopyR
            // 
            this.btnCopyR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCopyR.Location = new System.Drawing.Point(184, 152);
            this.btnCopyR.Name = "btnCopyR";
            this.btnCopyR.Size = new System.Drawing.Size(39, 21);
            this.btnCopyR.TabIndex = 6;
            this.btnCopyR.Tag = "R";
            this.btnCopyR.Text = "Copy";
            this.btnCopyR.UseVisualStyleBackColor = true;
            // 
            // btnCopyG
            // 
            this.btnCopyG.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCopyG.Location = new System.Drawing.Point(184, 180);
            this.btnCopyG.Name = "btnCopyG";
            this.btnCopyG.Size = new System.Drawing.Size(39, 21);
            this.btnCopyG.TabIndex = 6;
            this.btnCopyG.Tag = "G";
            this.btnCopyG.Text = "Copy";
            this.btnCopyG.UseVisualStyleBackColor = true;
            // 
            // btnCopyB
            // 
            this.btnCopyB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCopyB.Location = new System.Drawing.Point(184, 207);
            this.btnCopyB.Name = "btnCopyB";
            this.btnCopyB.Size = new System.Drawing.Size(39, 21);
            this.btnCopyB.TabIndex = 6;
            this.btnCopyB.Tag = "B";
            this.btnCopyB.Text = "Copy";
            this.btnCopyB.UseVisualStyleBackColor = true;
            // 
            // btnCopyRGB
            // 
            this.btnCopyRGB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCopyRGB.Location = new System.Drawing.Point(184, 234);
            this.btnCopyRGB.Name = "btnCopyRGB";
            this.btnCopyRGB.Size = new System.Drawing.Size(39, 21);
            this.btnCopyRGB.TabIndex = 6;
            this.btnCopyRGB.Tag = "RGB";
            this.btnCopyRGB.Text = "&Copy";
            this.btnCopyRGB.UseVisualStyleBackColor = true;
            // 
            // MainWindow
            // 
            this.AcceptButton = this.btnStart;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(235, 296);
            this.Controls.Add(this.btnCopyRGB);
            this.Controls.Add(this.btnCopyB);
            this.Controls.Add(this.btnCopyG);
            this.Controls.Add(this.btnCopyR);
            this.Controls.Add(this.chkHex);
            this.Controls.Add(this.chkTopMost);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtG);
            this.Controls.Add(this.txtRGB);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtR);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "MainWindow";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Color Picker";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox txtR;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.TextBox txtG;
        private System.Windows.Forms.TextBox txtRGB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkTopMost;
        private System.Windows.Forms.CheckBox chkHex;
        private System.Windows.Forms.Button btnCopyR;
        private System.Windows.Forms.Button btnCopyG;
        private System.Windows.Forms.Button btnCopyB;
        private System.Windows.Forms.Button btnCopyRGB;
    }
}