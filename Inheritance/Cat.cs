using DesignParttern.Inheritance.Interface;
using System;

namespace DesignParttern.Inheritance
{
    class Cat : Animal, IFourLegged, IOxygenBreather
    {
        public virtual void breath()
        {
            Console.WriteLine("breathing");
        }

        public void Rune()
        {
            throw new System.NotImplementedException();
        }
    }
}
