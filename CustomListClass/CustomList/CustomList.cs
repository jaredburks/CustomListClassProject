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
        public int Count { get; }
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
            for (int i = 0; i <= count; i++)
            {
                int j = 0;
                if(array[j] == null)
                {
                    array[j] = value;
                }
                else
                {
                    j++;
                }
            }
            count++;
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
