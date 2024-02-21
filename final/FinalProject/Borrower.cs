namespace LibraryManagement
{
    public class Borrower
    {
        public string Name { get; private set; }

        public Borrower(string name)
        {
            Name = name;
        }
    }
}
