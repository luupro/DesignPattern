namespace DesignParttern.CreationalDP.Prototype
{
    /// <summary>
    /// Base prototype
    /// </summary>
    public abstract class Shape
    {
        public int X { get; set; }
        public int Y { get; set; }
        public string color { get; set; }

        // A regular constructor.
        protected Shape() { }

        // The prototype constructor. A fresh object is initialized
        // with value from th existing object.
        protected Shape(Shape source)
        {
            this.X = source.X;
            this.Y = source.Y;
            this.color = source.color;
        }

        // The clone operation returns one of the Shape subclasses.
        abstract public Shape Clone();
    }
}
