using System;
using System.Collections.Generic;
using System.Text;

namespace _07.Tuple
{
    class GenericTuple<T1, T2>
    {
        public T1 FirstItem { get; set; }
        public T2 SecondItem { get; set; }

        public GenericTuple(T1 firstItem, T2 secondItem)
        {
            FirstItem = firstItem;
            SecondItem = secondItem;
        }

        public override string ToString()
        {
            return $"{FirstItem} -> {SecondItem}";
        }
    }
}
