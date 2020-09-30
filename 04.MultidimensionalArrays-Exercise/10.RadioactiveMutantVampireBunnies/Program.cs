using System;
using System.Collections.Generic;
using System.Linq;

namespace _10.RadioactiveMutantVampireBunnies
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] matrixSizes = Console.ReadLine().Split().Select(int.Parse).ToArray();
            char[,] charMatrix = new char[matrixSizes[0], matrixSizes[1]];
            int playerNextRow = 0;
            int playerNextColumn = 0;
            for (int i = 0; i < charMatrix.GetLength(0); i++)
            {
                char[] charRows = Console.ReadLine().ToCharArray();
                for (int j = 0; j < charMatrix.GetLength(1); j++)
                {
                    charMatrix[i, j] = charRows[j];
                    if (charMatrix[i, j] == 'P')
                    {
                        playerNextRow = i;
                        playerNextColumn = j;
                        charMatrix[i, j] = '.';
                    }
                }
            }
            bool playerAlive = true;
            int playerCurrentRow = playerNextRow;
            int playerCurrentColumn = playerNextColumn;
            char[] commandDirections = Console.ReadLine().ToCharArray();
            for (int i = 0; i < commandDirections.Length; i++)
            {  
                if (commandDirections[i] == 'U')
                {
                    playerNextRow -= 1;
                }
                else if (commandDirections[i] == 'D')
                {
                    playerNextRow += 1;
                }
                else if (commandDirections[i] == 'L')
                {
                    playerNextColumn -= 1;
                }
                else if (commandDirections[i] == 'R')
                {
                    playerNextColumn += 1;
                }
                if (playerNextRow >= 0 && playerNextRow < charMatrix.GetLength(0) && playerNextColumn >= 0 && playerNextColumn < charMatrix.GetLength(1))
                {
                    playerCurrentRow = playerNextRow;
                    playerCurrentColumn = playerNextColumn;
                }
                for (int j = 0; j < charMatrix.GetLength(0); j++)
                {
                    for (int k = 0; k < charMatrix.GetLength(1); k++)
                    {
                        if (charMatrix[j, k] == 'B')
                        {
                            if (j - 1 >= 0)
                            {
                                if (charMatrix[j - 1, k] != 'B')
                                {
                                    charMatrix[j - 1, k] = 'b';
                                }                                
                            }
                            if (j + 1 < charMatrix.GetLength(0))
                            {
                                if (charMatrix[j + 1, k] != 'B')
                                {
                                    charMatrix[j + 1, k] = 'b';
                                } 
                            }
                            if (k - 1 >= 0)
                            {
                                if (charMatrix[j, k - 1] != 'B')
                                {
                                    charMatrix[j, k - 1] = 'b';
                                }
                            }
                            if (k + 1 < charMatrix.GetLength(1))
                            {
                                if (charMatrix[j, k + 1] != 'B')
                                {
                                    charMatrix[j, k + 1] = 'b';
                                }                               
                            }
                        }
                    }   
                }
                for (int j = 0; j < charMatrix.GetLength(0); j++)
                {
                    for (int k = 0; k < charMatrix.GetLength(1); k++)
                    {
                        if (charMatrix[j, k] == 'b')
                        {
                            charMatrix[j, k] = 'B';
                        }
                    }
                }
                if (playerNextRow < 0 || playerNextRow >= charMatrix.GetLength(0) || playerNextColumn < 0 || playerNextColumn >= charMatrix.GetLength(1))
                {
                    break;
                }
                else if (charMatrix[playerCurrentRow, playerCurrentColumn] == 'B')
                {
                    playerAlive = false;
                    break;
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
            if (playerAlive == false)
            {
                Console.WriteLine($"dead: {playerCurrentRow} {playerCurrentColumn}");
            }
            else if (playerAlive == true)
            {
                Console.WriteLine($"won: {playerCurrentRow} {playerCurrentColumn}");
            }
        }
    }
}
