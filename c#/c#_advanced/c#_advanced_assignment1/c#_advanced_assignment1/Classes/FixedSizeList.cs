using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__advanced_assignment1.Classes
{
    internal class FixedSizeList<T>
    {
        private int capacity;
        private T[] list;
        private int count = 0;

        public FixedSizeList(int capacity )
        {
            this.capacity = capacity;
            list = new T[capacity];
        }

        public void Add(T item)
        {
            if (count >= capacity)
            {
                throw new Exception("list is full");
            }
            else
            {
                list[count++] = item;
            }
        }

        public T Get(int i)
        {
            if (i < 0 || i >= count)
            {
                throw new Exception("wrong index");
            }
            else
            {
                return list[i];

            }
        }


    }
}
