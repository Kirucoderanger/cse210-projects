public class Person
{
    private string _name;
    public Person (string name)//contractor
    {
        _name = name;
    }
    public string GetName()
    {
        return _name;
    }
}