using c__oop_assignment4.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__oop_assignment4.classes
{
    internal class Circle : ICircle
    {
        public Circle(double r)
        {
            R = r;
        }

        public double R {  get; set; }
        public double Area {  get; set; }

        public void DisplayShapeInfo()
        {
            Console.WriteLine($"r {R} area {Math.PI * R * R}");
        }
    }
}
