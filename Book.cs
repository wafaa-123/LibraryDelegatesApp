using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryDelegatesApp
{
    internal class Book
    {
        
            public string Title { get; set; }
            public string ISBN { get; set; }
            public DateTime PublicationDate { get; set; }

            public Book(string title, string isbn, DateTime pubDate)
            {
                Title = title;
                ISBN = isbn;
                PublicationDate = pubDate;
            }

            public override string ToString()
            {
                return $"Title: {Title}, ISBN: {ISBN}, Published on: {PublicationDate.ToShortDateString()}";
            }
        }
    }

