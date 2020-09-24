using System;
using System.Linq;

namespace _02.SumMatrixColumns
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] matrixSizes = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int[,] intMatrix = new int[matrixSizes[0], matrixSizes[1]];
            for (int i = 0; i < intMatrix.GetLength(0); i++)
            {
                int[] intColumns = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
                for (int j = 0; j < intMatrix.GetLength(1); j++)
                {
                    intMatrix[i, j] = intColumns[j];
                }
            }
            for (int i = 0; i < intMatrix.GetLength(1); i++)
            {
                int columnSum = 0;
                for (int j = 0; j < intMatrix.GetLength(0); j++)
                {
                    columnSum += intMatrix[j, i];
                }
                Console.WriteLine(columnSum);
            }
        }
    }
}