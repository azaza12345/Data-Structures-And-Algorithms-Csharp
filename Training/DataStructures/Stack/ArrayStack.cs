using System;

namespace DataStructures.Stack
{
    public class ArrayStack<T>
    {
        private T[] _items;
        private int _current = -1;
        private readonly int _size = 10;

        public ArrayStack(int size = 10)
        {
            _items = new T[size];
            _size = size;
        }

        public ArrayStack(T data, int size = 10) : this(size)
        {
            _items[0] = data;
            _current = 1;
        }

        public void Push(T data)
        {
            if (_current < _size)
            {
                _current++;
                _items[_current] = data;
            }
            else
            {
                throw new StackOverflowException("Stack Overflow");
            }
        }

        public T Pop()
        {
            if (_current > 0)
            {
                var item = _items[_current];
                _current--;
                return item;
            }
            throw new NullReferenceException();
        }

        public T Peek()
        {
            if (_current > 0)
            {
                return _items[_current];
            }
            throw new NullReferenceException();
        }
        
        
    }
}