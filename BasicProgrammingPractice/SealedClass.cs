using System;
using SealedClassProject;
namespace SealedClassProject
{
    sealed class SealedClassPractice
    {
        public void Test()
        {
            Console.WriteLine("Printing sealed class...");
        }
    }
    class ChildClass
    {
        static void Main()
        {
            SealedClassPractice obj = new SealedClassPractice();
            obj.Test();
        }
    }
}