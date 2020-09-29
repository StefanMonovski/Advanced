using System;

namespace _07.KnightGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int matrixSize = int.Parse(Console.ReadLine());
            char[,] charMatrixPositions = new char[matrixSize, matrixSize]; 
            for (int i = 0; i < charMatrixPositions.GetLength(0); i++)
            {
                char[] charRow = Console.ReadLine().ToCharArray();
                for (int j = 0; j < charMatrixPositions.GetLength(1); j++)
                {
                    charMatrixPositions[i, j] = charRow[j];
                }
            }
            int removeKnightCounter = 0;
            int currentCheckMostPossibleMovesCounter = 8;
            for (int i = 0; i < charMatrixPositions.GetLength(0); i++)
            {
                for (int j = 0; j < charMatrixPositions.GetLength(1); j++)
                {
                    if (charMatrixPositions[i, j] == 'K')
                    {
                        int currentKnightPossibleMovesCounter = 0;
                        int[][] intJaggedMatrixPossiblePositions = new int[8][];
                        intJaggedMatrixPossiblePositions[0] = new int[2] { i - 2, j - 1 };
                        intJaggedMatrixPossiblePositions[1] = new int[2] { i - 2, j + 1 };
                        intJaggedMatrixPossiblePositions[2] = new int[2] { i - 1, j + 2 };
                        intJaggedMatrixPossiblePositions[3] = new int[2] { i + 1, j + 2 };
                        intJaggedMatrixPossiblePositions[4] = new int[2] { i + 2, j - 1 };
                        intJaggedMatrixPossiblePositions[5] = new int[2] { i + 2, j + 1 };
                        intJaggedMatrixPossiblePositions[6] = new int[2] { i - 1, j - 2 };
                        intJaggedMatrixPossiblePositions[7] = new int[2] { i + 1, j - 2 };
                        foreach (int[] item in intJaggedMatrixPossiblePositions)
                        {
                            if (item[0] >= 0 && item[0] < charMatrixPositions.GetLength(0) && item[1] >= 0 && item[1] < charMatrixPositions.GetLength(1))
                            {
                                if (charMatrixPositions[item[0], item[1]] == 'K')
                                {
                                    currentKnightPossibleMovesCounter++;
                                }
                            }
                        }
                        if (currentKnightPossibleMovesCounter == 8 && currentCheckMostPossibleMovesCounter == 8)
                        {
                            charMatrixPositions[i, j] = '0';
                            removeKnightCounter++;
                        }
                        else if (currentKnightPossibleMovesCounter == 7 && currentCheckMostPossibleMovesCounter == 7)
                        {
                            charMatrixPositions[i, j] = '0';
                            removeKnightCounter++;
                        }
                        else if (currentKnightPossibleMovesCounter == 6 && currentCheckMostPossibleMovesCounter == 6)
                        {
                            charMatrixPositions[i, j] = '0';
                            removeKnightCounter++;
                        }
                        else if (currentKnightPossibleMovesCounter == 5 && currentCheckMostPossibleMovesCounter == 5)
                        {
                            charMatrixPositions[i, j] = '0';
                            removeKnightCounter++;
                        }
                        else if (currentKnightPossibleMovesCounter == 4 && currentCheckMostPossibleMovesCounter == 4)
                        {
                            charMatrixPositions[i, j] = '0';
                            removeKnightCounter++;
                        }
                        else if (currentKnightPossibleMovesCounter == 3 && currentCheckMostPossibleMovesCounter == 3)
                        {
                            charMatrixPositions[i, j] = '0';
                            removeKnightCounter++;
                        }
                        else if (currentKnightPossibleMovesCounter == 2 && currentCheckMostPossibleMovesCounter == 2)
                        {
                            charMatrixPositions[i, j] = '0';
                            removeKnightCounter++;
                        }
                        else if (currentKnightPossibleMovesCounter == 1 && currentCheckMostPossibleMovesCounter == 1)
                        {
                            charMatrixPositions[i, j] = '0';
                            removeKnightCounter++;
                        }
                    }
                }
                if (currentCheckMostPossibleMovesCounter == 0)
                {
                    break;
                }
                else if (i == charMatrixPositions.GetLength(0) - 1)
                {
                    i = - 1;
                    currentCheckMostPossibleMovesCounter--;
                }
            }
            Console.WriteLine(removeKnightCounter);
        }
    }
}
