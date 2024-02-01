using System;
namespace InheritanceProject
{
    using System;
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
    }
    public class Laptop : ElectronicDevice
    {
        public void RunProgram()
        {
            Console.WriteLine("Running a program.");
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
            phone.PowerOff();

            Laptop laptop = new Laptop();
            laptop.Manufacturer = "HP";
            laptop.Model = "Probook";
            laptop.Price = 83500;
            laptop.PowerOn();
            laptop.RunProgram();
            laptop.PowerOff();
        }
    }
}