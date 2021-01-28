using System;
using System.Collections.Generic;
using System.Text;

namespace CompositionAndDI
{
    public interface IShapeFactory<T> where T : IShape
    {
        IShape CreateShape(IShapeParameters parameters);
    }
}
