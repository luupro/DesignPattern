namespace DesignParttern.StructuralDP.Adapter
{
    /// <summary>
    /// But there's an incompatible class: SquarePeg.
    /// </summary>
    public class SquarePeg
    {
        private double width;
        public SquarePeg(int width)
        {
            this.width = width;
        }

        public double GetWidth()
        {
            // Return the square peg width.
            return width;
        }

    }
}