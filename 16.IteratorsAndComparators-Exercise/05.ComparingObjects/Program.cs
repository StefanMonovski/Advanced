using System;
using System.Collections.Generic;

namespace _05.ComparingObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            string input = "";
            while ((input = Console.ReadLine()) != "END")
            {
                string[] inputData = input.Split();
                Person person = new Person(inputData[0], int.Parse(inputData[1]), inputData[2]);
                people.Add(person);
            }
            int comparePosition = int.Parse(Console.ReadLine()) - 1;
            int countMatches = 0;
            int countNotMatches = 0;
            foreach (Person item in people)
            {
                int compare = people[comparePosition].CompareTo(item);
                if (compare == 0)
                {
                    countMatches++;
                }
                else
                {
                    countNotMatches++;
                }
            }
            if (countMatches == 1)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine($"{countMatches} {countNotMatches} {people.Count}");
            }
        }
    }
}
