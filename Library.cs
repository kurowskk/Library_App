using System;
using System.Collections.Generic;
using System.Text;

namespace Library_App
{

    ///this enumeration creates an option of 3 formats of books in the library.
    enum BookType
    {
        Paper = 1,
        Digital,
        Audio
    }

    /// <summary>
    /// Class handling librery operations such us reservations, returns, checkin availibility etc.
    /// Provides a list of library assets and manages them.
    /// </summary>
    class Library
    {
        //declaring a list of books in the library
        private List<Book> _bookList;
        //declaring defauld library id. The "const" keyword makes it impossible to change the value
        /// of the field variable 
        private const int DEFAULT_LIBID_START = 100;

        //Initialize the Library object with its attributes.
        public Library()
        {
        }


        private void CreateDefaultBook()
        {

        }

        private int DetermineLibID()
        {

        }

        /// <summary>
        /// Creates new instance of book and assign it to the library. A method asks user for input of book properties.
        /// </summary>
        /// <param name="BookName"></param>
        /// <param name="BookISBN"></param>
        /// <param name="authors"></param>
        /// <param name="bookType"></param>
        /// <param name="nCopies"></param>
        /// <returns></returns>
        public Book RegisterBook(string BookName, string BookISBN, string[] authors, BookType bookType, int nCopies)
        {

        }


        /// <summary>
        /// Enables user to find a book basing on name.
        /// </summary>
        /// <param name="bookName"></param>
        /// <returns></returns>
        public Book FindBookByName(string bookName)
        {

        }



        // Enables user to find a book basing on name.
        public Book FindBookByISBN(string bookISBN)
        {

        }
    }

}

