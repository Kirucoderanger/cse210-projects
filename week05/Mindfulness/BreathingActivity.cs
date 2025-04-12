
using System.Runtime.InteropServices;

public class BreathingActivity : Activity

{
public BreathingActivity (string name, string description ) : base(name, description)
{
        
}

public BreathingActivity (int duration) : base (duration)
{

}

public static void Run()
{
    Console.Clear();
    BreathingActivity breathingActivity = new BreathingActivity("Breathing Exercise","This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");
    breathingActivity.DisplayStartingMessage();
    int newDuration = int.Parse(Console.ReadLine());
    BreathingActivity breathingActivity1 = new BreathingActivity(newDuration);
    int duration = breathingActivity1.GetDuration();
    breathingActivity1.Breathing(duration);
}
    

public  void Breathing(int duration)
{
    if (duration > 0)
    {
        //ShowSpinnerWithMessage("Get ready to begin...", 3); // Simulate loading spinner with message for 3 seconds
        ShowSpinnerDots(5); // Simulate loading spinner with dots for 5 seconds
        int elapsed = 0;
        while (elapsed < duration)
        {
            Console.WriteLine("");
            Console.WriteLine("Now Breathe in...");
            Thread.Sleep(1000);
            base.Countdown(4); // Pause for 3 seconds
            elapsed += 3;

            if (elapsed >= duration) 
            {
                break;
            }
            Console.WriteLine("");
            Console.WriteLine("Breathe out...");
            Thread.Sleep(1000);
            Countdown(4); // Pause for 3 seconds
            elapsed += 3;
        }

        //Console.WriteLine("_finishingMessage");
    }
    else
    {
        Console.WriteLine("Invalid input. Please enter a positive number.");
    }
        //Console.WriteLine("Great job! You have completed the Breathing Activity.");
        //Console.WriteLine($"{DisplayEndingMessage()}");
        DisplayEndingMessage();

}
}
