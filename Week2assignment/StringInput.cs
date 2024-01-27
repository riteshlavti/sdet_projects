using System;
namespace StringInput
{
    class GenerateString
    {
        internal void DisplayString()
        {
            Console.WriteLine("Enter the length of string. - ");
            int stringLength = Convert.ToInt32(Console.ReadLine());
            Random random = new Random();
            string randomString = "";

            for (int index = 0; index < stringLength; index++)
            {
                randomString += (char)('a' + random.Next(26));
            }
            Console.WriteLine("Generated Random String is : " + randomString);
        }
    }
    class StringInput
    {
        public static void Main(string[] args)
        {
            GenerateString obj = new GenerateString();
            obj.DisplayString();
        }

    }
}
