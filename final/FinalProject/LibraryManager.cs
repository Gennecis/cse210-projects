using System;
using System.Collections.Generic;

namespace LibraryManagement
{
    public class LibraryManager
    {
        private List<LibraryLoan> loans;

        public LibraryManager()
        {
            loans = new List<LibraryLoan>();
        }

        public void CheckoutItem(LibraryCard libraryCard, LibraryItem item)
{
    // Check if the item is available
    if (item is LibraryBook)
    {
        LibraryBook libraryBook = (LibraryBook)item;
        if (libraryBook.Book.IsAvailable)
        {
            libraryBook.Book.SetAvailability(false);
            loans.Add(new LibraryLoan(libraryCard, item, DateTime.Now.AddDays(14)));
            Console.WriteLine($"Item '{libraryBook.Book.Title}' checked out successfully by {libraryCard.Borrower.Name}.");
        }
        else
        {
            Console.WriteLine($"Item '{libraryBook.Book.Title}' is not available.");
        }
    }
    else
    {
        Console.WriteLine("Cannot check out this type of item.");
    }
}

public void ReturnItem(LibraryItem item)
{
    // Mark the item as returned
    if (item is LibraryBook)
    {
        LibraryBook libraryBook = (LibraryBook)item;
        libraryBook.Book.SetAvailability(true);
        Console.WriteLine($"Item '{libraryBook.Book.Title}' returned successfully.");
    }
    else
    {
        Console.WriteLine("Cannot return this type of item.");
    }
}

        public void DisplayLoans()
        {
            // Display all active loans
            Console.WriteLine("Active Loans:");
            foreach (var loan in loans)
            {
                Console.WriteLine($"Borrower: {loan.LibraryCard.Borrower.Name}");
                Console.WriteLine($"Item: {loan.Item.GetType().Name}");
                Console.WriteLine($"Due Date: {loan.DueDate}");
                Console.WriteLine();
            }
        }
    }
}
