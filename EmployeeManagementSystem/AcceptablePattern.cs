using System.Text.RegularExpressions;

namespace EmployeeManagementSystem;

/// <summary>
/// This class contains patterns and checks the input with respect to respective pattern.
/// </summary>
public class AcceptablePattern
{
    const string optionsPattern = @"\d{1}$";
    const string namePattern = @"[A-za-z]+$";
    const string employeeIdPattern = @"[0-9]+$";
    const string joiningDatePattern = @"\d{4}-\d{2}-\d{2}";

    public static Regex optionsPatternRegex = new Regex(optionsPattern);
    public static Regex joiningDatePatternRegex = new Regex(joiningDatePattern);
    public static Regex namePatternRegex = new Regex(namePattern);
    public static Regex employeeIdPatternRegex = new Regex(employeeIdPattern);

    /// <summary>
    /// This method checks the option input matches the pattern or not.
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
    /// This method checks the name input matches the pattern or not.
    /// </summary>
    /// <param name="option">This is the input taken by user</param>
    /// <returns>It returns true or false</returns>
    public static bool CheckNameInput(string name)
    {
        if (namePatternRegex.IsMatch(name))
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
    /// This method checks the date input matches the pattern or not.
    /// </summary>
    /// <param name="option">This is the input taken by user</param>
    /// <returns>It returns true or false</returns>
    public static bool CheckDateInput(string joiningDate)
    {
        if (joiningDatePatternRegex.IsMatch(joiningDate))
        {
            return true;
        }
        else
        {
            Console.WriteLine("Invalid input!, Try again");
            return false;
        }
    }

}