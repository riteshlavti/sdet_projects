namespace BookManagementSystem;
public class BookOperation
{
    protected static List<BookDetails> bookList = new List<BookDetails>();

    /// <summary>
    /// This method is used to start the application.
    /// </summary>
    public void StartApp()
    {
        Console.WriteLine();
        Console.WriteLine("""
                        ------SELECT A OPERATION WHICH YOU WANT TO PERFORM------ 
                        1. Add Book
                        2. Delete Book
                        3. Update Book
                        4. Search Book
                        5. List Books
                        6. Exit
                        """);

        string bookOperationString = Console.ReadLine();
        if (!Patterns.CheckOptionsInput(bookOperationString))
        {
            return;
        }
        int bookOperation = Convert.ToInt32(bookOperationString);

        switch (bookOperation)
        {
            case 1:
                AddBookDetails.AddBook();
                break;
            case 2:
                SearchAndDeleteBook.DeleteBook();
                break;
            case 3:
                UpdateBookDetails.UpdateBook();
                break;
            case 4:
                SearchAndDeleteBook.SearchBook();
                break;
            case 5:
                DisplayAllBooks();
                break;
            case 6:
                Environment.Exit(0);
                break;
            default:
                Console.WriteLine("Choose correct option.");
                StartApp();
                break;
        }
        StartApp();
    }

    /// <summary>
    /// This method is used to display all books store in list.
    /// </summary>
    public void DisplayAllBooks()
    {
        Console.WriteLine("---BOOKS IN LIBRARY ARE---");

        if (bookList.Count == 0)
        {
            Console.WriteLine("There are no books available in library.");
        }

        foreach (var book in bookList)
        {
            Console.WriteLine("{0} written by {1} and pulished by {2} in year {3}.", book.Title, book.Author, book.Publication, book.PublicationYear.Year);
        }
    }

    /// <summary>
    /// This method is used to return the book with the help of book Id.
    /// </summary>
    /// <param name="bookId">This is the book id provided by the user.</param>
    /// <returns>It return the book if id is valid otherwise it returns null.</returns>
    public static BookDetails ReturnBookByID(int bookId)
    {
        foreach (BookDetails book in bookList)
        {
            if (book.BookId == bookId)
            {
                return book;
            }
        }
        Console.WriteLine("Book ID invalid!");
        return null;
    }
}