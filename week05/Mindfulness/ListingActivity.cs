using System;
using System.Collections.Generic;
using System.Threading;
using System.Runtime.InteropServices;



public class ListingActivity : Activity
{
    //private string _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public void Start(int duration)
    {
        //Console.WriteLine("Welcome to the Listing Activity!");
        //Console.WriteLine(_description);
        //Console.Write("Please enter the duration of the activity in seconds: ");
        //int duration = int.Parse(Console.ReadLine());

        //Console.WriteLine("Get ready...");
        //Thread.Sleep(2000);

        string prompt = GetRandomPrompt();
        Console.WriteLine($"Prompt: {prompt}");
        Console.WriteLine("You will have a few seconds to think about the prompt...");
        Countdown(5);

        Console.WriteLine("Start listing items! Press Enter after each item. When time is up, stop entering items.");
        List<string> items = CollectItems(duration);

        Console.WriteLine($"You listed {items.Count} items!");
        //Console.WriteLine("Great job! Thank you for participating in the Listing Activity.");
    }

    private string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }

    /*private void Countdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.WriteLine(i);
            Thread.Sleep(1000);
        }
    }*/

    private List<string> CollectItems(int duration)
    {
        List<string> items = new List<string>();
        DateTime endTime = DateTime.Now.AddSeconds(duration);

        while (DateTime.Now < endTime)
        {
            string input = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(input))
            {
                items.Add(input);
            }
        }

        return items;
    }
}
