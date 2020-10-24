using System;

namespace _02.CustomStack
{
    public class CustomStack
    {
        private const int INITIAL_CAPACITY = 4;
        private int[] items;

        public CustomStack()
        {
            this.items = new int[INITIAL_CAPACITY];
        }

        public int Count { get; private set; }

        public void Push(int element) 
        {
            if (this.items.Length == this.Count)
            {
                int[] copy = new int[this.items.Length * 2];
                for (int i = 0; i < this.items.Length; i++)
                {
                    copy[i] = this.items[i];
                }
                this.items = copy;
            }

            this.items[this.Count] = element;
            Count++;
        }

        public int Pop() 
        {
            if (this.Count == 0)
            {
                throw new System.Exception("CustomStack is empty");
            }

            int lastItem = this.items[this.Count - 1];
            this.items[this.Count - 1] = default;
            this.Count--;
            return lastItem;
        }

        public int Peek() 
        {
            if (this.Count == 0)
            {
                throw new System.Exception("CustomStack is empty!");
            }

            int lastItem = this.items[this.Count - 1];
            return lastItem;
        }

        public void ForEach(Action<int> action) 
        {
            for (int i = 0; i < this.Count; i++)
            {
                action(this.items[i]);
            }
        }
    }
}
