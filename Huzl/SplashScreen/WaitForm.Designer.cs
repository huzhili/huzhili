namespace Huzl.SplashScreen
{
    partial class WaitForm
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
            this.lblText = new System.Windows.Forms.Label();
            this.ucLoading1 = new SplashScreen.ucLoading();
            this.pnlBox = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblText
            // 
            this.lblText.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblText.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblText.Location = new System.Drawing.Point(77, 38);
            this.lblText.Margin = new System.Windows.Forms.Padding(0);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(201, 40);
            this.lblText.TabIndex = 3;
            this.lblText.Text = "正在加载";
            // 
            // ucLoading1
            // 
            this.ucLoading1.Active = true;
            this.ucLoading1.Color = System.Drawing.Color.SlateBlue;
            this.ucLoading1.Dock = System.Windows.Forms.DockStyle.Left;
            this.ucLoading1.InnerCircleRadius = 5;
            this.ucLoading1.Location = new System.Drawing.Point(0, 0);
            this.ucLoading1.Margin = new System.Windows.Forms.Padding(0);
            this.ucLoading1.Name = "ucLoading1";
            this.ucLoading1.NumberSpoke = 12;
            this.ucLoading1.OuterCircleRadius = 11;
            this.ucLoading1.RotationSpeed = 100;
            this.ucLoading1.Size = new System.Drawing.Size(77, 78);
            this.ucLoading1.SpokeThickness = 2;
            this.ucLoading1.StylePreset = SplashScreen.ucLoading.StylePresets.MacOSX;
            this.ucLoading1.TabIndex = 2;
            // 
            // pnlBox
            // 
            this.pnlBox.BackColor = System.Drawing.Color.Transparent;
            this.pnlBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBox.Controls.Add(this.lblTitle);
            this.pnlBox.Controls.Add(this.lblText);
            this.pnlBox.Controls.Add(this.ucLoading1);
            this.pnlBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBox.Location = new System.Drawing.Point(0, 0);
            this.pnlBox.Name = "pnlBox";
            this.pnlBox.Size = new System.Drawing.Size(280, 80);
            this.pnlBox.TabIndex = 4;
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTitle.Location = new System.Drawing.Point(77, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(201, 38);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "请稍等...";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // WaitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 80);
            this.Controls.Add(this.pnlBox);
            this.Name = "WaitForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "WaitForm";
            this.TopMost = true;
            this.pnlBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblText;
        private ucLoading ucLoading1;
        private System.Windows.Forms.Panel pnlBox;
        private System.Windows.Forms.Label lblTitle;
    }
}