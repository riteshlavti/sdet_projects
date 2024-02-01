using System.ComponentModel.DataAnnotations;

namespace LibraryManagementSystem
{
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

        private DateTime Date;

        protected BookType Type
        {
            get; set;
        }
        public int BookId
        {
            get;
        }
        public BookDetails(string title, string author, string publication, DateTime date, int bookId)
        {
            Title = title;
            Author = author;
            Publication = publication;
            Date = date;
            BookId=bookId;
        }

    }
    class FictionalBook : BookDetails
    {
        
        public FictionalBook(string title, string author, string publication, DateTime date, int bookId) : base(title, author, publication, date, bookId)
        {
            Type = BookType.FictionalBook;       
        }
    }
    class HorrorBook : BookDetails
    {
        public HorrorBook(string title, string author, string publication, DateTime date, int bookId) : base(title, author, publication, date, bookId)
        {
            Type = BookType.HorrorBook;       
        }
    }
    class AdventureBook : BookDetails
    {
        public AdventureBook(string title, string author, string publication, DateTime date, int bookId) : base(title, author, publication, date, bookId)
        {
            Type = BookType.AdventureBook;       
        }

    }
}
