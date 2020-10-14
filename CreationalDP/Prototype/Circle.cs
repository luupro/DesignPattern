﻿namespace DesignParttern.CreationalDP.Prototype
{
    class Circle : Shape
    {
        public int Radius { get; set; }

        public Circle() { }

        public Circle(Circle source) : base(source)
        {
            this.Radius = source.Radius;
        }

        public override Shape Clone()
        {
            return new Circle(this);
        }
    }
}
