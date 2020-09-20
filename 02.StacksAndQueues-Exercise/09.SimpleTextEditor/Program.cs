using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.SimpleTextEditor
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "";
            int numberCommands = int.Parse(Console.ReadLine());
            Stack<string> textVersions = new Stack<string>();
            textVersions.Push(text);
            for (int i = 0; i < numberCommands; i++)
            {
                List<string> commandData = Console.ReadLine().Split().ToList();
                if (commandData[0] == "1")
                {
                    string appendString = commandData[1];
                    text += appendString;
                    textVersions.Push(text);
                }
                else if (commandData[0] == "2")
                {
                    int eraseCount = int.Parse(commandData[1]);
                    text = text.Remove(text.Length - eraseCount);
                    textVersions.Push(text);
                }
                else if (commandData[0] == "3")
                {
                    int indexReturn = int.Parse(commandData[1]);
                    Console.WriteLine(text[indexReturn - 1]);
                }
                else if (commandData[0] == "4")
                {
                    textVersions.Pop();
                    text = textVersions.Pop();
                    textVersions.Push(text);
                }
            }
        }
    }
}
