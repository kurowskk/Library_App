using System;
using System.Collections.Generic;
using System.Text;

namespace Library_App
{
    /// <summary>
    /// The class handles all the book operations and specifies the attributes of the book. The class
    /// is generalization of digital and paper book.
    /// </summary>
    class Book
    {
        ///declaring a name of each book
        private string _bookName;
        //declaring a commercial book identifier for a book
        private string _bookISBN;
        //declaring a list consisting of book authors available in the library
        private List<string> _bookAuthorList;
        //List specifing a book, libID, asset status and loan period
        private List<LibraryAsset> _libAssetList;

        ///Initialize the Book object with its attributes.
        /// The constructor requires the caller to provide book name and
        /// ISBN in order to create an digital book. 
        public Book(string Name, string bookISBN)
        {
            _bookName = Name;
            _bookISBN = bookISBN;

        }
        /// <summary>
        /// The name of the book. Read-only attribute.
        /// </summary>
        public string Name
        {
            get { return _bookName; }
        }

        /// <summary>
        /// Book's commercial number. Specific for every single book. Read-only attribute.
        /// </summary>
        public string BookISBNF
        {
            get { return _bookISBN; }
        }

        /// <summary>
        /// A list consisting of authors that can be found within a library. Read-only attribute.
        /// </summary>
        public List<string> Authors
        {
            get { return _bookAuthorList; }
        }

        /// <summary>
        /// A list enumerating through library assets. Read-only attribute.
        /// </summary>
        public IEnumerable<LibraryAsset> Assets
        {
            get { return _libAssetList; }
        }

        /// <summary>
        /// Checking for availability of an asset(AssetStatus).
        /// </summary>
        public bool LibraryAsset CheckAvailibility()
        {
            return ;
        }

        /// <summary>
        /// Enables user to borrow the book. Changes status of the asset.
        /// </summary>
        /// <returns></returns>
        public LibraryAsset BorrowBook()
        {

        }
        /// <summary>
        /// Enables user to reurn the book. Changes the status of an asset and inserts an item to the list of currently available positions. The method is 
        /// asking user for input of library id.
        /// </summary>
        /// 
        public TimeSpan Int Decimal ReturnBook(int libId)
        {

        }

        /// <summary>
        /// Enables user to reserve a book. Changes AssetStatus to "Reserved"
        /// </summary>
        /// <returns></returns>
        public LibraryAsset ReserveBook()
        {

        }


        /// <summary>
        /// Finds the library asset, if there is no asset in the library:returns null
        /// </summary>
        /// <param name="libID"></param>
        /// <returns></returns>
        private LibraryAsset findLibraryAsset(int libID)
        {

        }

        /// <summary>
        /// Finds the next available asset of the object.
        /// </summary>
        /// <returns></returns>
        private LibraryAsset findNextAvailableAsset()
        {

        }

    }
}
