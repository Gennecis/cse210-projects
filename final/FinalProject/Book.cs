using System;

namespace LibraryManagement
{
    public class Book
    {
        public string Title { get; private set; }
        public string Author { get; private set; }
        public int Year { get; private set; }
        public bool IsAvailable { get; private set; }

        public Book(string title, string author, int year)
        {
            Title = title;
            Author = author;
            Year = year;
            IsAvailable = true;
        }

        public void SetAvailability(bool isAvailable)
        {
            IsAvailable = isAvailable;
        }

        public virtual void DisplayDetails()
        {
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Author: {Author}");
            Console.WriteLine($"Year: {Year}");
            Console.WriteLine($"Available: {(IsAvailable ? "Yes" : "No")}");
        }
    }
}
