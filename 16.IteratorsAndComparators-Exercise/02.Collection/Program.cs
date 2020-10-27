using System;
using System.Linq;

namespace _02.Collection
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] createInput = Console.ReadLine().Split();
            ListyIterator<string> listyIterator = new ListyIterator<string>(createInput.Skip(1).ToList());
            string command = "";
            while ((command = Console.ReadLine()) != "END")
            {
                switch (command)
                {
                    case "Move": Console.WriteLine(listyIterator.Move()); break;
                    case "HasNext": Console.WriteLine(listyIterator.HasNext()); break;
                    case "Print": listyIterator.Print(); break;
                    case "PrintAll": listyIterator.PrintAll(); break;
                }

            }
        }
    }
}
