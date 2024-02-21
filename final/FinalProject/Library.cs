using System;
using System.Collections.Generic;

namespace LibraryManagement
{
    public class Library
    {
        private List<LibraryItem> items;

        public Library()
        {
            items = new List<LibraryItem>();
        }

        public void AddItem(LibraryItem item)
        {
            items.Add(item);
        }

        public void DisplayItems()
        {
            foreach (var item in items)
            {
                item.DisplayDetails();
                Console.WriteLine();
            }
        }
    }
}
