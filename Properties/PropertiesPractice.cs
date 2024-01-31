using System;
namespace PropertiesProject
{
    class PropertiesPractice
    {
        int _Pincode;
        public int Pincode
        {
            set
            {
                if(value==313204)
                _Pincode=value;
            }
            get
            {
                return _Pincode;
            }
        }
        static void Main()
        {
            PropertiesPractice obj = new PropertiesPractice();
            obj.Pincode=313203;
            Console.WriteLine(obj.Pincode);
        }
    }
}