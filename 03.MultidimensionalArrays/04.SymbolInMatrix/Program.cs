using System;

namespace _04.SymbolInMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int matrixSize = int.Parse(Console.ReadLine());
            char[,] charMatrix = new char[matrixSize, matrixSize];
            for (int i = 0; i < charMatrix.GetLength(0); i++)
            {
                char[] charRows = Console.ReadLine().ToCharArray();
                for (int j = 0; j < charMatrix.GetLength(1); j++)
                {
                    charMatrix[i, j] = charRows[j];
                }
            }
            char specialSymbol = Char.Parse(Console.ReadLine());
            bool matrixContainsSpecialSymbol = false;
            int[] position = new int[2];
            for (int i = 0; i < matrixSize; i++)
            {
                for (int j = 0; j < matrixSize; j++)
                {
                    if (charMatrix[j, i] == specialSymbol)
                    {
                        matrixContainsSpecialSymbol = true;
                        position[0] = j;
                        position[1] = i;
                        break;
                    }
                }
            }
            if (matrixContainsSpecialSymbol)
            {
                Console.WriteLine($"({position[0]}, {position[1]})");
            }
            else
            {
                Console.WriteLine($"{specialSymbol} does not occur in the matrix");
            }
        }
    }
}
