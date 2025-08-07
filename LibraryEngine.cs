using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryDelegatesApp
{
    internal class LibraryEngine
    {
        public delegate string GetBookInfoDelegate(Book b);

            #region a. User Defined Delegate
            public static void ProcessBooks(List<Book> bList, GetBookInfoDelegate fPtr)
            {
                foreach (Book b in bList)
                {
                    Console.WriteLine(fPtr(b));
                }
            }
            #endregion

            #region b. BCL Delegates (Func)
            public static void ProcessBooksUsingFunc(List<Book> bList, Func<Book, string> fPtr)
            {
                foreach (Book b in bList)
                {
                    Console.WriteLine(fPtr(b));
                }
            }
            #endregion

            #region c. Anonymous Method (GetISBN)
            public static void ProcessBooksWithAnonymousMethod(List<Book> bList)
            {
                foreach (Book b in bList)
                {
                    Func<Book, string> getISBN = delegate (Book book)
                    {
                        return book.ISBN;
                    };

                    Console.WriteLine(getISBN(b));
                }
            }
            #endregion

            #region d. Lambda Expression (GetPublicationDate)
            public static void ProcessBooksWithLambda(List<Book> bList)
            {
                foreach (Book b in bList)
                {
                    Func<Book, DateTime> getPubDate = book => book.PublicationDate;
                    Console.WriteLine(getPubDate(b).ToShortDateString());
                }
            }
            #endregion
        }
    }
