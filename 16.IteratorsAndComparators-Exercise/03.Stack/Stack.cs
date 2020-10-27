using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03.Stack
{
    class Stack<T> : IEnumerable<T>
    {
        public List<T> Elements { get; set; }
        private int index = -1;

        public Stack(List<T> elements)
        {
            Elements = elements;
            index += elements.Count;
        }

        public void Push(params T[] pushElements)
        {
            foreach (T item in pushElements)
            {
                Elements.Add(item);
                index++;
            }
        }

        public void Pop()
        {
            if (index < 0)
            {
                Console.WriteLine("No elements");
            }
            else
            {
                Elements.RemoveAt(index);
                index--;
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = index; i >= 0; i--)
            {
                yield return Elements[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
