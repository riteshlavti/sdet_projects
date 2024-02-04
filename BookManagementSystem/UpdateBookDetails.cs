namespace BookManagementSystem;
/// <summary>
/// This class is used for Updating book details and it is inheriting BookOperation class.
/// </summary>
public class UpdateBookDetails : BookOperation
{
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
        int menuOption = Convert.ToInt32(Console.ReadLine());

        if (menuOption == 1)
        {
            Console.Write("Enter new title - ");
            string title = Console.ReadLine();
            if (!Patterns.CheckTitleAndPublicationInput(title))
            {
                return;
            }
            book.Title = title;
        }
        else if (menuOption == 2)
        {
            Console.Write("Enter new Author - ");
            string author = Console.ReadLine();
            if (!Patterns.CheckAuthorInput(author))
            {
                return;
            }
            book.Author = author;
        }
        else if (menuOption == 3)
        {
            Console.Write("Enter new Publication - ");
            string publication = Console.ReadLine();
            if (!Patterns.CheckTitleAndPublicationInput(publication))
            {
                return;
            }
            book.Publication = publication;
        }
        else if (menuOption == 4)
        {
            Console.Write("Enter new publishing year -");
            string publicationYearString = Console.ReadLine();
            if (!Patterns.CheckYearPattern(publicationYearString))
            {
                return;
            }
            DateTime publicationYear = new DateTime(int.Parse(publicationYearString), 1, 1);
            book.PublicationYear = publicationYear;
        }
        else
        {
            Console.WriteLine("Enter the correct option - ");
            UpdateBook();
        }
    }
}
