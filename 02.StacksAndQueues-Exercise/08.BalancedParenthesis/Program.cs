using System;
using System.Collections.Generic;

namespace _08.BalancedParenthesis
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] input = Console.ReadLine().ToCharArray();
            Stack<char> parenthesis = new Stack<char>();
            bool balanced = true;
            if (input.Length % 2 == 0)
            {
                for (int i = 0; i < input.Length; i++)
                {
                    if (input[i] == '(' || input[i] == '[' || input[i] == '{')
                    {
                        parenthesis.Push(input[i]);
                    }
                    if (input[i] == ')' || input[i] == ']' || input[i] == '}')
                    {
                        string currentBracket = string.Concat(parenthesis.Pop(), input[i]);
                        if (currentBracket != "()" && currentBracket != "[]" && currentBracket != "{}")
                        {
                            balanced = false;
                            break;
                        }
                    }
                }
            }
            else
            {
                balanced = false;
            }
            if (balanced)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }          
        }
    }
}
