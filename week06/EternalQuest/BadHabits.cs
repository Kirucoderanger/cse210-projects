public class BadHabits : Goal
{
    public BadHabits(int goalType, string name, string description, int points) : base ( goalType, name,  description,  points)
    {
        
    }

   

     public override  string GetDetailString()
    {
        return base.GetDetailString();
    }
    public override string RecordEvent()
    {
        return "Congratulations you have accomplished your goal!";
    }
}