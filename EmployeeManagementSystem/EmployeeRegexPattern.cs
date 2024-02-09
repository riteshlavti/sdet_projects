using System.Text.RegularExpressions;

namespace EmployeeManagementSystem
{
    /// <summary>
    /// Contains patterns and checks the input with respect to respective pattern.
    /// </summary>
    public static class EmployeeRegexPattern
    {
        public const string optionsPattern = @"\d{1}$";
        public const string idPattern = @"[0-9]+";
        public const string namePattern = @"[A-za-z]+$";
        public const string technologyPattern = @".+";
        public const string employeeIdPattern = @"[0-9]+$";
        public const string joiningDatePattern = @"\d{4}-\d{2}-\d{2}";
    }
}