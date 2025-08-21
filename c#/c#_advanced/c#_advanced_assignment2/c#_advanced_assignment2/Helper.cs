using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__advanced_assignment2
{
    public static class Helper
    {
        public static void swap<T>(ref T x ,ref T y)
        {
            T temp = x;
            x = y;
            y = temp;
        }
    }
}
