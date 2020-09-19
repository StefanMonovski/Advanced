using System;
using System.Collections.Generic;

namespace _06.SongsQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> songs = new Queue<string>(Console.ReadLine().Split(", "));
            while (songs.Count != 0)
            {
                string command = Console.ReadLine();
                if (command == "Play")
                {
                    songs.Dequeue();
                }
                if (command == "Show")
                {
                    Console.WriteLine(String.Join(", ", songs));
                }
                if (command.Contains("Add"))
                {
                    string addSong = command.Substring(4);
                    if (songs.Contains(addSong))
                    {
                        Console.WriteLine($"{addSong} is already contained!");
                    }
                    else
                    {
                        songs.Enqueue(addSong);
                    }
                }
            }
            Console.WriteLine("No more songs!");
        }
    }
}
