using System;
using System.Collections.Generic;
using System.Text;

namespace _02.GenericBoxOfInteger
{
    class Box<T>
    {
        public T GenericBox { get; set; }

        public Box(T item)
        {
            GenericBox = item;
        }

        public override string ToString()
        {
            return $"{GenericBox.GetType()}: {GenericBox}";
        }
    }
}
