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
            HashSet<string> words = new HashSet<string>();
            using (StreamReader reader = new StreamReader("../../../Words.txt"))
            {
                string[] wordsArray = reader.ReadToEnd().Split();
                foreach (string item in wordsArray)
                {
                    words.Add(item);
                }
            }
            Dictionary<string, int> wordsCount = new Dictionary<string, int>();
            using (StreamReader reader = new StreamReader("../../../Input.txt"))
            {
                int charPosition = 0;
                while (charPosition < reader.BaseStream.Length)
                {
                    char currentChar;
                    string currentWord = "";
                    while (Char.IsLetter(currentChar = (char)reader.Read()))
                    {
                        currentWord += currentChar;
                        charPosition++;
                        if (charPosition == reader.BaseStream.Length)
                        {
                            break;
                        }
                    }
                    if (currentWord != "")
                    {
                        currentWord = currentWord.ToLower();
                        if (words.Contains(currentWord))
                        {
                            if (wordsCount.ContainsKey(currentWord))
                            {
                                wordsCount[currentWord]++;
                            }
                            else
                            {
                                wordsCount.Add(currentWord, 1);
                            }
                        }
                    }
                    if (!Char.IsLetter(currentChar))
                    {
                        charPosition++;
                    }
                }  
            }
            using (StreamWriter writer = new StreamWriter("../../../Output.txt"))
            {
                foreach (var item in wordsCount.OrderByDescending(x => x.Value))
                {
                    writer.WriteLine($"{item.Key} - {item.Value}");
                }
            }
        }
    }
}
