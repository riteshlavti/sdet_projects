using System.Text.RegularExpressions;

namespace FileHandlingProject;

/// <summary>
/// Contain methods for taking user input.
/// </summary>
public class InputFileDetails
{
    /// <summary>
    /// Takes input as string from user.
    /// </summary>
    /// <returns>Returns string taken by user.</returns>
    public static string InputString()
    {
        string fileContent = Console.ReadLine();
        return fileContent;
    }

    /// <summary>
    /// Take input string and matches with the regex pattern.
    /// </summary>
    /// <param name="regexPattern">Give input as regexPattern</param>
    /// <param name="allowedAttempts">It is the number of times a user can try if invalid input is given.</param>
    /// <returns>Returns string taken by user if it is valid else recall itself 4 times.</returns>
    /// <exception cref="No attempts left"></exception>
    public static string InputString(string regexPattern, int allowedAttempts = 4)
    {
        if (allowedAttempts == 0)
        {
            throw new Exception("No attempts left! ");
        }
        string userInput = Console.ReadLine();
        if (Regex.IsMatch(userInput, regexPattern))
        {
            return userInput;
        }
        if (allowedAttempts > 1)
        {
            Console.WriteLine("Try again, invalid input! {0} attempts left", allowedAttempts - 1);
        }
        return InputString(regexPattern, --allowedAttempts);
    }
}

