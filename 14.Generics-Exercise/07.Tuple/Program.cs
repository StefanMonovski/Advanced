using System;

namespace _07.Tuple
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstInput = Console.ReadLine().Split();
            GenericTuple<string, string> firstTuple = new GenericTuple<string, string>(firstInput[0] + " " + firstInput[1], firstInput[2]);
            string[] secondInput = Console.ReadLine().Split();
            GenericTuple<string, int> secondTuple = new GenericTuple<string, int>(secondInput[0], int.Parse(secondInput[1]));
            string[] thirdInput = Console.ReadLine().Split();
            GenericTuple<int, double> thirdTuple = new GenericTuple<int, double>(int.Parse(thirdInput[0]), double.Parse(thirdInput[1]));
            Console.WriteLine(firstTuple.ToString());
            Console.WriteLine(secondTuple.ToString());
            Console.WriteLine(thirdTuple.ToString());
        }
    }
}
