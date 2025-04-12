using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
// author: Kirubel Mekonen
// date: 2025-10-04
// description: This code defines a base class for mindfulness activities, including properties and methods for managing activity details and user interactions.
// The listing activity has an option to save and load data from a file, allowing users to keep track of their progress and reflections.
// The code includes methods for displaying messages, simulating loading spinners, and handling user input for activity duration and prompts.
// This code defines an Activity class that can be used as a base class for different mindfulness activities.
// It includes properties for the activity name, description, and duration, as well as methods to display messages and instructions.
// The ShowSpinnerInSeconds method simulates a loading spinner for a specified number of seconds.
// The class can be extended to create specific activities like BreathingActivity, ReflectingActivity, and ListingActivity.
// The methods can be called in the main program to provide a structured experience for users participating in mindfulness activities.
// The class can be further enhanced by adding more properties and methods as needed for specific activities.
// The class is designed to be flexible and reusable, allowing for easy integration into a larger mindfulness program.
// The class can be used to create a variety of mindfulness activities, each with its own unique characteristics and behaviors.
// The class can be instantiated and used in the main program to provide a consistent user experience across different activities.
// The class can be easily modified or extended to accommodate new features or requirements in the mindfulness program.
// The class can be used as a foundation for building a comprehensive mindfulness application that includes various activities and features.
// The class can be tested and validated to ensure that it meets the requirements of the mindfulness program and provides a positive user experience.
// The class can be documented to provide clear instructions and guidelines for developers and users who will be working with it in the future.
// The class can be integrated with other components of the mindfulness program to create a cohesive and user-friendly application.
// The class is designed to be flexible and reusable, allowing for easy integration into a larger mindfulness program.
// The class can be used to create a variety of mindfulness activities, each with its own unique characteristics and behaviors.


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
                BreathingActivity.Run();
                break;
            case "2":
                ReflectingActivity.Run();
                break;
            case "3":
                ListingActivity.Run();
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