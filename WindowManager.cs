using System;
using System.Collections.Generic;
using System.Text;

namespace CompositionAndDI
{
    public class WindowManager
    {
        private readonly IShapeFactory<Rectangle> _rectangleFactory;
        private readonly IShapeFactory<Cirlce> _CircleFactory;

        public WindowManager(IShapeFactory<Rectangle> rectangleFactory, IShapeFactory<Cirlce> CirlceFactory)
        {
            this._rectangleFactory = rectangleFactory ?? throw new ArgumentNullException(nameof(rectangleFactory));
            this._CircleFactory = CirlceFactory ?? throw new ArgumentNullException(nameof(CirlceFactory));
        }

        public void CreateRectangleWithUserParams(IShapeParameters parameters)
        {
			//IShape rectangle = this._rectangleFactory.CreateShape(new RectangleParameters() { width = 15, height = 20 });
            IShape rectangle = this._rectangleFactory.CreateShape(parameters);
            Console.WriteLine($"Factory: Rectangle created");
            Console.WriteLine($"Factory: El área del Rectangle es: {rectangle.getArea():0.00}");
        }
        public void CreateCircleWithUserParams(IShapeParameters parameters)
        {
			//IShape Cirlce = this._CirlceFactory.CreateShape(new CirlceParameters() { radius = 8 });
            IShape Cirlce = this._CircleFactory.CreateShape(parameters);
            Console.WriteLine($"Factory: Cirlce created");
            Console.WriteLine($"Factory: El área de la ventana es: {Cirlce.getArea():0.00}");
        }        
    }
}
