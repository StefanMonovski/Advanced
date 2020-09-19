using System;
using System.Collections.Generic;

namespace _01.ReverseStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<char> input = new Stack<char>(Console.ReadLine());
            string output = "";
            while (input.Count != 0)
            {
                output += input.Pop();
            }
            Console.WriteLine(output);
        }
    }
}
