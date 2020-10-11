using System;
using System.Collections.Generic;

namespace _05.FilterByAge
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            int numberInputs = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberInputs; i++)
            {
                string[] input = Console.ReadLine().Split(", ");
                people.Add(new Person(input[0], int.Parse(input[1])));
            }
            string condition = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            string format = Console.ReadLine();
            Func<Person, bool> conditionDelegate = CheckAgeCondition(condition, age);
            Action<Person> printDelegate = PrintCheckedPeople(format);
            foreach (Person item in people)
            {
                if (conditionDelegate(item))
                {
                    printDelegate(item);
                }
            }
        }

        static Func<Person, bool> CheckAgeCondition(string condition, int age)
        {
            switch (condition)
            {
                case "younger": return x => x.Age < age;
                case "older": return x => x.Age >= age;
                default: return null;
            }
        }

        static Action<Person> PrintCheckedPeople(string format)
        {
            switch (format)
            {
                case "name": return x => Console.WriteLine(x.Name);
                case "age": return x => Console.WriteLine(x.Age);
                case "name age": return x => Console.WriteLine($"{x.Name} - {x.Age}");
                default: return null;
            }
        }
    }

    public class Person
    {
        public string Name;
        public int Age;

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
}
