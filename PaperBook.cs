using System;
using System.Collections.Generic;
using System.Text;

namespace Library_App
{
    /// <summary>
    /// The specialization of a Book class. Handles attributes and operations on digital books.
    /// </summary>
    class PaperBook : Book
    {
        //declaring a constant specifing the time it is allowed to keep a book for. The "const" keyword makes it impossible to change the value
        /// of the field variable 
        private const int MAX_BORROW_DAYS = 30;
        //declaring a late penalty for each day exceeding the deadine. The "const" keyword makes it impossible to change the value
        /// of the field variable 
        private const float LATE_PENALTY_PER_DAY = 0.25f;

        ///Initialize the PaperBook object with its attributes.
        /// The constructor requires the caller to provide book name and
        /// ISBN in order to create an digital book. 
        public PaperBook(string bookName, string BookISBN) :
            base(Name, bookISBN)
        {
            _bookName = bookName;
            _bookISBN = BookISBN;
        }

        ///Enables user to borrow the book.Changes status of the asset.
        public override LibraryAsset BorrowBook()
        {

        }

        ///Enables user to reurn the book.Changes the status of an asset and inserts an item to the list of currently available positions. The method is 
        /// asking user for input of library id.
        public override TimeSpan Int decimal ReturnBook(int libID)
        {

        }



    }

}



