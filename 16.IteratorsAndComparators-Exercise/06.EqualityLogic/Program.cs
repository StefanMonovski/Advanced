using System;
using System.Collections.Generic;

namespace _06.EqualityLogic
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedSet<Person> peopleSortedSet = new SortedSet<Person>();
            HashSet<Person> peopleHashSet = new HashSet<Person>();
            int numberInput = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberInput; i++)
            {
                string[] inputData = Console.ReadLine().Split();
                peopleSortedSet.Add(new Person(inputData[0], int.Parse(inputData[1])));
                peopleHashSet.Add(new Person(inputData[0], int.Parse(inputData[1])));
            }
            Console.WriteLine(peopleSortedSet.Count);
            Console.WriteLine(peopleHashSet.Count);
        }
    }
}
