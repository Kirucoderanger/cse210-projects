

// This code defines an Activity class that can be used as a base class for different mindfulness activities.
// It includes properties for the activity name, description, and duration, as well as methods to display messages and instructions.
    public class Activity
    {
        // Properties, methods, and fields for the Activity class can be added here.
        private string _name;
        private string _description;
        private int _duration;
        public void SetName(string name)
        {
            _name = name;
        }
        public string GetName()
        {
            return _name;
        }
        public void SetDescription(string description)
        {
            _description = description;
        }
        public string GetDescription()
        {
            return _description;
        }
        public void SetDuration(int duration)
        {
            _duration = duration;
        }
        public int GetDuration()
        {
            return _duration;
        }
        


        /*public string Name
        
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        public int Duration
        {
            get { return _duration; }
            set { _duration = value; }
        }*/
        /*
        public void SetDurationFromInput()
        {
            Console.Write("Enter the duration of the activity in seconds: ");
            string duration = Console.ReadLine();
            Activity activity = new Activity(int.Parse(duration));
            
            
            SetDuration(duration);
            //return _duration; // Ensure the method returns the updated duration
        }
        public Activity(int duration)
        {
            _duration = duration;
        }
        
        public void SetDuration(int duration)
        {
            _duration = duration;
        }

        public void SetDuration(string duration)
        {
            _duration = int.Parse(duration);
        }*/
        
        public Activity(string name, string description)
        {
            SetName(name);
            SetDescription(description);
            //_name = name;
            //_description = description;
            DisplayStartingMessage();

             Console.Write("Enter a new duration for the activity in seconds: ");
                int newDuration = int.Parse(Console.ReadLine());
                //_duration = newDuration;
                SetDuration(newDuration);
                
                Console.WriteLine($"The activity will last for: {GetDuration()} seconds.");
                //Console.WriteLine($"The activity will last for: {newDuration} seconds.");
            //SetDurationFromInput();
            //Console.Write("Enter the duration of the activity in seconds: ");
            //_duration = Console.ReadLine() != null ? int.Parse(Console.ReadLine()) : 0;
            //_duration = int.TryParse(Console.ReadLine(), out int duration) ? duration : 0;
            //_duration = int.Parse(Console.ReadLine());
           // _duration = Math.Max(_duration, 0); // Ensure duration is non-negative
            
            
            
            if (name == "Breathing Exercise")
            {
                BreathingActivity BreathingActivity = new BreathingActivity();
                BreathingActivity.Run(GetDuration());
            }
            else if (name == "Reflection Activity")
            {
                ReflectingActivity reflectingActivity = new ReflectingActivity();
                reflectingActivity.Start(GetDuration());
                
                
            }
            else if (name == "Gratitude Journal")
            {
                ListingActivity listingActivity = new ListingActivity();
                listingActivity.Start(GetDuration());
            }
            else
            {
                Console.WriteLine("Invalid activity name.");
            }
            DisplayEndingMessage();

        }
        
        
            // Default constructor
        public Activity()
        {
            //_name = "Default Activity";
            //_description = "This is a default activity description.";
            //_duration = 0;
        }
       /* public Activity(string name, string description, int duration)
        {
            _name = name;
            _description = description;
            _duration = duration;


            if (Name == "Breathing Exercise")
            {
                DisplayActivityDetails();
                DisplayStartingMessage();
                DisplayInstructions();
                ShowSpinnerInSeconds(3); // Simulate loading spinner for 3 seconds
                ShowSpinner(3); // Simulate loading spinner for 3 seconds
                BreathingActivity breathingActivity = new BreathingActivity();
                breathingActivity.Run();
            }
            else if (Name == "Reflecting")
            {
                DisplayActivityDetails();
                DisplayStartingMessage();
                
                ReflectingActivity reflectingActivity = new ReflectingActivity();
                reflectingActivity.Start();
            }
            else if (Name == "Listing")
            {
                ListingActivity listingActivity = new ListingActivity();
                listingActivity.Start();
            }
            else
            {
                Console.WriteLine("Invalid activity name.");
            }
        }*/
        public void DisplayActivityDetails()
        {
            Console.WriteLine($"Activity Name: {GetName}");
            Console.WriteLine($"Description: {GetDescription}");
            //Console.WriteLine($"Duration: {Duration} minutes");
        }
        public void DisplayStartingMessage()
        {
            //Activity activity = new Activity();

            Console.WriteLine("Welcome to the Mindfulness Activity!");
            Console.WriteLine($"You are about to start: {GetName()}");
            Console.WriteLine($"Description: {GetDescription()}");
            //Console.WriteLine($"This activity will last for {Duration} minutes.");
        }
        public void DisplayEndingMessage()
        {
            //Activity activity = new Activity();
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
        public void DisplayInstructions()
        {
            Console.WriteLine("Instructions:");
            Console.WriteLine("1. Find a comfortable position.");
            Console.WriteLine("2. Close your eyes and take a deep breath.");
            Console.WriteLine("3. Focus on your breathing and let go of any distractions.");
            Console.WriteLine("4. Continue for the duration of the activity.");
        }
        public void DisplayInstructions(string instructions)
        {
            Console.WriteLine("Instructions:");
            Console.WriteLine(instructions);
            Console.WriteLine("1. Find a comfortable position.");
            Console.WriteLine("2. Close your eyes and take a deep breath.");
            Console.WriteLine("3. Focus on your breathing and let go of any distractions.");
            Console.WriteLine("4. Continue for the duration of the activity.");
        
            Console.WriteLine("5. When you are ready, open your eyes and take a moment to reflect.");
            Console.WriteLine("6. Take a moment to express gratitude for the experience.");
            Console.WriteLine("Please follow the instructions carefully.");
            Console.WriteLine("Take a deep breath and relax.");
            Console.WriteLine("Focus on your breathing and let go of any distractions.");
        }
        public void DisplayReflection()
        {
            Console.WriteLine("Reflect on your experience during the activity.");
            Console.WriteLine("What did you learn about yourself?");
            Console.WriteLine("How do you feel after completing the activity?");
        }
        public void DisplayGratitude()
        {
            Console.WriteLine("Take a moment to express gratitude.");
            Console.WriteLine("Think of three things you are grateful for today.");
            Console.WriteLine("Reflect on the positive aspects of your life.");
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
            }
        }





    


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
// The class can be used to create a variety of mindfulness activities, each with its own unique characteristics and behaviors.
// The class can be easily modified or extended to accommodate new features or requirements in the mindfulness program.
// The class is designed to be flexible and reusable, allowing for easy integration into a larger mindfulness program.
// The class can be used to create a variety of mindfulness activities, each with its own unique characteristics and behaviors.
// The class can be easily modified or extended to accommodate new features or requirements in the mindfulness program.
// The class is designed to be flexible and reusable, allowing for easy integration into a larger mindfulness program.
// The class can be used to create a variety of mindfulness activities, each with its own unique characteristics and behaviors.
// The class can be easily modified or extended to accommodate new features or requirements in the mindfulness program.
// The class is designed to be flexible and reusable, allowing for easy integration into a larger mindfulness program.



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
            Thread.Sleep(1000);
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
    
