using System.Collections.Generic;

namespace DesignParttern.CreationalDP.Prototype
{
    //Some where in the client code
    class Application
    {
        public List<Shape> Shapes { get; set; }

        public Application()
        {
            var circle = new Circle();
            circle.X = 10;
            circle.Y = 10;
            circle.Radius = 20;
            Shapes.Add(circle);

            var anotherCircle = circle.Clone();
            Shapes.Add(anotherCircle);
            // The `anoherCircle` variable contains an exact copy
            // of the `circle` object.

            Rectangle rectangle = new Rectangle();
            rectangle.Width = 10;
            rectangle.Height = 20;
            Shapes.Add(rectangle);
        }

        public void BusinessLogic()
        {
            // Prototype rocks because it lets you produce a copy of 
            // an object without knowing anything about its type.
            var shapesCopy = new List<Shape>();

            // For instance, we don't know the exact elements in the
            // shapes array. All we know is that they are all
            // shapes. But thanks to polymorphism, when we call the
            // `clone` method on a shape the program checks its real
            // class and runs the appropriate clone method defined
            // in that class. That's why we get proper Clones
            // instead of a set of simple Shape objects.
            foreach (var s in Shapes)
            {
                shapesCopy.Add(s.Clone());
            }

            // The `shapesCopy` array contains exact copies of the
            // `shape` array's children.
        }
    }
}
