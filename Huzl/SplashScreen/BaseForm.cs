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
    public partial class BaseForm : Form
    {
        public BaseForm()
        {
            InitializeComponent();
            this.Cursor = Cursors.WaitCursor;
            this.TopMost = true;
        }

        public virtual void KillMe(object o, EventArgs e)
        {
            this.Close();
            this.Cursor = Cursors.Default; ;
        }

        public virtual void ChangeTitle(object sender, EventArgs e) { }

        public virtual void ChangeText(object sender, EventArgs e) { }
    }
}
