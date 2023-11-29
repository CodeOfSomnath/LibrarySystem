// This class contains Library implementation all functions and class are related to Library
// addBook - for adding books
// removeBook - for removing books
// widrawBook - for widraw books
// submitBook - for submit books
// These functions are supported by This Library class later it will updated

namespace LibrarySystem
{
    
    public class Library {
        // this variable stores all books avaliable in library
        LinkedList<Book> storedBooks;
        // this variable stores borrowed books but it have to avaliable in stored books
        LinkedList<Book> borrowedBooks;

        public Library()
        {
            storedBooks = new LinkedList<Book>();
            borrowedBooks = new LinkedList<Book>();
        }

        // This add book in library by taking a book
        public void AddBook(Book book)
        {
            storedBooks.AddLast(book);
        }


        // This can return book by checking if it contains in library stored books
        // title - This is title of the book
        // author - This is author of the Book
        // it returns null if book isnot stored
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

        // This function is used for borrow book from library
        // title - The name of the book which you are want
        // author - The author of the book
        // returns null if book is not found
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

        // This functon is used for submit book
        // title - This is title for book
        // author - This is author for book
        // returns if submitted accepted or not
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

        // This function returns the string of the library
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