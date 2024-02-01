using System;
namespace RecursiveMethod
{
    class RecursiveProgram
    {
        static void Main()
        {
            Console.WriteLine("Enter a number to calculate its factorial:");
            int number = Convert.ToInt32(Console.ReadLine());

            long factorial = CalculateFactorial(number);
            Console.WriteLine("Factorial of {0} is: {1}", number, factorial);
        }
        static long CalculateFactorial(int n)
        {
            if (n == 0 || n == 1)
            {
                return 1;
            }
            else
            {
                return n * CalculateFactorial(n - 1);
            }
        }
    }
}