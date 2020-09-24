using System;
using System.Linq;

namespace _03.PrimaryDiagonal
{
    class Program
    {
        static void Main(string[] args)
        {
            int matrixSize = int.Parse(Console.ReadLine());
            int[,] intMatrix = new int[matrixSize, matrixSize];
            for (int i = 0; i < intMatrix.GetLength(0); i++)
            {
                int[] intColumns = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int j = 0; j < intMatrix.GetLength(1); j++)
                {
                    intMatrix[i, j] = intColumns[j];
                }
            }
            int sumPrimaryDiagonal = 0;
            for (int i = 0; i < matrixSize; i++)
            {
                sumPrimaryDiagonal += intMatrix[i, i];
            }
            Console.WriteLine(sumPrimaryDiagonal);
        }
    }
}
