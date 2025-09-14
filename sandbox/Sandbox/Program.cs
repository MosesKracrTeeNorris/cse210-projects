using System;
using System.Collections.Generic;
using System.IO;
class Program
{
    static void Main(string[] args)
    {
        Person p1 = new Person();
        p1._firstName = "Peter";
        p1._lastName = "Kollie";
        p1._age = 37;
        Person p2 = new Person();
        p2._firstName = "James";
        p2._lastName = "Doe";
        p2._age = 28;
        Person p3 = new Person();
        p3._firstName = "Tina";
        p3._lastName = "Browne";
        p3._age = 24;

        List<Person> people = new List<Person>();
        people.Add(p1);
        people.Add(p2);
        people.Add(p3);

        foreach (Person p in people)
        {
            Console.WriteLine($"{p._firstName} {p._lastName} {p._age}");
            
        }

        SaveToFile(people);

        List<Person> newPeople = ReadFromFile();
        foreach (Person p in newPeople)
        {
            Console.WriteLine(p._lastName);
        }
    }
    public static void SaveToFile(List<Person> people)
    {
        Console.WriteLine("Saving to file...");

        string filename = "people.txt";
        
        using(StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Person p in people)
            {
                outputFile.WriteLine($"{p._firstName}=={p._lastName}=={p._age}");
            }
        }
    }
    public static List<Person> ReadFromFile()
    {
        Console.WriteLine("Reading list from a file...");
        List<Person> people = new List<Person>();
        string filename = "people.txt";

        string[] lines = System.IO.File.ReadAllLines(filename);

        return people;
    }
}
