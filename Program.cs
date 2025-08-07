using System;
using System.Collections.Generic;

namespace LibraryDelegatesApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Book> books = new List<Book>()
            {
                new Book("C# Basics", "111-222", new DateTime(2020, 1, 1)),
                new Book("Advanced C#", "333-444", new DateTime(2021, 5, 10)),
            };

            BookFunctions bf = new BookFunctions();

            #region a. User Defined Delegate
            Console.WriteLine("User Defined Delegate:");
            LibraryEngine.ProcessBooks(books, bf.GetTitle);
            #endregion

            #region b. BCL Func Delegate
            Console.WriteLine("\nBCL Func Delegate:");
            LibraryEngine.ProcessBooksUsingFunc(books, bf.GetTitle);
            #endregion

            #region c. Anonymous Method
            Console.WriteLine("\nAnonymous Method:");
            LibraryEngine.ProcessBooksWithAnonymousMethod(books);
            #endregion

            #region d. Lambda Expression
            Console.WriteLine("\nLambda Expression:");
            LibraryEngine.ProcessBooksWithLambda(books);
            #endregion
        }
    }
}
