using System;
using System.Collections.Generic;
using System.Linq;

namespace _11.ThePartyReservationFilterModule
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> guests = Console.ReadLine().Split().ToList();
            List<string> filteredGuests = new List<string>();
            List<string> currentFilteredGuests = new List<string>();
            string command = "";
            while ((command = Console.ReadLine()) != "Print")
            {
                string[] commandData = command.Split(";");
                string action = commandData[0];
                string criteria = commandData[1];
                string value = commandData[2];
                Func<List<string>, string, string, List<string>> filterGuestsPredicate = GetFilter(guests, criteria, value);
                currentFilteredGuests = filterGuestsPredicate(guests, criteria, value);
                Func<List<string>, List<string>, string, List<string>> addOrRemovePredicate = AddOrRemove(filteredGuests, currentFilteredGuests, action);
                filteredGuests = addOrRemovePredicate(filteredGuests, currentFilteredGuests, action);
            }
            for (int i = 0; i < guests.Count; i++)
            {
                if (filteredGuests.Contains(guests[i]))
                {
                    guests.Remove(guests[i]);
                    i--;
                }
            }
            Action<List<string>> printGuests = x => Console.WriteLine(string.Join(" ", x));
            printGuests(guests);
        }

        static Func<List<string>, List<string>, string, List<string>> AddOrRemove(List<string> filteredGuests, List<string> currentFilteredGuests, string action)
        {
            switch (action)
            {
                case "Add filter": return (x, y, z) => x.Concat(y).ToList();
                case "Remove filter": return (x, y, z) => x.Where(g => !y.Contains(g)).ToList();
                default: return null;
            }
        }

        static Func<List<string>, string, string, List<string>> GetFilter(List<string> guests, string criteria, string value)
        {
            switch (criteria)
            {
                case "Starts with": return (x, y, z) => x.Where(g => g.Substring(0, z.Length) == z).ToList();
                case "Ends with": return (x, y, z) => x.Where(g => g.Substring(g.Length - z.Length, z.Length) == z).ToList();
                case "Length": return (x, y, z) => x.Where(g => g.Length == int.Parse(z)).ToList();
                case "Contains": return (x, y, z) => x.Where(g => g.Contains(z)).ToList();
                default: return null;
            }
        }
    }
}
