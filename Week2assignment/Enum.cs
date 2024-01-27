using System;
public enum DayOfWeek
{
    Monday,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday,
    Sunday
}

class EnumeratorUse
{
    static void Main()
    {
        DayOfWeek today = DayOfWeek.Friday;

        if (today == DayOfWeek.Saturday || today == DayOfWeek.Sunday)
        {
            Console.WriteLine("Today is the weekend!");
        }
        else
        {
            Console.WriteLine("Today is a weekday.");
        }
    }
}
