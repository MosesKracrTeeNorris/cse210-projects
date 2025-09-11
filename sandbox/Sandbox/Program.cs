using System;
Using System.Collections.Generic;
Using System.IO
class Program
{
    static void Main(string[] args)
    {
        person p1 = new person();
        p1._firstName = "Peter";
        p1._lastName = "Kollie";
        p1._age = "37";
        person p2 = new person();
        p2._firstName = "James";
        p2._lastName = "Doe";
        p2._age = "28";
        person p3 = new person();
        p3._firstName = "Tina";
        p3._lastName = "Browne";
        p3._age = 24;

        List<person> people = new List<person>();
        people.Add(p1);
        people.Add(p2);
        people.Add(p3);

        foreach (person p in people)
        {
            Console.WriteLine($"{p._firstName} {p._lastName} {p._age}");
            
        }

        //SaveToFile(people);

        List<person> newPeople = ReadFromFile();
        foreach (person p in newPeople)
        {
            Console.WriteLine(p._lastName);
        }
    }
    public static void SaveToFile(List<person> people)
    {
        Console.WriteLine("Saving to file...");

        string filename = "people.txt"
        
        using(StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (person p in people)
            {
                outputFile.WriteLine($"{p._firstName}=={p._lastName}=={p._age}");
            }
        }
    }
    public static List<person> ReadFromFile()
    {
        Console.WriteLine("Reading list from a file...");
        list<person> people = new List<person>();
        string filename = "people.txt";

        string[] lines = System.IO.File.ReadAllLines(filename);

        return people;
    }
}
