using System;
using System.Collections.Generic;
using System.Text;

namespace CompositionAndDI
{
    public class RectangleParameters : IShapeParameters
    {
        public double width { get; set; }
        public double height { get; set; }
    }
}
