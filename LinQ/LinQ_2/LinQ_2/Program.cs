using Day_01_G03;
using System.Collections.Generic;
using System.Reflection;

namespace LinQ_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var customers = ListGenerator.CustomersList;
            var products = ListGenerator.ProductsList;


            #region element operators

            ////1
            //Console.WriteLine(products.FirstOrDefault(p => p.UnitsInStock == 0));

            ////2
            //Console.WriteLine(products.FirstOrDefault(p => p.UnitPrice  >1000));

            ////3
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //Console.WriteLine(Arr.Where(n=>n>5).Skip(1).FirstOrDefault());


            #endregion

            #region Aggregate Operators

            ////1
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //Console.WriteLine(Arr.Count(n=> n %2 !=0));

            ////2
            //var result = customers.Select(c => new
            //{
            //    c.CustomerID,
            //    OrdersCount = c.Orders.Count()
            //});
            //foreach (var item in result)
            //{
            //    Console.WriteLine($"Customer: {item.CustomerID}, Orders: {item.OrdersCount}");
            //}

            ////3
            //var res = products.GroupBy(p => p.Category)
            //    .Select(g => new
            //    {
            //        cat = g.Key,
            //        count = g.Count()
            //    });
            //foreach (var VARIABLE in res)
            //{
            //    Console.WriteLine(VARIABLE);
            //}

            //4
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //Console.WriteLine(Arr.Sum());

            ////5
            string[] words = File.ReadAllLines("Data\\dictionary_english.txt");
            //var total = words.Sum(w => w.Length);
            //Console.WriteLine(total);

            ////6
            //Console.WriteLine(words.Min(w=>w.Length));

            ////7
            //Console.WriteLine(words.Max(w=>w.Length));

            ////8
            //Console.WriteLine(words.Average(w=>w.Length));

            ////9
            //var res = products.GroupBy(p => p.Category)
            //    .Select(g => new
            //    {
            //        cat = g.Key,
            //        units = g.Sum(p => p.UnitsInStock)
            //    });
            //foreach (var VARIABLE in res)
            //{
            //    Console.WriteLine(VARIABLE);
            //}

            ////10
            //var cheapestPrice = products.GroupBy(p => p.Category)
            //    .Select(g => new { Category = g.Key, MinPrice = g.Min(p => p.UnitPrice) });

            ////11
            //var cheapestPrice = 
            //    from p in products
            //    group p by p.Category into  g
            //    let minPrice = g.Min(x => x.UnitPrice)
            //    select new { Category = g.Key, Products = g.Where(x => x.UnitPrice == minPrice) };

            ////12
            //var mostExpensivePrice = products.GroupBy(p => p.Category)
            //    .Select(g => new { Category = g.Key, MaxPrice = g.Max(p => p.UnitPrice) });
            //foreach (var VARIABLE in mostExpensivePrice)
            //{
            //    Console.WriteLine(VARIABLE);
            //}

            ////13
            //var mostExpensiveProducts = products.GroupBy(p => p.Category)
            //    .Select(g => new { Category = g.Key, Products = g.Where(x => x.UnitPrice == g.Max(p => p.UnitPrice)) });

            ////14
            //var avgPrice = products.GroupBy(p => p.Category)
            //    .Select(g => new { Category = g.Key, Avg = g.Average(p => p.UnitPrice) });



            #endregion

            #region Set Operators

            ////1
            //var UniqueCat = products.Select(p => p.Category).Distinct();

            ////2
            //var FirstLetters = products.Select(p => p.ProductName[0])
            //    .Union(customers.Select(c => c.CustomerName[0]));
            //foreach (var VARIABLE in FirstLetters)
            //{
            //    Console.WriteLine(VARIABLE);
            //}

            ////3
            //var commonLetters = products.Select(p => p.ProductName[0])
            //    .Intersect(customers.Select(c => c.CustomerName[0]));
            //foreach (var VARIABLE in commonLetters)
            //{
            //    Console.WriteLine(VARIABLE);
            //}

            ////4
            //var onlyProducts = products.Select(p => p.ProductName[0])
            //    .Except(customers.Select(c => c.CustomerName[0]));


            ////5
            //var lastThree = products.Select(p => p.ProductName.Substring(Math.Max(0, p.ProductName.Length - 3)))
            //    .Concat(customers.Select(c => c.CustomerName.Substring(Math.Max(0, c.CustomerName.Length - 3))));

            #endregion

            #region Partitioning Operators

            ////1
            //var First3 = customers.Where(c => c.Region == "WA")
            //    .SelectMany(c => c.Orders)
            //    .Take(3);

            ////2
            //var skip2 = customers.Where(c => c.Region == "WA")
            //    .SelectMany(c => c.Orders)
            //    .Skip(2);

            ////3
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var Smaller = numbers.TakeWhile((n, i) => n >= i);

            ////4
            //var Div3 = numbers.SkipWhile(n => n % 3 != 0);

            ////5
            //var Less = numbers.SkipWhile((n, i) => n >= i);

            #endregion

            #region Quantifiers

            ////1
            //bool hasei = words.Any(w => w.Contains("ei"));

            ////2
            //var OutOfStock = products.GroupBy(p => p.Category)
            //    .Where(g => g.Any(p => p.UnitsInStock == 0));

            ////3
            //var AllInStock = products.GroupBy(p => p.Category)
            //    .Where(g => g.All(p => p.UnitsInStock > 0));
            #endregion

            #region Grouping Operators

            ////1
            //List<int> nums = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
            //var groupedByRemainder = nums.GroupBy(n => n % 5);

            //foreach (var group in groupedByRemainder)
            //{
            //    Console.WriteLine($"Numbers with a remainder of {group.Key} when divided by 5: ");

            //    foreach (var num in group)
            //    {
            //        Console.WriteLine($"{num}");
            //    }
            //}

            ////2
            //var FirstLetter = words.GroupBy(w => w[0]);

            ////3
            //string[] arrWords = { "from", "salt", "earn", "last", "near", "form" };
            //var anagrams = arrWords.GroupBy(w => String.Concat(w.OrderBy(c => c)));
            #endregion

        }

    }
}
