using DesignParttern.Inheritance;

namespace DesignParttern
{
    class Application
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat();
            Cat americanCat = new AmericanShorthairCat();
            cat.breath();
            americanCat.breath();
        }
    }
}
