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
    public void SetIscomplete(string isComplete)
    {
        string _isComplete = isComplete;
        //_completed = isComplete;
    }
    public void SetGoals(int goalType, string name, string description, int points)
    {
        _goalType = goalType;
        _name = name;
        _description = description;
        _points = points;
    }
    public virtual void SetGoals()
    {
       
        //_completed = completed;
    }
    public virtual void SetGoals(int goalType, string name, string description, int points, string completed)
    {
        _goalType = goalType;
        _name = name;
        _description = description;
        _points = points;
        //_completed = completed;
    }
    public Goal(int goalType, string name, string description, int points, bool completed)
    {
        _goalType = goalType;
        _name = name;
        _description = description;
        _points = points;
        //_completed = completed;
    }
    public Goal(int goalType, string name, string description, int points, string isComplete)
    {
        _goalType = goalType;
        _name = name;
        _description = description;
        _points = points;
        //_completed = completed;
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

    public bool IsCompleted()
    {
        return false;
        //return _completed;
    }

    public void MarkAsCompleted()
    {
        string _isComplete = "true";
    }
    public virtual  string GetDetailString()
    {
        return $"{_goalType},{_name},{_description},{_points},{IsCompleted()}";
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
}
// Compare this snippet from week06/Shapes/Circle.cs:
