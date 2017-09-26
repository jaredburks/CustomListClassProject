using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CustomListProject
{
    public class CustomList<T> : IEnumerable<T>
    {
        private T[] array;
        private int count;
        private int capacity;
        public int Count { get { return count; } }
        public int Capacity { get; set; }
        public T this[int i]
        {
            get { return array[i]; }
            set { array[i] = value; }
        }
        public CustomList()
        {
            count = 0;
            capacity = 4;
            array = new T[capacity];
            Capacity = capacity;
        }

        public void Add(T value)
        {
            T[] holderArray;

            if (count == capacity)
            {
                capacity = capacity * 2;
            }
            holderArray = array;
            array = new T[capacity];
            int spot = 0;
            foreach (T element in holderArray)
            {
                array[spot] = holderArray[spot];
                spot++;
            }
            count++;
            array[count-1] = value;
        }
        public bool Remove(T value)
        {
            T[] holderArray;
            bool isValue = false;
            holderArray = array;

            for(int i = 0; i < count; i++)
            {
                if (holderArray[i].Equals(value))
                {
                    isValue = true;
                }
            }
            if (isValue)
            {
                for (int j = 0; j < count; j++)
                {
                    array[j] = holderArray[j];
                    if (value.Equals(holderArray[j]))
                    {
                        isValue = true;
                    }
                    if (isValue)
                    {
                        array[j] = holderArray[j + 1];
                    }
                }
            }
            count--;
            return isValue;
        }
        public void Sort()
        {

        }

        public void Zip(CustomList<T> value)
        {

        }
        public override string ToString()
        {
            return base.ToString();
        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public static CustomList<T> operator+(CustomList<T> a , CustomList<T> b)
        {
            return a;
        }
        public static CustomList<T> operator-(CustomList<T> a, CustomList<T> b)
        {
            return a;
        }
    }
}
