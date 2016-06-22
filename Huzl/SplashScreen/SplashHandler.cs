using System;
using System.Threading;
using System.Windows.Forms;

namespace Huzl.SplashScreen
{
    public static class SplashHandler
    {
        static SplashWindow splash;
        /// <summary>
        /// 启动闪屏
        /// </summary>
        public static void Start()
        {
            Thread splashThread = new Thread(new ThreadStart(StartSplash));
            splashThread.Start();
        }

        static void StartSplash()
        {
            //实体化闪屏窗体
            splash = new SplashWindow();

            //运行闪屏窗体
            Application.Run(splash);
        }

        public static void Close()
        {
            if (splash == null) return;

            //关闭闪屏窗体
            splash.Invoke(new EventHandler(splash.KillMe));
            splash.Dispose();
            splash = null;
        }
        /// <summary>
        /// 改变闪屏窗体文字内容
        /// </summary>
        /// <param name="text"></param>
        public static void ChangeText(string text)
        {
            if (splash == null) return;
            splash.Invoke(new EventHandler(splash.ChangeText), text);
        }
        /// <summary>
        /// 置于顶部
        /// 等待光标（沙漏）
        /// </summary>
        public static void BringTop()
        {
            if (splash == null) return;
            splash.Invoke(new EventHandler(splash.BringTop));
        }
    }
}
