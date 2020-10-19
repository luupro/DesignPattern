namespace DesignParttern.StructuralDP.Adapter
{
    /// <summary>
    /// Say you have two classes with compatible interfaces:
    /// RoundHole and RoundPeg.
    /// </summary>
    class RoundHole
    {
        private double radius;

        public RoundHole(double radius)
        {
            this.radius = radius;
        }

        public double GetRadius()
        {
            // Return the radius of the hole
            return radius;
        }

        public bool fits(RoundPeg peg)
        {
            return this.GetRadius() >= peg.GetRadius();
        }

    }
}
