using System.Formats.Asn1;
using System.Text.RegularExpressions;
namespace BookManagementSystem
{
    /// <summary>
    /// Patterns class contain different patterns required to validate the user input.
    /// </summary>
    public class Patterns
    {
        const string titleAndPublicationPattern = @"[A-Za-z0-9]+$";
        const string authorPattern = @"[A-za-z]+$";
        const string optionsPattern = @"\d{1}$";
        const string yearPattern = @"^(1\d{3}|2\d{3})$";
        const string bookIdPattern = @"[0-9]+$";
        public static Regex titleAndPublicationPatternRegex = new Regex(titleAndPublicationPattern);
        public static Regex authorPatternRegex = new Regex(authorPattern);
        public static Regex optionsPatternRegex = new Regex(optionsPattern);
        public static Regex yearPatternRegex = new Regex(yearPattern);
        public static Regex bookIdPatternRegex = new Regex(bookIdPattern);

        /// <summary>
        /// This method validates the option input matches the pattern or not.
        /// </summary>
        /// <param name="option">This is the input taken by user</param>
        /// <returns>It returns true or false</returns>
        public static bool CheckOptionsInput(string option)
        {
            if (optionsPatternRegex.IsMatch(option))
            {
                return true;
            }
            else
            {
                Console.WriteLine("Invalid input!");
                return false;
            }
        }

        /// <summary>
        /// This method validates the title input matches the pattern or not.
        /// </summary>
        /// <param name="title">This is the input taken by user</param>
        /// <returns>It returns true or false</returns>
        public static bool CheckTitleAndPublicationInput(string title)
        {
            if (titleAndPublicationPatternRegex.IsMatch(title))
            {
                return true;
            }
            else
            {
                Console.WriteLine("Invalid input!");
                return false;
            }
        }

        /// <summary>
        /// This method validates the author input matches the pattern or not.
        /// </summary>
        /// <param name="author">This is the input taken by user</param>
        /// <returns>It returns true or false</returns>
        public static bool CheckAuthorInput(string author)
        {
            if (authorPatternRegex.IsMatch(author))
            {
                return true;
            }
            else
            {
                Console.WriteLine("Invalid input!");
                return false;
            }
        }

        /// <summary>
        /// This method validates the year input matches the pattern or not.
        /// </summary>
        /// <param name="year">This is the input taken by user</param>
        /// <returns>It returns true or false</returns>
        public static bool CheckYearPattern(string year)
        {
            if (yearPatternRegex.IsMatch(year))
            {
                return true;
            }
            else
            {
                Console.WriteLine("Invalid input!");
                return false;
            }
        }

        /// <summary>
        /// This method validates the id input matches the pattern or not.
        /// </summary>
        /// <param name="id">This is the input taken by user</param>
        /// <returns>It returns true or false</returns>
        public static bool CheckBookIdPattern(string id)
        {
            if (bookIdPatternRegex.IsMatch(id))
            {
                return true;
            }
            else
            {
                Console.WriteLine("Invalid input!");
                return false;
            }
        }
    }
}