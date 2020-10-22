using System;

namespace _01.GenericBoxOfString
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberInput = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberInput; i++)
            {
                string input = Console.ReadLine();
                Box<string> box = new Box<string>(input);
                Console.WriteLine(box.ToString());
            }
        }
    }
}
