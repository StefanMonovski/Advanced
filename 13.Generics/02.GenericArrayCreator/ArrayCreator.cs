using System;
using System.Collections.Generic;
using System.Text;

namespace GenericArrayCreator
{
    class ArrayCreator
    {
        public static T[] Create<T>(int length, T item)
        {
            T[] genericArray = new T[length];
            for (int i = 0; i < length; i++)
            {
                genericArray[i] = item;
            }
            return genericArray;
        }
    }
}
