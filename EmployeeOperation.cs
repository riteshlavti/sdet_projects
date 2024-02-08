namespace EmployeeManagementSystem;

/// <summary>
/// This class is used for defining basic operations like add, read, remove and edit employee.
/// </summary>
public class EmployeeOperation : EmployeeManager
{
    /// <summary>
    /// This static method is used for adding employee to the list.
    /// </summary>
    public static void AddEmployee()
    {
        Console.WriteLine("---ADDING A EMPLOYEE---");

        int employeeID = EmployeeDetailsInput.InputID();
        string employeeName = EmployeeDetailsInput.InputName();
        string employeeTechnology = EmployeeDetailsInput.InputTechnology();
        DateOnly employeeJoiningDate = EmployeeDetailsInput.InputJoiningDate();

        EmployeeDetails employee = new EmployeeDetails(employeeID, employeeName, employeeTechnology, employeeJoiningDate);
        employeeDictionary.Add(employeeID, employee);

        Console.WriteLine("{0} added succesfully! ", employeeName);
    }

    /// <summary>
    /// This static method is used for reading employee details from employee list.
    /// </summary>
    public static void ReadEmployee()
    {
        Console.WriteLine("---DISPLAY EMPLOYEE DETAILS---");
        int employeeID = EmployeeDetailsInput.InputID();
        
        try
        {
            if (!employeeDictionary.ContainsKey(employeeID))
            {
                throw new KeyNotFoundException("Employee doesn't exist!");
            }
            else
            {
                Console.WriteLine("""
                Employee details are - 
                Name - {0},
                Technology - {1},
                Joining Date - {2}
                """, 
                employeeDictionary[employeeID].EmployeeName,
                employeeDictionary[employeeID].EmployeeTechnology, 
                employeeDictionary[employeeID].EmployeeJoiningDate);
            }
        }
        catch (Exception error)
        {
            Console.WriteLine(error.Message);
        }
    }

    /// <summary>
    /// This static method is used for removing employee from employee list.
    /// </summary>
    public static void RemoveEmployee()
    {
        Console.WriteLine("---REMOVE A EMPLOYEE---");

        if (employeeDictionary.Count == 0)
        {
            Console.WriteLine("There are 0 employees in the company!");
            return;
        }

        int employeeID = EmployeeDetailsInput.InputID();

        try
        {
            if (!employeeDictionary.Remove(employeeID))
            {
                throw new KeyNotFoundException("Employee doesn't exist!");
            }
            else
            {
                Console.WriteLine("Employee deleted successfully!");
            }
        }
        catch (Exception error)
        {
            Console.WriteLine(error);
        }
    }

    /// <summary>
    /// This static method is used to edit the employee details.
    /// </summary>
    public static void EditEmployee()
    {
        Console.WriteLine("---EDIT EMPLOYEE DETAIL---");

        int employeeID = EmployeeDetailsInput.InputID();
        if (employeeDictionary.ContainsKey(employeeID) == false)
        {
            Console.WriteLine("Employee doesn't exist.");
            return;
        }

        string menu = """
                        Enter the option which you want to update -
                        1. Name
                        2. Technology
                        3. Joining Date
                        """;
        Console.WriteLine(menu);
        int menuOption = EmployeeDetailsInput.InputMenuOption();

        if (menuOption == 1)
        {
            employeeDictionary[employeeID].EmployeeName = EmployeeDetailsInput.InputName();
            Console.WriteLine("Employee name updated successfully!");
        }
        else if (menuOption == 2)
        {
            employeeDictionary[employeeID].EmployeeTechnology = EmployeeDetailsInput.InputTechnology();
            Console.WriteLine("Employee technology updated successfully!");

        }
        else if (menuOption == 3)
        {
            employeeDictionary[employeeID].EmployeeJoiningDate = EmployeeDetailsInput.InputJoiningDate();
            Console.WriteLine("Employee joining date updated successfully!");
        }
    }
}
