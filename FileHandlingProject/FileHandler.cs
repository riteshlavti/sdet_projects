namespace FileHandlingProject;

/// <summary>
/// This class is used for defining stat application method and for taking and returning file path.
/// </summary>
public class FileHandler
{
    /// <summary>
    /// This static method is used for starting application.
    /// </summary>
    public static void StartApplication()
    {
        Console.WriteLine("\n-----FILE HANDLER-----\n");
        Console.WriteLine("""
                            Enter the operation which you want to perform-
                            1. Create a file.
                            2. Read a file.
                            3. Append a file.
                            4. Delete a file.
                            5. Count Lines.
                            6. Display a file.
                            7. Exit.
                            """);

        int menuOption = InputDetails.InputMenuOption();

        switch (menuOption)
        {
            case 1:
                FileHandlingOperations.CreateFile();
                break;
            case 2:
                FileHandlingOperations.ReadFile();
                break;
            case 3:
                FileHandlingOperations.AppendFile();
                break;
            case 4:
                FileHandlingOperations.DeleteFile();
                break;
            case 5:
                FileHandlingOperations.CountLines();
                break;
            case 6:
                FileHandlingOperations.DisplayFile();
                break;
            case 7:
                Environment.Exit(0);
                break;
            default:
                Console.WriteLine("Invalid choice try again!");
                break;
        }
        StartApplication();
    }

    /// <summary>
    /// This static method is used for taking path from user and returning path.
    /// </summary>
    /// <returns>It returns path as string.</returns>
    public static string InputAndReturnPath()
    {
        Console.WriteLine("Enter the path for file - ");
        string path = Console.ReadLine();
        return path;
    }
}
