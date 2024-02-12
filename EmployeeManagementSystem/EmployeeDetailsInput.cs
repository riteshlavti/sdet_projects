using System.Text.RegularExpressions;

namespace EmployeeManagementSystem
{
    /// <summary>
    /// Contain methods to take employee details input from user.
    /// </summary>
    public  class EmployeeDetailsInput
    {
        /// <summary>
        /// Returns input string if it is valid else recall itself for 4 times if user give invalid input.
        /// </summary>
        /// <param name="regexPattern">Give input as regexPattern</param>
        /// <param name="allowedAttempts">It is the number of times a user can try if invalid input is given.</param>
        /// <returns></returns>
        /// <exception cref="No attempts left"></exception>
        public static string InputString(string regexPattern, int allowedAttempts = 4)
        {
            if (allowedAttempts == 0)
            {
                throw new Exception("No attempts left! ");
            }
            string userInput = Console.ReadLine();
            if (Regex.IsMatch(userInput, regexPattern))
            {
                return userInput;
            }
            if(allowedAttempts>1)
            {
                Console.WriteLine("Try again, invalid input! {0} attempts left", allowedAttempts-1);
            }
            return InputString(regexPattern, --allowedAttempts);
        }

        /// <summary>
        /// Used for taking date input as string and then converts and return as DateOnly if it is valid else throws exception.
        /// </summary>
        /// <param name="allowedCounts">It is the number of times a user can try if invalid input is given.</param>
        /// <returns>Returns date if it is valid else recall itself untill user have attempts left.</returns>
        /// <exception cref="No more attempts left"></exception>
        /// <exception cref="Invalid Date Exception"></exception>
        public static DateOnly inputJoiningDate(int allowedCounts = 4)
        {
            if(allowedCounts==0)
            {
                throw new Exception("No more attempts left.");
            }
            Console.Write("Enter employee joining date [yyyy-mm-dd] - ");
            string employeeJoiningDate = Console.ReadLine();
            
            try
            {
                if(Regex.IsMatch(employeeJoiningDate,EmployeeRegexPattern.JOINING_DATE_PATTERN))
                {
                    DateOnly joiningDate = DateOnly.Parse(employeeJoiningDate);
                    return joiningDate;
                }
                else 
                {
                    throw new Exception("Invalid format!");
                }      
            }
            catch (Exception error)
            {
                Console.WriteLine($"Error - {error.Message}. {allowedCounts} attempts left! Try again");
                return inputJoiningDate(allowedCounts-1);
            }
        }
    }
}