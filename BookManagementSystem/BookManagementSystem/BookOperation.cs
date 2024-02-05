namespace BookManagementSystem;

/// <summary>
/// This class is used for adding books to list and it is inheriting BookOperation class.
/// </summary>
public class BookOperation : BookManager
{
    /// <summary>
    /// This method is used to add the books in the list.
    /// </summary>
    public static void AddBook()
    {
        Console.WriteLine("---ADDING A BOOK---");

        Console.WriteLine("Which type of book you want to add - ");
        string bookTypeMenu = """
                    1. Fictional Book.
                    2. Horror Book.
                    3. Adventurer Book.
                    """;
        Console.WriteLine(bookTypeMenu);
        int bookType = UserInput.InputMenuOption();

        string title = UserInput.InputBookTitle();
        string author = UserInput.InputBookAuthor();
        string publication = UserInput.InputBookPublication();
        DateTime publicationYear = UserInput.InputBookPublicationYear();
        int bookId = UserInput.InputBookID();

        if (bookType == (int)BookType.FictionalBook)
        {
            FictionalBook book = new FictionalBook(title, author, publication, publicationYear, bookId);
            bookList.Add(book);
        }
        else if (bookType == (int)BookType.HorrorBook)
        {
            HorrorBook book = new HorrorBook(title, author, publication, publicationYear, bookId);
            bookList.Add(book);
        }
        else
        {
            AdventureBook book = new AdventureBook(title, author, publication, publicationYear, bookId);
            bookList.Add(book);
        }
        Console.WriteLine("{0} added succesfully! ", title);
    }

    /// <summary>
    /// This method is used for searching books in the list.
    /// </summary>
    public static void SearchBook()
    {
        Console.WriteLine("---SEARCH A BOOK---");
        int bookId = UserInput.InputBookID();

        BookDetails book = ReturnBookByID(bookId);
        if (book == null)
        {
            return;
        }
        Console.WriteLine("Your book is - {0}, written by {1} and published by {2}", book.Title, book.Author, book.Publication);
    }

    /// <summary>
    /// This method is used for deleting book in the list.
    /// </summary>
    public static void DeleteBook()
    {
        Console.WriteLine("---DELETE A BOOK---");
        int bookId = UserInput.InputBookID();

        BookDetails book = ReturnBookByID(bookId);
        if (book == null)
        {
            return;
        }
        else
        {
            bookList.Remove(book);
            Console.WriteLine("Book deleted successfully!");
        }
    }

    /// <summary>
    /// This method is used to update the book details.
    /// </summary>
    public static void UpdateBook()
    {
        Console.WriteLine("---UPDATE BOOK DETAIL---");
        Console.Write("Enter the book Id - ");

        int bookId = Convert.ToInt32(Console.ReadLine());
        BookDetails book = ReturnBookByID(bookId);
        if (book == null)
        {
            return;
        }

        string menu = """
                        Enter the option which you want to update -
                        1. Title
                        2. Author
                        3. Publication
                        4. Publishing year
                        """;
        Console.WriteLine(menu);
        int menuOption = UserInput.InputMenuOption();

        if (menuOption == 1)
        {
            book.Title = UserInput.InputBookTitle();
            Console.WriteLine("Book title updated successfully!");
        }
        else if (menuOption == 2)
        {
            book.Author = UserInput.InputBookAuthor();
            Console.WriteLine("Book author updated successfully!");

        }
        else if (menuOption == 3)
        {
            book.Publication = UserInput.InputBookPublication();
            Console.WriteLine("Book publication updated successfully!");

        }
        else if (menuOption == 4)
        {
            book.PublicationYear = UserInput.InputBookPublicationYear();
            Console.WriteLine("Book publication year updated successfully!");
        }
        else
        {
            Console.WriteLine("Enter the correct option - ");
            UpdateBook();
        }
    }
}