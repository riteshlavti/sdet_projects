using System;
namespace InheritanceProject
{
    public class ElectronicDevice
    {
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public decimal Price { get; set; }

        /// <summary>
        /// It is the method for powering on the device.
        /// </summary>
        public void PowerOn()
        {
            Console.WriteLine("Device powered on.");
        }

        /// <summary>
        /// It is the method for powering off the device.
        /// </summary>
        public void PowerOff()
        {
            Console.WriteLine("Device powered off.");
        }
    }

    public class Smartphone : ElectronicDevice
    {
        
        /// <summary>
        /// This method is used for making a call.
        /// </summary>
        public void MakeCall()
        {
            Console.WriteLine("Making a call.");
        }

        /// <summary>
        /// This method is used for sending text message.
        /// </summary>
        /// <param name="recipient">Name of the receiver.</param>
        /// <param name="message">Message which needs to be sent.</param>
        public void SendTextMessage(string recipient, string message)
        {
            Console.WriteLine($"Sending text message to {recipient}: {message}");
        }
    }

    public class Laptop : ElectronicDevice
    {
        /// <summary>
        /// This method is used for running a program on laptop.
        /// </summary>
        public void RunProgram()
        {
            Console.WriteLine("Running a program.");
        }

        /// <summary>
        /// This method is used for putting laptop on hibernate mode.
        /// </summary>
        public void Hibernate()
        {
            Console.WriteLine("Putting laptop into hibernation mode.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Smartphone phone = new Smartphone();
            phone.Manufacturer = "Samsung";
            phone.Model = "S23 Ultra";
            phone.Price = 70000;
            phone.PowerOn();
            phone.MakeCall();
            phone.SendTextMessage("Ritik","Hello!");
            phone.PowerOff();


            Laptop laptop = new Laptop();
            laptop.Manufacturer = "HP";
            laptop.Model = "Probook";
            laptop.Price = 83500;
            laptop.PowerOn();
            laptop.RunProgram();
            laptop.Hibernate();
            laptop.PowerOff();
        }
    }
}