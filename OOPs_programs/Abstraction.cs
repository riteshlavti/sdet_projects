using System;
namespace AbstractionProject
{
    public abstract class Employee
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public decimal Salary { get; set; }
        public abstract void PerformRole();
    }
    public class AutomationEngineer : Employee
    {
        public string Department { get; set; }

        public override void PerformRole()
        {
            Console.WriteLine("Automation Engineer {0} is working in {1} department.",Name,Department);
        }
    }
    public class Developer : Employee
    {
        public string ProgrammingLanguage { get; set; }

        public override void PerformRole()
        {
            Console.WriteLine("Developer {0} is coding in {1}.",Name,ProgrammingLanguage);
        }
    }
    class Program
    {
        static void Main()
        {
            Employee manager = new AutomationEngineer { Name = "Ritik", Age = 40, Salary = 80000, Department = "QA" };
            Employee developer = new Developer { Name = "Parth", Age = 30, Salary = 60000, ProgrammingLanguage = ".NET" };
            manager.PerformRole();      
            developer.PerformRole();    
        }
    }

}