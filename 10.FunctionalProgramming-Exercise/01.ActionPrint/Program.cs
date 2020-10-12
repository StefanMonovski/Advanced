using System;

namespace _01.ActionPrint
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();
            Action<string> printWord = x => Console.WriteLine(x);
            foreach (string item in words)
            {
                printWord(item);
            }
        }
    }
}
