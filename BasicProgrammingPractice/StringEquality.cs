using System;
namespace StringEquality
{
    class StringEquality
    {
        static void Main()
        {
            string str1="hello";
            string str2="hello";
            Console.WriteLine(str1==str2);
            Console.WriteLine(str1);
            str2="world";
            Console.WriteLine(str2);
            Console.WriteLine(str1.Equals(str2));
        }
    }
}