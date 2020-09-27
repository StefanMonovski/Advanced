using System;
using System.Linq;

namespace _03.MaximalSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] matrixSizes = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[,] intMatrix = new int[matrixSizes[0], matrixSizes[1]];
            for (int i = 0; i < intMatrix.GetLength(0); i++)
            {
                int[] intRows = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int j = 0; j < intMatrix.GetLength(1); j++)
                {
                    intMatrix[i, j] = intRows[j];
                }
            }
            int maximalSum = int.MinValue;
            int[] position = new int[2];
            for (int i = 0; i < intMatrix.GetLength(0) - 2; i++)
            {
                for (int j = 0; j < intMatrix.GetLength(1) - 2; j++)
                {
                    int currentSum = 0;
                    for (int k = i; k < i + 3; k++)
                    {
                        for (int l = j; l < j + 3; l++)
                        {
                            currentSum += intMatrix[k, l];
                        }
                    }
                    if (currentSum > maximalSum)
                    {
                        maximalSum = currentSum;
                        position[0] = i;
                        position[1] = j;
                    }
                }
            }
            Console.WriteLine($"Sum = {maximalSum}");
            for (int i = position[0]; i < position[0] + 3; i++)
            {
                for (int j = position[1]; j < position[1] + 3; j++)
                {
                    Console.Write(intMatrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
