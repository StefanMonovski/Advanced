using System;
using System.Linq;

namespace _06.Quicksort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Quicksort<int>.Sort(array, 0, array.Length - 1);
            Console.WriteLine(string.Join(" ", array));
        }
    }

    public class Quicksort<T> where T : IComparable
    {
        public static void Sort(T[] array, int low, int high)
        {
            if (low < high)
            {
                int p = Partition(array, low, high);
                Sort(array, low, p);
                Sort(array, p + 1, high);
            }
        }

        public static int Partition(T[] array, int low, int high)
        {
            T pivot = array[(low + high) / 2];
            int i = low - 1;
            int j = high + 1;
            while (true)
            {
                do
                    i++;
                while (array[i].CompareTo(pivot) < 0);
                do
                    j--;
                while (array[j].CompareTo(pivot) > 0);
                if (i >= j)
                {
                    return j;         
                }
                T temp = array[i];
                array[i] = array[j];
                array[j] = temp;
            }
        }
    }
}
