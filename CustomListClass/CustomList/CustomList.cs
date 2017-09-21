using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class CustomList<T>
    {
        private T[] array;
        private int count;
        private int capacity;
        public int Count { get; set; }
        public int Capacity { get; set; }
        public T this[int i]
        {
            get { return array[i]; }
            set { array[i] = value; }
        }
        public CustomList()
        {
            array = new T[capacity];
            count = 0;
            capacity = 4;
        }

        public void Add(T value)
        {
            if (count == capacity)
            {
                capacity *= 2;
            }
        }
        public void Remove()
        {

        }
        public void Sort()
        {

        }
        public void Count()
        {

        }
        public void Zip()
        {

        }
        public override string ToString()
        {
            return base.ToString();
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
