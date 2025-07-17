using c__oop_assignment1.structs;
using System;
using System.Drawing;

namespace c__oop_assignment1
{
    internal class Program
    {
        enum WeekDays:byte
        {
            sudnay =1 , 
            monday =2 ,
            Tuesday =3 ,
            Wednesday =4 ,
            Thursday =5 ,
            Friday =6 ,
            Saturday =7 ,
        }

        enum Season:byte { 
            Spring=1,
            Summer=2,
            Autumn=3,
            Winter=4 }

        enum Permissions:byte
        {
            Read = 1,
            Write = 2,
            Delete = 4,
            Execute = 8
        }

        enum Colors { 
            Red=1,
            Green=2, 
            Blue=3 }
        static void Main(string[] args)
        {
            #region ex-1
            //foreach (var day in Enum.GetValues(typeof(WeekDays)))
            //{
            //    Console.WriteLine(day);
            //}
            #endregion

            #region ex-2
            ////stucts file
            //person[] persons = new person[]  {
            //    new person { name = "Youssef", age = 20 },
            //    new person { name = "Ali", age = 25 },
            //    new person { name = "Sara", age = 22 }
            //};

            //foreach (var person in persons) {
            //    Console.WriteLine($"{person.name}-{person.age}\n");
            //}
            #endregion

            #region ex-3
            //string Seasoni = Console.ReadLine();
            //if (Enum.TryParse(Seasoni, true, out Season season))
            //{
            //    switch (season)
            //    {
            //        case Season.Spring:
            //            Console.WriteLine("March to May");
            //            break;
            //        case Season.Summer:
            //            Console.WriteLine("June to August");
            //            break;
            //        case Season.Autumn:
            //            Console.WriteLine("September to November");
            //            break;
            //        case Season.Winter:
            //            Console.WriteLine("December to February");
            //            break;
            //    }
            //}
            #endregion

            #region ex-5
            //string colorI = Console.ReadLine();
            //if (Enum.TryParse(colorI, true, out Colors color))
            //{
            //    Console.WriteLine($"primary color.");
            //}
            #endregion

            #region ex-6
            //double x1 = double.Parse(Console.ReadLine());
            //double y1 = double.Parse(Console.ReadLine());
            //double x2 = double.Parse(Console.ReadLine());
            //double y2 = double.Parse(Console.ReadLine());

            //point p1 = new point { X = x1, Y = y1 };
            //point p2 = new point { X = x2, Y = y2 };

            //double distance = Math.Sqrt(Math.Pow(p2.X - p1.X, 2) + Math.Pow(p2.Y - p1.Y, 2));

            //Console.WriteLine(distance);
            #endregion

            #region ex-7
        //    person[] persons = new person[] {
        //    new person { name = "Youssef", age = 20 },
        //    new person { name = "Ali", age = 25 },
        //    new person { name = "Sara", age = 22 }
        //};

        //    person oldest = persons[0];
        //    foreach (var person in persons)
        //    {
        //        if (person.age > oldest.age)
        //            oldest = person;
        //    }
        //    Console.WriteLine($"Oldest Person: {oldest.name}");
            #endregion
        }
    }
}
