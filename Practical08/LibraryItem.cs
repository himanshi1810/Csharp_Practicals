namespace Practical08
{
    //To achieve abstaction and I don't want to show unwanted implementation
    public abstract class LibraryItem
    {
        public string Title { get; private set; }
        public string Author { get; private set; }
        public string ItemId { get; private set; }
        protected LibraryItem(string title, string author, string itemId)
        {
            Title = title;
            Author = author;
            ItemId = itemId;
        }
        public abstract void DisplayDetails();
    }
}
