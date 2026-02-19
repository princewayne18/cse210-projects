using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment = new Assignment("Prince", "History");
        string summary = assignment.GetSummary();
        Console.WriteLine(summary);
        Console.WriteLine();

        MathAssignment mathassignment = new MathAssignment("Nqobile", "Fractions", "7.3", "8.9");
        string a1 = mathassignment.GetHomeworkList();
        string summary2 = assignment.GetSummary();

        Console.WriteLine(a1);
        Console.Write(summary2);
        Console.WriteLine();

        WritingAssignment wa = new WritingAssignment("Mary Waters", "- European History", "The Causes of World War II");
        string a2 = wa.GetWritingInformation();

        Console.Write(a2);

    }
}