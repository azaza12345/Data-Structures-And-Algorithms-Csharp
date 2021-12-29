using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace DataStructures.Set
{
    public class EasySet<T> : IEnumerable
    {
        private List<T> _items = new List<T>();
        public int Count => _items.Count;
        
        public EasySet() { }
        
        public EasySet(T item)
        {
            _items.Add(item);
        }

        public EasySet(IEnumerable<T> items)
        {
            _items = items.ToList();
        }

        public void Add(T item)
        {
            if (_items.Contains(item)) return;
            
            _items.Add(item);
        }

        public void Remove(T item)
        {
            _items.Remove(item);
        }

        public EasySet<T> Union(EasySet<T> set)
        {
            return new EasySet<T>(_items.Union(set._items));
        }

        public EasySet<T> Intersection(EasySet<T> set)
        {
            var result = new EasySet<T>();

            foreach (var item in _items)
            {
                foreach (var item1 in _items)
                {
                    if (item.Equals(item1))
                    {
                        result.Add(item);
                        break;
                    }
                }
            }

            return result;
        }

        public EasySet<T> Difference(EasySet<T> set)
        {
            var result = new EasySet<T>(_items);
            foreach (var item in set._items)
            {
                result.Remove(item);
            }

            return result;
        }

        public bool Subset(EasySet<T> set)
        {
            foreach (var item in _items)
            {
                var equals = false;
                foreach (var item1 in set._items)
                {
                    if (item.Equals(item1))
                    {
                        equals = true;
                        break;
                    }
                }

                if (!equals)
                {
                    return false;
                }
            }

            return true;
        }

        public IEnumerator GetEnumerator()
        {
            return _items.GetEnumerator();
        }
    }
}