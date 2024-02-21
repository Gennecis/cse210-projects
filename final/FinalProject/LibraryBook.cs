namespace LibraryManagement
{
    public class LibraryBook : LibraryItem
    {
        public Book Book { get; private set; }

        public LibraryBook(Book book)
        {
            Book = book;
        }

        public override void DisplayDetails()
        {
            Console.WriteLine($"Library Item ID: {Id}");
            Book.DisplayDetails();
        }
    }
}
