namespace BookManagementSystem
{
    /// <summary>
    /// This class contains the details of book.
    /// </summary>
    public abstract class BookDetails
    {
        public string Title
        {
            get; set;
        }
        public string Author
        {
            get; set;
        }
        public string Publication
        {
            get; set;
        }
        public DateTime PublicationYear
        {
            get; set;
        }
        protected BookType Type
        {
            get; set;
        }
        public int BookId
        {
            get;
        }
        public BookDetails(string title, string author, string publication, DateTime publicationYear, int bookId)
        {
            Title = title;
            Author = author;
            Publication = publication;
            PublicationYear = publicationYear;
            BookId = bookId;
        }
    }

    class FictionalBook : BookDetails
    {
        public FictionalBook(string title, string author, string publication, DateTime publicationYear, int bookId)
        : base(title, author, publication, publicationYear, bookId)
        {
            Type = BookType.FictionalBook;
        }
    }

    class HorrorBook : BookDetails
    {
        public HorrorBook(string title, string author, string publication, DateTime publicationYear, int bookId)
        : base(title, author, publication, publicationYear, bookId)
        {
            Type = BookType.HorrorBook;
        }
    }

    class AdventureBook : BookDetails
    {
        public AdventureBook(string title, string author, string publication, DateTime publicationYear, int bookId)
        : base(title, author, publication, publicationYear, bookId)
        {
            Type = BookType.AdventureBook;
        }
    }
}