using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.Jagged_ArrayModification
{
    class Program
    {
        static void Main(string[] args)
        {
            int columnSize = int.Parse(Console.ReadLine());
            int[][] intJaggedMatrix = new int[columnSize][];
            for (int i = 0; i < columnSize; i++)
            {
                int[] intRows = Console.ReadLine().Split().Select(int.Parse).ToArray();
                intJaggedMatrix[i] = intRows;
            }
            string command = "";
            while ((command = Console.ReadLine()) != "END")
            {
                List<string> commandData = command.Split().ToList();
                string operation = commandData[0];
                int row = int.Parse(commandData[1]);
                int column = int.Parse(commandData[2]);
                int value = int.Parse(commandData[3]);
                if (row >= 0 && row < intJaggedMatrix.GetLength(0) && column >= 0 && column < intJaggedMatrix[row].Length)
                {
                    //if column size
                    if (operation == "Add")
                    {
                        intJaggedMatrix[row][column] += value;
                    }
                    else if (operation == "Subtract")
                    {
                        intJaggedMatrix[row][column] -= value;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid coordinates");
                }
            }
            foreach (int[] item in intJaggedMatrix)
            {
                Console.WriteLine(string.Join(" ", item));
            }
        }
    }
}
