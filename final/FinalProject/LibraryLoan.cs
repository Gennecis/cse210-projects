using System;

namespace LibraryManagement
{
    public class LibraryLoan
    {
        public LibraryCard LibraryCard { get; private set; }
        public LibraryItem Item { get; private set; }
        public DateTime DueDate { get; private set; }

        public LibraryLoan(LibraryCard libraryCard, LibraryItem item, DateTime dueDate)
        {
            LibraryCard = libraryCard;
            Item = item;
            DueDate = dueDate;
        }
    }
}
