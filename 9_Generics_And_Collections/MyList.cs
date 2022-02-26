using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_Generics_And_Collections
{
    public class MyList<T> : IEnumerable
    {
        private T[] _items;
        private const int _defaultCapacity = 4;
        public int currentPosition = 0;

        public MyList()
        {
            _items = new T[_defaultCapacity];
        }

        public T GetItem(int i)
        {
            return _items[i];
        }

        public T[] GetAllItems()
        {
            return _items;
        }

        public void Update(int index, T value)
        {
            _items[index] = value;
        }

        public void Add(T item)
        {
            if (currentPosition == _items.Length)
            {
                _items = EnsureCapacity(currentPosition);

            }
            _items[currentPosition] = item;
            currentPosition++;
        }

        public void Delete(int index)
        {
            _items[index] = default;
        }



        public int Length()
        {
            return _items.Length;
        }

        public void SwapByIndex(int index1, int index2)
        {
            T stock = _items[index2];
            _items[index2] = _items[index1];
            _items[index1] = stock;
        }

        public void SwapByValue(T item1, T item2)
        {
            int index1 = Array.IndexOf(_items, item1);
            int index2 = Array.IndexOf(_items, item2);
            SwapByIndex(index1, index2);
        }

        private T[] EnsureCapacity(int lastLength)
        {
            //  if ((uint)newCapacity > Array.MaxLength) newCapacity = Array.MaxLength;

            if (Array.MaxLength < lastLength * 2)
            {
                T[] new_item = new T[Array.MaxLength];
                int newCopyPosition = currentPosition - _items.Length;
                _items.CopyTo(new_item, newCopyPosition);
                return new_item;
            }
            else
            {
                T[] new_item = new T[lastLength * 2];
                int newCopyPosition = currentPosition - _items.Length;
                _items.CopyTo(new_item, newCopyPosition);
                return new_item;
            }


        }

        public T this[int i]
        {
            get => _items[i];
            set
            {
                if (currentPosition == _items.Length)
                {
                    _items = EnsureCapacity(currentPosition);


                }

                _items[i] = value;
                currentPosition++;


            }
            //_items[i] = value;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator)GetEnumerator();
        }

        private GeneralEnum GetEnumerator()
        {
            return new GeneralEnum(_items);
        }

        public class GeneralEnum : IEnumerator
        {
            public T[] _items;

            // Enumerators are positioned before the first element
            // until the first MoveNext() call.
            int position = -1;

            public GeneralEnum(T[] listOfElements)
            {
                _items = listOfElements;
            }

            public bool MoveNext()
            {
                position++;
                return (position < _items.Length);
            }

            public void Reset()
            {
                position = -1;
            }

            object IEnumerator.Current
            {
                get
                {
                    return Current;
                }
            }

            public T Current
            {
                get
                {
                    try
                    {
                        return _items[position];
                    }
                    catch (IndexOutOfRangeException)
                    {
                        throw new InvalidOperationException();
                    }
                }
            }

        }
    }
}
