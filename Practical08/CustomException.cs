namespace Practical08
{
    //Here I define Some Custom Exception Which I need
    public class ItemNotFoundException : Exception
    {
        public ItemNotFoundException(string message) : base(message) { }
    }

    public class ItemNotBorrowableException : Exception
    {
        public ItemNotBorrowableException(string message) : base(message) { }
    }
    public class ItemAlreadyBorrowedException : Exception
    {
        public ItemAlreadyBorrowedException(string message) : base(message) { }
    }
    public class ItemNotReturnedException : Exception
    {
        public ItemNotReturnedException(string message) : base(message) { }
    }
}
