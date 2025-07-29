using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__oop_assignment3.classes
{
    internal class _3dpoint:IComparable< _3dpoint>
    {
      

        public int x {  get; set; }
        public int y { get; set; }
        public int z { get; set; }

        public _3dpoint(int x, int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public override string ToString()
        {
            return $"Point Coordinates: ({x}, {y}, {z})";
        }

        public int CompareTo(_3dpoint? other)
        {
            if (other is null) return 1;
            return (this.x, this.y).CompareTo((other.x, other.y));


        }

        public static bool operator ==(_3dpoint? p1, _3dpoint? p2)
        {
            if (ReferenceEquals(p1, p2))
                return true;

            if (p1 is null || p2 is null)
                return false;

            return p1.x == p2.x && p1.y == p2.y && p1.z == p2.z;
        }

        public static bool operator !=(_3dpoint? p1, _3dpoint? p2)
        {
            return !(p1 == p2);
        }


    }
}
