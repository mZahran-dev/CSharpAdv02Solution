using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advance02
{
    internal class FixedSizeList<T>
    {
        #region Properties
        private T[] _items;
        private int _count;

        public int Count
        {
            get { return _count; } 
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Count cannot be negative.");
                }
                _count = value;
            }
        }
        public int Capacity
        {
            get { return _items.Length; } 
        }
        #endregion

        #region Constructor
        public FixedSizeList(int capacity)
        {
            if (capacity < 0)
            {
                throw new ArgumentException("Capacity must be a non-negative number.");
            }
            _items = new T[capacity];
            _count = 0;
        } 
        #endregion

        #region Methods
        public void Add(T item)
        {
            if (_count >= _items.Length)
            {
                throw new InvalidOperationException("List is full. Cannot add more items.");
            }
            _items[_count] = item;
            _count++;
        }

        public T Get(int index)
        {
            if (index < 0 || index >= _count)
            {
                throw new ArgumentOutOfRangeException("Index is out of range.");
            }
            return _items[index];
        } 
        #endregion


    }
}
