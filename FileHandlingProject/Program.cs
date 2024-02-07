using System.Data.SqlTypes;
using System.Dynamic;
using System.Net.Http.Json;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json.Serialization;
using System.Xml.Serialization;
using System;
using System.IO;
using Newtonsoft.Json;

namespace fileHandlingPractice;
public class fileHandlingOperations
{
    static void Main()
    {
        string path = @"C:\Users\ritesh.lavti\Desktop\Git.txt";
        if (File.Exists(path))
        {
            Console.WriteLine("FIle exist");
        }

        //Read all lines and stores in string array;
        string[] lines;
        lines = File.ReadAllLines(path);
        Console.WriteLine(lines[0]);
        Console.WriteLine(lines[3]);

        //Read all text and stores in a single string.
        string line;
        line = File.ReadAllText(path);
        Console.WriteLine(line);

        //Used to copy file from existing file with path to 
        //destination path.
        string copyPath = @"C:\Users\ritesh.lavti\Desktop\GitCopy.txt";
        File.Copy(path, copyPath);

        bool overwrite = true;
        File.Copy(path, copyPath, overwrite);
        Console.WriteLine(File.Exists(copyPath));

        //Used to delete a file.
        File.Delete(copyPath);
        Console.WriteLine(File.Exists(copyPath));

        //Read all bytes from a file as binary data, stores ascii code of character
        byte[] readBytes = File.ReadAllBytes(path);
        Console.WriteLine(readBytes[0]);
        Console.WriteLine(readBytes[1]);
        Console.WriteLine(readBytes[2]);
        Console.WriteLine(readBytes[3]);

        //WriteAllText
        //WriteAllLines
        //AppendAllText
        //AppendAllLines

        DateTime creationTime = File.GetCreationTime(path);

        //FileInfo methods - obj.DirectoryName, obj.Extension, 
        //obj.Exists, obj.Length.

        /** 
        DirectoryInfo and Directory class to manipulate directories

        */
        string src = @"D:\newDir\file.txt";
        Console.WriteLine(Directory.Exists(src));
        Directory.CreateDirectory(@"D:\newDir\file.txt\subDir");
        string[] subDir = Directory.GetDirectories(src);
        Console.WriteLine(subDir[0]);

        string srcPAth = @"D:\newDir\file.txt\temp.txt";
        File.AppendAllText(srcPAth,line);

        string[] files = Directory.GetFiles(src);
        Console.WriteLine(files[0]);

        DirectoryInfo dir = new DirectoryInfo(src);
        Console.WriteLine(dir.FullName);

        StreamWriter sw = new StreamWriter(srcPAth);

        // To write on the console screen 
        Console.WriteLine("Enter the Text that you want to write on File");

        // To read the input from the user 
        string strr = Console.ReadLine();

        // To write a line in buffer 
        sw.WriteLine(strr);

        // To write in output stream 
        sw.Flush();

        // To close the stream 
        sw.Close();



        // StreamReader sr = new StreamReader("H://geeksforgeeks.txt");

        // Console.WriteLine("Content of the File");

        // // This is use to specify from where  
        // // to start reading input stream 
        // sr.BaseStream.Seek(0, SeekOrigin.Begin);

        // // To read line from input stream 
        // string str = sr.ReadLine();

        // // To read the whole file line by line 
        // while (str != null)
        // {
        //     Console.WriteLine(str);
        //     str = sr.ReadLine();
        // }
        // Console.ReadLine();

        // // to close the stream 
        // sr.Close();
        SerDeser obj = new SerDeser();
        obj.Id = 1;
        obj.Name = "Hello";


        XmlSerializer serializer = new XmlSerializer(typeof(SerDeser));
        
        using (TextWriter writer = new StreamWriter("person.xml"))
        {
            serializer.Serialize(writer, obj);
        }

        Console.WriteLine("Object serialized.");


        string json = JsonConvert.SerializeObject(obj);
        // Deserialize the object from XML
        // using (TextReader reader = new StreamReader("person.xml"))
        // {
        //     SerDeser deserializedPerson = (SerDeser)serializer.Deserialize(reader);
        //     Console.WriteLine("Deserialized Person:");
        //     Console.WriteLine("Name: " + deserializedPerson.Name);
        //     Console.WriteLine("Id: " + deserializedPerson.Id);
        

        // }
    }
    public class SerDeser
    {
        public int Id{get; set;}
        public string Name{get; set;}
    }
}