using Practical08.Exceptions;
using Practical08.Interface;

namespace Practical08.Models
{
    //Overriding the method of LibraryItem and also performing Inheritance from LibraryItem which is abstract Class
    public class Book : LibraryItem, IBorrowable
    {
        public string ISBN { get; private set; }
        private bool _isBorrowed = false;
        //It is inherit the constructor of Library Item
        public Book(string title, string author, string itemId, string isbn)
            : base(title, author, itemId)
        {
            ISBN = isbn;
        }
        //Is Check item is borrowed or not
        public void BorrowItem()
        {
            if (_isBorrowed)
            {
                throw new ItemAlreadyBorrowedException("Book is already borrowed.");
            }
            _isBorrowed = true;
        }
        //Is check item is returned or not
        public void ReturnItem()
        {
            if (!_isBorrowed)
            {
                throw new Exception("Book was not borrowed.");
            }
            _isBorrowed = false;
        }
        //Displaying Details
        public override void DisplayDetails()
        {
            Console.WriteLine($"Book: {Title} by {Author}, ISBN: {ISBN}, Item ID: {ItemId}, Status: {(_isBorrowed ? "Borrowed" : "Available")}");
        }
    }
}
