using Day_01_G03;
using System.Globalization;
using System.Threading;

namespace LinQ_1
{
    internal class Program
    {
        public static void ViewList<T>(IEnumerable<T> list, string? title = "")
        {
            if (!string.IsNullOrEmpty(title))
                Console.WriteLine($"--- {title} ---");

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(); // for spacing
        }

        static void Main(string[] args)
        {
            var custumers= ListGenerator.CustomersList; 
            var products = ListGenerator.ProductsList;



            #region  Restriction Operators

            //1
            //var q1 = products.Where(p => p.UnitsInStock == 0);
            //ViewList(q1);

            //2
            //var q2 = products.Where(p => p.UnitsInStock != 0 && p.UnitPrice > 3);
            //ViewList(q2);

            //3
            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            //var q3 = Arr.Select((name, index) => new { name, index }).Where(x => x.name.Length < x.index);
            //ViewList(q3);


            #endregion

            #region Element Operators

            //1
            //var q1 = products.FirstOrDefault(p => p.UnitsInStock == 0);
            //Console.WriteLine(q1);

            //2
            //var q2 = products.FirstOrDefault(p => p.UnitPrice > 1000);
            //Console.WriteLine(q2);

            //3
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var q3 = Arr.Where(n => n > 5).Skip(1).FirstOrDefault();
            //Console.WriteLine(q3);

            #endregion

            #region Aggregate Operators

            //1
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var q1 = Arr.Count(a => a % 2 == 1);
            //Console.WriteLine(q1);

            //2
            //var q1 = custumers.Select(c => new { c.CustomerName, OrdersCount = c.Orders.Length });
            //ViewList(q1);

            //3
            //var q3 = products.GroupBy(p => p.Category).Select(g => new { g.Key, count = g.Count() });
            //ViewList(q3);

            //4
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var q4 = Arr.Sum();
            //Console.WriteLine(q4);

            //5
            //string[] str = File.ReadAllLines("dictionary_english.txt");
            //var q5 = str.Sum(s => s.Length);

            //6
            //string[] str = File.ReadAllLines("dictionary_english.txt");
            //var q6 = str.Min(s => s.Length);

            //7
            //string[] str = File.ReadAllLines("dictionary_english.txt");
            //var q7 = str.Max(s => s.Length);

            //8
            //string[] str = File.ReadAllLines("dictionary_english.txt");
            //var q8 = str.Average(s => s.Length);



            #endregion

            #region Ordering Operators

            //1
            //var q1 = products.OrderBy(p => p.ProductName);
            //ViewList(q1);

            //2
            //String[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var q2 = Arr.OrderBy(w => w, StringComparer.OrdinalIgnoreCase);
            //ViewList(q2);

            //3
            //var q3 = products.OrderByDescending(p => p.UnitsInStock);
            //ViewList(q3);

            //4
            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            //var q4 = Arr.OrderBy(a => a.Length).ThenBy(a => a);
            //ViewList(q4);

            //5
            //String[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var q5 = Arr.OrderBy(w => w.Length).ThenBy(w => w, StringComparer.OrdinalIgnoreCase);
            //ViewList(q5);

            //6
            //var q6 = products.OrderBy(p => p.Category).ThenByDescending(p => p.UnitPrice);
            //ViewList(q6);

            //7
            //String[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var q7 = Arr.OrderBy(w => w.Length).ThenByDescending(w => w, StringComparer.OrdinalIgnoreCase);
            //ViewList(q7);

            //8
            //string[] Arr = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};
            //var q8 = Arr.Where(w => w.Length > 1 && w[1] == 'i').Reverse();
            //ViewList(q8);


            #endregion

            #region Transformation Operators

            //1
            //var q1 = products.Select(p => p.ProductName);
            //ViewList(q1);

            //2
            //String[] words = { "aPPLE", "BlUeBeRrY", "cHeRry" };
            //var q2 = words.Select(w => new{upper =w.ToUpper() , lower = w.ToLower()});
            //ViewList(q2);

            //3
            //var q3 = products.Select(p => new { p.ProductName, Price = p.UnitPrice });
            //ViewList(q3);

            //4
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var q4= Arr.Select((val, idx) => new { val, idx }).Where(x => x.val == x.idx);
            //ViewList(q4);

            //5
            //int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            //int[] numbersB = { 1, 3, 5, 7, 8 };
            //var q5 = from a in numbersA
            //    from b in numbersB
            //    where a < b
            //    select new { a, b };

            //ViewList(q5);

            //6
            //var q6 = custumers.SelectMany(c => c.Orders).Where(o => o.Total < 500);
            //ViewList(q6);

            //7
            //var q7 = custumers.SelectMany(c => c.Orders).Where(o => o.OrderDate.Year >= 1998);
            //ViewList(q7);


            #endregion

            #region Element Operators
            //1
            //var q1 = products.FirstOrDefault(p => p.UnitsInStock == 0);

            //2
            //var q2 = products.FirstOrDefault(p => p.UnitPrice > 1000);

            //if (q2 != null)
            //    Console.WriteLine($"Expensive product: {q2.ProductName}, Price: {q2.UnitPrice}");
            //else
            //    Console.WriteLine("No product found with price > 1000.");

            //3
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var q3 = Arr.Where(n => n > 5).Skip(1).FirstOrDefault();

            //Console.WriteLine(q3);

            #endregion



        }
    }
}
