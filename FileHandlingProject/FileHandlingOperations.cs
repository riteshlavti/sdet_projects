namespace FileHandlingProject;

/// <summary>
/// Contains file operations - create file, append file, delete file & read file.
/// </summary>
public class FileHandlingOperations
{
    /// <summary>
    /// Used to create and add text to file.
    /// </summary>
    public static void CreateFile()
    {
        try
        {
            Console.WriteLine("Enter the path of file - ");

            string path = InputFileDetails.InputString();
            using (FileStream file = new FileStream(path, FileMode.Create))
            {
                file.Close();
            }

            Console.WriteLine("File created successfully! Do you want add some text to it [y/n] - ");

            string choice = InputFileDetails.InputString(FileHandlingRegexPattern.YESORNOCHOICEPATTERN);
            if (choice == "y" || choice == "Y")
            {
                Console.WriteLine("Enter the text which you want to write in the file- ");
                File.WriteAllText(path, InputFileDetails.InputString());
                Console.WriteLine("Text added successfully!");
            }
        }
        catch (Exception error)
        {
            Console.WriteLine($"{error.Message}, Try again!");
        }
    }

    /// <summary>
    /// Used to delete file.
    /// </summary>
    public static void DeleteFile()
    {
        try
        {
            Console.WriteLine("Enter the path of file - ");
            string path = InputFileDetails.InputString();

            File.Delete(path);
            Console.WriteLine("File deleted successfully.");
        }
        catch (FileNotFoundException error)
        {
            Console.WriteLine($"{error.Message}, Try again!");
        }
    }

    /// <summary>
    /// Used to read file.
    /// </summary>
    public static void ReadFile()
    {
        try
        {
            Console.WriteLine("Enter the path of file - ");
            string fileContent = File.ReadAllText(InputFileDetails.InputString());
            Console.WriteLine(fileContent);
        }
        catch (Exception error)
        {
            Console.WriteLine($"{error.Message}, Try again!");
        }
    }

    /// <summary>
    /// Used to append text to file.
    /// </summary>
    public static void AppendFile()
    {
        try
        {

            Console.WriteLine("Enter the path of file - ");
            string path = InputFileDetails.InputString();

            if (File.Exists(path))
            {
                Console.WriteLine("Enter the text which you want to write in the file- ");
                File.AppendAllText(path, InputFileDetails.InputString());
                Console.WriteLine("Text appended successfully.");
            }
            else
            {
                throw new Exception("File doesn't exist");
            }
        }
        catch (Exception error)
        {
            Console.WriteLine($"{error.Message}, Try again!");
        }
    }

    /// <summary>
    /// Used to count number of lines in a file.
    /// </summary>
    public static void CountLines()
    {
        try
        {
            Console.WriteLine("Enter the path of file - ");

            string path = InputFileDetails.InputString();
            Console.WriteLine($"Number of lines in your file - {File.ReadAllText(path).Split("\n").Length}");
        }
        catch (Exception error)
        {
            Console.WriteLine($"{error.Message}, Try again!");
        }
    }

    /// <summary>
    /// Used to display file.
    /// </summary>
    public static void DisplayFile()
    {
        try
        {
            Console.WriteLine("Enter the path of file - ");
            string path = InputFileDetails.InputString();
            FileInfo fileInfo = new FileInfo(path);
            Console.WriteLine("""
        
                            Full name of file - {0}
                            Content of file - {1}
                            Creation Time of file - {2}
                            """, fileInfo.FullName, File.ReadAllText(path), fileInfo.CreationTime);
        }
        catch (Exception error)
        {
            Console.WriteLine($"{error.Message}, Try again!");
        }
    }
}
