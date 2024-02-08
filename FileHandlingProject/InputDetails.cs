namespace FileHandlingProject;

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
    
    public static string ChoiceOption()
    {
        string yesOrNo = Console.ReadLine();
        if(AcceptablePattern.CheckChoicesInput(yesOrNo))
        {
            return yesOrNo;
        }
        return ChoiceOption();
    }

    public static string FileContentInput()
    {
        Console.WriteLine("Enter the text which you want to append in the file- ");
        string fileContent = Console.ReadLine();
        return fileContent;
    }
}

