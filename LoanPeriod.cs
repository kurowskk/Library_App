using System;
using System.Collections.Generic;
using System.Text;

namespace Library_App
{
    /// <summary>
    /// Class handles operations on loan period attributes. It calculates the time library user can loan an asset for
    /// as well as specifying the potential late period. 
    /// </summary>
    class LoanPeriod
    {

        struct Loan_Period
        {
            //declaring the date the book was borrowed on
            private DateTime _borrowedOn;
            //declaring the date the book was returned on
            private DateTime _returnedOn;
            //declaring the date the book is due
            private DateTime _dueDate;

            ///Initialize the loan period object with its attributes.
            /// The constructor requires the caller to provide the date when the book was borrowed and returned in order to create a loan period. 
            public Loan_Period(DateTime borrowedOn, DateTime returnedOn, DateTime dueDate)
            {
                _borrowedOn = borrowedOn;
                _returnedOn = returnedOn;
                _dueDate = dueDate;
            }

            /// <summary>
            /// Date the asset was borrowed on.
            /// </summary>
            public DateTime BorrowedOn
            {
                get { return _borrowedOn; }
                set { _borrowedOn = value; }
            }

            /// <summary>
            /// Date the asset was returned on.
            /// </summary>
            public DateTime ReturnedOn
            {
                get { return _returnedOn; }
                set { _returnedOn = value; }
            }

            /// <summary>
            /// Date the asset is due.
            /// </summary>
            public DateTime DueTime
            {
                get { return _dueDate; }
                set { _dueDate = value; }
            }

            /// <summary>
            /// The duration of a loan.
            /// </summary>
            /// <returns></returns>
            public TimeSpan LoanDuration()
            {
                return TimeSpan timeSpan = _borrowedOn - _returnedOn;
            }

            /// <summary>
            /// The number of days that was exceeded after the asset was due.
            /// </summary>
            public TimeSpan LatePeriod()
            {
                get {
                    return TimeSpan timeSpan = _returnedOn - _dueDate;
                }

            }

        }
    }
}

