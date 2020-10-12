using System;
using System.Linq;

namespace _05.AppliedArithmetics
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
            string command = "";
            while ((command = Console.ReadLine()) != "end")
            {
                Func<int[], int[]> operationDelegate = GetOperation(numbers, command);
                if (operationDelegate != null)
                {
                    numbers = operationDelegate(numbers);
                }
                else if (command == "print")
                {
                    Action<int[]> printNumbers = x => Console.WriteLine(string.Join(" ", x));
                    printNumbers(numbers);
                }
            }
        }

        static Func<int[], int[]> GetOperation(int[] number, string command)
        {
            switch (command)
            {
                case "add": return x => x = x.Select(n => n + 1).ToArray();
                case "multiply": return x => x = x.Select(n => n * 2).ToArray();
                case "subtract": return x => x = x.Select(n => n - 1).ToArray();
                default: return null;
            }
        }
    }
}
