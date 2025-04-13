public class Goal
{
    private int _goalType;
    private string _name;
    private string _description;
    private int _points;
    //private bool _completed;
    public Goal(int goalType, string name, string description, int points)
    {
        //_completed = completed;
        _goalType = goalType;
        _name = name;
        _description = description;
        _points = points;
    }
    public virtual int GetGoalType()
    {
        return _goalType;
    }
    
    public virtual string RecordEvent()
    {
        

        return "Congratulations you have accomplished your goal!";
    }

    public virtual string GetName()
    {
        return _name;
    }

     public virtual string GetDescription()
    {
        return _description;
    }


    public virtual int GetPoints()
    {
        return _points;
    }
    

    public virtual  bool IsCompleted()
    {
        return false;
       
       
    }
    public virtual bool GetIsCompleted()
    {
        return false;
    }
    
    public virtual  string GetDetailString()
    {
        return $"{_goalType},{_name},{_description},{_points}";
    }
    public virtual void GetStringRepresentation()
    {
        GetDetailString().ToString();

        Console.WriteLine($"Goal Type: {_goalType}");
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine($"Description: {_description}");
        Console.WriteLine($"Points: {_points}");
        //Console.WriteLine($"Completed: {_completed}");
        //Console.WriteLine($"Completed: {IsCompleted()}");
    }
    public virtual void RecordEvent(int goalType)
    {
        if (goalType == 1)
        {
            Console.WriteLine("Simple Goal Completed!");
        }
        else if (goalType == 2)
        {
            Console.WriteLine("Checklist Goal Completed!");
        }
        else if (goalType == 3)
        {
            Console.WriteLine("Eternal Goal Completed!");
        }
    }
    public virtual int GetBonusPoints()
    {
        return 0;
    }
    public virtual int GetTargetAmount()
    {
        return 0;
    }
    public virtual int GetCurrentAmount()
    {
        return 0;
    }
    public virtual int SetCurrentAmount()
    {
        return 0;
    }
}
// Compare this snippet from week06/Shapes/Circle.cs:
