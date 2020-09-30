using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.Bombs
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
                for (int j = 0; j < intMatrix.GetLength(1); j++)
                {
                    intMatrix[i, j] = intRows[j];
                }
            }
            List<string> bombCoordinates = Console.ReadLine().Split().ToList();
            for (int i = 0; i < bombCoordinates.Count; i++)
            {
                int[] currentCoordinates = bombCoordinates[i].Split(",").Select(int.Parse).ToArray();
                int currentBombRow = currentCoordinates[0];
                int currentBombColumn = currentCoordinates[1];
                if (intMatrix[currentBombRow, currentBombColumn] >= 0)
                {
                    int bombDamageValue = intMatrix[currentBombRow, currentBombColumn];
                    for (int j = 0; j < intMatrix.GetLength(0); j++)
                    {
                        for (int k = 0; k < intMatrix.GetLength(1); k++)
                        {
                            if (intMatrix[j, k] > 0)
                            {
                                if (Math.Abs(j - currentBombRow) <= 1 && k == currentBombColumn)
                                {
                                    intMatrix[j, k] -= bombDamageValue;
                                }
                                else if (Math.Abs(k - currentBombColumn) <= 1 && j == currentBombRow)
                                {
                                    intMatrix[j, k] -= bombDamageValue;
                                }
                                else if (j + k == currentBombRow + currentBombColumn && (j + 1 == currentBombRow || j - 1 == currentBombRow))
                                {
                                    intMatrix[j, k] -= bombDamageValue;
                                }
                                else if (j - k == currentBombRow - currentBombColumn && (k + 1 == currentBombColumn || k - 1 == currentBombColumn))
                                {
                                    intMatrix[j, k] -= bombDamageValue;
                                }
                            }    
                        }
                    }
                }
            }
            int aliveCells = 0;
            int aliveCellsSum = 0;
            for (int i = 0; i < intMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < intMatrix.GetLength(1); j++)
                {
                    if (intMatrix[i, j] > 0)
                    {
                        aliveCells++;
                        aliveCellsSum += intMatrix[i, j];
                    }
                }
            }
            Console.WriteLine($"Alive cells: {aliveCells}");
            Console.WriteLine($"Sum: {aliveCellsSum}");
            for (int i = 0; i < intMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < intMatrix.GetLength(1); j++)
                {
                    Console.Write(intMatrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
