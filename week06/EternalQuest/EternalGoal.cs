public class EternalGoal : Goal
{
    private int _bonus;
    private int _bonusMultiplier;

    public EternalGoal(string name, string description, int points) : base ( name,  description,  points)
    {
        SetGoal(name, description, points);
    }

   /*public EternalGoal(string name, string description, int bonus, int bonusMultiplier) : base(name, description)
    {
        _bonus = bonus;
        _bonusMultiplier = bonusMultiplier;
    }

    public override int RecordEvent()
    {
        return _bonus * _bonusMultiplier;
    }

    public override string GetGoalType()
    {
        return "Eternal Goal";
    }*/

     public virtual  string GetDetailString()
    {
        return base.GetDetailString();
    }
}