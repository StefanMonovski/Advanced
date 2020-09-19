using System;
using System.Collections.Generic;

namespace _03.SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<char> characters = new Stack<char>(Console.ReadLine());
            string digits = "";
            int output = 0;
            while (characters.Count != 0)
            {               
                char character = characters.Pop();
                if (Char.IsDigit(character))
                {
                    digits += character;
                }
                else if (character == '+' || character == '-')
                {
                    output += GetNumber(digits, character);
                    digits = "";
                }
                if (characters.Count == 0)
                {
                    character = '+';
                    output += GetNumber(digits, character);
                }               
            }          
            Console.WriteLine(output);
        }

        static int GetNumber(string digits, char character)
        {
            char[] digitsArray = digits.ToCharArray();
            Array.Reverse(digitsArray);
            int number = int.Parse(new string(digitsArray));
            if (character == '-')
            {
                return -number;
            }
            else
            {
                return number;
            }
        }
    }
}
