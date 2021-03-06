﻿using System;
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
            array[count - 1] = value;
        }
        public bool Remove(T value)
        {
            T[] holderArray;
            bool isValue = false;
            holderArray = array;

            for (int i = 0; i < count; i++)
            {
                if (holderArray[i].Equals(value))
                {
                    isValue = true;
                }
            }
            if (isValue)
            {
                isValue = false;
                for (int j = 0; j < count; j++)
                {
                    if (value.Equals(holderArray[j]))
                    {
                        isValue = true;
                    }
                    else if (!isValue)
                    {
                        array[j] = holderArray[j];
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

        public void Zip(CustomList<T> list)
        {
            T[] holderArray;
            holderArray = array;
            array = new T[0];
            count = 0;
            int spot = 0;
            int spot2 = 0;

            foreach (T element in holderArray)
            {
                Add(holderArray[spot2]);
                spot++;
                Add(list[spot2]);
                spot++;
                spot2++;
            }
        }
        public override string ToString()
        {
            string c = null;
            for (int i = 0; i < count; i++)
            {
                Convert.ToString(array[i]);
                c += array[i];
            }
            return c;
        }

        public IEnumerator<T> GetEnumerator()
        {
            T[] values = new T[100];
            int top = 0;
            for (int i = top - 1; i >= 0; i--)
            {
                yield return values[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public static CustomList<T> operator +(CustomList<T> a, CustomList<T> b)
        {
            CustomList<T> holderArray = new CustomList<T>();

            for (int i = 0; i < a.count; i++)
            {
                holderArray.Add(a[i]);
            }
            for (int i = 0; i < a.count; i++)
            {
                holderArray.Add(b[i]);
            }
            return holderArray;
        }
        public static CustomList<T> operator -(CustomList<T> list1, CustomList<T> list2)
        {
            CustomList<T> holderArray = new CustomList<T>();
            bool duplicate = false;

            for (int i = 0; i < list2.count; i++)
            {
                for (int j = 0; j < list1.count; j++)
                {
                    if(list2[i].Equals(list1[j]) && !duplicate)
                    {
                        duplicate = true;
                    }
                    else
                    {
                        holderArray.Add(list1[j]);
                    }
                }
            }
            return holderArray;
        }
    }
}
