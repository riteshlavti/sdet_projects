namespace BookManagementSystem
{
    /// <summary>
    /// This class is used for defining functions for taking user input from console.
    /// </summary>
    public class UserInput
    {
        /// <summary>
        /// This function is taking title as input from user.
        /// </summary>
        /// <returns>It returns the title if it is valid.</returns>
        public static string InputBookTitle()
        {
            Console.Write("Enter the title of Book - ");
            string title = Console.ReadLine();
            if (Patterns.CheckTitleAndPublicationInput(title))
            {
                return title;
            }
            return InputBookTitle();
        }

        /// <summary>
        /// This function is taking author as input from user.
        /// </summary>
        /// <returns>It returns the author if it is valid.</returns>
        public static string InputBookAuthor()
        {
            Console.Write("Enter the author of Book - ");
            string author = Console.ReadLine();
            if (Patterns.CheckTitleAndPublicationInput(author))
            {
                return author;
            }
            return InputBookAuthor();
        }

        /// <summary>
        /// This function is taking book publication as input from user.
        /// </summary>
        /// <returns>It returns the book publication if it is valid.</returns>
        public static string InputBookPublication()
        {
            Console.Write("Enter the publication of Book - ");
            string publication = Console.ReadLine();
            if (Patterns.CheckTitleAndPublicationInput(publication))
            {
                return publication;
            }
            return InputBookPublication();
        }

        /// <summary>
        /// This function is taking publication year as input from user.
        /// </summary>
        /// <returns>It returns the publication year if it is valid.</returns>
        public static DateTime InputBookPublicationYear()
        {
            Console.Write("Enter publication year - ");
            string publicationYearString = Console.ReadLine();
            if (Patterns.CheckYearPattern(publicationYearString))
            {
                DateTime publicationYear = new DateTime(int.Parse(publicationYearString), 1, 1);
                return publicationYear;
            }
            return InputBookPublicationYear();
        }

        /// <summary>
        /// This function is taking book ID as input from user.
        /// </summary>
        /// <returns>It returns the book ID if it is valid.</returns>
        public static int InputBookID()
        {
            Console.Write("Enter the book Id- ");
            string bookIdString = Console.ReadLine();
            if (Patterns.CheckBookIdPattern(bookIdString))
            {
                return Convert.ToInt32(bookIdString);
            }
            return InputBookID();
        }

        /// <summary>
        /// This function is taking menu option as input from user.
        /// </summary>
        /// <returns>It returns the menu option if it is valid.</returns>
        public static int InputMenuOption()
        {
            string bookOperationString = Console.ReadLine();
            if (Patterns.CheckOptionsInput(bookOperationString))
            {
                int bookOperation = Convert.ToInt32(bookOperationString);
                return bookOperation;
            }
            return InputMenuOption();
        }
    }
}