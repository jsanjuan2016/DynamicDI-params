using System;
using System.Collections.Generic;
using System.Text;

namespace CompositionAndDI
{
    public class CirlceFactory : IShapeFactory<Cirlce>
    {
        public CirlceFactory()
        {
        }
        public IShape CreateShape(IShapeParameters parameters)
        {
            CirlceParameters _parameters = parameters as CirlceParameters;
            return new Cirlce(_parameters.radius);
        }
    }
}
