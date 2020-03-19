using System;
using System.Collections.Generic;
using System.Text;

namespace Library_App
{
    /// <summary>
    /// The specialization of a Book class. Handles attributes and operations on digital books.
    /// </summary>
    class DigitalBook : Book
    {
        //declaring the maximum amount of days for which book can be borrowed
        private int maxBorrowDays;
        //declaring the amount of money due for each day of exceeding the deadline
        private float _latePenaltyPerDay;

        ///Initialize the DigitalBook object with its attributes.
        /// The constructor requires the caller to provide book name and
        /// ISBN in order to create an digital book. 
        public DigitalBook(string bookName, string BookISBN) :
            base(Name, bookISBN)
        {
            _bookName = bookName;
            _bookISBN = BookISBN;

        }
        /// <summary>
        /// Determine the maximum duration of a loan. 
        /// </summary>
        private DetermineLoanLicense()
        {

        }

        /// <summary>
        /// Enables user to borrow the book. Changes status of the asset.
        /// </summary>
        /// <returns></returns>
        public override LibraryAsset BorrowBook()
        {

        }


        ///Enables user to reurn the book.Changes the status of an asset and inserts an item to the list of currently available positions. 
        ///The method is  asking user for input of library id.
        public override TimeSpan Int decimal ReturnBook(int libID)
        {

        }












    }
}

