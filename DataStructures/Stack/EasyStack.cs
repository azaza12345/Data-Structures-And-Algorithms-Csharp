using System;
using System.Collections.Generic;
using System.Linq;

namespace DataStructures.Stack
{
    public class EasyStack<T> : ICloneable
    {
        private List<T> _items = new List<T>();
        public int Count => _items.Count;
        public bool IsEmpty => Count == 0;

        public void Push(T data)
        {
            _items.Add(data);
        }

        public T Pop()
        {
            if (!IsEmpty)
            {
                var item = _items.FirstOrDefault();
                _items.Remove(item);
                return item;
            }

            throw new NullReferenceException("Stack is Empty");
        }

        public T Peek()
        {
            if (!IsEmpty)
            {
                return _items.FirstOrDefault();;
            }

            throw new NullReferenceException("Stack is Empty");
        }

        public void Clear()
        {
            _items.Clear();
        }

        public override string ToString()
        {
            return "Stack Count: " + Count;
        }

        public object Clone()
        {
            var newStack = new EasyStack<T>();
            newStack._items = new List<T>(_items);
            return newStack;
        }
    }
}