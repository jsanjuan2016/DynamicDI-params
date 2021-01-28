using System;
using System.Collections.Generic;
using System.Text;

namespace CompositionAndDI
{
    public class RectangleFactory : IShapeFactory<Rectangle>
    {
        public RectangleFactory()
        {
        }
        public IShape CreateShape(IShapeParameters parameters)
        {
            RectangleParameters _parameters = parameters as RectangleParameters;
            return new Rectangle(_parameters.width, _parameters.height);
        }
    }
}
