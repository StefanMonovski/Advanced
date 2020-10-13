using System;
using System.Linq;

namespace _09.ListOfPredicates
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbersLength = int.Parse(Console.ReadLine());
            int[] numbers = new int[numbersLength];
            for (int i = 0; i < numbersLength; i++)
            {   
                numbers[i] = i + 1;
            }
            int[] dividers = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();          
            numbers = GetDivisibleNumbers(numbers, dividers, isNumberDivisibleByAllDividers);
            Action<int[]> printNumbers = x => Console.WriteLine(string.Join(" ", x));
            printNumbers(numbers);
        }

        static int[] GetDivisibleNumbers(int[] numbers, int[] dividers, Func<int, int[], bool> isNumberDivisibleByAllDividers)
        {
            return numbers.Where(x => isNumberDivisibleByAllDividers(x, dividers)).ToArray();
        }

        static bool isNumberDivisibleByAllDividers(int number, int[] dividers)
        {
            foreach (int item in dividers)
            {
                if (number % item != 0)
                {
                    return false;
                }
            }
            return true;
        }   
    }
}
