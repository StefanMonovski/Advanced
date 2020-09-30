using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.Miner
{
    class Program
    {
        static void Main(string[] args)
        {
            int matrixSize = int.Parse(Console.ReadLine());
            char[,] charMatrix = new char[matrixSize, matrixSize];
            List<string> commandDirections = Console.ReadLine().Split().ToList();
            int totalCoal = 0;
            int minerNextRow = 0;
            int minerNextColumn = 0;
            for (int i = 0; i < charMatrix.GetLength(0); i++)
            {
                char[] charRow = Console.ReadLine().Replace(" ", "").ToCharArray();
                for (int j = 0; j < charMatrix.GetLength(1); j++)
                {
                    charMatrix[i, j] = charRow[j];
                    if (charMatrix[i, j] == 'c')
                    {
                        totalCoal++;
                    }
                    if (charMatrix[i, j] == 's')
                    {
                        minerNextRow = i;
                        minerNextColumn = j;
                    }
                }
            }
            int collectedCoal = 0;
            int minerCurrentRow = minerNextRow;
            int minerCurrentColumn = minerNextColumn;
            for (int i = 0; i < commandDirections.Count; i++)
            {
                if (commandDirections[i] == "up")
                {
                    minerNextRow = minerCurrentRow - 1;
                }
                else if (commandDirections[i] == "down")
                {
                    minerNextRow = minerCurrentRow + 1;
                }
                else if (commandDirections[i] == "left")
                {
                    minerNextColumn = minerCurrentColumn - 1;
                }
                else if (commandDirections[i] == "right")
                {
                    minerNextColumn = minerCurrentColumn + 1;
                }  
                if (minerNextRow >= 0 && minerNextRow < charMatrix.GetLength(0) && minerNextColumn >= 0 && minerNextColumn < charMatrix.GetLength(1))
                {
                    if (charMatrix[minerNextRow, minerNextColumn] == 'c')
                    {
                        totalCoal--;
                        collectedCoal++;
                        charMatrix[minerNextRow, minerNextColumn] = '*';
                        if (totalCoal == 0)
                        {
                            Console.WriteLine($"You collected all coals! ({minerNextRow}, {minerNextColumn})");
                            break;
                        }
                    }
                    if (charMatrix[minerNextRow, minerNextColumn] == 'e')
                    {
                        Console.WriteLine($"Game over! ({minerNextRow}, {minerNextColumn})");
                        break;
                    }
                    minerCurrentRow = minerNextRow;
                    minerCurrentColumn = minerNextColumn;
                }
                else
                {
                    minerNextRow = minerCurrentRow;
                    minerNextColumn = minerCurrentColumn;
                }
                if (i == commandDirections.Count - 1)
                {
                    Console.WriteLine($"{totalCoal} coals left. ({minerNextRow}, {minerNextColumn})");
                    break;
                }
            }
        }
    }
}
