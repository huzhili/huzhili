using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PluginContracts
{
    public interface IServicePlugin
    {
        string Name { get; }

        string Text { get; }

        void Run();
    }
}
