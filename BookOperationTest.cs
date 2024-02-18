using BookManagementSystem;
using NuGet.Frameworks;

namespace BookManagementTesting
{
    public class BookOperation_UnitTest
    {
        int bookType = 1, bookId = 1;
        string title = "xyz", author = "zzz", publication = "yyy";
        DateTime publicationYear;
        BookDetails book;

        [SetUp]
        public void SetUpForTest()
        {
            book = BookOperation.AddBook(bookType, bookId, title, author, publication, publicationYear);
            publicationYear = new DateTime(2002, 1, 1);
        }

        [Test]
        public void Test_AddBook()
        {
            int count =1;
            Assert.That(count, Is.EqualTo(BookManager.bookList.Count));
        }

        [Test]
        public void Test_DeleteBook()
        {
            bool result = BookOperation.DeleteBook(bookId);
            Assert.IsTrue(result);
        }

        [Test]
        public void Test_SearchBook()
        {
            BookDetails testBook = BookOperation.SearchBook(bookId);
            Assert.That(testBook.Title, Is.EqualTo(book.Title));
            Assert.That(testBook.Author, Is.EqualTo(book.Author));
            Assert.That(testBook.Publication, Is.EqualTo(book.Publication));
        }

        [Test]
        public void Test_UpdateBook_stringInput()
        {
            int menuOption = 1;
            string input = "new_input";
            BookOperation.UpdateBook(bookId, menuOption, input);
            Assert.That(book.Title, Is.EqualTo(input));
        }

        [Test]
        public void Test_UpdateBook_publicationDate()
        {
            int menuOption = 1;
            DateTime testPublicationYear = new DateTime(2000, 01, 01);
            BookOperation.UpdateBook(bookId, menuOption, testPublicationYear);
            Assert.That(book.PublicationYear, Is.EqualTo(testPublicationYear));
        }

        [Test]
        public void Test_ReturnBookById()
        {
            BookDetails testBook = BookManager.ReturnBookByID(bookId);
            Assert.That(book.BookId, Is.EqualTo(testBook.BookId));
        }

        [Test]
        public void Test_ReturnBookById_InvalidIDCase()
        {
            int testBookId = 2;
            BookDetails testBook = BookManager.ReturnBookByID(testBookId);
            Assert.IsNull(testBook);
        }
    }
}