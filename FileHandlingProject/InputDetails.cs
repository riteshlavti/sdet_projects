namespace FileHandlingProject;

/// <summary>
/// This class is used for defining methods for taking user input.
/// </summary>
public class InputDetails
{
    /// <summary>
    /// This function is taking menu option as input from user.
    /// </summary>
    /// <returns>It returns the menu option if it is valid.</returns>
    public static int InputMenuOption()
    {
        string bookOperationString = Console.ReadLine();
        if (AcceptablePattern.CheckOptionsInput(bookOperationString))
        {
            int bookOperation = Convert.ToInt32(bookOperationString);
            return bookOperation;
        }
        return InputMenuOption();
    }

    /// <summary>
    /// This function is taking choices[yes/no] input from user.
    /// </summary>
    /// <returns>It returns the choices input as string if it is valid.</returns>
    public static string ChoiceOption()
    {
        string yesOrNo = Console.ReadLine();
        if(AcceptablePattern.CheckChoicesInput(yesOrNo))
        {
            return yesOrNo;
        }
        return ChoiceOption();
    }

    /// <summary>
    /// This method is used for writing text in file.
    /// </summary>
    /// <returns></returns>
    public static string FileContentInput()
    {
        Console.WriteLine("Enter the text which you want to write in the file- ");
        string fileContent = Console.ReadLine();
        return fileContent;
    }
}

