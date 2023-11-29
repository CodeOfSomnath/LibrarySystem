/**
 * This file contains all functions and class related Book
 * This file contains Book class which is represent the actual Book
 * This is now only support the representation of the Book
 */
namespace LibrarySystem
{
    // This is a implementation of book representation
    public class Book
    {
        // This attribute contains file Name it can only access but not asignable
        public string Title { get; }
        // This attribure contains author it can only assign
        public string Author { get; }

        // this constructor creates Book with title and author
        // title - file name
        // author - author name
        public Book(string title, string author)
        {
            Author = author;
            Title = title;
        }


        // checks Book is equal to another  Book 
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

        // it is returns Book as string
        public override string ToString()
        {
            return $"{{Title: {Title}, Author: {Author}}}";
        }


    }
}