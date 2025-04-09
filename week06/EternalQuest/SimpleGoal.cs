public class SimpleGoal : Goal
{
    private string _name;
    private string _description;
    private bool _isComplete;

    public SimpleGoal(string name, string description, int points) : base ( name,  description,  points)
    {
        SetGoal(name, description, points);
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