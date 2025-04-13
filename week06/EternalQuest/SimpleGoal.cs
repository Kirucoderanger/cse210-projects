public class SimpleGoal : Goal
{
    
    private bool _isComplete;

    public SimpleGoal(int goalType, bool completed, string name, string description, int points) : base (goalType, name,  description,  points)
    {
       
        _isComplete = completed;
    }

    public override  string GetDetailString()
    {
        return $"{GetGoalType()},{_isComplete},{GetName()},{GetDescription()}, {GetPoints()}";
    }
    public override int GetPoints()
    {
        return base.GetPoints();
    }
    public override int GetGoalType()
    {
        return base.GetGoalType();
    }
    public override bool  IsCompleted()
    {
        _isComplete = true;
        return _isComplete;
        
    }
    public override bool GetIsCompleted()
    {
        return _isComplete;
    }
   
    public override string RecordEvent()
    {
        if (_isComplete == false)
        {
            _isComplete = true;
            return "Congratulations you have accomplished your goal!";
        }
        else
        {
            return "Goal already completed.";
        }
    }
}