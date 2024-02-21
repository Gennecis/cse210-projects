namespace LibraryManagement
{
    public class LibraryCard
    {
        public Borrower Borrower { get; private set; }

        public LibraryCard(Borrower borrower)
        {
            Borrower = borrower;
        }
    }
}
