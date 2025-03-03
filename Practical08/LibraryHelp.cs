namespace Practical08
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
