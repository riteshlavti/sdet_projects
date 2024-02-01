using System;
using System.Text.RegularExpressions;
namespace RegExPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            string emailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

            Console.WriteLine("Enter an email address:");
            string email = Console.ReadLine();

            if (Regex.IsMatch(email, emailPattern))
            {
                Console.WriteLine("Valid email address.");
            }
            else
            {
                Console.WriteLine("Invalid email address.");
            }
        }
    }

}