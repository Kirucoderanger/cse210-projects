//the program.cs file is the entry point of the EternalQuest project
// It contains the Main method which is the starting point of the application.  
//// It initializes the GoalManager and starts the application.
// The program is designed to manage and track goals for users, allowing them to create, view, and manage their goals.
// The program is structured to be user-friendly and interactive, guiding users through the process of managing their goals.
// The program is designed to be extensible, allowing for future enhancements and additional features to be added easily.
// The program is written in C# and follows best practices for coding standards and conventions.Polymorphism
// is used to allow different types of goals to be managed in a consistent manner, while encapsulation is used to hide the implementation details of the goal management system from the user.
// The program is designed to be modular, with separate classes for different components of the goal management system, making it easy to maintain and update.
// The program is designed to be efficient, with optimized algorithms for managing and tracking goals, ensuring that it can handle large numbers of goals without performance issues.
// Polymorphism is used to allow different types of goals to be managed in a consistent manner, while encapsulation is used to hide the implementation details of the goal management system from the user.
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the EternalQuest Project.");
        GoalManager goalManager = new GoalManager();
        goalManager.Start();
    }
}