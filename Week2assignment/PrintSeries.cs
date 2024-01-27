using System;
namespace PrintSeries
{
    class Series
    {
        private int seriesLength;
        internal void TakeInput()
        {
            Console.WriteLine("Enter the length of series: ");
            string input=Console.ReadLine();
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
            int currentNumber = 1;
            Console.Write("Series: 1 ");
            for (int index = 1; index < seriesLength; index++)
            {
                Console.Write(index * index + currentNumber + " ");
                currentNumber = index * index + currentNumber;
            }
        }
    }
    
    class PrintSeries
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello");
            Series obj = new Series();
            obj.TakeInput();
            obj.DisplaySeries();
        }

    }
}