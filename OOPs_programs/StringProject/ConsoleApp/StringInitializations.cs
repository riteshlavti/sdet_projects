using System.Text;
namespace StringPractice
{
    class Program
    {
        static void Main()
        {
            // Using String (Immutable)
            string str = "Hello, ";
            str = str + "world";
            
            string multiLineStart = """
                    This is the beginning 
                    of a string 
                    """;
            //To include double quotation mark in string, double it.
            string verbatimUse = @"This is used to ""justify the use of verbatim"" ";
            string verbatimUsee = @"c:\Docs\Source\a.txt";
            // CS9000: Raw string literal delimiter must be on its own line.
            
            Console.WriteLine(multiLineStart);
            StringBuilder mutableString = new StringBuilder("Hello, ");
            mutableString.Append("World!");
            Console.WriteLine(mutableString);
            Console.WriteLine(verbatimUse);
            Console.WriteLine(verbatimUsee);
        }
    }
}

