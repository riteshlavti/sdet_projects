using System;
namespace OutAndRef
{
    class OutRef
    {
        public void OutCheck(out int a)
        {
            a=10;
        }
        public void RefCheck(ref int a)
        {
            a++;
        }
        static void Main()
        {
            int number;
            OutRef obj = new OutRef();
            
            obj.OutCheck(out number);
            Console.WriteLine(number);
            obj.RefCheck(ref number);
            Console.WriteLine(number);
        }
    }
}