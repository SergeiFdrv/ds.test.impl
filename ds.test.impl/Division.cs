using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace ds.test.impl
{
    /// <summary>
    /// Деление без остатка
    /// </summary>
    class Division : IPlugin
    {
        public string PluginName => "Divide";

        public string Version => "0.1";

        public Image Image => throw new NotImplementedException();

        public string Description =>
            "Divide x by y and get the quotient without the remainder";

        public int Run(int input1, int input2) => input1 / input2;
    }
}
