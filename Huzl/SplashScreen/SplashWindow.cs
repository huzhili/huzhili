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
    public partial class SplashWindow : Form
    {
        public SplashWindow()
        {
            InitializeComponent();
            ucLoading1.Active = true;
        }

        public void KillMe(object o, EventArgs e)
        {
            this.Close();
            this.Cursor = Cursors.Default; ;
        }

        public void BringTop(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            this.TopMost = true;
        }

        public void ChangeText(object sender, EventArgs e)
        {
            lblText.Text = sender as string;
        }
    }
}
