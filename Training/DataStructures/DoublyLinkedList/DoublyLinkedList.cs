using System;
using System.Collections;

namespace DataStructures.DoublyLinkedList
{
    public class DoublyLinkedList<T> : IEnumerable
    {
        public DoublyItem<T> Head { get; set; }
        public DoublyItem<T> Tail { get; set; }
        public int Count { get; set; }

        public DoublyLinkedList()
        {
            Head = null;
            Tail = null;
            Count = 0;
        }

        public DoublyLinkedList(T data)
        {
            var item = new DoublyItem<T>(data);
            Head = item;
            Tail = item;
            Count++;
        }

        public void Add(T data)
        {
            var item = new DoublyItem<T>(data);
            if (Count != 0)
            {
                Tail.Next = item;
                item.Previous = Tail;
                Tail = item;
                Count++;
            }
            else
            {
                Head = item;
                Tail = item;
                Count++;
            }
        }

        public void Delete(T data)
        {
            var currentItem = Head;

            if (Head.Data.Equals(data))
            {
                Head = Head.Next;
                Head.Previous = null;
                return;
            }

            while (currentItem != null)
            {
                if (currentItem.Data.Equals(data))
                {
                    currentItem.Previous.Next = currentItem.Next;
                    currentItem.Next.Previous = currentItem.Previous;
                    return;
                }

                currentItem = currentItem.Next;
            }
        }

        public DoublyLinkedList<T> Reverse()
        {
            var result = new DoublyLinkedList<T>();
            var item = Tail;

            while (item != null)
            {
                result.Add(item.Data);
                item = item.Previous;
            }

            return result;
        }

        public IEnumerator GetEnumerator()
        {
            var item = Head;
            while (item != null)
            {
                yield return item.Data;
                item = item.Next;
            }
        }
    }
}