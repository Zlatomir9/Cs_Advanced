using System;
using System.Collections.Generic;
using System.Text;

namespace GenericCountMethodStrings
{
    public class Box<T> where T : IComparable
    {
        public List<T> Values { get; set; }

        public Box(List<T> values)
        {
            this.Values = values;
        }

        public int Count(T element)
        {
            int count = 0;

            foreach (T item in Values)
            {
                if (element.CompareTo(item) < 0)
                {
                    count++;
                }
            }

            return count;
        }
    }
}
