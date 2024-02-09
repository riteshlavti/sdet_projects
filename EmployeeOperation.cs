using System.Linq.Expressions;

namespace EmployeeManagementSystem
{
    /// <summary>
    /// Contain methods add, read, remove and edit employee.
    /// </summary>
    public class EmployeeOperation : EmployeeManager
    {
        /// <summary>
        /// Used for adding employee to the list.
        /// </summary>
        public static void AddEmployee()
        {
            try
            {
                Console.WriteLine("---ADDING A EMPLOYEE---");

                Console.Write("Enter employee ID - ");
                int employeeID = Convert.ToInt32(EmployeeDetailsInput.InputString(EmployeeRegexPattern.employeeIdPattern));

                Console.Write("Enter employee name - ");
                string employeeName = EmployeeDetailsInput.InputString(EmployeeRegexPattern.namePattern);

                Console.Write("Enter employee technology - ");
                string employeeTechnology = EmployeeDetailsInput.InputString(EmployeeRegexPattern.technologyPattern);

                DateOnly employeeJoiningDate = EmployeeDetailsInput.inputJoiningDate();

                EmployeeDetails employee = new EmployeeDetails(employeeID, employeeName, employeeTechnology, employeeJoiningDate);
                employeeDictionary.Add(employeeID, employee);

                Console.WriteLine("{0} added succesfully! ", employeeName);
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
            }
        }

        /// <summary>
        /// Used for reading employee details from employee list.
        /// </summary>
        public static void ReadEmployee()
        {
            Console.WriteLine("---DISPLAY EMPLOYEE DETAILS---");

            try
            {
                Console.Write("Enter employee id - ");
                int employeeID = Convert.ToInt32(EmployeeDetailsInput.InputString(EmployeeRegexPattern.idPattern));

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
        /// Used for removing employee from employee list.
        /// </summary>
        public static void RemoveEmployee()
        {
            Console.WriteLine("---REMOVE A EMPLOYEE---");

            if (employeeDictionary.Count == 0)
            {
                Console.Write("There are 0 employees in the company!");
                return;
            }

            try
            {
                Console.Write("Enter employee id - ");
                int employeeID = Convert.ToInt32(EmployeeDetailsInput.InputString(EmployeeRegexPattern.idPattern));

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
                Console.WriteLine(error.Message);
            }
        }

        /// <summary>
        /// Used to edit the employee details.
        /// </summary>
        public static void EditEmployee()
        {
            Console.WriteLine("---EDIT EMPLOYEE DETAIL---");

            Console.Write("Enter employee id - ");
            try
            {
                int employeeID = Convert.ToInt32(EmployeeDetailsInput.InputString(EmployeeRegexPattern.idPattern));

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
                int userChoice = Convert.ToInt32(EmployeeDetailsInput.InputString(EmployeeRegexPattern.optionsPattern));

                if (userChoice == 1)
                {
                    employeeDictionary[employeeID].EmployeeName = EmployeeDetailsInput.InputString(EmployeeRegexPattern.namePattern);
                    Console.WriteLine("Employee name updated successfully!");
                }
                else if (userChoice == 2)
                {
                    employeeDictionary[employeeID].EmployeeTechnology = EmployeeDetailsInput.InputString(EmployeeRegexPattern.technologyPattern);
                    Console.WriteLine("Employee technology updated successfully!");

                }
                else if (userChoice == 3)
                {
                    employeeDictionary[employeeID].EmployeeJoiningDate = EmployeeDetailsInput.inputJoiningDate();
                    Console.WriteLine("Employee joining date updated successfully!");
                }
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
            }
        }
    }
}
