using System;

namespace _02.RecursiveFactorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int factorial = RecursiveFactorial(input);
            Console.WriteLine(factorial);
        }

        private static int RecursiveFactorial(int input)
        {
            if (input == 1)
            {
                return 1;
            }
            int currentFactorial = input * RecursiveFactorial(input - 1);
            return currentFactorial;
        }
    }
}
