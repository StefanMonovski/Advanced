using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01.ListyIterator
{
    class ListyIterator<T>
    {
        public List<T> Elements { get; set; }
        private int index = 0;

        public ListyIterator(List<T> elements)
        {
            Elements = elements;
        }

        public bool Move()
        {
            if (index + 1 < Elements.Count)
            {
                index++;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool HasNext()
        {
            if (index + 1 < Elements.Count)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Print()
        {
            if (Elements.Count == 0)
            {
                Console.WriteLine("Invalid Operation!");
            }
            else
            {
                Console.WriteLine(Elements[index]);
            }
        }
    }
}
