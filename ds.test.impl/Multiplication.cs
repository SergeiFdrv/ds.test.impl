using System;
using System.Collections.Generic;
using System.Text;

namespace ds.test.impl
{
    /// <summary>
    /// Умножение
    /// </summary>
    class Multiplication : IPlugin
    {
        public string PluginName => "Multiply";

        public string Version => "0.1";

        public System.Drawing.Image Image => throw new NotImplementedException();

        public string Description => "Return x times y";

        public int Run(int input1, int input2) => input1 * input2;
    }
}
