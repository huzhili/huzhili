using Huzl.SplashScreen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
/*
    Source For:https://github.com/aledut/SplashScreen.git
*/
namespace Huzl.SplashScreenDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            Splash.Close();
            
            this.Focus();
            this.BringToFront();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Splash.ChangeText("Loading...");
            Thread.Sleep(3000); // Simulates delay
            Splash.ChangeText("Loaded");
            Thread.Sleep(1000); // Simulates delay
        }
    }
}
