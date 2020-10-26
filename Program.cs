using System;
using System.Text;

namespace DesignParttern
{
    public class Program
    {
        public static string FindIntersection(string[] strArr)
        {
            var firstNumbersArray = strArr[0].Replace(" ", "").Split(",");
            var secondNumbersArray = strArr[1].Replace(" ", "").Split(",");
            var result = new StringBuilder();

            foreach (var element in firstNumbersArray)
            {
                if (Array.IndexOf(secondNumbersArray, element) > -1)
                {
                    result.Append(element);
                    result.Append(",");
                }
            }
            // code goes here
            if (result.Length != 0)
            {
                result = result.Remove(result.Length - 1, 1);
            }


            return result.ToString();

        }

        static void Main()
        {
            // keep this function call here
            var inputString = new string[] { "1, 3, 4, 7, 13", "1, 2, 4, 13, 15" };
            Console.WriteLine(FindIntersection(inputString));
        }
    }
}
