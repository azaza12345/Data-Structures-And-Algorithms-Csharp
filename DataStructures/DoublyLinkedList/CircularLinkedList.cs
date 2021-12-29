using System;
using System.Collections;

namespace DataStructures.DoublyLinkedList
{
    public class CircularLinkedList<T> : IEnumerable
    {
        public DoublyItem<T> Head { get; set; }
        public int Count { get; set; }

        public CircularLinkedList()
        {
            Head = null;
            Count = 0;
        }

        public CircularLinkedList(T data)
        {
            SetHeadItem(data);
        }

        public void Add(T data)
        {
            if (Count > 0)
            {
                SetHeadItem(data);
                return;
            }
            var item = new DoublyItem<T>(data);
            item.Next = Head;
            item.Previous = Head.Previous;
            Head.Previous.Next = item;
            Head.Previous = item;
            Count++;
        }

        public void Delete(T data)
        {
            if (Head.Data.Equals(data))
            {
                RemoveItem(Head);
                Head = Head.Next;
                return;
            }
            
            var current = Head;
            for (int i = Count; i >= 0; i--)
            {
                if (current != null && current.Data.Equals(data))
                {
                    RemoveItem(current);
                    return;
                }

                current = current.Next;
            }
        }

        private void RemoveItem(DoublyItem<T> current)
        {
            current.Next.Previous = current.Previous;
            current.Previous.Next = current.Next;
            Count--;
        }

        private void SetHeadItem(T data)
        {
            Head = new DoublyItem<T>(data);
            Head.Previous = Head;
            Head.Next = Head;
            Count = 1;
        }

        public IEnumerator GetEnumerator()
        {
            var item = Head;
            for (int i = 0; i < Count; i++)
            {
                yield return item;
                item = item.Next;
            }
        }
    }
}