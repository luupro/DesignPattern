namespace DesignParttern.StructuralDP.Adapter
{
    public class RoundPeg
    {
        private double radius;
        public RoundPeg(double radius)
        {
            this.radius = radius;
        }

        public double GetRadius()
        {
            // Return the radius of the peg.
            return radius;
        }

    }
}
