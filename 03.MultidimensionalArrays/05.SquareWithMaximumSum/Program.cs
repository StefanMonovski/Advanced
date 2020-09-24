using System;
using System.Linq;

namespace _05.SquareWithMaximumSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] matrixSizes = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int[,] intMatrix = new int[matrixSizes[0], matrixSizes[1]];
            for (int i = 0; i < intMatrix.GetLength(0); i++)
            {
                int[] intRows = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
                for (int j = 0; j < intMatrix.GetLength(1); j++)
                {
                    intMatrix[i, j] = intRows[j];
                }
            }
            int biggestSubmatrixSum = 0;
            int[] position = new int[2];
            for (int i = 0; i < intMatrix.GetLength(0) - 1; i++)
            {
                for (int j = 0; j < intMatrix.GetLength(1) - 1; j++)
                {
                    int currentSubmatrixSum = intMatrix[i, j] + intMatrix[i, j + 1] + intMatrix[i + 1, j] + intMatrix[i + 1, j + 1];
                    if (currentSubmatrixSum > biggestSubmatrixSum)
                    {
                        biggestSubmatrixSum = currentSubmatrixSum;
                        position[0] = i;
                        position[1] = j;
                    }
                }
            }
            Console.WriteLine(intMatrix[position[0], position[1]] + " " + intMatrix[position[0], position[1] + 1]);
            Console.WriteLine(intMatrix[position[0] + 1, position[1]] + " " + intMatrix[position[0] + 1, position[1] + 1]);
            Console.WriteLine(biggestSubmatrixSum);
        }
    }
}
