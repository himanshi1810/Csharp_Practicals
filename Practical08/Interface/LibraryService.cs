using Practical08.Exceptions;
using Practical08.Models;

namespace Practical08.Interface
{
    //I can Achieve Method Overloading and also in this program custom exception I can thorw.
    public class LibraryService
    {
        //List is showing book and journal
        private List<LibraryItem> _libraryItems = new List<LibraryItem>();

        // Method Overloading: Add a single item
        public void AddItem(LibraryItem item)
        {
            _libraryItems.Add(item);
        }
        // Method Overloading: Add multiple items
        public void AddItems(params LibraryItem[] items)
        {
            _libraryItems.AddRange(items);
        }
        // Method to get all library items
        public List<LibraryItem> GetItems()
        {
            return _libraryItems;
        }
        public void BorrowItem(string itemId, User user)
        {
            var item = _libraryItems.Find(i => i.ItemId == itemId);
            if (item == null)
            {
                throw new Exception("Item not found.");
            }

            if (item is IBorrowable borrowableItem)
            {
                try
                {
                    borrowableItem.BorrowItem();
                    Console.WriteLine($"{user.Name} borrowed {item.Title}");
                }
                catch (ItemAlreadyBorrowedException ex)
                {
                    throw new ItemAlreadyBorrowedException($"Item with ID {itemId} is already borrowed.");
                }
            }
            else
            {
                throw new Exception("Item is not borrowable.");
            }
        }

        public void ReturnItem(string itemId, User user)
        {
            var item = _libraryItems.Find(i => i.ItemId == itemId);
            if (item == null)
            {
                throw new Exception("Item not found.");
            }

            if (item is IBorrowable borrowableItem)
            {
                borrowableItem.ReturnItem();
                Console.WriteLine($"{user.Name} returned {item.Title}");
            }
            else
            {
                throw new Exception("Item is not borrowable.");
            }
        }
    }
}
