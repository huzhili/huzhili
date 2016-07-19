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
    public partial class SplashWindow : BaseForm
    {
        public SplashWindow()
        {
            InitializeComponent();
            ucLoading1.Active = true;
        }

        public override void ChangeText(object sender, EventArgs e)
        {
            lblText.Text = sender as string;
        }
    }
}
