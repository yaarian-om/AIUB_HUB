using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIUB_LABTASK
{
    class Book
    {
        #region Properties
        private string bookName;
        private string bookAuthor;
        private string bookId;
        private string bookType;
        private int bookCopy; // How Many Copy
        public static int bookCounter;
        #endregion Properties

        #region Constructor
        public Book() { /*Empty Constructor*/}
        public Book(string bookName, string bookAuthor, string bookId, string bookType, int bookCopy)
        {
            this.bookName = bookName;
            this.bookAuthor = bookAuthor;
            this.bookId = bookId;
            this.bookType = bookType;
            this.bookCopy = bookCopy;
        }
        #endregion Constructor

        #region Setter_Getter_Methods
        public string BookName
        {
            get { return bookName; }
            set
            {
                bookName = value;
            }
        }
        public string BookAuthor
        {
            get { return bookAuthor; }
            set
            {
                bookAuthor = value;
            }
        }

        public string BookId
        {
            get { return bookId; }
            set
            {
                bookId = value;
            }
        }

        public string BookType
        {
            get { return bookType; }
            set
            {
                bookType = value;
            }
        }

        public int BookCopy
        {
            get { return bookCopy; }
            set
            {
                bookCopy = value;
            }
        }
        #endregion Setter_Getter_Methods

        #region My_Methods
        public void showInfo() {
            Console.WriteLine("Book Name = "+BookName);
            Console.WriteLine("Book Author = " + bookAuthor);
            Console.WriteLine("Book ID = " + BookId);
            Console.WriteLine("Book Type = " + BookType);
            Console.WriteLine("Book Copy = " + BookCopy);
        }

        public void addBookCopy(int x) {
            if (x <= 0){Console.WriteLine("Enter A Valid Positive Number of Books Except 0");}
            else{bookCopy = bookCopy + x;}
        }

        static void showTotalBookInfo() { }

        #endregion My_Methods


    }
}
