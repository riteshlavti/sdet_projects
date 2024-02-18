using System.Text.RegularExpressions;
using BookManagementSystem;

namespace BookManagementTesting
{
    [TestFixture]
    public class BookDetailPattern_RegexTest
    {
        bool falseValue = false;
        bool trueValue = true;
        
        [Test]
        public void RegexMatch_TitleAndPublicationInput_ValidString()
        {
            string validInput = "100 Laws of Nature";

            bool isMatch = Regex.IsMatch(validInput, BookDetailPattern.titleAndPublicationPattern);

            Assert.That(trueValue,Is.EqualTo(isMatch));
        }

        [Test]
        public void RegexMatch_TitleAndPublicationInput_InValidString()
        {
            string invalidInput = "100 Laws of Nature$$";

            bool isMatch = Regex.IsMatch(invalidInput, BookDetailPattern.titleAndPublicationPattern);

            Assert.That(falseValue,Is.EqualTo(isMatch));
        }

        [Test]
        public void RegexMatch_AuthorInput_ValidString()
        {
            string validInput = "Jay Shah";

            bool isMatch = Regex.IsMatch(validInput, BookDetailPattern.authorPattern);

            Assert.That(trueValue,Is.EqualTo(isMatch));
        }

        [Test]
        public void RegexMatch_AuthorInput_InValidString()
        {
            string invalidInput = "Jay12";

            bool isMatch = Regex.IsMatch(invalidInput, BookDetailPattern.authorPattern);

            Assert.That(falseValue,Is.EqualTo(isMatch));
        }

        [Test]
        public void RegexMatch_PublicationYearInput_ValidString()
        {
            string validInput = "2002";

            bool isMatch = Regex.IsMatch(validInput, BookDetailPattern.yearPattern);

            Assert.That(trueValue,Is.EqualTo(isMatch));
        }

        [Test]
        public void RegexMatch_PublicationYearInput_InValidString()
        {
            string invalidInput = "20023";

            bool isMatch = Regex.IsMatch(invalidInput, BookDetailPattern.yearPattern);

            Assert.That(falseValue,Is.EqualTo(isMatch));
        }

        [Test]
        public void RegexMatch_UserChoiceInput_ValidString()
        {
            string validInput = "1";

            bool isMatch = Regex.IsMatch(validInput, BookDetailPattern.userChoicePattern);

            Assert.That(trueValue,Is.EqualTo(isMatch));
        }

        [Test]
        public void RegexMatch_UserChoiceInput_InValidString()
        {
            string invalidInput = "a";

            bool isMatch = Regex.IsMatch(invalidInput, BookDetailPattern.userChoicePattern);

            Assert.That(falseValue,Is.EqualTo(isMatch));
        }
    }
}