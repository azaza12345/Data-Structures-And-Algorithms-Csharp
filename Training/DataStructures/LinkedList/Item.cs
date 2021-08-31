using System;

namespace Training.DataStructure
{
    public class Item<T>
    {
        private T _data;
        public Item<T> Next { get; set; }

        public Item(T data)
        {
            _data = data;
        }

        public T Data
        {
            get => _data;
            set
            {
                if (value == null)
                    throw new ArgumentNullException(nameof(value));
                _data = value;
            }
        }

        public override string ToString()
        {
            return Data.ToString();
        }
    }
}