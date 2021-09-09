using System;
using System.Collections.Generic;
using System.Text;

namespace Hw_12
{
    public class LinkedList<T> where T : class 
    {
        public LinkedListElement<T> Head { get; private set; }

        public LinkedList(T head)
        {
            Head = new LinkedListElement<T> { Value = head };
        }

        public void Add(T value)
        {
            var newElement = new LinkedListElement<T>
            {
                Value = value,
                Prev = Last()
            };
            Last().Next = newElement;
        }

        public LinkedListElement<T> Last()
        {
            var current = Head;

            while (current.Next != null)
            {
                current = current.Next;
            }
            return current;
        }

        public void Reverse()
        {
            Head = Last();
            var current = Last();
            Swap(current);
            while (current.Next != null)
            {
                current = current.Next;
                Swap(current);
            }
        }

        private void Swap(LinkedListElement<T> element)
        {
            var prev = element.Prev;
            element.Prev = element.Next;
            element.Next = prev;
        }

        public IEnumerator<T> GetEnumerator()
        {
            return new LinkedListEnumerator<T>(Head);
        }
    }
    
}
