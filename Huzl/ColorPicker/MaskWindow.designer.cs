namespace ColorPicker
{
    partial class MaskWindow
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
            this.SuspendLayout();
            // 
            // MaskWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Cursor = System.Windows.Forms.Cursors.Cross;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MaskWindow";
            this.Opacity = 0.2D;
            this.Text = "MaskWindow";
            this.Load += new System.EventHandler(this.MaskWindow_Load);
            this.Click += new System.EventHandler(this.MaskWindow_Click);
            this.ResumeLayout(false);

        }

        #endregion
    }
}