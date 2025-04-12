public class Goal
{
    private int _goalType;
    private string _name;
    private string _description;
    private int _points;
    //private bool _completed;
    public Goal(int goaltype, string name, string description, int points)
    {
        _name = name;
        _points = points;
        _description = description;
        _goalType = goaltype;

    }
    public virtual int GetGoalType()
    {
        return _goalType;
    }
    public void SetGoal(int goalType, string name,string description, int points)
    {
        _name = name;
        _points = points;
        _description = description;
        _goalType = goalType;
        //_completed = false;
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
        //_completed = true;
    }
    public virtual  string GetDetailString()
    {
        return $"{_goalType},{_name},{_description},{_points}";
    }
}
// Compare this snippet from week06/Shapes/Circle.cs:
