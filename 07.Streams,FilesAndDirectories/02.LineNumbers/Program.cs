using System;
using System.IO;

namespace _02.LineNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader reader = new StreamReader("../../../Input.txt"))
            {
                int counter = 1;
                string line = "";
                using (StreamWriter writer = new StreamWriter("../../../Output.txt"))
                {
                    while ((line = reader.ReadLine()) != null)
                    {
                        writer.WriteLine($"{counter}. {line}");
                        counter++;
                    }
                }
            }
        }
    }
}
