using System;

namespace GenericScale
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            EqualityScale<int> compareNumbers = new EqualityScale<int>(5, 6);
            Console.WriteLine(compareNumbers.AreEqual());
            EqualityScale<string> compareStrings = new EqualityScale<string>("hello", "hello");
            Console.WriteLine(compareStrings.AreEqual());
        }
    }
}
