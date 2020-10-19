using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person()
        {
            Name = "No name";
            Age = 1;
        }
        public Person(int age)
        : this()
        {
            Age = age;
        }
        public Person(string name, int age)
        : this(age)
        {
            Name = name;
        }
    }

    class Pollsters
    {
        public List<Person> Members { get; set; }

        public List<Person> GetMembersOver30()
        {
            List<Person> membersOver30 = new List<Person>();
            foreach (Person item in Members)
            {
                if (item.Age > 30)
                {
                    membersOver30.Add(item);
                }
            }
            return membersOver30;
        }
    }
}
