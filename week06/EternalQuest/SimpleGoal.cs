public class SimpleGoal : Goal
{
    
    private string _isComplete;

    public SimpleGoal(int goalType, string name, string description, int points, string completed) : base (goalType, name,  description,  points)
    {
       
        _isComplete = completed;
    }
    /* public override  string GetDetailString()
    {
        return $"{GetGoalType()},{GetName()},{GetDescription()}, {GetPoints()},{_isComplete}";
    }*/
    public SimpleGoal(int goalType, string name, string description, int points) : base (goalType, name,  description,  points)
    {
        _isComplete = "false";
    }
    public override void  SetGoals() 
    {
       
        _isComplete = "true";
    }
    
    public override string RecordEvent()
    {
        if (_isComplete == "false")
        {
            _isComplete = "true";
            return base.RecordEvent();
        }
        else
        {
            return "Goal already completed.";
        }
    }
    public override string GetName()
    {
        return base.GetName();
    }

    public override string GetDescription()
    {
        return base.GetDescription();
    }
    public override int GetPoints()
    {
        return base.GetPoints();
    }
    public override int GetGoalType()
    {
        return base.GetGoalType();
    }
    public bool IsCompleted()
    {
        return _isComplete == "true";
    }

    public void MarkAsComplete()
    {
        _isComplete = "true";
    }

    public string IsComplete()
    {
        return _isComplete;
    }
    public override string GetDetailString()
    {
        return base.GetDetailString();
    }
}