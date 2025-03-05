using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise5 Project.");
        DesplayMessage();
        PromptUserName();
        PromptUserNumber();
        int number = PromptUserNumber();
        int square = SquareNumber1(number);
        string name = PromptUserName();
        DisplayResult(name, number, square);

        static void DesplayMessage()
        {
            Console.WriteLine("Welcome to the program CSE 210: Programming with Classes.");
            
        }
        static string PromptUserName()
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine($"Hello, {name}! Welcome to the program.");
            return name;
        }

        static int PromptUserNumber()
        {
            Console.WriteLine("Enter a number: ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine($"You entered the number {number}.");
            return number;
        }
        static int SquareNumber1(int number)
        {
            return number * number;
        }
        static void DisplayResult(string name, int number, int square)
        {
            Console.WriteLine($"Thank you, {name}! You entered the number {number}.");
            Console.WriteLine($"The square of {number} is {square}.");
            Console.WriteLine("Thank you for using the program.");
        }


    }



   
}