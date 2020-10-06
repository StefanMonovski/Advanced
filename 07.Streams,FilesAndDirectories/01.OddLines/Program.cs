using System;
using System.IO;

namespace _01.OddLines
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader reader = new StreamReader("../../../Input.txt"))
            {
                int counter = 0;
                string line = "";
                using (StreamWriter writer = new StreamWriter("../../../Output.txt"))
                {
                    while ((line = reader.ReadLine()) != null)
                    {
                        if (counter % 2 == 1)
                        {
                            writer.WriteLine(line);
                        }
                        counter++;
                    }
                }
            }
        }
    }
}
