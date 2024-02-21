using System;

namespace LibraryManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();

            while (true)
            {
                Console.WriteLine("Library Management System");
                Console.WriteLine("1. Add Book");
                Console.WriteLine("2. Display All Items");
                Console.WriteLine("3. Exit");
                Console.Write("Enter your choice: ");

                int choice;
                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Invalid choice. Please enter a number.");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        AddBook(library);
                        break;
                    case 2:
                        DisplayAllItems(library);
                        break;
                    case 3:
                        Console.WriteLine("Exiting the program. Goodbye!");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please enter a valid option.");
                        break;
                }
            }
        }

        static void AddBook(Library library)
        {
            Console.Write("Enter book title: ");
            string title = Console.ReadLine();
            Console.Write("Enter book author: ");
            string author = Console.ReadLine();
            Console.Write("Enter publication year: ");
            int year;
            if (!int.TryParse(Console.ReadLine(), out year))
            {
                Console.WriteLine("Invalid year. Please enter a number.");
                return;
            }

            Book book = new Book(title, author, year);
            LibraryBook libraryBook = new LibraryBook(book);
            library.AddItem(libraryBook);

            Console.WriteLine("Book added successfully!");
        }

        static void DisplayAllItems(Library library)
        {
            Console.WriteLine("All Items in the Library:");
            library.DisplayItems();
        }
    }
}
