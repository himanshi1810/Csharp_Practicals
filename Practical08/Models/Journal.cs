using Practical08.Exceptions;
using Practical08.Interface;

namespace Practical08.Models
{
    //Overriding the method of LibraryItem 
    public class Journal : LibraryItem, IBorrowable
    {
        public string JournalNumber { get; private set; }
        private bool _isBorrowed = false;

        public Journal(string title, string author, string itemId, string journalNumber)
            : base(title, author, itemId)
        {
            JournalNumber = journalNumber;
        }
        //Item Is borrowed or not
        public void BorrowItem()
        {
            if (_isBorrowed)
            {
                throw new ItemAlreadyBorrowedException("Journal is already borrowed.");
            }
            _isBorrowed = true;
        }
        //Item is returned or not
        public void ReturnItem()
        {
            if (!_isBorrowed)
            {
                throw new Exception("Journal was not borrowed.");
            }
            _isBorrowed = false;
        }
        //Displaying Details of Book
        public override void DisplayDetails()
        {
            Console.WriteLine($"Journal: {Title} by {Author}, Journal Number: {JournalNumber}, Item ID: {ItemId}, Status: {(_isBorrowed ? "Borrowed" : "Available")}");
        }
    }
}
