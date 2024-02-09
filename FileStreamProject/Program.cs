using System;
using System.IO;
using Newtonsoft.Json;

// Class to be serialized
public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
}

class Program
{
    static void Main()
    {
        string path = @"D:/newDir/temp.txt";

        // StreamReader obj2= new StreamReader(path);

        StreamWriter obj3 = new StreamWriter(path);
        

        // Create an object to serialize
        Person person = new Person { Name = "John", Age = 30 };

        // JSON serialization using Syste.Text.Json
        string jsonString = JsonSerializer.Serialize(person);
        StreamWriter obj = new StreamWriter("person.json");

        // Serialize the object to JSON
        string json = JsonConvert.SerializeObject(person);
        obj3.WriteLine(json);
        Console.WriteLine("Object serialized to JSON.");

        // Deserialize the object from JSON
        string jsonFromFile = File.ReadAllText("person.json");
        Person deserializedPerson = JsonConvert.DeserializeObject<Person>(jsonFromFile);

        Console.WriteLine("Deserialized Person:");
        Console.WriteLine("Name: " + deserializedPerson.Name);
        Console.WriteLine("Age: " + deserializedPerson.Age);
    }
}
