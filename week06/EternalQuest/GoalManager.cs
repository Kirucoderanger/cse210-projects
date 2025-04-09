

public class GoalManager
{
    List<Goal> goals = new List<Goal>();
    
    private int _goalType;
    private string _name;
    private string _description;
    private int _points;
    private int _targetAmount;
    private int _bonusPoints;
    public void SetGoaltype(int goalType)
    {
        _goalType = goalType;
    }
    public void SetName(string name)
    {
        _name = name;
    }
    public void SetDescription(string description)
    {
        _description = description;
    }
    public void SetPoints(int points)
    {
        _points = points;
    }
    public void SetTargetAmount(int targetAmount)
    {
        _targetAmount = targetAmount;
    }
    public void SetBonusPoints(int bonusPoints)
    {
        _bonusPoints = bonusPoints;
    }
    public void Start()
    {
        // This method should initialize the goal manager and set up any necessary data structures.
        // You can create a List<Goal> to store the goals and initialize it here.
        
        bool running = true;
        while (running)
        {
            
            Console.WriteLine("You have 0 points.");
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
                    Console.WriteLine("which type of goal you wold like to create"); 
                    int GoalType = int.Parse(Console.ReadLine());
                    SetGoaltype(GoalType);
                    // Add logic to add a new goal
                    if (GoalType == 1)
                    {
                        Console.WriteLine("Enter goal name:");
                        string Name = Console.ReadLine();
                        SetName(Name);
                        
                        Console.WriteLine("Enter goal description:");
                        string Description = Console.ReadLine();
                        SetDescription(Description);
                        Console.WriteLine("Enter goal points:");
                        int Points = int.Parse(Console.ReadLine());
                        SetPoints(Points);

                        
                        goals.Add(new SimpleGoal(Name, Description, Points)); 

                    }
                    else if(GoalType == 2)
                    {
                        Console.WriteLine("Enter goal name:");
                        string Name = Console.ReadLine();
                        SetName(Name);
                        
                        Console.WriteLine("Enter goal description:");
                        string Description = Console.ReadLine();
                        SetDescription(Description);
                        Console.WriteLine("Enter goal points:");
                        int Points = int.Parse(Console.ReadLine());
                        SetPoints(Points);
                        Console.WriteLine("How many times this goal need to be completed for a bonus:");
                        int TargetAmount = int.Parse(Console.ReadLine());
                        SetTargetAmount(TargetAmount);
                        Console.WriteLine("Enter bonus points (for Checklist goals):");
                        int BonusPoints = int.Parse(Console.ReadLine());
                        SetBonusPoints(BonusPoints);
                        goals.Add(new ChecklistGoal(Name, Description, Points, TargetAmount, BonusPoints)); 

                    }
                    else if(GoalType == 3)
                    {
                        Console.WriteLine("Enter goal name:");
                        string Name = Console.ReadLine();
                        SetName(Name);
                        
                        Console.WriteLine("Enter goal description:");
                        string Description = Console.ReadLine();
                        SetDescription(Description);
                        Console.WriteLine("Enter goal points:");
                        int Points = int.Parse(Console.ReadLine());
                        SetPoints(Points);

                        goals.Add(new EternalGoal(Name, Description, Points)); 

                    }
                    else 
                    {
                        Console.WriteLine("Invalid input try again");
                    }

                    
                     
                    
                    break;
                case "2":
                    // Add logic to mark a goal as completed
                    Console.WriteLine("_description");
                    foreach(Goal goal in goals)
                    {
                    //float pay = employee1.CalculatePay(); //Polymorphism in Action
                    Console.WriteLine(goal.ToString());
                    string detail = goal.GetDetailString();
                    Console.WriteLine(detail);
                    }
                    break;
                case "3":
                    // Add logic to view goals
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
}