using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Learning04 World!");
        Assignment assignment = new Assignment("Samuel Bennett", "Multiplication");
        MathAssignment mathAssignment = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");
        WritingAssignment writingAssignment = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        
        string summary = assignment.GetSummary();
        Console.WriteLine(summary);

        summary = mathAssignment.GetSummary();
        Console.WriteLine(summary);
        string problems = mathAssignment.GetHomeworkList();
        Console.WriteLine(problems);

        summary = writingAssignment.GetSummary();
        Console.WriteLine(summary);
        string title = writingAssignment.GetWritingInformation();
        Console.WriteLine(title);




    }
}