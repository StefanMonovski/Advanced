using System;

namespace _07.PascalTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            long columnSize = long.Parse(Console.ReadLine());
            long[][] intJaggedMatrix = new long[columnSize][];
            long[] firstRow = new long[3] { 0, 1, 0 };
            intJaggedMatrix[0] = firstRow;
            long[] previousRow = firstRow;
            for (int i = 1; i < columnSize; i++)
            {
                long[] nextRow = new long[previousRow.Length + 1];
                for (int j = 0; j < previousRow.Length - 1; j++)
                {
                    nextRow[j + 1] = previousRow[j] + previousRow[j + 1];
                }
                intJaggedMatrix[i] = nextRow;
                previousRow = nextRow;
            }
            foreach (long[] item in intJaggedMatrix)
            {
                for (int i = 1; i < item.Length - 1; i++)
                {
                    Console.Write(item[i] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
