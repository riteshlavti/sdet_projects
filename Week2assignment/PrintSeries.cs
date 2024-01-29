using System;

namespace PrintSeriesProgram
{
    class PrintSeries
    {
        private int seriesLength;
        internal void TakeInput()
        {
            Console.WriteLine("Enter the length of series: ");
            string input = Console.ReadLine();
            this.seriesLength = Convert.ToInt32(input);
            return;
        }
        internal void DisplaySeries()
        {
            if (seriesLength <= 0)
            {
                Console.WriteLine("To print series, length should be greater than 0.");
                return;
            }
            int currentNumber = 1, nextNumber;
            Console.Write("Series : ");
            for (int index = 1; index <= seriesLength; index++)
            {
                Console.Write(currentNumber + " ");
                nextNumber = index * index + currentNumber;
                currentNumber=nextNumber;
            }
        }
        public static void Main(string[] args)
        {
            PrintSeries obj = new PrintSeries();
            obj.TakeInput();
            obj.DisplaySeries();
        }
    }
}