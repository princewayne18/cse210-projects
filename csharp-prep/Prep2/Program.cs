using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("what is your grade percentage: ");
        string grade = Console.ReadLine();
        int gradeP =int.Parse(grade);

        if (gradeP > 90)
        {
            Console.WriteLine("A");
        }

        else if (gradeP>80)
        {
            Console.WriteLine("B");
        }
        else if (gradeP>70)
        {
            Console.WriteLine("C"); 
        }
        else if (gradeP>60)
        {
            Console.WriteLine("D");
        }
        else 
        {
            Console.WriteLine("F");
        }


    }    
}