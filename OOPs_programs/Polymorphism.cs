using System;
namespace PolymorphismProject
{
    public interface IPaymentMethod
    {
        void ProcessPayment(decimal amount);
    }

    public class CreditCardPayment : IPaymentMethod
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine("Processing credit card payment for amount: {0}",amount);
        }
    }

    public class UPIPayment : IPaymentMethod
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine("Processing UPI payment for amount: {0}",amount);
        }
    }

    public class CashOnDelivery : IPaymentMethod
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine("Collecting cash on delivery for amount: {0}",amount);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            IPaymentMethod paymentMethod = new CreditCardPayment();
            paymentMethod.ProcessPayment(1000);

            paymentMethod = new UPIPayment();
            paymentMethod.ProcessPayment(250);

            paymentMethod = new CashOnDelivery();
            paymentMethod.ProcessPayment(5400);
        }
    }
}