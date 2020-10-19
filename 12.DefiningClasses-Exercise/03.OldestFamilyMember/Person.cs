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

    class Family
    {
        public List<Person> Members { get; set; }

        public void AddMember(Person member)
        {
            Members.Add(member);
        }
        public Person GetOldestMember()
        {
            Person oldestMember = new Person();
            int oldestAge = int.MinValue;
            foreach (Person item in Members)
            {
                if (item.Age > oldestAge)
                {
                    oldestAge = item.Age;
                    oldestMember = item;
                }
            }
            return oldestMember;
        }
    }
}
