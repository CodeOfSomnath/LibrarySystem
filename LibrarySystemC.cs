namespace LibrarySystem
{
    public class LibrarySystemC
    {
        Library library;
        public LibrarySystemC()
        {
            library = new Library();
        }

        public void showOptions()
        {
            Console.WriteLine("Options are:");
            Console.WriteLine("\t1.Add Book");
            Console.WriteLine("\t2.Borrow Book");
            Console.WriteLine("\t3.Submit Book");
            Console.WriteLine("\t4.Remove Book");
            Console.WriteLine("\t5.Show Options");
            Console.WriteLine("\t6.Show Books");
            Console.WriteLine("\t7.Exit");
        }

        public void start()
        {
            Console.WriteLine("######## Welcome to Library System ########");
            showOptions();
            while (true)
            {
                Console.WriteLine("Enter your option(option number): ");
                string? inp = Console.ReadLine();
                if (inp == null)
                {
                    showOptions();
                    continue;
                }

                if (inp == "7")
                {
                    break;
                }

                if (inp == "1")
                {
                    Console.Write("Enter book name: ");
                    string? title = Console.ReadLine();
                    Console.Write("Enter book author: ");
                    string? author = Console.ReadLine();

                    if (title == null || author == null)
                    {
                        continue;
                    }
                    var book = new Book(title, author);
                    library.AddBook(book);
                    Console.WriteLine("Book successfully added...");
                }

                if (inp == "2")
                {
                    Console.Write("Enter book name: ");
                    string? title = Console.ReadLine();
                    Console.Write("Enter book author: ");
                    string? author = Console.ReadLine();

                    if (title == null || author == null)
                    {
                        continue;
                    }

                    var book = library.BorrowBook(title, author);
                    if (book != null)
                    {
                        Console.WriteLine("Book is successfully borrowed...");
                    }
                }

                if (inp == "3")
                {
                    Console.Write("Enter book name: ");
                    string? title = Console.ReadLine();
                    Console.Write("Enter book author: ");
                    string? author = Console.ReadLine();

                    if (title == null || author == null)
                    {
                        continue;
                    }

                    bool isSubmitAble  = library.SubmitBook(title,author);
                    if (isSubmitAble)
                    {
                        Console.WriteLine("Book is successfully submitted...");
                    }
                }

                if (inp == "4")
                {
                    Console.Write("Enter book name: ");
                    string? title = Console.ReadLine();
                    Console.Write("Enter book author: ");
                    string? author = Console.ReadLine();

                    if (title == null || author == null)
                    {
                        continue;
                    }

                    var book = library.RemoveBook(title, author);
                    if (book != null)
                    {
                        Console.WriteLine("Book is successfully removed...");
                    }
                }

                if (inp == "5")
                {
                    showOptions();
                }

                if (inp == "6")
                {
                    Console.WriteLine(library);
                }


            }

        }

    }
}