using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Xml.XPath;

public class GoalManager
{
    protected List<Goal> goals = new List<Goal>();
    
    private int _score = 0;
    
    public void SetScore(int score)
    {
        _score = _score + score;
    }
    public void SetScore1(int score)
    {
        _score = _score - score;
    }
    public int GetScore()
    {
        return _score;
    }
    public List<Goal> GetGoals()
    {
        return goals;
    }
    public void SetGoals(List<Goal> goals)
    {
        this.goals = goals;
    }
    public void Start()
    {
        // This method should initialize the goal manager and set up any necessary data structures.
        // You can create a List<Goal> to store the goals and initialize it here.
        
        bool running = true;
        while (running)
        {
            
            Console.WriteLine($"You have {_score} points.");
            /*Console.WriteLine("You have 0 completed goals.");
            Console.WriteLine("You have 0 total goals.");
            Console.WriteLine("You have 0 total points.");
            Console.WriteLine("You have 0 bonus points.");
            Console.WriteLine("You have 0 total bonus points.");
            Console.WriteLine("You have 0 total completed goals.");*/

            Console.WriteLine("Welcome to the Goal Manager!");
            Console.WriteLine("Please choose an option:");
            Console.WriteLine("1. Create a new goal");
            Console.WriteLine("2. List goals");
            Console.WriteLine("3. Save goals");
            Console.WriteLine("4. Load goals");
            Console.WriteLine("5. Record an event for a goal");
            Console.WriteLine("6. Quit");
            Console.Write("Enter your choice (1-6): ");
            

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.WriteLine("Select the type of goal you want to create:");
                    Console.WriteLine("1. Simple Goal");
                    Console.WriteLine("2. Checklist Goal");
                    Console.WriteLine("3. Eternal Goal");
                    Console.WriteLine("4. Bad Habits");
                    Console.WriteLine("which type of goal you wold like to create"); 
                    int GoalType = int.Parse(Console.ReadLine());
                    //SetGoaltype(GoalType);
                    // Add logic to add a new goal
                    if (GoalType == 1)
                    {
                        Console.WriteLine("Enter goal name:");
                        string Name = Console.ReadLine();
                        //SetName(Name);
                        
                        Console.WriteLine("Enter goal description:");
                        string Description = Console.ReadLine();
                        //SetDescription(Description);
                        Console.WriteLine("Enter goal points:");
                        int Points = int.Parse(Console.ReadLine());
                        //SetPoints(Points);
                        //bool completed = false;

                        
                        goals.Add(new SimpleGoal(GoalType, false, Name, Description, Points)); 

                    }
                    else if(GoalType == 2)
                    {
                        Console.WriteLine("Enter goal name:");
                        string Name = Console.ReadLine();
                        //SetName(Name);
                        
                        Console.WriteLine("Enter goal description:");
                        string Description = Console.ReadLine();
                        //SetDescription(Description);
                        Console.WriteLine("Enter goal points:");
                        int Points = int.Parse(Console.ReadLine());
                        //SetPoints(Points);
                        Console.WriteLine("How many times this goal need to be completed for a bonus:");
                        int TargetAmount = int.Parse(Console.ReadLine());
                        //SetTargetAmount(TargetAmount);
                        Console.WriteLine("Enter bonus points (for Checklist goals):");
                        int BonusPoints = int.Parse(Console.ReadLine());
                        //SetBonusPoints(BonusPoints);
                        goals.Add(new ChecklistGoal(GoalType, Name, Description, Points, TargetAmount, BonusPoints, 0)); 

                    }
                    else if(GoalType == 3)
                    {
                        Console.WriteLine("Enter goal name:");
                        string Name = Console.ReadLine();
                        //SetName(Name);
                        
                        Console.WriteLine("Enter goal description:");
                        string Description = Console.ReadLine();
                        //SetDescription(Description);
                        Console.WriteLine("Enter goal points:");
                        int Points = int.Parse(Console.ReadLine());
                        //SetPoints(Points);

                        goals.Add(new EternalGoal(GoalType, Name, Description, Points)); 

                    }
                    else if(GoalType == 4)
                    {
                        Console.WriteLine("Enter Habit name:");
                        string Name = Console.ReadLine();
                        //SetName(Name);
                        
                        Console.WriteLine("Enter thr bad habit description:");
                        string Description = Console.ReadLine();
                        //SetDescription(Description);
                        Console.WriteLine("Enter points should be deducted every time you did a bad habit:");
                        int Points = int.Parse(Console.ReadLine());
                        //SetPoints(Points);

                        goals.Add(new BadHabits(GoalType, Name, Description, Points)); 

                    }
                    else 
                    {
                        Console.WriteLine("Invalid input try again");
                    }

                    
                     
                    
                break;
                case "2":
                // Add logic to mark a goal as completed
                //Console.WriteLine("_description");
                foreach(Goal goal in goals)
                {
                //float pay = employee1.CalculatePay(); //Polymorphism in Action
                //Console.WriteLine(goal.ToString());
                string detail = goal.GetDetailString();
                if (detail.Split(',')[0] == "1")
                    {
                        if (detail.Split(',')[1] == "True")
                        {
                            Console.Write(" [ X ] ");
                            Console.WriteLine(detail);
                        }
                        else
                        {
                            Console.Write(" [   ] ");
                            Console.WriteLine(detail);
                        }
                        //Console.WriteLine("SimpleGoal");
                        //Console.WriteLine(detail);
                        //Console.WriteLine(detail.Split(',')[2]);
                    }
                    else if (detail.Split(',')[0] == "2")
                    {
                        if (detail.Split(',')[6] == detail.Split(',')[4])
                        {
                            Console.Write(" [ X ] ");
                            Console.WriteLine(detail);
                        }
                        else
                        {
                            Console.Write(" [   ] ");
                            Console.WriteLine(detail);
                        }
                        //Console.WriteLine("ChecklistGoal");
                        //Console.WriteLine(detail);
                        //Console.WriteLine(detail.Split(',')[2]);
                    }
                    else if (detail.Split(',')[0] == "3")
                    {
                        //Console.WriteLine("EternalGoal");
                        //Console.WriteLine(detail);
                        //Console.WriteLine(
                        Console.Write(" [   ] ");
                        Console.WriteLine(detail);
                    }
                    else if (detail.Split(',')[0] == "4")
                    {
                        //Console.WriteLine("EternalGoal");
                        //Console.WriteLine(detail);
                        //Console.WriteLine(
                        Console.Write(" [   ] ");
                        Console.WriteLine(detail);
                    }
                
                }
                break;
                case "3":
                // Add logic to save goals to a file
                Console.WriteLine("Enter the filename to save goals:");
                string saveFilename = Console.ReadLine();
                
                GoalsToFile(saveFilename);
                Console.WriteLine($"Goals have been saved to {saveFilename}.");

                

            
                
                
                
                break;
                case "4":
                // Add logic to load goals
                Console.WriteLine("Enter the filename to load goals from:");
                string loadFilename = Console.ReadLine();

                //List<string> entryLines = LoadFromFile(loadFilename);
                List<string> entryLines = new List<string>();
                string[] lines = System.IO.File.ReadAllLines(loadFilename);
                foreach (string line in lines)
                {
                    entryLines.Add(line);
                }
                
                foreach (string line in lines)
                {
                    string[] parts = line.Split(',');
                    int goalTypeIdentifier = int.Parse(parts[0]);

                    if (goalTypeIdentifier == 1)
                    {
                        // SimpleGoal
                        //Console.WriteLine("SimpleGoal");
                        int goalType = int.Parse(parts[0]);
                        string name = parts[1];
                        string description = parts[2];
                        int points = int.Parse(parts[3]);
                        //bool isCompleted = bool.Parse(parts[4]);
                        string isCompleted = parts[4];
                        bool result = bool.Parse(isCompleted);
                        //int targetAmount = int.Parse(parts[5]);
                        //int bonusPoints = int.Parse(parts[6]);
                        //goals.Add(new SimpleGoal(goalType, name, description, points, isCompleted)); 
                        
                        Goal goal = new SimpleGoal(goalType, result, name, description, points);
                        goals.Add(goal);
                    }
                    else if (goalTypeIdentifier == 2)
                    {
                        // ChecklistGoal
                        int goalType = int.Parse(parts[0]);
                        string name = parts[1];
                        string description = parts[2];
                        int points = int.Parse(parts[3]);
                        int targetAmount = int.Parse(parts[4]);
                        int bonusPoints = int.Parse(parts[5]);
                        int currentAmount = int.Parse(parts[6]);

                        
                        Goal goal = new ChecklistGoal(goalType, name, description, points, targetAmount, bonusPoints, currentAmount);
                        goals.Add(goal);
                    }
                    else if (goalTypeIdentifier == 3)
                    {
                        // EternalGoal
                        int goalType = int.Parse(parts[0]);
                        string name = parts[1];
                        string description = parts[2];
                        int points = int.Parse(parts[3]);
                        //bool isCompleted = bool.Parse(parts[4]);
                        
                        Goal goal = new EternalGoal(goalType, name, description, points);
                        goals.Add(goal);
                    }
                    else if (goalTypeIdentifier == 4)
                    {
                        // EternalGoal
                        int goalType = int.Parse(parts[0]);
                        string name = parts[1];
                        string description = parts[2];
                        int points = int.Parse(parts[3]);
                        //bool isCompleted = bool.Parse(parts[4]);
                        
                        Goal goal = new BadHabits(goalType, name, description, points);
                        goals.Add(goal);
                    }
                    else
                    {
                        Console.WriteLine("Invalid goal format in file.");
                    }
                }
                Console.WriteLine($"Goals have been loaded from {loadFilename}.");
                break;
                case "5":
                // Add logic to view goals
                Console.WriteLine("The goals are:");
                int i = 1;
                foreach(Goal goal in goals)
                {
                    
                    string detail = goal.GetDetailString();

                    Console.WriteLine($"{i}. {detail.Split(',')[2]}");
                    i = i + 1;

                }
                Console.WriteLine("Enter the number of the goal you want to mark as completed:");
                int goalNumber = int.Parse(Console.ReadLine()) - 1;
                //string line1 = goals[goalNumber].GetDetailString();
                //string[] parts1 = line1.Split(',');
                //parts1[4] = "True";
                if (goalNumber >= 0 && goalNumber < goals.Count)
                {
                    Goal selectedGoal = goals[goalNumber];
                    if (selectedGoal.GetIsCompleted() == true)
                    {
                        Console.WriteLine($"Goal '{goals[goalNumber].GetName()}' already completed!");
                        break;
                    }
                    else 
                    {
                        //Goal selectedGoal = goals[goalNumber];
                        if (selectedGoal.GetGoalType() == 1)         
                        {
                            selectedGoal = new SimpleGoal(selectedGoal.GetGoalType(),selectedGoal.IsCompleted(),selectedGoal.GetName(),selectedGoal.GetDescription(),selectedGoal.GetPoints());
                            SetScore(selectedGoal.GetPoints());
                            Console.WriteLine($"Goal '{selectedGoal.GetName()}' marked as completed!");
                            //selectedGoal.RecordEvent();
                            //selectedGoal.GetDetailString().Split(',')[4] = "true";
                            //selectedGoal.GetDetailString().Split(',')[4] = "true";
                            //selectedGoal.MarkAsCompleted();
                            //selectedGoal.SetGoals();
                            //goals[goalNumber] = selectedGoal;
                        }
                        else if (selectedGoal.GetGoalType() == 2)
                        
                        {
                            if (selectedGoal.GetCurrentAmount() >= selectedGoal.GetTargetAmount())
                            {
                                Console.WriteLine($"Goal '{selectedGoal.GetName()}' already completed!");
                                
                            }
                            else if (selectedGoal.GetCurrentAmount() < selectedGoal.GetTargetAmount())
                            {
                                if (selectedGoal.GetCurrentAmount() + 1 == selectedGoal.GetTargetAmount())
                                {
                                    selectedGoal.SetCurrentAmount();
                                    SetScore(selectedGoal.GetPoints());
                                    SetScore(selectedGoal.GetBonusPoints());
                                    Console.WriteLine($"Goal '{selectedGoal.GetName()}' marked as completed!");
                                    
                                }
                                else
                                {
                                    selectedGoal.SetCurrentAmount();
                                    SetScore(selectedGoal.GetPoints());
                                    Console.WriteLine($"Goal '{selectedGoal.GetName()}' marked as in progress!");
                                    
                                }
                                
                            }
                            //selectedGoal = new ChecklistGoal(selectedGoal.GetGoalType(),selectedGoal.GetName(),selectedGoal.GetDescription(),selectedGoal.GetPoints(),selectedGoal.GetTargetAmount(),selectedGoal.GetBonusPoints(),selectedGoal.SetCurrentAmount());
                            
                            
                        }
                        else if (selectedGoal.GetType() == typeof(EternalGoal))
                        {
                            SetScore(selectedGoal.GetPoints());
                            
                        }
                        else if (selectedGoal.GetType() == typeof(BadHabits))
                        {
                            SetScore1(selectedGoal.GetPoints());
                            
                        }
                        //selectedGoal = new SimpleGoal(selectedGoal.GetGoalType(),selectedGoal.GetName(),selectedGoal.GetDescription(),selectedGoal.GetPoints(),selectedGoal.IsCompleted());

                        //selectedGoal.RecordEvent();
                    }
                    //Goal selectedGoal = goals[goalNumber];
                    
                    //selectedGoal = new SimpleGoal(selectedGoal.GetGoalType(),selectedGoal.GetName(),selectedGoal.GetDescription(),selectedGoal.GetPoints(),selectedGoal.IsCompleted());
                    //selectedGoal.GetDetailString().Split(',')[4] = "true";
                    //selectedGoal.GetDetailString().Split(',')[4] = "true";
                    //selectedGoal.MarkAsCompleted();
                    //selectedGoal.SetGoals();
                    //goals[goalNumber] = selectedGoal;
                    //SetScore(selectedGoal.GetPoints());
                    //Console.WriteLine($"Goal '{selectedGoal.GetName()}' marked as completed!");
                    
                    //_score += selectedGoal.GetPoints();
                }
                else if (goalNumber >= 0 && goalNumber < goals.Count)
                {
                    Console.WriteLine($"Goal '{goals[goalNumber].GetName()}' already completed!");
                }
                else if (goalNumber < 0 && goalNumber > goals.Count)
                {
                    Console.WriteLine("Goal number out of range.");
                }
                else
                {
                    Console.WriteLine("Invalid goal number.");
                }
                break;
                case "6":
                running = false;
                break;
                default:
                Console.WriteLine("Invalid choice. Please try again.");
                break;
            }
        }

        
    }
    // This class is responsible for managing the goals in the game.
    // It should allow adding new goals, marking goals as completed, and tracking the number of completed goals.
    // It should also provide a way to retrieve the list of goals and their completion status.
    // You can use a List<Goal> to store the goals and a counter for completed goals.






    /*private List<Goal> _goals = new List<Goal>();
    private int _completedGoals = 0;

    public void AddGoal(Goal goal)
    {
        _goals.Add(goal);
    }

    public void CompleteGoal(int index)
    {
        if (index >= 0 && index < _goals.Count)
        {
            _goals[index].Complete();
            _completedGoals++;
        }
    }

    public int GetCompletedGoalsCount()
    {
        return _completedGoals;
    }*/


    public  void GoalsToFile(  string saveFilename)
        {
            
            using(StreamWriter writer = File.AppendText(saveFilename))
            {
                foreach (Goal  goal in goals)
                {
                    string detail = goal.GetDetailString();
                    writer.WriteLine(detail);
                }
            }


        }    
        public void  LoadFromFile(string loadFilename)
        {   
            List<string> entryLins = new List<string>();
            string[] lines = System.IO.File.ReadAllLines(loadFilename);
            foreach (string line in lines)
            {
               Console.WriteLine(line);  
               string[] parts = line.Split(',');    
               int goalType = int.Parse(parts[0]);
                        string name = parts[1];
                        string description = parts[2];
                        int points = int.Parse(parts[3]);
                        //bool isCompleted = bool.Parse(parts[4]);
                        string isCompleted = parts[4];
                        bool result = bool.Parse(isCompleted);
                        //int targetAmount = int.Parse(parts[5]);
                        //int bonusPoints = int.Parse(parts[6]);
                        goals.Add(new SimpleGoal(goalType, result, name, description, points)); 
                        
                        //Goal goal = new SimpleGoal(goalType, name, description, points, isCompleted);
                        //goals.Add(goal);


            }
           

            
            //return entryLins;
            
        }
        public void RecordEvent()        
        {
            // Implement logic to record an event for the goal
            // This could involve updating the goal's status or points based on the event.
            Console.WriteLine("Event recorded for the goal.");
        }
}