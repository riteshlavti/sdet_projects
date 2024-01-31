using System;
namespace DateAndTimeProject
{
    class DateAndTimePractice
    {
        static void Main()
        {
            DateTime currentDateTime = DateTime.Now;
            Console.WriteLine(currentDateTime);

            DateTime futureDateTime = currentDateTime.AddHours(3);
            Console.WriteLine(futureDateTime);

            string formattedDate = currentDateTime.ToString("yyyy/dd-MM");
            Console.WriteLine(formattedDate);

            TimeSpan timeDifference = futureDateTime - currentDateTime;
            Console.WriteLine(timeDifference);

            string shortDate = currentDateTime.ToShortDateString();
            Console.WriteLine(shortDate);
        }
    }
}