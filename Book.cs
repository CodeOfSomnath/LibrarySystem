namespace LibrarySystem
{
    // This is a implementation of book representation
    public class Book
    {
        public string Title { get; }
        public string Author { get; }
        
        public Book(string title, string author)
        {
            Author = author;
            Title = title;
        }


        public override bool Equals(object? obj)
        {
            if (obj == null)
            {
                return false;
            }
            var book = obj as Book;
            if (book.Title == Title && book.Author == Author)
            {
                return true;
            }
            return false;
        }


        public override string ToString()
        {
            return $"{{Title: {Title}, Author: {Author}}}";
        }


    }
}