using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _03.WordCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = File.ReadAllLines("../../../Words.txt");
            char[] input = File.ReadAllText("../../../Input.txt").ToLower().ToCharArray();
            Dictionary<string, int> wordsCount = new Dictionary<string, int>();
            foreach (string item in words)
            {
                wordsCount.Add(item, 0);
            }
            int charPosition = 0;
            while (charPosition < input.Length)
            {
                char currentChar;
                string currentWord = "";
                while (Char.IsLetter(currentChar = input[charPosition]))
                {
                    currentWord += currentChar;
                    charPosition++;
                    if (charPosition == input.Length)
                    {
                        break;
                    }
                }
                if (currentWord != "")
                {
                    currentWord = currentWord.ToLower();
                    if (wordsCount.ContainsKey(currentWord))
                    {
                        wordsCount[currentWord]++;
                    }
                }
                if (!Char.IsLetter(currentChar))
                {
                    charPosition++;
                }
            }
            foreach (var item in wordsCount)
            {
                string line = $"{item.Key} - {item.Value}";
                File.AppendAllText("../../../ActualOutput.txt", $"{line}\n");
            }
            foreach (var item in wordsCount.OrderByDescending(x => x.Value))
            {
                string line = $"{item.Key} - {item.Value}";
                File.AppendAllText("../../../ExpectedOutput.txt", $"{line}\n");
            }
            
        }
    }
}
