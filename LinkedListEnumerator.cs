using System;
using System.Collections.Generic;
using System.Text;

namespace Hw_12
{
    public class LinkedListEnumerator<T> : IEnumerator<T>
        where T : class
    {
        public LinkedListElement<T> Head { get; set; }

        public LinkedListEnumerator(LinkedListElement<T> head)
        {
            this.Head = head;
        }
        public object Current
        {
            get
            {
                if (Head == null)
                    throw new InvalidOperationException();
                return Head;
            }
        }

        T IEnumerator<T>.Current
        {
            get
            {
                if (Head == null)
                    throw new InvalidOperationException();
                return Head.Value;
            }
        }

        public bool MoveNext()
        {
            if (Head.Next != null)
            {
                Head = Head.Next;
                return true;
            }
            else
                return false;
        }

        public void Reset()
        {
            while (Head.Prev != null)
            {
                Head = Head.Prev;
            }
        }

        public void Dispose()
        { }
    }
}
