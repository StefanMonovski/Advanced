using System;
using System.Collections.Generic;

namespace _07.SoftUniParty
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "";
            HashSet<string> vipGuests = new HashSet<string>();
            HashSet<string> regularGuests = new HashSet<string>();
            while ((input = Console.ReadLine()) != "PARTY")
            {
                if (Char.IsDigit(input[0]))
                {
                    vipGuests.Add(input);
                }
                else if (!Char.IsDigit(input[0]))
                {
                    regularGuests.Add(input);
                }
            }
            while ((input = Console.ReadLine()) != "END")
            {
                if (vipGuests.Contains(input))
                {
                    vipGuests.Remove(input);
                }
                else if (regularGuests.Contains(input))
                {
                    regularGuests.Remove(input);
                }
            }
            Console.WriteLine(vipGuests.Count + regularGuests.Count);
            foreach (string item in vipGuests)
            {
                Console.WriteLine(item);
            }
            foreach (string item in regularGuests)
            {
                Console.WriteLine(item);
            }
        }
    }
}
