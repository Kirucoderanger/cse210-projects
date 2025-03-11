public class Resume 
{
    public string name = "";
    public List<Job> _jobs = new List<Job>();

    public void DisplayAll()
    {
        Console.WriteLine($"Name: {name}" );
        Console.WriteLine("Jobs:");
        foreach (Job i in _jobs)
        {
        //Console.WriteLine($"{_jobs[i]._company} ({_jobs[i]._jobTitle}) {_jobs[i]._startYear}-{_jobs[i]._endYear}");
        Console.WriteLine($"{i._jobTitle } ({i._company}) {i._startYear}-{i._endYear}");
        i.Display();
        }
    }
    
}