using Huzl.SplashScreen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace Huzl.SplashScreenDemo
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            SplashHandler.Start();
            Thread.Sleep(300);
            SplashHandler.BringTop();
            SplashHandler.ChangeText("Carregando...");

            Application.Run(new Form1());
        }
    }
}
