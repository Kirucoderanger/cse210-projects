
using System.Runtime.InteropServices;

public class BreathingActivity : Activity
    {
        
       Activity activity = new Activity();
        //private int _duration;
        //private string _description = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
        //private string _startingMessage = "Welcome to the Breathing Activity!";
        //private string _finishingMessage = "Great job! You have completed the Breathing Activity.";
        
        /*public BreathingActivity()
        {
            _duration = 0;
            _description = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
            _startingMessage = "Welcome to the Breathing Activity!";
            _finishingMessage = "Great job! You have completed the Breathing Activity.";
        }*/

       
       /* private string _description = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
        private string _startingMessage = "Welcome to the Breathing Activity!";
        private string _finishingMessage = "Great job! You have completed the Breathing Activity.";
        
        public void Run()
        {
            Console.WriteLine(_startingMessage);
            Console.WriteLine(_description);
            Console.Write("Enter the duration of the activity in seconds: ");
            
            if (int.TryParse(Console.ReadLine(), out int duration) && duration > 0)
            {
                Console.WriteLine("Get ready to begin...");
                Thread.Sleep(2000); // Pause for 2 seconds before starting
                
                int elapsed = 0;
                while (elapsed < duration)
                {
                    Console.WriteLine("Breathe in...");
                    Countdown(3); // Pause for 3 seconds
                    elapsed += 3;

                    if (elapsed >= duration) break;

                    Console.WriteLine("Breathe out...");
                    Countdown(3); // Pause for 3 seconds
                    elapsed += 3;
                }

                Console.WriteLine(_finishingMessage);
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a positive number.");
            }
        }*/

        
        public void Run(int duration)
        {
            //Console.WriteLine("Welcome to the Breathing Activity!");
            //Console.WriteLine("This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");
            //Console.Write("Enter the duration of the activity in seconds: ");
            //_duration = duration;
            //Console.WriteLine(_description);
            //Console.WriteLine(_startingMessage);
            //Console.WriteLine(_description);
        
            //Activity activity = new Activity();
            
            //Console.WriteLine(duration);
            if (duration > 0)
            {
                
                //ShowSpinner(3); // Simulate loading spinner for 3 seconds
                //ShowSpinnerInSeconds(5); // Simulate loading spinner for 5 seconds
                //ShowSpinnerWithMessage("Get ready to begin...", 3); // Simulate loading spinner with message for 3 seconds
                ShowSpinnerDots(5); // Simulate loading spinner with dots for 5 seconds
                //PauseWithCountdown(5); // Simulate loading spinner with countdown for 5 seconds
                //Thread.Sleep(2000); // Pause for 2 seconds before starting
                
                int elapsed = 0;
                while (elapsed < duration)
                {
                    
                    Console.WriteLine("");
                    Console.WriteLine("Now Breathe in...");
                    Thread.Sleep(1000);
                    Countdown(4); // Pause for 3 seconds
                    elapsed += 3;

                    if (elapsed >= duration) break;
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
                //DisplayEndingMessage();
        
        }
    }
