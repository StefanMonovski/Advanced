using System;
using System.Linq;

namespace _05.MergeSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Console.WriteLine(string.Join(" ", Mergesort<int>.Merge(array)));
        }
    }

    public class Mergesort<T> where T : IComparable
    {
        public static T[] Merge(T[] array)
        {
            if (array.Length == 1)
            {
                return array;
            }
            T[] leftArray = new T[array.Length / 2];
            T[] rightArray = new T[array.Length - array.Length / 2];
            Array.Copy(array, 0, leftArray, 0, array.Length / 2);
            Array.Copy(array, array.Length / 2, rightArray, 0, array.Length - array.Length / 2);
            leftArray = Merge(leftArray);
            rightArray = Merge(rightArray);
            return Sort(leftArray, rightArray);
        }

        public static T[] Sort(T[] leftArray, T[] rightArray)
        {
            T[] sortedArray = new T[leftArray.Length + rightArray.Length];
            int sortedIndex = 0;
            int leftIndex = 0;
            int rightIndex = 0;
            while (leftIndex < leftArray.Length && rightIndex < rightArray.Length)
            {
                if (leftArray[leftIndex].CompareTo(rightArray[rightIndex]) < 0)
                {
                    sortedArray[sortedIndex] = leftArray[leftIndex];
                    leftIndex++;
                }
                else
                {
                    sortedArray[sortedIndex] = rightArray[rightIndex];
                    rightIndex++;
                }
                sortedIndex++;
            }
            for (int i = leftIndex; i < leftArray.Length; i++)
            {
                sortedArray[sortedIndex] = leftArray[i];
                sortedIndex++;
            }
            for (int i = rightIndex; i < rightArray.Length; i++)
            {
                sortedArray[sortedIndex] = rightArray[i];
                sortedIndex++;
            }
            return sortedArray;
        }
    }
}
