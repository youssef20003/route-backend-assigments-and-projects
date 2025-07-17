namespace c__assigmnet3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region ex-1
            //int x = int.Parse(Console.ReadLine());
            //if (x % 3 == 0 && x % 4 == 0)
            //{
            //    Console.WriteLine("yes");
            //}
            //else {
            //    Console.WriteLine("no");
            //}
            #endregion

            #region ex-2
            //int x = int.Parse(Console.ReadLine());
            //if (x >= 0)
            //{
            //    Console.WriteLine("psotive");
            //}
            //else
            //{
            //    Console.WriteLine("negative");
            //}
            #endregion

            #region ex-3
            //int x = int.Parse(Console.ReadLine());
            //int y = int.Parse(Console.ReadLine());
            //int z = int.Parse(Console.ReadLine());
            //int max = Math.Max(x, Math.Max(y, z));
            //int min = Math.Min(x, Math.Min(y, z));
            //Console.WriteLine($"max : {max}");
            //Console.WriteLine($"min : {min}");
            #endregion

            #region ex-4
            //int x = int.Parse(Console.ReadLine());
            //if (x % 2 == 0 )
            //{
            //    Console.WriteLine("even");
            //}
            //else
            //{
            //    Console.WriteLine("odd");
            //}
            #endregion

            #region ex-5
            //char x = char.ToLower(Console.ReadLine()[0]);
            //if ("aeiou".Contains(x))
            //    Console.WriteLine("vowel");
            //else
            //    Console.WriteLine("consonant");
            #endregion

            #region ex-6
            //int x = int.Parse(Console.ReadLine());
            //for (int i = 1; i <= x; i++) {
            //    Console.WriteLine(i);
            //}
            #endregion

            #region ex-7
            //int x = int.Parse(Console.ReadLine());
            //for (int i = 1; i <= 12; i++)
            //{
            //    Console.WriteLine(x*i);
            //}
            #endregion

            #region ex-8
            //int x = int.Parse(Console.ReadLine());
            //for (int i = 1; i <= x; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            #endregion

            #region ex-9
            //int baseNum = int.Parse(Console.ReadLine());
            //int exp = int.Parse(Console.ReadLine());
            //int r = 1;
            //for (int i = 1; i <= exp; i++) {
            //    r *= baseNum;
            //}
            //Console.WriteLine(r);
            #endregion

            #region ex-10
            //int m1 = int.Parse(Console.ReadLine());
            //int m2 = int.Parse(Console.ReadLine());
            //int m3 = int.Parse(Console.ReadLine());
            //int m4 = int.Parse(Console.ReadLine());
            //int m5 = int.Parse(Console.ReadLine());
            //Console.WriteLine("total marks : " + (m1 + m2 + m3 + m4 + m5));
            //Console.WriteLine("average marks : " + ((m1 + m2 + m3 + m4 + m5) / 5));
            //Console.WriteLine("percentege : " + ((m1 + m2 + m3 + m4 + m5) / 500) * 100);
            #endregion

            #region ex-11
            //int month = int.Parse(Console.ReadLine());
            //switch (month)
            //{
            //    case 1:
            //    case 3:
            //    case 5:
            //    case 7:
            //    case 8:
            //    case 10:
            //    case 12:
            //        Console.WriteLine("Days in Month: 31");
            //        break;
            //    case 4:
            //    case 6:
            //    case 9:
            //    case 11:
            //        Console.WriteLine("Days in Month: 30");
            //        break;

            //    case 2:
            //        Console.WriteLine("Days in Month: 28 or 29 (leap year)");
            //        break;

            //    default:
            //        Console.WriteLine("Invalid");
            //        break;
            //}
            #endregion

            #region ex-12
            //double x = double.Parse(Console.ReadLine());
            //char op = Console.ReadLine()[0];
            //double y = double.Parse(Console.ReadLine());
            //double r = 0;
            //switch (op)
            //{
            //    case '+': r = x + y; break;
            //    case '-': r = x - y; break;
            //    case '*': r = x * y; break;
            //    case '/': r = y != 0 ? x / y : 0; break;
            //    default: Console.WriteLine("Invalid operator"); break;
            //}
            //Console.WriteLine(r);
            #endregion

            #region ex-13
            //string str = Console.ReadLine();
            //for (int i = str.Length - 1; i >= 0; i--)
            //{
            //    Console.Write(str[i]);
            //}
            #endregion

            #region ex-14
            //int x = int.Parse(Console.ReadLine());
            //int rev = 0;
            //while (x != 0)
            //{
            //    rev = rev * 10 + x % 10;
            //    x /= 10;
            //}
            //Console.WriteLine(rev);
            #endregion

            #region ex-15
            //int start = int.Parse(Console.ReadLine());
            //int end = int.Parse(Console.ReadLine());
            //for (int i = start; i <= end; i++)
            //{
            //    bool Prime = true;
            //    if (i <= 1) Prime = false;
            //    for (int j = 2; j * j <= i; j++)
            //    {
            //        if (i % j == 0)
            //        {
            //            Prime = false;
            //            break;
            //        }
            //    }
            //    if (Prime) Console.WriteLine(i);
            //}
            #endregion

            #region ex-16  
            //int decimaln= int.Parse(Console.ReadLine());
            //int remainder;
            //string result = string.Empty;
            //while (decimaln > 0)
            //{
            //    remainder = decimaln % 2;
            //    decimaln/= 2;
            //    result = remainder.ToString() + result;
            //}
            //Console.WriteLine(result);
            #endregion

            #region ex-17
            //double x1 = double.Parse(Console.ReadLine());
            //double y1 = double.Parse(Console.ReadLine());
            //double x2 = double.Parse(Console.ReadLine());
            //double y2 = double.Parse(Console.ReadLine());
            //double x3 = double.Parse(Console.ReadLine());
            //double y3 = double.Parse(Console.ReadLine());
            //double slope1 = (y2 - y1) * (x3 - x2);
            //double slope2 = (y3 - y2) * (x2 - x1);
            //if (slope1 == slope2)
            //{
            //    Console.WriteLine("straight line");
            //}
            //else
            //{
            //    Console.WriteLine("not lie on a straight line");
            //}
            #endregion

            #region ex-18
            //double hours = double.Parse(Console.ReadLine());
            //if (hours >= 2 && hours < 3)
            //    Console.WriteLine("Highly Efficient");
            //else if (hours >= 3 && hours < 4)
            //    Console.WriteLine("Increase speed");
            //else if (hours >= 4 && hours <= 5)
            //    Console.WriteLine("Training required");
            //else if (hours > 5)
            //    Console.WriteLine("Leave the company");
            //else
            //    Console.WriteLine("Invalid time");
            #endregion

            #region ex-19

            #endregion

            #region ex-20
            //d
            #endregion
        }
    }
}
