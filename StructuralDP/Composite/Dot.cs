namespace DesignParttern.StructuralDP.Composite
{
    /// <summary>
    /// The leaf class represents end objects of a composition. A
    /// left object can't have any sub-objects. Usually, it's leaf
    /// objects that do the actual work, while composite objects only
    /// delegate to their sub-components.
    /// </summary>
    public class Dot : Graphic
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Dot(int x, int y) { }

        public void Draw()
        {
            throw new System.NotImplementedException();
        }

        public void Move(int x, int y)
        {
            throw new System.NotImplementedException();
        }
    }
}
