using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace ds.test.impl
{
    /// <summary>
    /// Класс геометрических операций
    /// </summary>
    abstract class Geometry : IPlugin
    {
        public abstract string PluginName { get; }

        public abstract string Version { get; }

        public abstract Image Image { get; }

        public abstract string Description { get; }

        public abstract int Run(int input1, int input2);

        /// <summary>
        /// Найти гипотенузу прямоугольного треугольника по двум известным катетам
        /// </summary>
        protected double PythagorasHypotenuse(double side1, double side2)
        {
            return Math.Sqrt(side1 * side1 + side2 * side2);
        }

        /// <summary>
        /// Найти катет прямоугольного треугольника по известному катету и гипотенузе
        /// </summary>
        /// <param name="hypotenuse">Гипотенуза</param>
        /// <param name="leg">Известный катет</param>
        protected double PythagorasLeg(double hypotenuse, double leg)
        {
            return Math.Sqrt(hypotenuse * hypotenuse - leg * leg);
        }
    }
}
