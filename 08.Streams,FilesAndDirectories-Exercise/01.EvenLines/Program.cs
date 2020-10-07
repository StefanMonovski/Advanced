using System;
using System.IO;
using System.Text.RegularExpressions;

namespace _01.EvenLines
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
                        if (counter % 2 == 0)
                        {
                            string pattern = @"[-,.!?]";
                            line = Regex.Replace(line, pattern, "@");
                            string[] lineAsArray = line.Split();
                            Array.Reverse(lineAsArray);
                            line = string.Join(" ", lineAsArray);
                            writer.WriteLine(line);
                        }
                        counter++;
                    }
                }
            }
        }
    }
}
