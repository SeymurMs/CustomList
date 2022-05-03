using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CustomLists
{
    internal class CustomList<T> : IEnumerable<T>
    {
       private int _index;
        private T[] _arr;
        public int Capacity
        {
            get => _arr.Length;
            set
            {
                if (value > 0)
                {
                    _arr = new T[value];
                }
                else
                {
                    _arr = new T[0];
                }
               
            }
        }
        public int Count { get=> _index;}
        public T this[int index]
        {
            get => _arr[index];
            set => _arr[index] = value;
        }

        public IEnumerator<T> GetEnumerator()
        {

            for (int i = 0; i < Count; i++)
            {
                yield return _arr[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
        public void CustomAddList(T element)
        {
            _index++;
            if (_index==1)
            {
                Capacity = 4;
                Array.Resize(ref _arr,Capacity);
                _arr[Count - 1] = element;
            }
            else if (Capacity>Count)
            {
                Array.Resize(ref _arr, _arr.Length);
                _arr[Count-1] = element;
            }
            else
            {
                Array.Resize(ref _arr, _arr.Length + Capacity);
                _arr[Count - 1] = element;

            }
               
            
           
        }

        public bool CustomContainsList(T element)
        {


            for (int i = 0; i < _arr.Length; i++)
            {

                if (_arr[i].Equals(element))
                {
                    return true;
                }
            }
            return false;
        }
        public bool CustomExistsListV2(Predicate<T> x)
        {
            for (int i = 0; i < _arr.Length; i++)
            {
                if (x(_arr[i]))
                {
                    return true;
                }
            }
            return false;
        }
        public T CustumFindList(Predicate<T> x)
        {
            for (int i = 0; i < _arr.Length; i++)
            {
                if (x(_arr[i]))
                {
                    return _arr[i];
                }
            }
            return default(T);
        }
        public CustomList<T> CustomFindAllList(Predicate<T> x)
        {
            CustomList<T> vs = new CustomList<T>();
            for (int i = 0; i < _arr.Length; i++)
            {
                if (x(_arr[i]))
                {
                    vs.CustomAddList(_arr[i]);
                }
            }
            return vs;

        }
        public int CustomFindIndexList(int startIndex, Predicate<T> x)
        {

            for (int i = startIndex; i < _arr.Length; i++)
            {
                if (x(_arr[i]))
                {
                    return i;
                }
            }
            return -1;
        }
        public int CustomIndexOfList(T index)
        {
            for (int i = 0; i < _arr.Length; i++)
            {
                if (_arr[i].Equals(index))
                {
                    return i;
                }
            }
            return -1;
        }
        public void CustomRemoveAllList(Predicate<T> x)
        {
            T[] arr = new T[0];
            for (int i = 0; i < _arr.Length; i++)
            {
                if (!x(_arr[i]))
                {
                    Array.Resize(ref arr, arr.Length + 1);
                    arr[arr.Length - 1] = _arr[i];
                }
            }
        }
        public void CustomRemoveList(T index) 
        {
            T[] arr = new T[0];
            int count = 0;
            for (int i = 0; i < _arr.Length; i++)
            {
                if (_arr[i].Equals(index))
                {
                    count = i;
                    break;
                }
            }
            for (int i = 0; i < _arr.Length; i++)
            {
                if (i != count)
                {
                    Array.Resize(ref arr, arr.Length + 1);
                    arr[arr.Length - 1] = _arr[i];
                }
            }
            _arr = arr;


        }
        public void CustomRemoveAtList(int index)
        {
            T[] arr = new T[0];

            for (int i = 0; i < _arr.Length; i++)
            {
                if (i != index)
                {
                    Array.Resize(ref arr, arr.Length + 1);
                    arr[arr.Length - 1] = _arr[i];
                }
            }
            _arr = arr;


        }

        


    }
}
