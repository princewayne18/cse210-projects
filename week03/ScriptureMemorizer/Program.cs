using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        //this is for Loading from a file 
        //it takes any random text 
        string[] lines = File.ReadAllLines("scriptures.txt");
        Random random = new Random();

        string line = lines[random.Next(lines.Length)];
        string[] parts = line.Split('|');


        string book = parts[0];
        int chapter = int.Parse(parts[1]);
        int startVerse = int.Parse(parts[2]);
        int endVerse;
        string text;
        Reference reference;


        if (parts.Length == 5)
        {
            endVerse = int.Parse(parts[3]);
            text = parts[4];
            reference = new Reference(book, chapter, startVerse, endVerse);
        }
         else
        {
            text = parts[3];
            reference = new Reference(book, chapter, startVerse);
        }

        Scripture scripture = new Scripture(reference, text);

        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());


            if (scripture.IsCompletehidden())
            {
                break;
            }

            Console.WriteLine();
            Console.Write("Press Enter to continue or type 'quit' to exit: ");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                break;
            }

            scripture.HideRandomWords(3);
        }
    }
}