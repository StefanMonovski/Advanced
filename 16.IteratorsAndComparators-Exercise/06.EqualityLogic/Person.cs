using System;
using System.Collections.Generic;
using System.Text;

namespace _06.EqualityLogic
{
    class Person : IComparable<Person>
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public int CompareTo(Person other)
        {
            int result = Name.CompareTo(other.Name);
            if (result == 0)
            {
                result = Age.CompareTo(other.Age);
            }
            return result;
        }

        public override bool Equals(object obj)
        {
            Person personObj = obj as Person;
            bool result = Name.Equals(personObj.Name);
            if (result == true)
            {
                result = Age.Equals(personObj.Age);
            }
            return result;
        }

        public override int GetHashCode()
        {
            int hash = 13;
            hash = (hash * 7) + Name.GetHashCode() + Age.GetHashCode();
            return hash;
        }
    }
}
