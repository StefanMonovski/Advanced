using System;
using System.Collections.Generic;
using System.Text;

namespace BoxOfT
{
    public class Box<T>
    {
        public Stack<T> GenericBox { get; set; }
        public int Count { get { return GenericBox.Count; } set { value = GenericBox.Count; } }

        public Box()
        {
            GenericBox = new Stack<T>();
        }

        public void Add(T item)
        {
            GenericBox.Push(item);
        }
        public T Remove()
        {
            return GenericBox.Pop();
        }
    }
}
