using static c__advanced_assignment4.LibraryEngine;

namespace c__advanced_assignment4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Book> books = new List<Book>()
            {
                new Book("111", "C# Basics", new string[] {"John", "Mary"}, new DateTime(2020,5,1), 300),
                new Book("222", "Advanced C#", new string[] {"Alice"}, new DateTime(2021,7,15), 450),
                new Book("333", "ASP.NET Core", new string[] {"Bob", "Steve"}, new DateTime(2022,10,5), 500)
            };

            //LibraryEngine.ProcessBooks(books, new BookDelegate(BookFunctions.GetTitle));

            //LibraryEngine.ProcessBooks<string>(books, BookFunctions.GetAuthors);

            //LibraryEngine.ProcessBooks<string>(books, delegate (Book b) { return b.ISBN; });

            //LibraryEngine.ProcessBooks<string>(books, b => b.PublicationDate.ToString());


            ////1
            //Console.WriteLine(books.Exists(b => b.Price > 400));

            ////2
            //Console.WriteLine(books.Find(b => b.Price > 400));

            ////3
            //List<Book> expensiveBooks = books.FindAll(b => b.Price > 400);
            //foreach (var b in expensiveBooks)
            //    Console.WriteLine(b);

            ////4
            //Console.WriteLine(books.FindIndex(b => b.Price > 400));

            ////5
            //Console.WriteLine(books.FindLast(b => b.Price > 400));

            ////6
            //Console.WriteLine(books.FindLastIndex(b => b.Price > 400));

            ////7
            //books.ForEach(b => Console.WriteLine(b.Title));

            ////8
            //Console.WriteLine(books.TrueForAll(b => b.Price > 200));


        }
    }
}
