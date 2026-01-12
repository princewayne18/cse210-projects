using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string userName = PromptUserName();
        int userNumber = PromptUserNumber();
        int squareNumber = SquareNumber(userNumber);
        DisplayResult(userName, squareNumber);

    }
        static void  DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");
        }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        string userNumber = Console.ReadLine();
        int favoriteNumber = int.Parse(userNumber);

        return favoriteNumber;
    }

    static int SquareNumber(int number)
    {
        return number * number;
    }

        static void DisplayResult(string name, int squaredNumber)
        {
        Console.Write($"{name}, the square of your number is {squaredNumber}");
        }
    
}