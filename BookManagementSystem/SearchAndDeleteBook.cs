namespace BookManagementSystem
{
    /// <summary>
    /// This class is used for searching and deleting books with the help of book id 
    /// and it is inheriting BookOperation class.
    /// </summary>
    public class SearchAndDeleteBook : BookOperation
    {

        /// <summary>
        /// This method is used for searching books in the list.
        /// </summary>
        public static void SearchBook()
        {
            Console.WriteLine("---SEARCH A BOOK---");
            Console.WriteLine("Enter the book Id - ");
            string bookIdString = Console.ReadLine();
            if (!Patterns.CheckBookIdPattern(bookIdString))
            {
                return;
            }
            int bookId = Convert.ToInt32(Console.ReadLine());

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
            Console.WriteLine("Enter the book Id which you want to delete - ");
            string bookIdString = Console.ReadLine();
            if (!Patterns.CheckBookIdPattern(bookIdString))
            {
                return;
            }
            int bookId = Convert.ToInt32(bookIdString);

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
    }
}