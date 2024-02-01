using System.Diagnostics;
using System.Transactions;

namespace LibraryManagementSystem;

interface IBookOperation
{
    void AddBook();
    void DeleteBook();
    void UpdateBook();
    void SearchBook();
    void ListBooks();
}
public class BookManager : IBookOperation
{
    private List<BookDetails> list ;
    public BookManager()
    {
       list = new List<BookDetails>();
    }
    public static void Start()
    {
        Console.WriteLine("""
                        Select the operation which you want to use- 
                        1. Add Book
                        2. Delete Book
                        3. Update Book
                        4. Search Book
                        5. List Books
                        6. Exit
                        """);

        int bookOperation = Convert.ToInt32(Console.ReadLine());

        BookManager obj = new BookManager();

        switch (bookOperation)
        {
            case 1:
                obj.AddBook();
                break;
            case 2:
                obj.DeleteBook();
                break;
            case 3:
                obj.UpdateBook();
                break;
            case 4:
                obj.SearchBook();
                break;
            case 5:
                obj.ListBooks();
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
            list.Add(book);
        }
        else if (bookType == (int)BookType.HorrorBook)
        {
            HorrorBook book = new HorrorBook(title, author, publication, obj, bookId);
            list.Add(book);
        }
        else
        {
            AdventureBook book = new AdventureBook(title, author, publication, obj, bookId);
            list.Add(book);
        }
        Console.WriteLine("{0} added succesfully! ", title);
    }
    public void DeleteBook()
    {
        Console.WriteLine("Enter the book Id which you want to delete - ");
        int bookId = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("length of list : "+ list.Count);
        foreach (var item in list)
        {
            if (item.BookId == bookId)
            {
                Console.WriteLine("{0} deleted succesfully! ", item.Title);
                list.Remove(item);
            }
        }
        Console.WriteLine("Can't find book");
    }
    public void UpdateBook()
    {
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
            foreach (var item in list)
            {
                if (item.BookId == bookId)
                {
                    item.Title = title;
                    Console.WriteLine("Book updated successfully!");
                    break;
                }
            }
        }
        else if (menuOption == 2)
        {
            Console.Write("Enter new Author - ");
            string title = Console.ReadLine();
            foreach (BookDetails item in list)
            {
                if (item.BookId == bookId)
                {
                    item.Title = title;
                    Console.WriteLine("Book updated successfully!");
                    break;
                }

            }

        }
        else if (menuOption == 3)
        {
            Console.Write("Enter new Publication - ");
            string title = Console.ReadLine();
            foreach (var item in list)
            {
                if (item.BookId == bookId)
                {
                    item.Title = title;
                    Console.WriteLine("Book updated successfully!");
                    break;
                }
            }
        }
        else
        {
            Console.WriteLine("Enter the correct option - ");
            UpdateBook();
        }        
    }
    public void SearchBook()
    {
        Console.WriteLine("Enter the book Id - ");
        int bookId = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(list.Count);
        foreach (var item in list)
        {
            Console.WriteLine("searching...{0}",item.BookId);
            
            if (item.BookId == bookId)
            {
                Console.WriteLine("Your book is - " + item.Title);
                Start();
            }

        }
        Console.WriteLine("Can't find book!");
    }
    public void ListBooks()
    {
        Console.WriteLine("Available books are - ");
        foreach (var item in list)
        {
            Console.WriteLine("{0} written by {1} and pulished by {2}.", item.Title, item.Author, item.Publication);
        }
    }
}
