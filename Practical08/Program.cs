using Practical08;

// Create address
Address address = new Address("123 Ramdevnagar", "Ahmedabad", "Gujarat", "10001");

// Create users
User student = new Student("U001", "Himanshi Gandhi", address, "S12345");
User librarian = new Librarian("U002", "Himanshi", address, "E12345");

// Create library items
Book book = new Book("The god of small things", "Arundhati Roy", "B001", "987654321007");
Journal journal = new Journal("The Acorn", "Mohandas Karamchand Gandhi", "J001", "1234-5678");

// Create library service
LibraryService libraryService = new LibraryService();
libraryService.AddItems(book, journal);

// Borrow and return items
try
{
    libraryService.BorrowItem("J001", librarian); // Journal
    libraryService.BorrowItem("B001", student);  // Book
    libraryService.ReturnItem("B001", student);  // Book
    libraryService.BorrowItem("B002", student);  // Give an exception of not found
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}

// Display user info
student.DisplayInfo();
librarian.DisplayInfo();

// Display library items
LibraryHelper.DisplayLibraryItems(libraryService.GetItems());


