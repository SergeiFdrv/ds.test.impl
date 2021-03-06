﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace ds.test.impl.Ops.geometry
{
    /// <summary>
    /// Площадь прямоугольного треугольника при известной гипотенузе
    /// </summary>
    class RightAngledTriangleAreaHypotenuse : Geometry
    {
        public override string PluginName => "90TrnglAreaHypotenuse";

        public override string Version => "0.1";

        public override Image Image => throw new NotImplementedException();

        public override string Description => "Find the area of a right angled triangle" +
            " using the hypotenuse and one of the legs";

        public override int Run(int input1, int input2)
        {
            double hypotenuse, leg1;
            if (input1 > input2)
            {
                hypotenuse = input1;
                leg1 = input2;
            }
            else
            {
                leg1 = input1;
                hypotenuse = input2;
            }
            double leg2 = PythagorasLeg(hypotenuse, leg1);
            // leg1 * hypotenuse * sin(угол между leg1 и hypotenuse) / 2
            // = leg1 * hypotenuse * (leg2 / hypotenuse) / 2
            // = leg1 * leg2 / 2
            return (int)(leg1 * leg2 / 2);
        }
    }
}
