using System;

namespace DesignParttern.StructuralDP.Adapter
{
    class Client
    {
        static void MainProcess(string[] args)
        {
            //Somewhere in client code
            var hole = new RoundHole(5);
            var rpeg = new RoundPeg(5);
            var rs1 = hole.fits(rpeg); // true

            var small_sqpeg = new SquarePeg(5);
            var large_sqpeg = new SquarePeg(10);
            //hole.fits(small_sqpeg); // this won't compile (incompatible types)

            var small_sqpeg_adapter = new SquarePegAdapter(small_sqpeg);
            var large_sqpeg_adapter = new SquarePegAdapter(large_sqpeg);
            var rs2 = hole.fits(small_sqpeg_adapter); // true
            var rs3 = hole.fits(large_sqpeg_adapter); // false

            Console.WriteLine(rs1);
            Console.WriteLine(rs2);
            Console.WriteLine(rs3);
        }
    }
}
