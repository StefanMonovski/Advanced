using System;
using System.Linq;

namespace _01.SumMatrixElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] matrixSizes = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int[,] intMatrix = new int[matrixSizes[0], matrixSizes[1]];
            int sum = 0;
            for (int i = 0; i < intMatrix.GetLength(0); i++)
            {
                int[] intColumns = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
                for (int j = 0; j < intMatrix.GetLength(1); j++)
                {
                    intMatrix[i, j] = intColumns[j];
                }
            }
            foreach (int item in intMatrix)
            {
                sum += item;
            }
            Console.WriteLine(intMatrix.GetLength(0));
            Console.WriteLine(intMatrix.GetLength(1));
            Console.WriteLine(sum);
        }
    }
}
