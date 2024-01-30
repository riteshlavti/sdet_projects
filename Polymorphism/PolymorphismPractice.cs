using System;
namespace PolymorphismProject
{
    class ParentClass
    {
        public virtual void Test()
        {
            Console.WriteLine("parent class");
        }
    }
    class ChildClass : ParentClass
    {
        public override void Test()
        {
            Console.WriteLine("child class");
            base.Test();
        }
    }
    class ChildClassTwo : ParentClass
    {
        public new void Test()
        {
            Console.WriteLine("child two class");
        }
    }
    class PolymorphismPractice
    {
        static void Main()
        {
            ChildClass obj = new ChildClass();
            obj.Test();
            ChildClassTwo objTwo = new ChildClassTwo();
            objTwo.Test();
        }
    }
}