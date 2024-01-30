using System;
namespace InheritanceProject
{
    class ParentClass
    {
        public void Display1()
        {
            Console.WriteLine("Printing in ParentClass");
        }
        
    }
    class ParentTwo
    {
        public void Display2()
        {
            Console.WriteLine("Printing in Parent2");
        }
        public ParentTwo(int a ){
            Console.WriteLine("Example of calling parameterized constructor from child class for input : "+a);
        }
    }
    interface IParent
    {
        
    }
    interface IParentTwo
    {
        void Display3();

    }
    class ChildA : ParentClass
    {
        public void DisplayA()
        {
            Console.WriteLine("Printing in ChildA");
        }
    }
    class ChildB : ChildA
    {
        public void DisplayB()
        {
            Console.WriteLine("Printing in ChildB");
        }
    }
    class ChildC: IParent, IParentTwo
    {
        public void Display3()
        {
            Console.WriteLine("Multiple inheritance using interface.");
        }
        
    }
    class ChildD: ParentTwo
    {
        public ChildD(int a) : base(a)
        {
            Console.WriteLine("ChildD constructor calling");
        }
    }
    class InheritancePractice
    {
        static void Main()
        {
            ParentClass obj = new ParentClass();
            // Object class is the automatically the base class for all classes.
            // Console.WriteLine(obj.GetType());
            // Console.WriteLine(obj.GetHashCode());            
            // Console.WriteLine(obj.ToString());
            ChildA A= new ChildA();
            ChildB B = new ChildB();
            ChildC C = new ChildC();
            ChildD D = new ChildD(10);
            A.DisplayA();
            A.Display1();
            B.Display1();
            C.Display3();
        }
    }


}