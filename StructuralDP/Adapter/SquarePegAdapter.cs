using System;
using System.Collections.Generic;
using System.Text;

namespace DesignParttern.StructuralDP.Adapter
{
    /// <summary>
    /// An adapter class lets you fit square pegs into round holes.
    /// It extend the RoundPeg class to let the adapter objects act
    /// as round pegs.
    /// </summary>
    public class SquarePegAdapter : RoundPeg
    {
        // In reality, the adapter contain an instance of the
        // SquarePeg class.
        private SquarePeg peg;

        public SquarePegAdapter(SquarePeg peg) : base(peg.GetWidth())
        {
            this.peg = peg;
        }

        public double GetRadius()
        {
            // The adapter pretends that it's a round peg with a
            // radius that could fit the square pet that the adapter
            // actually wraps
            return peg.GetWidth() * Math.Sqrt(2) / 2;
        }
    }
}
