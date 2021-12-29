using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;

namespace DataStructures.Dictionary
{
    public class MyDictionary<TKey, TValue> : IEnumerable
    {
        private int _size = 100;
        private Item<TKey, TValue>[] _items;

        public MyDictionary()
        {
           _items = new Item<TKey, TValue>[_size];
        }

        public void Add(Item<TKey, TValue> item)
        {
            var hash = GetHash(item.Key);

            if (_items[hash] == null)
            {
                _items[hash] = item;
            }
            else
            {
                var placed = false;
                for (int i = 0; i < _size; i++)
                {
                    if (_items[i].Key.Equals(item.Key))
                    {
                        return;
                    }
                    if (_items[i] == null)
                    {
                        _items[hash] = item;
                        placed = true;
                        break;
                    }
                }

                if (!placed)
                {
                    for (int i = hash; i < _size; i++)
                    {
                        if (_items[i].Key.Equals(item.Key))
                        {
                            return;
                        }
                        if (_items[i] == null)
                        {
                            _items[hash] = item;
                            placed = true;
                            break;
                        }
                    }
                }

                if (!placed)
                {
                    throw new Exception("Dictionary is full");
                }
            }
        }

        public void Remove(TKey key)
        {
            var hash = GetHash(key);

            if (_items[hash].Key.Equals(key))
            {
                _items[hash] = null;
            }
            else
            {
                var placed = false;
                for (int i = 0; i < _size; i++)
                {
                    if (_items[i].Key.Equals(key))
                    {
                        _items[hash] = null;
                        return;
                    }
                    if (_items[i] == null)
                    {
                        return;
                    }
                }

                if (!placed)
                {
                    for (int i = hash; i < _size; i++)
                    {
                        if (_items[i].Key.Equals(key))
                        {
                            _items[hash] = null;
                            return;
                        }
                        if (_items[i] == null)
                        {
                            return;
                        }
                    }
                }
                if (!placed)
                {
                    throw new Exception("Dictionary is full");
                }
            }
        }

        public TValue Search(TKey key)
        {
            var hash = GetHash(key);

            if (_items[hash] == null)
            {
                return default;
            }
            if (_items[hash].Key.Equals(key))
            {
                return _items[hash].Value;
            }
            else
            {
                var placed = false;
                for (int i = 0; i < _size; i++)
                {
                    if (_items[i] == null)
                    {
                        return default;
                    }
                    if (_items[i].Key.Equals(key))
                    {
                        return _items[hash].Value;
                    }
                }

                if (!placed)
                {
                    for (int i = hash; i < _size; i++)
                    {
                        if (_items[i] == null)
                        {
                            return default;
                        }
                        if (_items[i].Key.Equals(key))
                        {
                            return _items[hash].Value;
                        }
                    }
                }
            }

            return default;
        }

        private int GetHash(TKey key)
        {
            return key.GetHashCode() % _size;
        }

        public IEnumerator GetEnumerator()
        {
            foreach (var item in _items)
            {
                if (item != null)
                {
                    yield return item;
                }
            }
        }
    }
}