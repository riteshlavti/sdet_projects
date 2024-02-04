using System;
namespace PolymorphismProject
{
    /// <summary>
    /// Interface for Payment process method.
    /// </summary>
    public interface IPaymentMethod
    {
        void ProcessPayment(decimal amount);
    }

    public class CreditCardPayment : IPaymentMethod
    {
        /// <summary>
        /// This method is used for Processing payment by credit card.
        /// </summary>
        /// <param name="amount">Amount which needs to pay.</param>
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine("Processing credit card payment for amount: {0}",amount);
        }
    }

    public class UPIPayment : IPaymentMethod
    {
        /// <summary>
        /// This method is used for Processing payment by UPI.
        /// </summary>
        /// <param name="amount">Amount which needs to pay.</param>
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine("Processing UPI payment for amount: {0}",amount);
        }
    }

    public class CashOnDelivery : IPaymentMethod
    {
        /// <summary>
        /// This method is used for Processing payment by Cash on delievery.
        /// </summary>
        /// <param name="amount">Amount which needs to pay.</param>
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