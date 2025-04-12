public class EternalGoal : Goal
{
    public EternalGoal(int goalType, string name, string description, int points) : base ( goalType, name,  description,  points)
    {
        
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

     public override  string GetDetailString()
    {
        return base.GetDetailString();
    }
}