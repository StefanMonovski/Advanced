using System;
using System.Collections.Generic;
using System.IO;

namespace _04.MergeFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> firstInput = new List<string>();
            using (StreamReader reader = new StreamReader("../../../Input1.txt"))
            {
                string line = "";
                while ((line = reader.ReadLine()) != null)
                {
                    firstInput.Add(line);
                }
            }
            List<string> secondInput = new List<string>();
            using (StreamReader reader = new StreamReader("../../../Input2.txt"))
            {
                string line = "";
                while ((line = reader.ReadLine()) != null)
                {
                    secondInput.Add(line);
                }
            }
            int shortInputCount = Math.Min(firstInput.Count, secondInput.Count);
            using (StreamWriter writer = new StreamWriter("../../../Output.txt"))
            {
                for (int i = 0; i < shortInputCount; i++)
                {
                    writer.WriteLine(firstInput[i]);
                    writer.WriteLine(secondInput[i]);
                }
                if (firstInput.Count > shortInputCount)
                {
                    for (int i = shortInputCount; i < firstInput.Count; i++)
                    {
                        writer.WriteLine(firstInput[i]);
                    }
                }
                else if (secondInput.Count > shortInputCount)
                {
                    for (int i = shortInputCount; i < secondInput.Count; i++)
                    {
                        writer.WriteLine(secondInput[i]);
                    }
                }
            }
        }
    }
}
