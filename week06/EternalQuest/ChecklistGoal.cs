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
    public override int GetTargetAmount()
    {
        return _targetAmount;
    }
    public override int GetCurrentAmount()
    {
        return _currentAmount;
    }
    public override int GetBonusPoints()
    {
        return _bonusPoints;
    }
    public override int GetGoalType()
    {
        return base.GetGoalType();
    }
    public override int SetCurrentAmount()
    {
        _currentAmount = _currentAmount + 1;
        return _currentAmount;
    }

    public override int GetPoints()
    {
        if (_currentAmount >= _targetAmount)
        {
            return base.GetPoints() + _bonusPoints;
        }
        return base.GetPoints();
    }
    public override string RecordEvent()
    {
        if (_currentAmount < _targetAmount)
        {
            _currentAmount++;
            return $"Current amount: {_currentAmount}/{_targetAmount}";
        }
        else
        {
            return "Goal already completed.";
        }
    }
}