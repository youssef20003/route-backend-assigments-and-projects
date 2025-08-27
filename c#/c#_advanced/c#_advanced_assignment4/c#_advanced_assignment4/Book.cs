﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__advanced_assignment4
{
    public class Book
    {
        public string ISBN { get; set; }
        public string Title { get; set; }
        public string[] Authors { get; set; }
        public DateTime PublicationDate { get; set; }
        public decimal Price { get; set; }

        public Book(string _ISBN, string _Title,string[] _Authors, DateTime _PublicationDate,decimal _Price)
        {
            ISBN = _ISBN;
            Title = _Title;
            Authors = _Authors;
            PublicationDate = _PublicationDate;
            Price = _Price;

        }

 



        public override string ToString()
        {
            string authors = Authors != null ? string.Join(", ", Authors) : "Unknown";
            return $"Title: {Title}, ISBN: {ISBN}, Authors: {authors}, Published: {PublicationDate.ToShortDateString()}, Price: {Price:C}";
        }
    }
}
