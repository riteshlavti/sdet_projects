using System;
namespace TotalMarks
{
    class CalculateMarks
    {
        private int[] marksArray = new int[5];
        private int result = 0;
        internal void SumMarks()
        {
            Console.WriteLine("Enter marks for 5 subjects : ");
            for (int index = 0; index < 5; index++)
            {
                string marks = Console.ReadLine();
                marksArray[index] = Convert.ToInt32(marks);
                result += marksArray[index];
            }
        }
        internal void DisplayResult()
        {
            Console.WriteLine("Grand total of entered marks is : " + result);
        }
    }
    class TotalMarks
    {
        public static void Main(string[] args)
        {

            CalculateMArks obj = new CalculateMArks();
            obj.SumMarks();
            obj.DisplayResult();

        }
    }
}
