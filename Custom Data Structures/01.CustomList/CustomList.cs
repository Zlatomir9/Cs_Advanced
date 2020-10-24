using System;
using System.Collections.Generic;
using System.Text;

namespace _01.CustomList
{
    public class CustomList
    {
        private const int INITIAL_CAPACITY = 2;
        public CustomList()
        {
            this.Items = new int[INITIAL_CAPACITY];
        }

        private int[] Items { get; set; }
        public int Count { get; private set; }

        public int this[int index]
        {
            get
            {
                if (index >= this.Count)
                {
                    throw new ArgumentOutOfRangeException();
                }
                return Items[index];
            }
            set 
            {
                if (index >= this.Count)
                {
                    throw new ArgumentOutOfRangeException();
                }
                Items[index] = value;
            }
        }
        
        private void Resize() 
        {
            int[] copy = new int[this.Items.Length * 2];

            for (int i = 0; i < this.Items.Length; i++)
            {
                copy[i] = this.Items[i];
            }
            this.Items = copy;
        }

        public void Add(int item) 
        {
            if (this.Count == this.Items.Length)
            {
                this.Resize();
            }

            this.Items[this.Count] = item;
            this.Count++;
        }

        private void Shift(int index) 
        {
            for (int i = index; i < this.Count - 1; i++)
            {
                this.Items[i] = this.Items[i + 1];
            }
        }

        private void Shrink() 
        {
            int[] copy = new int[this.Items.Length / 2];
            for (int i = 0; i < this.Count; i++)
            {
                copy[i] = this.Items[i];
            }
            this.Items = copy;
        }

        public int RemoveAt(int index) 
        {
            if (index >= this.Count)
            {
                throw new ArgumentOutOfRangeException();
            }

            int item = this.Items[index];
            this.Items[index] = default;
            this.Shift(index);

            this.Count--;
            if (this.Count <= this.Items.Length / 4)
            {
                this.Shrink();
            }

            return item;
        }

        private void ShiftToRight(int index) 
        {
            for (int i = Count; i > index; i--)
            {
                this.Items[i] = this.Items[i - 1];
            }
        }

        public void Insert(int index, int element) 
        {
            if (index > this.Count)
            {
                throw new ArgumentOutOfRangeException();
            }

            if (this.Count == this.Items.Length)
            {
                this.Resize();
            }

            this.ShiftToRight(index);
            this.Items[index] = element;
            this.Count++;
        }

        public bool Contains(int element)
        {
            for (int i = 0; i < this.Count; i++)
            {
                int item = this.Items[i];
                if (item == element)
                {
                    return true;
                }
            }

            return false;
        }

        public void Swap(int firstIndex, int secondIndex) 
        {
            if ((this.Count <= firstIndex || firstIndex < 0)
                ||(this.Count <= secondIndex || secondIndex < 0))
            {
                throw new ArgumentOutOfRangeException();
            }

            int element = this.Items[firstIndex];
            this.Items[firstIndex] = this.Items[secondIndex];
            this.Items[secondIndex] = element;
        }
    }
}
