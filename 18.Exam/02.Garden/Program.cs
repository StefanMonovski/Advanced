using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Garden
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] matrixSizes = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[,] flowersMatrix = new int[matrixSizes[0], matrixSizes[1]];
            List<int[]> plantedFlowersPositions = new List<int[]>();
            for (int i = 0; i < flowersMatrix.GetLength(0); i++)
            {
                for (int j = 0; i < flowersMatrix.GetLength(1); i++)
                {
                    flowersMatrix[i, j] = 0;
                }
            }
            string input = "";
            while ((input = Console.ReadLine()) != "Bloom Bloom Plow")
            {
                int[] inputData = input.Split().Select(int.Parse).ToArray();
                if (inputData[0] >= 0 && inputData[0] < flowersMatrix.GetLength(0) && inputData[1] >= 0 && inputData[1] < flowersMatrix.GetLength(1))
                {
                    flowersMatrix[inputData[0], inputData[1]] = 1;
                    plantedFlowersPositions.Add(new int[] { inputData[0], inputData[1] });
                }
                else
                {
                    Console.WriteLine("Invalid coordinates.");
                }
            }
            foreach (int[] item in plantedFlowersPositions)
            {
                int x = item[0];
                int y = item[1];
                for (int i = 0; i < flowersMatrix.GetLength(0); i++)
                {
                    for (int j = 0; j < flowersMatrix.GetLength(1); j++)
                    {
                        if (i == x && j != y)
                        {
                            flowersMatrix[i, j] += 1;
                        }
                        if (j == y && i != x)
                        {
                            flowersMatrix[i, j] += 1;
                        }
                    }
                }
            }
            for (int i = 0; i < flowersMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < flowersMatrix.GetLength(1); j++)
                {
                    Console.Write(flowersMatrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
