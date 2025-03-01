using Practical08.Models;

namespace Practical08.Helpers
{
    public static class LibraryHelper
    {
        public static void DisplayLibraryItems(List<LibraryItem> items)
        {
            foreach (var item in items)
            {
                item.DisplayDetails();
            }
        }
    }
}
