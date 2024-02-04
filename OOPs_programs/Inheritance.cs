using System;
namespace InheritanceProject
{
    public class ElectronicDevice
    {
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public decimal Price { get; set; }

        public void PowerOn()
        {
            Console.WriteLine("Device powered on.");
        }

        public void PowerOff()
        {
            Console.WriteLine("Device powered off.");
        }
    }

    public class Smartphone : ElectronicDevice
    {
        public void MakeCall()
        {
            Console.WriteLine("Making a call.");
        }

        public void SendTextMessage(string recipient, string message)
        {
            Console.WriteLine($"Sending text message to {recipient}: {message}");
        }
    }

    public class Laptop : ElectronicDevice
    {
        public void RunProgram()
        {
            Console.WriteLine("Running a program.");
        }

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