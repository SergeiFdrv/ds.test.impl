using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace ds.test.impl
{
    /// <summary>
    /// Площадь прямоугольного треугольника при известных катетах
    /// </summary>
    class RightAngledTriangleAreaLegs : Geometry
    {
        public override string PluginName => "90TrnglAreaLegs";

        public override string Version => "0.1";

        public override Image Image => throw new NotImplementedException();

        public override string Description =>
            "Find the area of a right angled triangle using the legs";

        public override int Run(int input1, int input2)
        {
            // input1 * hypotenuse * sin(угол между input1 и hypotenuse) / 2
            // = input1 * hypotenuse * (input2 / hypotenuse) / 2
            return input1 * input2 / 2;
        }
    }
}
