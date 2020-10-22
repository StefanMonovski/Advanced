using System;
using System.Collections.Generic;
using System.Text;

namespace _04.GenericSwapMethodInteger
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
