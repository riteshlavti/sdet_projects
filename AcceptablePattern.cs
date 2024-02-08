using System.Text.RegularExpressions;
namespace FileHandlingProject;

/// <summary>
/// This class is used for defining patters and pattern matching using Regex.
/// </summary>
public class AcceptablePattern
{
    const string optionsPattern = @"\d{1}$";
    const string choiceOptionPattern = @"[y]{1}|[n]{1}";

    public static Regex optionsPatternRegex = new Regex(optionsPattern);
    public static Regex choiceOptionPatternRegex = new Regex(choiceOptionPattern);

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
            Console.WriteLine("Invalid input!, Try again");
            return false;
        }
    }

    /// <summary>
    /// This method validates the choices input matches the pattern or not.
    /// </summary>
    /// <param name="choice">This is the input taken by user</param>
    /// <returns>It returns true or false</returns>
    public static bool CheckChoicesInput(string choice)
    {
        if(choiceOptionPatternRegex.IsMatch(choice))
        {
            return true;
        }
        else 
        {
            Console.WriteLine("Invalid choice!, Try again");
            return false;
        }
    }
}