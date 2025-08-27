using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__advanced_assignment4
{
    public static class BookFunctions
    {
        public static string GetTitle(Book B)
        {

            return B?.Title ?? "No Title";
        }

        public static string GetAuthors(Book B)
        {

            return (B?.Authors != null && B.Authors.Length > 0)
               ? string.Join(", ", B.Authors)
               : "No Authors";
        }

        public static string GetPrice(Book B)
        {

            return (B != null) ? $"{B.Price:C}" : "No Price";
        }
    }
}
