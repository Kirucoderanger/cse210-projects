using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Homework Project.");
        Assignment assignment1 = new Assignment("Kirubel","Fractions");
        Console.WriteLine(assignment1.GetSummary());
        MathAssignment mathAssignment1 = new MathAssignment("Kirubel","fractions","7","10 - 13");
        Console.WriteLine(mathAssignment1.GetHomeworkList());
        WritingAssignment writingAssignment1 = new WritingAssignment("Kirubel","European History","The Causes of World War II  by Mary Waters");
        Console.WriteLine(writingAssignment1.GetWritingInformation());

    }
}