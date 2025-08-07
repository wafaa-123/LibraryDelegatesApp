using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryDelegatesApp
{
    internal class BookFunctions
    {
        public string GetTitle(Book b)
        {
            return b.Title;
        }

        public string GetISBN(Book b)
        {
            return b.ISBN;
        }

        public DateTime GetPublicationDate(Book b)
        {
            return b.PublicationDate;
        }
    }
}
