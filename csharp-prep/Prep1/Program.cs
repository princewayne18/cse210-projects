using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("what is Your name? ");
        string name =Console.ReadLine();

        Console.Write("what is your last surname? ");
        string last_name= Console.ReadLine();

        Console.WriteLine($"Your name is {name}, {name} {last_name}");


    }
}