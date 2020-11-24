using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;

namespace ds.test.impl
{
    interface PluginFactory
    {
        int PluginsCount { get; }

        string[] GetPluginNames { get; }

        IPlugin GetPlugin(string pluginName);
    }
}
