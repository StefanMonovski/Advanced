using System;
using System.Linq;

namespace _02.SquaresInMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] matrixSizes = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[,] intMatrix = new int[matrixSizes[0], matrixSizes[1]];
            for (int i = 0; i < intMatrix.GetLength(0); i++)
            {
                char[] intRows = Console.ReadLine().Replace(" ", "").ToCharArray();
                for (int j = 0; j < intMatrix.GetLength(1); j++)
                {
                    intMatrix[i, j] = intRows[j];
                }
            }
            int countSquareEqualChars = 0;
            for (int i = 0; i < intMatrix.GetLength(0) - 1; i++)
            {
                for (int j = 0; j < intMatrix.GetLength(1) - 1; j++)
                {
                    if (intMatrix[i, j] == intMatrix[i, j + 1] && intMatrix[i, j] == intMatrix[i + 1, j] && intMatrix[i, j] == intMatrix[i + 1, j + 1])
                    {
                        countSquareEqualChars++;
                    }
                }
            }
            Console.WriteLine(countSquareEqualChars);
        }
    }
}
