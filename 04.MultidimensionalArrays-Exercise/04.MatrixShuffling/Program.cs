using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.MatrixShuffling
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] matrixSizes = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string[,] stringMatrix = new string[matrixSizes[0], matrixSizes[1]];
            for (int i = 0; i < stringMatrix.GetLength(0); i++)
            {
                string[] stringRows = Console.ReadLine().Split().ToArray();
                for (int j = 0; j < stringMatrix.GetLength(1); j++)
                {
                    stringMatrix[i, j] = stringRows[j];
                }
            }
            string command = "";
            while ((command = Console.ReadLine()) != "END")
            {
                List<string> commandData = command.Split().ToList();
                if (commandData[0] == "swap" && commandData.Count == 5)
                {
                    int x1 = int.Parse(commandData[1]);
                    int x2 = int.Parse(commandData[2]);
                    int y1 = int.Parse(commandData[3]);
                    int y2 = int.Parse(commandData[4]);
                    if (x1 >= 0 && x1 < stringMatrix.GetLength(0) && y1 >= 0 && y1 < stringMatrix.GetLength(0) && x2 >= 0 && x2 < stringMatrix.GetLength(1) && y2 >= 0 && y2 < stringMatrix.GetLength(1))
                    {
                        string tempValue = stringMatrix[x1, x2];
                        stringMatrix[x1, x2] = stringMatrix[y1, y2];
                        stringMatrix[y1, y2] = tempValue;
                        for (int i = 0; i < stringMatrix.GetLength(0); i++)
                        {
                            for (int j = 0; j < stringMatrix.GetLength(1); j++)
                            {
                                Console.Write(stringMatrix[i, j] + " ");
                            }
                            Console.WriteLine();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input!");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }
                
            }
        }
    }
}
