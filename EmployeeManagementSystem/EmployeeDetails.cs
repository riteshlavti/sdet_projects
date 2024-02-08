namespace EmployeeManagementSystem;

/// <summary>
/// This class is used for defining Employee properties and initializing using constructor.
/// </summary>
public class EmployeeDetails
{
    public int EmployeeID { get; }
    public string EmployeeName { get; set; }
    public string EmployeeTechnology { get; set; }
    public DateOnly EmployeeJoiningDate { get; set; }

    /// <summary>
    /// This constructor is used for initializaing Employee properties.
    /// </summary>
    /// <param name="employeeID">Accept employeeID as int.</param>
    /// <param name="employeeName">Accept employee name as string.</param>
    /// <param name="employeeTechnology">Accept employee technology as string.</param>
    /// <param name="employeeJoiningDate">Accept employee joining date as DateOnly</param>
    public EmployeeDetails(int employeeID, string employeeName, string employeeTechnology, DateOnly employeeJoiningDate)
    {
        EmployeeID = employeeID;
        EmployeeName = employeeName;
        EmployeeTechnology = employeeTechnology;
        EmployeeJoiningDate = employeeJoiningDate;
    }
}
