using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace _02.Collection
{
    class ListyIterator<T> : IEnumerable<T>
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

        public void PrintAll()
        {
            foreach (T item in Elements)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (T item in Elements)
            {
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
