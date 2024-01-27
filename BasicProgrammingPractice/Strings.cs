using System;
class StringPractice
{
    public static void Main()
    {
        // CS8997: Unterminated raw string literal.
        string multiLineStart = """this""";

// CS9000: Raw string literal delimiter must be on its own line.
    //     var multiLineEnd = """
    // This is the beginning of a string """;

        // CS8999: Line does not start with the same whitespace as the closing line
        // of the raw string literal
//         var noOutdenting = """
//     A line of text.
// Trying to outdent the second line.
//     """;
        Console.Write(multiLineStart);
    }
}