using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__advanced_assignment4
{
    public class LibraryEngine
    {
        public delegate string BookDelegate(Book b);
        public static void ProcessBooks<T>(List<Book> bList, Func<Book, T> fptr)
        {
            foreach (Book B in bList)
            {
                Console.WriteLine(fptr(B));
            }
        }

        public static void ProcessBooks(List<Book> bList, BookDelegate fptr)
        {
            foreach (Book B in bList)
            {
                Console.WriteLine(fptr(B));
            }
        }
    }
}
