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
        private T[] holderArray;
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
            count = 0;
            capacity = 4;
            array = new T[capacity];
            Count = count;
            Capacity = capacity;
        }

        public void Add(T value)
        {
            //array[0] = value;
            if (count == capacity)
            {
                holderArray = array;
                array = new T[capacity*2];
                int spot = 0;
                foreach (T element in holderArray)
                {
                    array[spot] = holderArray[spot];
                    spot++;
                }
            }
            count++;
            Count = count;
            array[count-1] = value;
        }
        public void Remove(T value)
        {
            foreach(T element in array)
            {
                if(element.Equals(value))
                {
                    array = array.Except(new T[] { value }).ToArray();
                }
            }
            count--;
            Count = count;
        }
        public void Sort()
        {

        }
        public void Iterate()
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
