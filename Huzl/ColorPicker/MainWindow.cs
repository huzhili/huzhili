using System;
using System.Drawing;
using System.Windows.Forms;

namespace ColorPicker
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            #region LoadData
            ViewColor();
            this.TopMost = true;
            chkTopMost.Checked = this.TopMost;
            InitEvent();
            #endregion

            base.OnLoad(e);

            this.Focus();
            this.BringToFront();
        }
        private void InitEvent()
        {
            btnCopyR.Click += BtnCopy_Click;
            btnCopyG.Click += BtnCopy_Click;
            btnCopyB.Click += BtnCopy_Click;
            btnCopyRGB.Click += BtnCopy_Click;
        }

        private void BtnCopy_Click(object sender, EventArgs e)
        {
            var btn = sender as Button;
            var tag = btn.Tag.ToString();
            switch (tag)
            {
                case "R":
                    var r = txtR.Text;
                    ClipboardText(r);
                    break;
                case "G":
                    var g = txtG.Text;
                    ClipboardText(g);
                    break;
                case "B":
                    var b = txtB.Text;
                    ClipboardText(b);
                    break;
                case "RGB":
                    var rgb = txtRGB.Text;
                    ClipboardText(rgb);
                    break;
            }
        }

        private void ClipboardText(string text)
        {
            Clipboard.SetData(DataFormats.Text, text);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            MaskWindow mask = new ColorPicker.MaskWindow(this);
            mask.Show();
            mask.Start();
        }

        public void UpdateColor(Color color)
        {
            pictureBox1.BackColor = color;
            ViewColor();
        }

        private void chkTopMost_CheckedChanged(object sender, EventArgs e)
        {
            this.TopMost = chkTopMost.Checked;
        }

        private void txtBox_MouseHover(object sender, EventArgs e)
        {
            var txtBox = sender as TextBox;
            txtBox.Focus();
            txtBox.SelectAll();
        }

        private void chkHex_CheckedChanged(object sender, EventArgs e)
        {
            ViewColor();
        }

        private void ViewColor()
        {
            var color = pictureBox1.BackColor;
            if (chkHex.Checked)
            {
                txtR.Text = color.R.ToString("X2");
                txtG.Text = color.G.ToString("X2");
                txtB.Text = color.B.ToString("X2");
                txtRGB.Text = "#" + txtR.Text + txtG.Text + txtB.Text;
            }
            else
            {
                txtR.Text = color.R.ToString("000");
                txtG.Text = color.G.ToString("000");
                txtB.Text = color.B.ToString("000");
                txtRGB.Text = txtR.Text + "," + txtG.Text + "," + txtB.Text;
            }
        }
    }
}