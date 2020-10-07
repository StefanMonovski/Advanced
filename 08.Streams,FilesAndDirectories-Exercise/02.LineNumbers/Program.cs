using System;
using System.IO;

namespace _02.LineNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines("../../../Input.txt");
            for (int i = 0; i < lines.Length; i++)
            {
                string line = lines[i];
                int countLetters = 0;
                int countPunctuations = 0;
                for (int j = 0; j < line.Length; j++)
                {
                    if (Char.IsLetter(line[j]))
                    {
                        countLetters++;
                    }
                    else if (Char.IsPunctuation(line[j]))
                    {
                        countPunctuations++;
                    }
                }
                lines[i] = $"Line {i + 1}:{line} ({countLetters})({countPunctuations})";
            }
            File.WriteAllLines("../../../Output.txt", lines);
        }
    }
}
