using System;
using System.Collections.Generic;

namespace _04.MatchingBrackets
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<int> indexes = new Stack<int>();
            for (int i = 0; i < input.Length; i++)
            {
                int startIndex = 0;
                int endIndex = 0;
                if (input[i] == '(')
                {
                    indexes.Push(i);
                }
                if (input[i] == ')')
                {
                    startIndex = indexes.Pop();
                    endIndex = i;
                    string substring = input.Substring(startIndex, endIndex - startIndex + 1);
                    Console.WriteLine(substring);
                }
            }
        }
    }
}
