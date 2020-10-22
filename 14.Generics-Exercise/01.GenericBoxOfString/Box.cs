using System;
using System.Collections.Generic;
using System.Text;

namespace _01.GenericBoxOfString
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
