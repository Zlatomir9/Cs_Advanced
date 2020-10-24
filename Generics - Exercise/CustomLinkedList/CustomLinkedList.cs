using System;

namespace CustomLinkedList
{
    public class CustomLinkedList<T>
    {
        private class ListNode
        {
            public ListNode(T value)
            {
                this.Value = value;
            }
            public T Value { get; set; }

            public ListNode NextNode { get; set; }
            public ListNode PreviousNode { get; set; }
        }

        private ListNode head;
        private ListNode tail;
        public int Count { get; set; }

        public void AddHead(T element)
        {
            if (this.Count == 0)
            {
                this.head = this.tail = new ListNode(element);
            }
            else
            {
                ListNode newHead = new ListNode(element);
                newHead.NextNode = this.head;
                this.head.PreviousNode = newHead;
                this.head = newHead;
            }

            this.Count++;
        }

        public void AddTail(T element)
        {
            if (this.Count == 0)
            {
                this.head = this.tail = new ListNode(element);
            }
            else
            {
                ListNode newTail = new ListNode(element);
                newTail.PreviousNode = this.tail;
                this.tail.NextNode = newTail;
                this.tail = newTail;
            }

            this.Count++;
        }

        public T RemoveFirst()
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException("The list is empty");
            }

            T firstElement = this.head.Value;
            this.head = this.head.NextNode;

            if (this.head != null)
            {
                this.head.PreviousNode = null;
            }
            else
            {
                this.tail = null;
            }
            this.Count--;
            return firstElement;
        }

        public T RemoveLast()
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException("The list is empty");
            }

            var lastElement = this.tail.Value;
            this.tail = this.tail.PreviousNode;

            if (this.tail != null)
            {
                this.tail.NextNode = null;
            }
            else
            {
                this.head = null;
            }
            this.Count--;
            return lastElement;
        }

        public void ForEach(Action<T> action)
        {
            var currentNode = this.head;

            while (currentNode != null)
            {
                action(currentNode.Value);
                currentNode = currentNode.NextNode;
            }
        }

        public T[] ToArray()
        {
            T[] array = new T[this.Count];
            int counter = 0;
            var currentNode = this.head;

            while (currentNode != null)
            {
                array[counter] = currentNode.Value;
                currentNode = currentNode.NextNode;
                counter++;
            }
            return array;
        }
    }
}
