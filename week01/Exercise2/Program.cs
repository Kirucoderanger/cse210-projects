using System;

class Program
{
    static void Main(string[] args)
    {
        string gradeLater = "";
        string gradeSaign = "";
        float gradeRemainder = 0;
        Console.Write("What is your grade? ");
        float grade = float.Parse(Console.ReadLine());
        // the following code will determine the grade sign
        gradeRemainder = grade % 10;
        
        if (gradeRemainder >= 7)
        {
            gradeSaign = "+";
        }
        else if (gradeRemainder < 3)
        {
            gradeSaign = "-";
        }
        else
        {
            gradeSaign = "";
        }  
        

        // the following code will determine if the student passed or failed
            if (grade >= 70)
            {
                Console.WriteLine("Congradulations You passed.");
            }
            else    
            {
                Console.WriteLine("We are sorry You failed, please try again.");
            } 
            
            // the following code will determine the grade letter
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
            // the following code will print the grade with the sign  excluding the grade of "F" and "A+"
            if (gradeLater == "F")
            {   
                Console.WriteLine($"You Got {gradeLater}.");
            }
            else if (gradeLater == "A")
            {
                if (gradeSaign == "-")
                {
                    Console.WriteLine($"You Got {gradeLater}{gradeSaign}.");
                }
                else
                {
                    Console.WriteLine($"You Got {gradeLater}.");
                }
                
            }
            else 
            {
                Console.WriteLine($"You Got {gradeLater}{gradeSaign}.");
            }
        
    }
}