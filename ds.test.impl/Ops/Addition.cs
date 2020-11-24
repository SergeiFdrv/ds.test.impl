using System;
using System.Collections.Generic;
using System.Text;

namespace ds.test.impl.Ops
{
    /// <summary>
    /// Сложение
    /// </summary>
    class Addition : IPlugin
    {
        public string PluginName => "Add";

        public string Version => "0.1";

        public System.Drawing.Image Image => throw new NotImplementedException();

        public string Description => "Add x to y";

        public int Run(int input1, int input2) => input1 + input2;
    }
}
