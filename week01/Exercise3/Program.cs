using System;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("This is a number guessing game, you will be asked the range of the number you want to guess.");
         string response = "yes";
        while (response == "yes")
        {
        Console.Write("Enter the minimum number: ");
        int min = int.Parse(Console.ReadLine());
        Console.Write("Enter the maximum number: ");
        int max = int.Parse(Console.ReadLine());
        Console.WriteLine($" you will guess the number between {min} and {max} and You will prompted to guess lower or higher for every guess until you get the number.");
        Random random = new Random();
        int number = random.Next(min, max + 1);
        Console.Write("Enter your guess: ");
        int guess = int.Parse(Console.ReadLine()); 
        int guesses = 1;
            while (guess != number)
            {
                if (guess < number)
                {
                    Console.WriteLine("Higher");
                }
                else
                {
                    Console.WriteLine("Lower");
                }
                Console.Write("Enter your guess: ");
                guess = int.Parse(Console.ReadLine());
                guesses++;
            }
            Console.WriteLine("Congratulations! You guessed the number.");
            Console.WriteLine($"It took you {guesses} guesses.");
            Console.Write("Do you want to play again? please enter yes if no enter any key: ");
            response = Console.ReadLine();
            
        }
        



        
       



    }
}