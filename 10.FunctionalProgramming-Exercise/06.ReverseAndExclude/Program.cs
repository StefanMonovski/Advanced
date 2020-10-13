using System;
using System.Linq;

namespace _06.ReverseAndExclude
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
            int divideBy = int.Parse(Console.ReadLine());
            Func<int[], int, int[]> excludeDivisibleNumbers = (x, y) => x.Where(n => n % y != 0).ToArray();
            numbers = excludeDivisibleNumbers(numbers, divideBy);
            Array.Reverse(numbers);
            Action<int[]> printNumbers = x => Console.WriteLine(string.Join(" ", x));
            printNumbers(numbers);
        }
    }
}
