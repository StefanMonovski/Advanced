using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int inputNumbers = int.Parse(Console.ReadLine());
            Pollsters pollsters = new Pollsters() { Members = new List<Person>() };
            for (int i = 0; i < inputNumbers; i++)
            {
                string[] input = Console.ReadLine().Split();
                Person person = new Person(input[0], int.Parse(input[1]));
                pollsters.Members.Add(person);
            }
            List<Person> membersOver30 = pollsters.GetMembersOver30();
            foreach (Person item in membersOver30.OrderBy(x => x.Name))
            {
                Console.WriteLine(item.Name + " - " + item.Age);
            }
        }
    }
}
