public class Person
{
    public string _givenName = "";
    public string _familyName = "";

    public void ShowEasternName()
    {
        Console.WriteLine($"{_givenName} {_familyName}");
    }

    public void ShowWesternName()
    {
        Console.WriteLine($"{_familyName} {_givenName}");
    }
}