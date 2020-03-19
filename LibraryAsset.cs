using System;
using System.Collections.Generic;
using System.Text;

namespace Library_App
{
    /// <summary>
    /// Specifies the status of an asset.
    /// </summary>
    enum AssetStatus
    {
        NotAvailable,
        Available,
        Loaned,
        Reserved
    }

    /// <summary>
    /// Class manages the assets of the library such as digital or paper copy of the library. 
    /// Library users loans assets corresponding to particular books.
    /// </summary>
    class LibraryAsset
    {
        //declaring an instance of a book
        private Book _book;
        //declaring id of a library branch
        private int _libID;
        //declaring availability status 
        private AssetStatus _status;
        //declaring a period for which book is borrowed
        private LoanPeriod _loanPeriod;

        ///Initialize the library asset object with its attributes.
        /// The constructor requires the caller to provide library id and book name in order to create a library asset. 
        public LibraryAsset(int libID, Book book)
        {
            _book = book;
            _libID = libID;
        }
        /// <summary>
        /// Id specific for an instance of a library. Read-only attribute.
        /// </summary>
        public int LibID
        {
            get { return _libID; }
        }

        /// <summary>
        /// Status of an asset. States whether the item is being currently used and how.
        /// </summary>
        public AssetStatus Status
        {
            get { return _status; }
            set { _status = value; }
        }

        /// <summary>
        /// Period of time between an asset being borrowed and returned
        /// </summary>
        public LoanPeriod LoanPeriod
        {
            get { return _loanPeriod; }
            set { _loanPeriod = value; }

        }
        /// <summary>
        /// Checking for availability of an asset(AssetStatus)
        /// </summary>
        public bool isAvailable
        {
            get { return isAvailable; }
        }

    }


}
