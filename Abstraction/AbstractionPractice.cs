using System;
namespace AbstractionProject
{
    abstract class Parent
    {
        public abstract void Test();
    }
    class ChildClass : Parent
    {
        public override void Test()
        {
            Console.WriteLine("Overriding abstract method.");
        }
    }
    class AbstractionPractice
    {
        static void Main()
        {
            ChildClass obj = new ChildClass();
            obj.Test();
        }
    }
}