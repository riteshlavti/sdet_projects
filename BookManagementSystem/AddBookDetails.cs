using System.Net;
namespace BookManagementSystem;

/// <summary>
/// This class is used for adding books to list and it is inheriting BookOperation class.
/// </summary>
public class AddBookDetails : BookOperation
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
        string bookTypeString = Console.ReadLine();
        Console.WriteLine(Patterns.CheckOptionsInput(bookTypeString));
        if (!Patterns.CheckOptionsInput(bookTypeString))
        {
            return;
        }
        int bookType  = Convert.ToInt32(bookTypeString);

        Console.WriteLine("Enter the title of Book - ");
        string title = Console.ReadLine();
        if (!Patterns.CheckTitleAndPublicationInput(title))
        {
            return;
        }

        Console.WriteLine("Enter the author of Book - ");
        string author = Console.ReadLine();
        if (!Patterns.CheckAuthorInput(author))
        {
            return;
        }

        Console.WriteLine("Enter the publisher of Book - ");
        string publication = Console.ReadLine();
        if (!Patterns.CheckTitleAndPublicationInput(publication))
        {
            return;
        }

        Console.Write("Enter publication year - ");
        string publicationYearString = Console.ReadLine();
        if (!Patterns.CheckYearPattern(publicationYearString))
        {
            return;
        }
        DateTime publicationYear = new DateTime(int.Parse(publicationYearString), 1, 1);

        Console.WriteLine("Enter the book Id- ");
        string bookIdString = Console.ReadLine();
        if(!Patterns.CheckBookIdPattern(bookIdString))
        {
            return;
        }
        int bookId = Convert.ToInt32(bookIdString);

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
}