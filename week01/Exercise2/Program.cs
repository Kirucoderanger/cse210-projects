using System;

class Program
{
    static void Main(string[] args)
    {
        string gradeLater = "";
        Console.Write("What is your grade? ");
        int grade = int.Parse(Console.ReadLine());

            if (grade >= 70)
            {
                Console.WriteLine("Congradulations You passed.");
            }
            else    
            {
                Console.WriteLine("We are sorry You failed, please try again.");
            } 
            

                if (grade >= 90)
                {
                    gradeLater = "A";
                }
                else if (grade >= 80)
                {
                    gradeLater = "B";
                }
                else if (grade >= 70)
                {
                    gradeLater = "C";
                }
                else if (grade >= 60)
                {
                    gradeLater = "D";
                }
                else
                {
                    gradeLater = "F";
                }
                Console.WriteLine($"You Got {gradeLater}.");
        
    }
}