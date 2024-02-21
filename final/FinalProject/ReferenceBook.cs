namespace LibraryManagement
{
    public class ReferenceBook : Book
    {
        public string Topic { get; private set; }

        public ReferenceBook(string title, string author, int year, string topic) : base(title, author, year)
        {
            Topic = topic;
        }

        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine($"Topic: {Topic}");
        }
    }
}
