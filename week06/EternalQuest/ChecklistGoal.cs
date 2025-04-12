public class ChecklistGoal : Goal
{
    private int _bonusPoints;
    private int _targetAmount;
    private int _currentAmount;

    public ChecklistGoal(int goalType, string name, string description,int points, int targetAmount, int bonusPoints, int currentAmount): base(goalType, name, description, points )
    {
        _targetAmount = targetAmount;
        _bonusPoints = bonusPoints;
        _currentAmount = currentAmount;
    }

     public override  string GetDetailString()
    {
        return $"{GetGoalType()},{GetName()},{GetDescription()}, {GetPoints()},{_targetAmount},{_bonusPoints},{_currentAmount}";
    }
   /* public override void RecordEvent()
    {
        if (_currentAmount < _targetAmount)
        {
            _currentAmount++;
            Console.WriteLine($"Current amount: {_currentAmount}/{_targetAmount}");
        }
        else
        {
            Console.WriteLine("Goal already completed.");
        }
    }*/

    public override int GetPoints()
    {
        if (_currentAmount >= _targetAmount)
        {
            return base.GetPoints() + _bonusPoints;
        }
        return base.GetPoints();
    }
}