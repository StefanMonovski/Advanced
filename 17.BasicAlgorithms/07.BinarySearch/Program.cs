using System;
using System.Linq;

namespace _07.BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int searchedNumber = int.Parse(Console.ReadLine());
            Console.WriteLine(BinarySearch.IndexOf(array, searchedNumber)); 
        }
    }

    public class BinarySearch
    {
        public static int IndexOf(int[] array, int searchedNumber)
        {
            int left = 0;
            int right = array.Length - 1;
            while (left <= right)
            {
                int middle = left + (right - left) / 2;
                if (array[middle] > searchedNumber)
                {
                    right = middle - 1;
                }
                else if (array[middle] < searchedNumber)
                {
                    left = middle + 1;
                }
                else
                {
                    return middle;
                }
            }
            return -1;
        }
    }
}
