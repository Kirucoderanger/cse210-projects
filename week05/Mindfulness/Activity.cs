

// This code defines an Activity class that can be used as a base class for different mindfulness activities.
// It includes properties for the activity name, description, and duration, as well as methods to display messages and instructions.
//Displaying the starting message
//Displaying the ending message
//Pausing while showing a spinner for a certain number of seconds
//Pausing while showing a countdown timer for a certain number of seconds
public class Activity
{
    // Properties, methods, and fields for the Activity class can be added here.
    private string _name;
    private string _description;
    private int _duration;
    public string GetName()
    {
        return _name;
    }
    public string GetDescription()
    {
        return _description;
    }
    public int GetDuration()
    {
        return _duration;
    }

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
        
    }
    public Activity(int duration)
    {
        _duration = duration;
    }
    public void DisplayStartingMessage()
    {
        Console.WriteLine("Welcome to the Mindfulness Activity!");
        Console.WriteLine($"You are about to start: {GetName()}");
        Console.WriteLine($"Description: {GetDescription()}");
        Console.Write("Enter a new duration for the activity in seconds: ");
        //Console.WriteLine($"This activity will last for {Duration} minutes.");
    }
    public void DisplayActivityDetails()
    {
        Console.WriteLine($"Activity Name: {GetName}");
        Console.WriteLine($"Description: {GetDescription}");
        //Console.WriteLine($"Duration: {Duration} minutes");
    }
    
    public void DisplayEndingMessage()
    {
        //Console.WriteLine($"Congratulations on completing the {Name} activity!");
        //Console.WriteLine("Thank you for participating in the Mindfulness Program.");
        Console.WriteLine("");
        Console.WriteLine("Well done!");
        ShowSpinner(3); // Simulate loading spinner for 3 seconds
        Console.WriteLine("");
        Console.WriteLine($"Great job! You have completed another {GetDuration()} seconds of the {GetName()} activity.");
        ShowSpinner(3); // Simulate loading spinner for 3 seconds
        Console.Clear();
    }
    public void ShowSpinnerInSeconds(int seconds)
    {
        Console.Write("Processing");
        for (int i = 0; i < seconds; i++)
        {
        Console.Write(".");
        System.Threading.Thread.Sleep(1000); // Pause for 1 second
        }
        Console.WriteLine();
    }

    public void ShowSpinner(int seconds)
    {
        DateTime endTime = DateTime.Now.AddSeconds(seconds);
        while (DateTime.Now < endTime)
        {
            Console.Write("/");
            Thread.Sleep(200);
            Console.Write("\b-");
            Thread.Sleep(200);
            Console.Write("\b\\");
            Thread.Sleep(200);
            Console.Write("\b|");
            Thread.Sleep(200);
            Console.Write("\b");
            Console.Write("");
        }
    }
    public void PauseWithCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
        Console.Write($"\rCountdown: {i} seconds remaining...");
        System.Threading.Thread.Sleep(1000); // Pause for 1 second
        }
        Console.WriteLine("\rCountdown complete!                  ");
    }
    public void ShowSpinnerDots(int seconds)
    {
        //Thread.Sleep(1000);
        Console.Clear();
        Console.WriteLine("Get ready to begin...");
        Console.Write("Loading");
        for (int i = 0; i < seconds; i++)
        {
            Console.Write(".");
            System.Threading.Thread.Sleep(1000); // Pause for 1 second
        }
        Console.WriteLine();
    }
    public void ShowSpinnerWithMessage(string message, int seconds)
    {
        Console.Write(message);
        for (int i = 0; i < seconds; i++)
        {
            Console.Write(".");
            System.Threading.Thread.Sleep(1000); // Pause for 1 second
        }
        Console.WriteLine();
    }

    public void Countdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i + " ");
            Thread.Sleep(1000); // Pause for 1 second
        }
        Console.WriteLine();
    }

}

