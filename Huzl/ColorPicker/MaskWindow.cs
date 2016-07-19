using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace ColorPicker
{
    public partial class MaskWindow : Form
    {
        private MainWindow _mainWindow;
        /// <summary>
        /// 定时刷新,获取鼠标位置颜色
        /// </summary>
        Timer _timer = new Timer() { Interval = 10 };

        public MaskWindow(MainWindow mainWindow)
        {
            InitializeComponent();
            _mainWindow = mainWindow;
        }

        private void MaskWindow_Load(object sender, EventArgs e)
        {
            this.Width = Screen.PrimaryScreen.Bounds.Width;
            this.Height = Screen.PrimaryScreen.Bounds.Height;

            this.Left = 0;
            this.Top = 0;
            Button acceptButton = new Button();
            acceptButton.Click += MaskWindow_Click;

            this.AcceptButton = acceptButton;
            this.CancelButton = acceptButton;

            _timer.Tick += _timer_Tick;
        }

        public void Start()
        {
            if (!_timer.Enabled)
                _timer.Start();
        }

        private void _timer_Tick(object sender, EventArgs e)
        {
            try
            {
                int x = MousePosition.X, y = MousePosition.Y;
                Color color = Screenshot().GetPixel(x, y);
                _mainWindow.UpdateColor(color);
            }
            catch (Exception ex)
            {

            }
        }

        private void MaskWindow_Click(object sender, EventArgs e)
        {
            int x = MousePosition.X, y = MousePosition.Y;
            Color color = Screenshot().GetPixel(x, y);
            _mainWindow.UpdateColor(color);
            _timer.Stop();
            this.Hide();
        }

        public Bitmap Screenshot()
        {
            Bitmap bmp = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            using (var gr = Graphics.FromImage(bmp))
            {
                gr.CopyFromScreen(Screen.PrimaryScreen.Bounds.X, Screen.PrimaryScreen.Bounds.Y,
                    0, 0, Screen.PrimaryScreen.Bounds.Size);
            }
            return bmp;
        }
    }
}
