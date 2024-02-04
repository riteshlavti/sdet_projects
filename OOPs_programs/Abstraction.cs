using System;
namespace AbstractionProject
{
    public enum Roles
    {
        SDE, 
        AutomationEngineer, 
        Operations
    }

    public enum ProgrammingLanguage
    {
        C_sharp,
        Java,
        C_CPP
    }

    public abstract class Employee
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public decimal Salary { get; set; }
        public string Department { get; set; }
        public abstract void PerformRole();
    }

    public class Operations : Employee
    {
        public override void PerformRole()
        {
            Console.WriteLine("Operation Engineer {0} is working with {1} team.",Name,Department);
        }
    }

    public class Developer : Employee
    {
        public string ProgrammingLanguage { get; set; }

        public override void PerformRole()
        {
            Console.WriteLine("Developer {0} is working with {1} team.",Name,Department);
        }

        public void ProgrammingBackground()
        {
            Console.WriteLine("{0} is developing software in {1} ",Name,ProgrammingLanguage);
        }
    }

    class Program
    {
        static void Main()
        {
            Operations operationsEngineer = new Operations { Name = "Ritik",
             Age = 40, Salary = 80000, Department = Roles.Operations};

            Developer developer = new Developer { Name = "Parth",
             Age = 30, Salary = 60000, ProgrammingLanguage = ProgrammingLanguage.C_sharp, Department=Roles.SDE };

            operationsEngineer.PerformRole();      
            developer.PerformRole();
            developer.ProgrammingBackground();
        }
    }
}