using System.Text.RegularExpressions;

namespace EmployeeManagementSystem
{
    /// <summary>
    /// Contains patterns and checks the input with respect to respective pattern.
    /// </summary>
    public static class EmployeeRegexPattern
    {
        public const string OPTIONS_PATTERN = @"\d{1}$";
        public const string ID_PATTERN = @"[0-9]+";
        public const string NAME_PATTERN = @"[A-za-z]+$";
        public const string TECHNOLOGY_PATTERN = @".+";
        public const string EMPLOYEE_ID_PATTERN = @"[0-9]+$";
        public const string JOINING_DATE_PATTERN = @"\d{4}-\d{2}-\d{2}";
    }
}