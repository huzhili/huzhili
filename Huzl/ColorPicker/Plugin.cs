using PluginContracts;
using System.ComponentModel.Composition;
using System.Windows.Forms;

namespace ColorPicker
{
    [Export(typeof(IPlugin))]
    public class Plugin : IPlugin
    {
        #region IPlugin Members

        public string Name
        {
            get
            {
                return "First_Plugin";
            }
        }

        public string Text
        {
            get
            {
                return "First Plugin";
            }
        }

        public void Run()
        {
            new MainWindow().Show();
        }

        #endregion
    }

    [Export(typeof(IServicePlugin))]
    public class ServicePlugin : IServicePlugin
    {
        #region IPlugin Members

        public string Name
        {
            get
            {
                return "First_Service_Plugin";
            }
        }

        public string Text
        {
            get
            {
                return "First Service Plugin";
            }
        }

        public void Run()
        {
            new MainWindow().Show();
        }

        #endregion
    }
}
