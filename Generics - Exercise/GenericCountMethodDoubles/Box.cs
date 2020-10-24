using System;
using System.Collections.Generic;

namespace GenericCountMethodDoubles
{
    public class Box<T> where T : IComparable
    {
        public Box(List<T> values)
        {
            this.Values = values;
        }

        public List<T> Values { get; set; }

        public int Count(T element) 
        {
            int count = 0;

            for (int i = 0; i < Values.Count; i++)
            {
                if (element.CompareTo(Values[i]) < 0)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
