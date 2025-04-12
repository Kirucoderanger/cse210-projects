using System;
using System.Collections.Generic;
using System.Threading;
using System.Runtime.InteropServices;
using System.Formats.Tar;
using System.Runtime.CompilerServices;
using System.IO;



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

    private int _count;
    public void SetCount(int count)
    {
        _count = count;

    }
    public int GetCount()
    {
        return _count;
    }


    public ListingActivity (string name, string description, int count) : base(name, description)
    {
        _count = count;
            
    }

    public ListingActivity (int duration) : base (duration)
    {

    }

    public static void Run()
        {
            Console.Clear();
            ListingActivity listingActivity = new ListingActivity("Gratitude Journal","This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", 0);
            listingActivity.DisplayStartingMessage();
            int newDuration = int.Parse(Console.ReadLine());
            ListingActivity listingActivity1 = new ListingActivity(newDuration);
            int duration = listingActivity1.GetDuration();
            Console.Clear();
            listingActivity1.ShowSpinnerWithMessage("Get ready to begin...", 3); // Simulate loading spinner with message for 3 seconds
            listingActivity1.Listing(duration);
        }

    public void Listing(int duration)
    {       
        string prompt = GetRandomPrompt();
        Console.WriteLine($"Prompt: {prompt}");
        Console.WriteLine("You will have a few seconds to think about the prompt...");
        PauseWithCountdown(5);
        Console.WriteLine("Start listing items! Press Enter after each item. When time is up, stop entering items.");
        List<string> items = CollectItems(duration);
        Console.WriteLine($"You listed {items.Count} items!");
        ShowSpinner(3);
        DisplayEndingMessage();
        Console.Write("Do you want to add this journal to an existing file? (y/n): ");
         string answer = Console.ReadLine();
        if (answer == "y")
        {
            Console.WriteLine("Please enter the filename to save to:");
            string saveFilename = Console.ReadLine();
            ToFile(items, saveFilename);
            Console.WriteLine($"Your journal has been added to {saveFilename}.");
        }
        else
        {
            Console.WriteLine("Please enter the filename to save to:");
            string saveFilename = Console.ReadLine();
            ToFile(items, saveFilename);
            Console.WriteLine($"Your journal has been saved to {saveFilename}.");
        }
        Console.Write("Do you want to load the previous journal file? (y/n): ");
        string answer2 = Console.ReadLine();
        if (answer2 == "y")
        {
            Console.WriteLine("Please enter the filename to load from:");
            string loadFilename = Console.ReadLine();
            LoadFromFile(loadFilename);
            Console.WriteLine($"Your journal has been loaded from {loadFilename}.");
        }
        else
        {
            Console.WriteLine("No previous journal file loaded.");
        }
        Console.WriteLine("Press any key to continue...");

        
        
        
    }

    private string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }

    List<string> CollectItems(int duration)
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
    public  void ToFile(List<string>items,  string saveFilename)
    {
        
        using(StreamWriter writer = File.AppendText(saveFilename))
        {
            foreach (string i in items)
            {
                writer.WriteLine(i);
            }
        }


    }
    public static List<string> LoadFromFile(string loadFilename)
    {   
        List<string> entryLins = new List<string>();
        string[] lines = System.IO.File.ReadAllLines(loadFilename);
        foreach (string line in lines)
        {
           Console.WriteLine(line);      
      }
      return entryLins;
    } 
}
