using System;
using System.Collections.Generic;
using System.Text;

namespace CompositionAndDI
{
    public class Rectangle : IShape
    {
        private readonly double _width;
        private readonly double _height;
        internal Rectangle(double width, double height)
        {
            this._width = width;
            this._height = height;
        }
        public double getArea()
        {
            return this._width * this._height;
        }
    }
}
