public class SimpleGoal : Goal
{
    private string _name;
    private string _description;
    private bool _isComplete;

    public SimpleGoal(int goalType, string name, string description, int points) : base (goalType, name,  description,  points)
    {
        SetGoal(goalType, name, description, points);
    }

    public void MarkAsComplete()
    {
        _isComplete = true;
    }

    public bool IsComplete()
    {
        return _isComplete;
    }

    public string GetName()
    {
        return _name;
    }

    public string GetDescription()
    {
        return _description;
    }
    public override string GetDetailString()
    {
        return base.GetDetailString();
    }
}