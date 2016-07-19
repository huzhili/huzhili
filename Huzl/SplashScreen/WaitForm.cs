using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Huzl.SplashScreen
{
    public partial class WaitForm : BaseForm
    {
        public WaitForm(string text)
        {
            InitializeComponent();
            lblText.Text = text;
        }

        Color _borderColor = Color.RoyalBlue;
        ButtonBorderStyle _borderStyle = ButtonBorderStyle.Solid;
        int _borderWidth = 1;

        public override void ChangeText(object sender, EventArgs e)
        {
            lblText.Text = sender as string;
        }

        public override void ChangeTitle(object sender, EventArgs e)
        {
            lblTitle.Text = sender as string;
        }

        private void pnlBox_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics,
                                   this.pnlBox.ClientRectangle,
                                   _borderColor,
                                   _borderWidth,
                                   _borderStyle,
                                   _borderColor,
                                   _borderWidth,
                                   _borderStyle,
                                   _borderColor,
                                   _borderWidth,
                                   _borderStyle,
                                   _borderColor,
                                   _borderWidth,
                                   _borderStyle);
        }
    }
}
