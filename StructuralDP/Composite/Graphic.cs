namespace DesignParttern.StructuralDP.Composite
{
    /// <summary>
    /// The component interface declares common operations for both
    /// simple and complex objects of a composition
    /// </summary>
    public interface Graphic
    {
        public void Move(int x, int y);
        public void Draw();
    }
}
