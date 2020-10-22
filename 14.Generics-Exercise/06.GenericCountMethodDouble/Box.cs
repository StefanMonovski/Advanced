using System;
using System.Collections.Generic;
using System.Text;

namespace _06.GenericCountMethodDouble
{
    class Box<T> where T : IComparable<T>
    {
        public T GenericBox { get; set; }

        public Box(T item)
        {
            GenericBox = item;
        }

        public int CompareTo(T item)
        {
            return GenericBox.CompareTo(item);
        }

        public override string ToString()
        {
            return $"{GenericBox.GetType()}: {GenericBox}";
        }
    }
}
