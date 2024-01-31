using System;
namespace PropertiesProject
{
    class PropertiesPractice
    {
        int _Pincode;
        int _CountryCode;
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
        public int CountryCode
        {
            get; set;
        }
        static void Main()
        {
            PropertiesPractice obj = new PropertiesPractice();
            obj.Pincode=313203;
            Console.WriteLine(obj.Pincode);
        }
    }
}