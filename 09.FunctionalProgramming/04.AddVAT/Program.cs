using System;
using System.Linq;

namespace _04.AddVAT
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<double, double> addVAT = x => x * 1.20;
            double[] prices = Console.ReadLine().Split(", ").Select(x => double.Parse(x)).Select(addVAT).ToArray();
            foreach (double item in prices)
            {
                Console.WriteLine($"{item:f2}");
            }
        }
    }
}
