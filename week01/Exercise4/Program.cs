using System;
using System.Collections;

class Program
{
    static void Main(string[] args)
    {
        int number;
        List<int> numbers = new List<int>();
        int sum = 0;

        do
        {
            Console.Write("Enter a list of numbers, type 0 when finished.");
            string answer = Console.ReadLine();
            number = int.Parse(answer);


            numbers.Add(number);

        } while (number != 0);
        Console.WriteLine("Enter a list of numbers, type 0 when finished. ");
        foreach (int n in numbers)
        {
            sum += n;

        }
        int max = numbers[0];
        foreach (int n in numbers)
        {
            if (n > max)
            {
                max = n;
            }
        }
        double average = sum / numbers.Count;

        Console.WriteLine($"The sum is {sum}");
        Console.WriteLine($"The average is {average}");
        Console.WriteLine($"the Largest number is {max}");

    }
}