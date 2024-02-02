namespace BookManagementSystem;
interface IBookOperation
{
    void AddBook();
    void DeleteBook();
    void UpdateBook();
    void SearchBook();
    void ListBooks();
}
public class BookManagement : IBookOperation
{
    private List<BookDetails> bookList = new List<BookDetails>();
    public void Start()
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
        int bookOperation = Convert.ToInt32(Console.ReadLine());
        switch (bookOperation)
        {
            case 1:
                AddBook();
                break;
            case 2:
                DeleteBook();
                break;
            case 3:
                UpdateBook();
                break;
            case 4:
                SearchBook();
                break;
            case 5:
                ListBooks();
                break;
            case 6:
                Environment.Exit(0);
                break;
            default:
                Console.WriteLine("Choose correct option.");
                Start();
                break;
        }
        Start();
    }
    public void AddBook()
    {
        Console.WriteLine("---ADDING A BOOK---");
        Console.WriteLine("Which type of book you want to add - ");
        string bookTypeMenu = """
                    1. Fictional Book.
                    2. Horror Book.
                    3. Adventurer Book.
                    """;
        Console.WriteLine(bookTypeMenu);
        int bookType = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the title of Book - ");
        string title = Console.ReadLine();
        Console.WriteLine("Enter the author of Book - ");
        string author = Console.ReadLine();
        Console.WriteLine("Enter the publisher of Book - ");
        string publication = Console.ReadLine();
        DateTime obj = DateTime.Now;
        Console.WriteLine("Enter the book Id- ");
        int bookId = Convert.ToInt32(Console.ReadLine());
        if (bookType == (int)BookType.FictionalBook)
        {
            FictionalBook book = new FictionalBook(title, author, publication, obj, bookId);
            bookList.Add(book);
        }
        else if (bookType == (int)BookType.HorrorBook)
        {
            HorrorBook book = new HorrorBook(title, author, publication, obj, bookId);
            bookList.Add(book);
        }
        else
        {
            AdventureBook book = new AdventureBook(title, author, publication, obj, bookId);
            bookList.Add(book);
        }
        Console.WriteLine("{0} added succesfully! ", title);
    }
    public void DeleteBook()
    {
        Console.WriteLine("---DELETE A BOOK---");
        Console.WriteLine("Enter the book Id which you want to delete - ");
        int bookId = Convert.ToInt32(Console.ReadLine());
        foreach (var item in bookList)
        {
            if (item.BookId == bookId)
            {
                Console.WriteLine("{0} deleted succesfully! ", item.Title);
                bookList.Remove(item);
                return;     
            }
        }
        Console.WriteLine("Can't find book");
    }
    public void UpdateBook()
    {
        Console.WriteLine("---UPDATE BOOK DETAIL---");
        Console.Write("Enter the book Id - ");
        int bookId = Convert.ToInt32(Console.ReadLine());
        string menu = """
                        Enter the option which you want to update -
                        1. Title
                        2. Author
                        3. Publication
                        """;
        Console.WriteLine(menu);
        int menuOption = Convert.ToInt32(Console.ReadLine());
        if (menuOption == 1)
        {
            Console.Write("Enter new title - ");
            string title = Console.ReadLine();
            foreach (var item in bookList)
            {
                if (item.BookId == bookId)
                {
                    item.Title = title;
                    Console.WriteLine("Book updated successfully!");
                    return;
                }
            }
        }
        else if (menuOption == 2)
        {
            Console.Write("Enter new Author - ");
            string author = Console.ReadLine();
            foreach (BookDetails item in bookList)
            {
                if (item.BookId == bookId)
                {
                    item.Title = author;
                    Console.WriteLine("Book updated successfully!");
                    return;
                }
            }
        }
        else if (menuOption == 3)
        {
            Console.Write("Enter new Publication - ");
            string publication = Console.ReadLine();
            foreach (var item in bookList)
            {
                if (item.BookId == bookId)
                {
                    item.Title = publication;
                    Console.WriteLine("Book updated successfully!");
                    return;
                }
            }
        }
        else
        {
            Console.WriteLine("Enter the correct option - ");
        }
    }
    public void SearchBook()
    {
        Console.WriteLine("---SEARCH A BOOK---");
        Console.WriteLine("Enter the book Id - ");
        int bookId = Convert.ToInt32(Console.ReadLine());
        foreach (var book in bookList)
        {
            if (book.BookId == bookId)
            {
                Console.WriteLine("Your book is - {0}, written by {1} and published by {2}", book.Title,book.Author,book.Publication);
                return;                 
            }
        }
        Console.WriteLine("Can't find book!");
    }
    public void ListBooks()
    {
        Console.WriteLine("---BOOKS IN LIBRARY ARE---");
        if(bookList.Count==0)
        {
            Console.WriteLine("There are no books available in library.");
        }
        foreach (var book in bookList)
        {
            Console.WriteLine("{0} written by {1} and pulished by {2}.", book.Title, book.Author, book.Publication);
        }
    }
}

