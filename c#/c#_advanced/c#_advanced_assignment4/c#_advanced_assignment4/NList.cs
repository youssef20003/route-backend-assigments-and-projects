using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__advanced_assignment4
{
    public class NList<T>
    {
        private List<T> list = new List<T> ();

        public void Add(T item) { 
        
            list.Add (item);
        }

        public bool Exist(Predicate<T> predicate) {

            foreach (T item in list) {

                if (predicate(item)) return true;
            }
            return false;
        }


        public T Find(Predicate<T> predicate)
        {
            foreach (T item in list)
            {

                if (predicate(item)) return item;
            }

            return default(T);
        }


        public List<T> FindAll(Predicate<T> predicate)
        {
            List<T> result = new List<T>();
            foreach (T item in list)
            {
                if (predicate(item)) result.Add(item);
            }
            return result;
        }

        public int FindIndex(Predicate<T> predicate)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (predicate(list[i])) return i;
            }
            return -1;
        }

        public T FindLast(Predicate<T> predicate)
        {
            for (int i = list.Count - 1; i >= 0; i--)
            {
                if (predicate(list[i])) return list[i];
            }
            return default(T);
        }

        public int FindLastIndex(Predicate<T> predicate)
        {
            for (int i = list.Count - 1; i >= 0; i--)
            {
                if (predicate(list[i])) return i;
            }
            return -1;
        }

        public void ForEach(Action<T> action)
        {
            foreach (T item in list)
            {
                action(item);
            }
        }

        public bool TrueForAll(Predicate<T> predicate)
        {
            foreach (T item in list)
            {
                if (!predicate(item)) return false;
            }
            return true;
        }



    }
}
