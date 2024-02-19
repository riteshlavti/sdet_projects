using System.Text.RegularExpressions;
using BookManagementSystem;

namespace BookManagementTesting
{
    [TestFixture]
    public class BookDetailPatternRegexTest
    {   
        [Test]
        public void RegexMatchTitleAndPublicationInputValidString()
        {
            Assert.IsTrue(Regex.IsMatch("100 Laws of Nature", BookDetailPattern.titleAndPublicationPattern));
        }

        [Test]
        public void RegexMatchTitleAndPublicationInputInValidString()
        {
            Assert.IsFalse(Regex.IsMatch("100 Laws of Nature$$", BookDetailPattern.titleAndPublicationPattern));
        }

        [Test]
        public void RegexMatchAuthorInputValidString()
        {
            Assert.IsTrue(Regex.IsMatch("Jay Shah", BookDetailPattern.authorPattern));
        }

        [Test]
        public void RegexMatchAuthorInputInValidString()
        {
            Assert.IsFalse(Regex.IsMatch("Jay Shah", BookDetailPattern.authorPattern));
        }

        [Test]
        public void RegexMatchPublicationYearInputValidString()
        {
            Assert.IsTrue(Regex.IsMatch("2002", BookDetailPattern.yearPattern));
        }

        [Test]
        public void RegexMatchPublicationYearInputInValidString()
        {
            Assert.IsFalse(Regex.IsMatch("20022", BookDetailPattern.yearPattern));
        }

        [Test]
        public void RegexMatchUserChoiceInputValidString()
        {
            Assert.IsTrue(Regex.IsMatch("1", BookDetailPattern.userChoicePattern));
        }

        [Test]
        public void RegexMatchUserChoiceInputInValidString()
        {
            Assert.IsFalse(Regex.IsMatch("a", BookDetailPattern.userChoicePattern));
        }
    }
}