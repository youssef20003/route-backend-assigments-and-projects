using c__oop_assignment4.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__oop_assignment4.classes
{
    internal class Myrectangle:IRectangle
    {
        public Myrectangle(int l, int w)
        {
            L = l;
            W = w;
        }

        public int L { get; set; }
        public int W { get; set; }
        public double Area { get; set; }

        public void DisplayShapeInfo()
        {
            Console.WriteLine($"L {L} , W {W} , area {L * W}");
        }
    }
}
