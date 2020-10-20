using System;
using System.Collections.Generic;
using System.Text;

namespace DesignParttern.StructuralDP.Composite
{
    public class Circle : Dot
    {
        public float Radius { get; set; }
        public Circle(int x, int y, float radius) : base(x, y) { }
    }
}
