using System;
using System.Linq;

namespace _05.SnakeMoves
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] matrixSizes = Console.ReadLine().Split().Select(int.Parse).ToArray();
            char[,] charMatrix = new char[matrixSizes[0], matrixSizes[1]];
            string input = Console.ReadLine();
            string inputSnake = String.Concat(Enumerable.Repeat(input, matrixSizes[0] * matrixSizes[1] / input.Length + 1));
            int inputSnakeCounter = 0;
            for (int i = 0; i < charMatrix.GetLength(0); i++)
            {
                char[] charRows = inputSnake.ToCharArray();
                if (i % 2 == 0)
                {
                    for (int j = 0; j < charMatrix.GetLength(1); j++)
                    {
                        charMatrix[i, j] = charRows[inputSnakeCounter];
                        inputSnakeCounter++;
                    }
                }
                else if (i % 2 == 1)
                {
                    for (int j = charMatrix.GetLength(1) - 1; j >= 0; j--)
                    {
                        charMatrix[i, j] = charRows[inputSnakeCounter];
                        inputSnakeCounter++;
                    }
                }
            }
            for (int i = 0; i < charMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < charMatrix.GetLength(1); j++)
                {
                    Console.Write(charMatrix[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
