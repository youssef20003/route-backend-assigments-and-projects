using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__oop_assignment3.classes
{
    internal class duration
    {
     

        public int hours {  get; set; }
        public int minutes { get; set; }
        public int seconds { get; set; }

        public duration(int hours, int minutes, int seconds)
        {
            this.hours = hours;
            this.minutes = minutes;
            this.seconds = seconds;
        }

        public duration( int seconds)
        {

            Normalize(seconds);

            
        }
        private void Normalize(int totalSeconds)
        {
            if (totalSeconds < 0) totalSeconds = 0;
            this.hours = totalSeconds / 3600;
            this.minutes = (totalSeconds % 3600) / 60;
            this.seconds = totalSeconds % 60;
        }

        public int tosec()
        {
            return hours * 3600 + minutes * 60 + seconds;
        }

        public override string ToString()
        {
            return $" Hours: {this.hours}, Minutes: {this.minutes}, Seconds: {this.seconds}";
        }

        public static duration operator +(duration left, duration right)
        {
            return new duration(left.hours + right.hours , left.minutes + right.seconds , left.seconds + right.seconds);
        }
        public static duration operator -(duration left, duration right)
        {
            return new duration(left.hours - right.hours, left.minutes - right.seconds, left.seconds - right.seconds);
        }
        public static duration operator +(duration left, int right)
        {
            return new duration(left.tosec() + right);
        }

        public static duration operator +(int left, duration right)
        {
            return new duration(left + right.tosec());
        }

        public static duration operator ++(duration d1)
        {
            return new duration(d1.hours ,++d1.minutes , d1.seconds);
        }

        public static duration operator --(duration d1)
        {
            return new duration(d1.hours, --d1.minutes, d1.seconds);
        }

        public static bool operator >(duration d1 , duration d2)
        {
            return d1.tosec() > d2.tosec();
        }

        public static bool operator <(duration d1, duration d2)
        {
            return d1.tosec() < d2.tosec();
        }

        public static bool operator >=(duration d1, duration d2)
        {
            return d1.tosec() >= d2.tosec();
        }

        public static bool operator <=(duration d1, duration d2)
        {
            return d1.tosec() <= d2.tosec();
        }

        public static bool operator true(duration d) 
        { 
           return d.tosec() > 0;
        }
        public static bool operator false(duration d)
        {
            return d.tosec() <= 0;
        }

        public static explicit operator DateTime(duration d)
        {
            return new DateTime(1, 1, 1, d.hours, d.minutes, d.seconds);
        }




    }
}
