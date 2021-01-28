using System;
using System.Collections.Generic;
using System.Text;

namespace CompositionAndDI
{
    public class Window
    {
        private readonly IShape _shape;

        public Window(IShape shape)
        {
            this._shape = shape ?? throw new ArgumentNullException(nameof(shape));
        }
    }
}
