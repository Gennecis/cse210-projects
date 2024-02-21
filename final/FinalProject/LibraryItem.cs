namespace LibraryManagement
{
    public abstract class LibraryItem
    {
        public string Id { get; private set; }

        public LibraryItem()
        {
            Id = System.Guid.NewGuid().ToString();
        }

        public abstract void DisplayDetails();
    }
}
