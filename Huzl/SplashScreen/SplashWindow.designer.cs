namespace Huzl.SplashScreen
{
    partial class SplashWindow
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
            this.ucLoading1 = new Huzl.SplashScreen.ucLoading();
            this.SuspendLayout();
            // 
            // lblText
            // 
            this.lblText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblText.Location = new System.Drawing.Point(12, 47);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(176, 27);
            this.lblText.TabIndex = 1;
            this.lblText.Text = "Loading, Please Wait...";
            this.lblText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ucLoading1
            // 
            this.ucLoading1.Active = true;
            this.ucLoading1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ucLoading1.Color = System.Drawing.Color.Black;
            this.ucLoading1.InnerCircleRadius = 5;
            this.ucLoading1.Location = new System.Drawing.Point(12, 12);
            this.ucLoading1.Name = "ucLoading1";
            this.ucLoading1.NumberSpoke = 12;
            this.ucLoading1.OuterCircleRadius = 11;
            this.ucLoading1.RotationSpeed = 100;
            this.ucLoading1.Size = new System.Drawing.Size(176, 29);
            this.ucLoading1.SpokeThickness = 2;
            this.ucLoading1.StylePreset = Huzl.SplashScreen.ucLoading.StylePresets.MacOSX;
            this.ucLoading1.TabIndex = 0;
            // 
            // SplashWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(200, 80);
            this.Controls.Add(this.lblText);
            this.Controls.Add(this.ucLoading1);
            this.Name = "SplashWindow";
            this.Text = "SplashWindow";
            this.TopMost = true;
            this.ResumeLayout(false);

        }

        #endregion

        private ucLoading ucLoading1;
        private System.Windows.Forms.Label lblText;
    }
}