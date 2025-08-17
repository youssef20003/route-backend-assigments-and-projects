using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__advanced_assignment1.Classes
{
    internal class Range<T> where T : IComparable<T>
    {
        public T Max { get; set; }
        public T Min { get; set; }

        public Range(T min, T max) { Min = min; Max = max; }

        public bool IsInRange(T value)
        {
             return (value.CompareTo(Min) >= 0 && value.CompareTo(Max) <= 0) ? true : false;
        }

        public T Length()
        {

            return (dynamic)Max - (dynamic)Min;
        }

        public override string ToString() { 
        
            return $"max {Max} min {Min}";
        }
    }
}