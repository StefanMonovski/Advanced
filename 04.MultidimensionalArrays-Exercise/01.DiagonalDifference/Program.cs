using System;
using System.Linq;

namespace _01.DiagonalDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            int matrixSize = int.Parse(Console.ReadLine());
            int[,] intMatrix = new int[matrixSize, matrixSize];
            for (int i = 0; i < intMatrix.GetLength(0); i++)
            {
                int[] intRows = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int j= 0; j < intMatrix.GetLength(1); j++)
                {
                    intMatrix[i, j] = intRows[j];
                }
            }
            int primaryDiagonalSum = 0;
            int secondaryDiagonalSum = 0;
            for (int i = 0; i < matrixSize; i++)
            {
                primaryDiagonalSum += intMatrix[i, i];
            }
            for (int i = 0; i < matrixSize; i++)
            {
                secondaryDiagonalSum += intMatrix[i, matrixSize - i - 1];
            }
            Console.WriteLine(Math.Abs(primaryDiagonalSum - secondaryDiagonalSum));
        }
    }
}
