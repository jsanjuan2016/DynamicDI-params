using System;
using System.Collections.Generic;
using System.Text;

namespace CompositionAndDI
{
    public class Cirlce : IShape
    {
        private const double PI = 3.1416;
        private readonly double _radius;
        internal Cirlce(double radius)
        {
            this._radius = radius;
        }
        public double getArea()
        {
            return PI * Math.Pow(this._radius, 2);
        }
    }
}
