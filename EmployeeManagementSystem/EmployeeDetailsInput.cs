namespace EmployeeManagementSystem;

/// <summary>
/// This class is defining methods to take employee details input from user.
/// </summary>
public class EmployeeDetailsInput
{
    /// <summary>
    /// This function is taking name as input from user.   
    /// </summary>
    /// <returns> Return string.</returns>
    public static string InputName()
    {
        Console.Write("Enter the employee name - ");
        string employeeName = Console.ReadLine();
        if (AcceptablePattern.CheckNameInput(employeeName))
        {
            return employeeName;
        }
        return InputName();
    }

    /// <summary>
    /// This function is taking id as input from user.   
    /// </summary>
    /// <returns> Return int.</returns>
    public static int InputID()
    {
        Console.Write("Enter the employee ID - ");
        string employeeID = Console.ReadLine();
        if (AcceptablePattern.CheckOptionsInput(employeeID))
        {
            return Convert.ToInt32(employeeID);
        }
        return InputID();
    }

    /// <summary>
    /// This function is taking technology as input from user.   
    /// </summary>
    /// <returns> Return string.</returns>
    public static string InputTechnology()
    {
        Console.Write("Enter the employee technology - ");
        string employeeName = Console.ReadLine();

        return employeeName;
    }

    /// <summary>
    /// This function is taking Date from user as string in particular format.
    /// </summary>
    /// <returns>Returns DateOnly.</returns>
    public static DateOnly InputJoiningDate()
    {
        Console.Write("Enter the joining date [yyyy-mm-dd] - ");
        string employeeJoiningDateString = Console.ReadLine();

        try
        {
            if (AcceptablePattern.CheckDateInput(employeeJoiningDateString))
            {
                DateOnly dateOnly = DateOnly.Parse(employeeJoiningDateString);
                return dateOnly;
            }
        }
        catch (Exception error)
        {
            Console.WriteLine("Error - {0}", error);
        }

        return InputJoiningDate();
    }

    /// <summary>
    /// This function is taking menu option as input from user.
    /// </summary>
    /// <returns>Returns int value.</returns>
    public static int InputMenuOption()
    {
        string menuOptionString = Console.ReadLine();
        if (AcceptablePattern.CheckOptionsInput(menuOptionString))
        {
            return Convert.ToInt32(menuOptionString);
        }
        return InputMenuOption();
    }
}
