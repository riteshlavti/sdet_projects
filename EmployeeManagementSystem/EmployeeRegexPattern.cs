using System.Text.RegularExpressions;

namespace EmployeeManagementSystem
{
    /// <summary>
    /// Contains patterns and checks the input with respect to respective pattern.
    /// </summary>
    public static class EmployeeRegexPattern
    {
        public const string OPTIONSPATTERN = @"\d{1}$";
        public const string IDPATTERN = @"[0-9]+";
        public const string NAMEPATTERN = @"[A-za-z]+$";
        public const string TECHNOLOGYPATTERN = @".+";
        public const string EMPLOYEEPATTERN = @"[0-9]+$";
        public const string JOININGDATEPATTERN = @"\d{4}-\d{2}-\d{2}";
    }
}