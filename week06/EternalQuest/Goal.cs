public class Goal
{
    private string _name;
    private string _description;
    private int _points;
    //private bool _completed;
    public Goal(string name, string description, int points)
    {
        _name = name;
        _points = points;
        _description = description;

    }
    public void SetGoal(string name,string description, int points)
    {
        _name = name;
        _points = points;
        _description = description;
        //_completed = false;
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
        return $"{_name},{_description},{_points}";
    }
}
// Compare this snippet from week06/Shapes/Circle.cs:
