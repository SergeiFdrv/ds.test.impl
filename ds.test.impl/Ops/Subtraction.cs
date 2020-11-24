using System;
using System.Collections.Generic;
using System.Text;

namespace ds.test.impl.Ops
{
    class Subtraction : IPlugin
    {
        public string PluginName => "Subtract";

        public string Version => "0.1";

        public System.Drawing.Image Image => throw new NotImplementedException();

        public string Description => "Subtract y from x";

        public int Run(int input1, int input2) => input1 - input2;
    }
}
