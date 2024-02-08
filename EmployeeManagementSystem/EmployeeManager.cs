using System.Security.Cryptography.X509Certificates;
namespace EmployeeManagementSystem;

/// <summary>
/// This class is used for defining start method and initializing the data structure for 
/// storing employee details.
/// </summary>
public class EmployeeManager
{
    protected static Dictionary<int, EmployeeDetails> employeeDictionary = new Dictionary<int, EmployeeDetails>();

    /// <summary>
    /// This static method is used for defining start application.
    /// </summary>
    public static void StartApplication()
    {
        Console.WriteLine("""

                            -----Employee Manager-----
                            
                            Which operation you want to perform-
                            1. Add Employee details.
                            2. Edit Employee details.
                            3. Read Employee details.
                            4. Delete Employee details.
                            5. Exit.
                            """);
        int menuOption = EmployeeDetailsInput.InputMenuOption();

        switch (menuOption)
        {
            case 1: 
                EmployeeOperation.AddEmployee();
                break;
            case 2:
                EmployeeOperation.EditEmployee();
                break;
            case 3:
                EmployeeOperation.ReadEmployee();
                break;
            case 4:
                EmployeeOperation.RemoveEmployee();
                break;
            case 5:
                Environment.Exit(0);
                break;
            default:
                Console.WriteLine("Invalid choice! Select correct option.");
                break;
        }
        StartApplication();
    }
}
