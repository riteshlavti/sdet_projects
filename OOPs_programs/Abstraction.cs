using System;
namespace AbstractionProject
{
    /// <summary>
    /// Roles enum contains different constant value named roles.
    /// </summary>
    public enum Roles
    {
        SDE, 
        AutomationEngineer, 
        Operations
    }

    /// <summary>
    /// Programming language enum contains constant value named programming languages.
    /// </summary>
    public enum ProgrammingLanguage
    {
        C_sharp,
        Java,
        C_CPP
    }

    /// <summary>
    /// This class contains common details of employee.
    /// </summary>
    public abstract class Employee
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public decimal Salary { get; set; }
        public string Department { get; set; }
        public abstract void PerformRole();
    }

    /// <summary>
    /// Operations class is for Operations Team Details.
    /// </summary>
    public class Operations : Employee
    {
        /// <summary>
        /// It is overriden method showing role of Employee.
        /// </summary>
        public override void PerformRole()
        {
            Console.WriteLine("Operation Engineer {0} is working with {1} team.",Name,Department);
        }
    }

    /// <summary>
    /// Developer class is for Developer Team Details.
    /// </summary>
    public class Developer : Employee
    {
        public string ProgrammingLanguage { get; set; }

        /// <summary>
        /// It is overriden method showing role of Employee.
        /// </summary>
        public override void PerformRole()
        {
            Console.WriteLine("Developer {0} is working with {1} team.",Name,Department);
        }

        /// <summary>
        /// This method is showing Programming language of developer.
        /// </summary>
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