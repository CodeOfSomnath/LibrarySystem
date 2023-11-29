namespace LibrarySystem
{
    public class Library {
        LinkedList<Book> storedBooks;
        LinkedList<Book> borrowedBooks;
        public Library()
        {
            storedBooks = new LinkedList<Book>();
            borrowedBooks = new LinkedList<Book>();
        }

        public void AddBook(Book book)
        {
            storedBooks.AddLast(book);
        }

        public Book? RemoveBook(string title, string author)
        {
            var book = new Book(title, author);
            bool isRemoved = storedBooks.Remove(book);
            if (isRemoved)
            {
                return book;
            }
            return null;
        }


        public Book? BorrowBook(string title, string author)
        {
            var book = new Book(title, author);
            bool hasBook = storedBooks.Remove(book);
            if (hasBook)
            {
                borrowedBooks.AddLast(book);
                return book;
            }
            return null;
        }


        public bool SubmitBook(string title, string author)
        {
            var book = new Book(title, author);
            bool isBorrowed = borrowedBooks.Remove(book);
            if (isBorrowed)
            {
                storedBooks.AddLast(book);
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            string result = "Stored Books are:\n";
            foreach (var book in storedBooks)
            {
                result += $"\n\t{book}";
            }
            result += "\n\nBorrowed Books are:\n";
            foreach (var book in borrowedBooks)
            {
                result += $"\n\t{book}";
            }
            return result;
        }

    }
}