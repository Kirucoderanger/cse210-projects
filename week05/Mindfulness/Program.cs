using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Mindfulness Project.");
        bool running = true;

       

        while (running)
        {
            Console.WriteLine("\nWelcome to the Mindfulness Program!");
            Console.WriteLine("Please choose an activity:");
            Console.WriteLine("1. Breathing Exercise");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Gratitude Journal");
            Console.WriteLine("4. Quit");

            Console.Write("Enter your choice (1-4): ");
            string choice = Console.ReadLine();

            switch (choice)
            {
            case "1":
                // Breathing Exercise
                Activity activity = new Activity("Breathing Exercise", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");
                //activity.DisplayActivityDetails();
                //activity.DisplayStartingMessage();
                //activity.DisplayInstructions();
                //activity.ShowSpinnerInSeconds(3); // Simulate loading spinner for 3 seconds
                //activity.ShowSpinner(3); // Simulate loading spinner for 3 seconds
                // Uncomment the following line to run the Breathing Activity
                // BreathingActivity breathingActivity = new BreathingActivity();
                // breathingActivity.Run();
                

                
                

                /*Console.WriteLine("You chose the Breathing Exercise.");
                BreathingActivity breathingActivity = new BreathingActivity();
                breathingActivity.Run();*/
                // Add logic for Breathing Exercise here
                break;
            case "2":
                // Reflection Activity
                Activity activity1 = new Activity("Reflection Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
                //Console.WriteLine("You chose the Reflection Activity.");
                //ReflectingActivity reflectingActivity = new ReflectingActivity();
                //reflectingActivity.Start();
                // Add logic for Reflection Activity here
                break;
            case "3":
                Activity activity2 = new Activity("Gratitude Journal", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
                //Console.WriteLine("You chose the Gratitude Journal.");
                //ListingActivity listingActivity = new ListingActivity();
                //listingActivity.Start();
                // Add logic for Gratitude Journal here
                break;
            case "4":
                Console.WriteLine("Thank you for using the Mindfulness Program. Goodbye!");
                running = false;
                break;
            default:
                Console.WriteLine("Invalid choice. Please try again.");
                break;
            }
        }
    }
}