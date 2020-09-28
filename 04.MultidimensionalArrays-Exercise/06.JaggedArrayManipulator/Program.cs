using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.JaggedArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int columnSize = int.Parse(Console.ReadLine());
            double[][] doubleJaggedMatrix = new double[columnSize][];
            for (int i = 0; i < columnSize; i++)
            {
                double[] doubleRows = Console.ReadLine().Split().Select(double.Parse).ToArray();
                doubleJaggedMatrix[i] = doubleRows;
            }
            for (int i = 0; i < columnSize - 1; i++)
            {
                if (doubleJaggedMatrix[i].Length == doubleJaggedMatrix[i + 1].Length)
                {
                    for (int j = 0; j < doubleJaggedMatrix[i].Length; j++)
                    {
                        doubleJaggedMatrix[i][j] *= 2; 
                    }
                    for (int j = 0; j < doubleJaggedMatrix[i + 1].Length; j++)
                    {
                        doubleJaggedMatrix[i + 1][j] *= 2;
                    }
                }
                else if (doubleJaggedMatrix[i].Length != doubleJaggedMatrix[i + 1].Length)
                {
                    for (int j = 0; j < doubleJaggedMatrix[i].Length; j++)
                    {
                        doubleJaggedMatrix[i][j] /= 2;
                    }
                    for (int j = 0; j < doubleJaggedMatrix[i + 1].Length; j++)
                    {
                        doubleJaggedMatrix[i + 1][j] /= 2;
                    }
                }
            }
            string command = "";
            while ((command = Console.ReadLine()) != "End")
            {
                List<string> commandData = command.Split().ToList();
                string operation = commandData[0];
                int row = int.Parse(commandData[1]);
                int column = int.Parse(commandData[2]);
                int value = int.Parse(commandData[3]);
                if (row >= 0 && row < doubleJaggedMatrix.GetLength(0) && column >= 0 && column < doubleJaggedMatrix[row].Length)
                {
                    if (operation == "Add")
                    {
                        doubleJaggedMatrix[row][column] += value;
                    }
                    else if (operation == "Subtract")
                    {
                        doubleJaggedMatrix[row][column] -= value;
                    }
                }    
            }
            foreach (double[] item in doubleJaggedMatrix)
            {
                Console.WriteLine(String.Join(" ", item));
            }
        }
    }
}
