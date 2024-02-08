namespace FileHandlingProject;

public class FileHandlingOperations
{
    public static void CreateFile()
    {
        try
        {
            string path = FileHandler.InputAndReturnPath();
            using(FileStream file = new FileStream(path, FileMode.Create))
            {
                file.Close();
            }           
            Console.WriteLine("File created successfully! Do you want add some text to it [y/n] - ");
            string choice = InputDetails.ChoiceOption();
            if(choice == "y")
            {
                File.WriteAllText(path, InputDetails.FileContentInput());
            }
        }
        catch (FileNotFoundException ex)
        {
            Console.WriteLine(ex);
            Console.WriteLine("Retry!");
        }
        catch(Exception ex)
        {
            Console.WriteLine(ex);
            Console.WriteLine("Retry!");

        }
    }

    public static void DeleteFile()
    {
        try
        {
            string path = FileHandler.InputAndReturnPath();
            File.Delete(path);
            Console.WriteLine("File deleted successfully.");
        }
        catch (FileNotFoundException ex)  
        {
           Console.WriteLine(ex);
           Console.WriteLine("Retry!");
        }
    }

    public static void ReadFile()
    {
        try
        {
            string fileContent = File.ReadAllText(FileHandler.InputAndReturnPath());
            Console.WriteLine(fileContent);
        }
        catch(Exception ex)
        {
            Console.WriteLine(ex);
            Console.WriteLine("Retry!");
        }
    }

    public static void AppendFile()
    {
        try
        {
            string path = FileHandler.InputAndReturnPath();
            File.AppendAllText(path, InputDetails.FileContentInput());
            Console.WriteLine("Text appended successfully.");
        }
        catch (Exception ex)
        {    
            Console.WriteLine(ex);
            Console.WriteLine("Try again!");
        }
    }

    public static void CountLines()
    {
        try
        {
            string path = FileHandler.InputAndReturnPath();
            Console.WriteLine($"Number of lines in your file - {File.ReadAllText(path).Split("\n").Length}");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex);
            Console.WriteLine("Retry!");
        }
    }

    public static void DisplayFile()
    {
        string path = FileHandler.InputAndReturnPath();
        FileInfo fileInfo = new FileInfo(path);
        Console.WriteLine("""
        
                            Full name of file - {0}
                            Content of file - {1}
                            Creation Time of file - {2}
                            """,fileInfo.FullName,File.ReadAllText(path),fileInfo.CreationTime);
    }
}
