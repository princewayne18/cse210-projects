using System;
using System.Collections.Generic;
using System.IO;
class Program
{
    static void Main(string[] args)
    {
        Person person1 = new Person("Prince", "Dube", 33);

        Person person2 = new Person("Alex", "Sibanda", 35);

        List<Person> _person = new List<Person>();
        _person.Add(person1);
        _person.Add(person2);

        foreach (Person p in _person)
        {
            Console.WriteLine(p._firstName);
        }

        SaveToFile(_person);
    }

    public static void SaveToFile(List<Person>_person)
    {
        Console.WriteLine("Saving to file...");
        string filename = "people.txt";

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Person p in _person)
            {
                outputFile.WriteLine(p._firstName);
            }
        }

    }
}