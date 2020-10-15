using System;
using System.Collections.Generic;
using System.Linq;

namespace _10.PredicateParty_
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> guests = Console.ReadLine().Split().ToList();
            string command = "";
            while ((command = Console.ReadLine()) != "Party!")
            {
                string[] commandData = command.Split();
                string action = commandData[0];
                string criteria = commandData[1];
                string value = commandData[2];
                Func<List<string>, string, string, List<string>> getSelectedGuestsPredicate = GetSelectedGuests(guests, criteria, value);
                List<string> selectedGuests = getSelectedGuestsPredicate(guests, criteria, value);
                guests = RemoveOrDoubleGuests(guests, selectedGuests, action);
            }
            if (guests.Count != 0)
            {
                string guestsOutput = string.Join(", ", guests);
                Action<string> printGuestsOutput = x => Console.WriteLine($"{x} are going to the party!");
                printGuestsOutput(guestsOutput);
            }
            else
            {
                Console.WriteLine("Nobody is going to the party!");
            }
        }

        static Func<List<string>, string, string, List<string>> GetSelectedGuests(List<string> guests, string criteria, string value)
        {
            switch (criteria)
            {
                case "StartsWith": return (x, y, z) => x.Where(g => g.Substring(0, z.Length) == z).ToList();
                case "EndsWith": return (x, y, z) => x.Where(g => g.Substring(g.Length - z.Length, z.Length) == z).ToList();
                case "Length": return (x, y, z) => x.Where(g => g.Length == int.Parse(z)).ToList();
                default: return null;
            }
        }

        static List<string> RemoveOrDoubleGuests(List<string> guests, List<string> selectedGuests, string action)
        {
            if (action == "Remove")
            {
                for (int i = 0; i < guests.Count; i++)
                {
                    if (selectedGuests.Contains(guests[i]))
                    {
                        guests.Remove(guests[i]);
                        i--;
                    }
                }
            }
            else if (action == "Double")
            {
                for (int i = 0; i < guests.Count; i++)
                {
                    if (selectedGuests.Contains(guests[i]))
                    {
                        guests.Insert(i, guests[i]);
                        i++;
                    }
                }
            }
            return guests;
        }
    }
}
