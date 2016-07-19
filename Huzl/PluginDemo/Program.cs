using Huzl.SplashScreen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace PluginDemo
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            bool ret;
            System.Threading.Mutex mutex = new System.Threading.Mutex(true, Application.ProductName, out ret);

            if (ret)
            {
                //System.Windows.Forms.Application.EnableVisualStyles();   //这两行实现   XP   可视风格   
                //System.Windows.Forms.Application.DoEvents();             //这两行实现   XP   可视风格

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Splash.Start("正在启动");
                Application.Run(Client.MainInstance());
                //Main为你程序的主窗体，如果是控制台程序不用这句
                mutex.ReleaseMutex();
            }
            else
            {
                MessageBox.Show(null, "程序已经运行，请不要重复运行程序！", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                //提示信息，可以删除。
                Application.Exit();//退出程序
            }
        }
    }

    public class Client
    {
        // 定义一个标识确保线程同步
        private static readonly object _locker = new object();

        // 定义一个静态变量来保存类的实例
        private static MainWindow _mainInstance = new MainWindow();

        // 定义私有构造函数，使外界不能创建该类实例
        private Client()
        {

        }

        /// <summary>
        /// 定义公有方法提供一个全局访问点,同时你也可以定义公有属性来提供全局访问点
        /// </summary>
        /// <returns></returns>
        public static MainWindow MainInstance()
        {
            // 当第一个线程运行到这里时，此时会对locker对象 "加锁"，
            // 当第二个线程运行该方法时，首先检测到locker对象为"加锁"状态，该线程就会挂起等待第一个线程解锁
            // lock语句运行完之后（即线程运行完之后）会对该对象"解锁"
            // 双重锁定只需要一句判断就可以了
            if (_mainInstance == null)
            {
                lock (_locker)
                {
                    // 如果类的实例不存在则创建，否则直接返回
                    if (_mainInstance == null)
                    {
                        _mainInstance = new MainWindow();
                    }
                }
            }
            return _mainInstance;
        }
    }
}
