using System;
using System.Threading;
using System.Windows.Forms;

namespace Huzl.SplashScreen
{
    /// <summary>
    /// 加载窗口
    /// </summary>
    public class Splash : IDisposable
    {
        public Splash(string text = "正在加载")
        {
            Start(text);
        }

        private static string _text = "正在加载";
        /// <summary>
        /// 设置或获取文本内容
        /// </summary>
        public string Text
        {
            get { return _text; }
            set
            {
                _text = value;
                ChangeText(_text);
            }
        }
        private static string _title = "请稍候...";
        /// <summary>
        /// 设置或获取标题内容
        /// </summary>
        public string Title
        {
            get { return _title; }
            set
            {
                _title = value;
                ChangeTitle(_title);
            }
        }
        /// <summary>
        /// Loading窗体
        /// </summary>
        static BaseForm _splash;
        /// <summary>
        /// 启动闪屏
        /// </summary>
        public static void Start(string text = "正在加载")
        {
            _text = text;
            Thread splashThread = new Thread(new ThreadStart(StartSplash));
            splashThread.Start();
            Thread.Sleep(200);
        }

        static void StartSplash()
        {
            if (_splash != null)
            {
                Close();
            }
            //实例化闪屏窗体
            _splash = new WaitForm(_text);

            //运行闪屏窗体
            Application.Run(_splash);
        }

        public static void Close()
        {
            if (_splash == null) return;
            //关闭闪屏窗体
            _splash.Invoke(new EventHandler(_splash.KillMe));
            _splash.Dispose();
            _splash = null;
        }

        /// <summary>
        /// 改变闪屏窗体文字内容
        /// </summary>
        /// <param name="text"></param>
        public static void ChangeText(string text)
        {
            if (_splash == null) return;
            _splash.Invoke(new EventHandler(_splash.ChangeText), text);
        }

        /// <summary>
        /// 改变闪屏窗体标题内容
        /// </summary>
        /// <param name="text"></param>
        public static void ChangeTitle(string title)
        {
            if (_splash == null) return;
            _splash.Invoke(new EventHandler(_splash.ChangeTitle), title);
        }

        public void Dispose()
        {
            Close();
        }
    }
}

/*
    #region 启动Loading程序
        Splash.Start();
        Splash.BringTop();
        Splash.ChangeText("Starting...");
    #endregion

    #region 数据加载完成结束
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            Splash.Close();

            this.Focus();
            this.BringToFront();
        }
    #endregion
*/
