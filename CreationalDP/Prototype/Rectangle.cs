namespace DesignParttern.CreationalDP.Prototype
{
    /// <summary>
    /// Concrete prototype. The cloning method creates a new object
    /// and passes it to the constructor. Until the constructor is
    /// finished, it has a reference to a fresh clone. Therefore, 
    /// nobody has access to a partly-build clone. This keeps the
    /// cloning result consistent.
    /// </summary>
    public class Rectangle : Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public Rectangle() { }

        public Rectangle(Rectangle source) : base(source)
        {
            // A parent constructor call is needed to copy private
            // fields defined in the parent class.
            this.Width = source.Width;
            this.Height = source.Height;
        }

        public override Shape Clone()
        {
            return new Rectangle(this);
        }
    }
}
