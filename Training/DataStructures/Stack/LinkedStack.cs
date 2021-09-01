using System;
using System.Runtime;

namespace DataStructures.Stack
{
    public class LinkedStack<T>
    {
        public Item<T> Head { get; set; }
        public int Count { get; set; }

        public LinkedStack()
        {
            Head = null;
            Count = 0;
        }

        public LinkedStack(T data)
        {
            var item = new Item<T>(data);
            Head = item;
            Count = 1;
        }

        public void Push(T data)
        {
            var item = new Item<T>(data);
            item.Previous = Head;
            Head = item;
            Count++;
        }

        public T Pop()
        {
            if (Count > 0)
            {
                var itemData = Head.Data;
                Head = Head.Previous;
                Count--;
                return itemData;
            }

            throw new NullReferenceException("Stack is Empty");

        }

        public T Peek()
        {
            if (Count > 0)
            {
                return Head.Data;
            }

            throw new NullReferenceException("Stack is Empty");
        }
    }
}