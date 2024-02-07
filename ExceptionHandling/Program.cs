public class ExceptionTest
{
    static double SafeDivision(double x, double y)
    {
        if (y == 0)
            throw new DivideByZeroException();
        return x / y;
    }

    public static void Main()
    {
        // Input for test purposes. Change the values to see
        // exception handling behavior.
        double a = 98; int b = 0;
        double result;

        try
        {
            string str= Console.ReadLine();
            int c = Convert.ToInt32(str);
            // Console.WriteLine("{0} divided by {1} = {2}", a, b, result);
        }
        catch (FormatException ex)
        {
            Console.WriteLine("Attempted divide by zero."+ ex);
        }
        Console.WriteLine("No abnormal termination.");
    }
}