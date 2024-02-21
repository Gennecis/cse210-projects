namespace LibraryManagement
{
    public class Author
    {
        public string Name { get; private set; }
        public string Bio { get; private set; }

        public Author(string name, string bio)
        {
            Name = name;
            Bio = bio;
        }
    }
}
