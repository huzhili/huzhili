using Huzl.SplashScreen;
using PluginContracts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PluginDemo
{
    public partial class MainWindow : Form
    {
        Dictionary<string, IPlugin> _Plugins;

        Dictionary<string, IServicePlugin> _ServicePlugins;
        public MainWindow()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            #region LoadData
            LoadPlugins();
            #endregion

            base.OnLoad(e);
            Splash.Close();

            this.Focus();
            this.BringToFront();
        }

        void LoadPlugins()
        {

            GenericMEFPluginLoader<IServicePlugin> loaderService = new GenericMEFPluginLoader<IServicePlugin>("Plugins");
            _ServicePlugins = new Dictionary<string, IServicePlugin>();
            IEnumerable<IServicePlugin> servicePlugins = loaderService.Plugins;
            foreach (var item in servicePlugins)
            {
                _ServicePlugins.Add(item.Name, item);
                var tsmServicePluginItem = new ToolStripMenuItem()
                {
                    Name = item.Name,
                    Text = item.Name
                };
                tsmServicePluginItem.Click += TsmServicePluginItem_Click;
                servicePluginsToolStripMenuItem.DropDownItems.Add(tsmServicePluginItem);
            }

            GenericMEFPluginLoader<IPlugin> loader = new GenericMEFPluginLoader<IPlugin>("Plugins");
            _Plugins = new Dictionary<string, IPlugin>();
            IEnumerable<IPlugin> plugins = loader.Plugins;
            foreach (var item in plugins)
            {
                _Plugins.Add(item.Name, item);
                var tsmPluginItem = new ToolStripMenuItem()
                {
                    Name = item.Name,
                    Text = item.Name
                };
                tsmPluginItem.Click += TsmItem_Click;
                pluginsToolStripMenuItem.DropDownItems.Add(tsmPluginItem);
            }
        }

        private void TsmServicePluginItem_Click(object sender, EventArgs e)
        {
            var item = sender as ToolStripMenuItem;
            var key = item.Name;
            if (_ServicePlugins.ContainsKey(key))
            {
                IServicePlugin plugin = _ServicePlugins[key];
                plugin.Run();
            }
        }

        private void TsmItem_Click(object sender, EventArgs e)
        {
            var item = sender as ToolStripMenuItem;
            var key = item.Name;
            if (_Plugins.ContainsKey(key))
            {
                IPlugin plugin = _Plugins[key];
                plugin.Run();
            }
        }
    }
}
