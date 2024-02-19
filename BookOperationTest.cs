using BookManagementSystem;
using NuGet.Frameworks;

namespace BookManagementTesting
{
    public class BookOperationUnitTest
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
        public void TestAddBook()
        {
            Assert.That(1, Is.EqualTo(BookManager.bookList.Count));
        }

        [Test]
        public void TestDeleteBook()
        {
            Assert.IsTrue(BookOperation.DeleteBook(bookId));
        }

        [Test]
        public void TestSearchBook()
        {
            BookDetails testBook = BookOperation.SearchBook(bookId);
            Assert.That(testBook.Title, Is.EqualTo(book.Title));
            Assert.That(testBook.Author, Is.EqualTo(book.Author));
            Assert.That(testBook.Publication, Is.EqualTo(book.Publication));
        }

        [Test]
        public void TestUpdateBookStringInput()
        {
            string input = "new_input";
            BookOperation.UpdateBook(bookId, 1, input);
            Assert.That(book.Title, Is.EqualTo(input));
        }

        [Test]
        public void TestUpdateBookPublicationDate()
        {
            DateTime testPublicationYear = new DateTime(2000, 01, 01);
            BookOperation.UpdateBook(bookId, 1, testPublicationYear);
            Assert.That(book.PublicationYear, Is.EqualTo(testPublicationYear));
        }

        [Test]
        public void TestReturnBookById()
        {
            Assert.That(book.BookId, Is.EqualTo(BookManager.ReturnBookByID(bookId).BookId));
        }

        [Test]
        public void TestReturnBookByIdInvalidIDCase()
        {
            Assert.IsNull(BookManager.ReturnBookByID(2));
        }
    }
}