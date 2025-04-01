public class MathAssignment : Assignment
{
    private string _textBookSection;
    private string _problems;

    public MathAssignment(string studentName, string topic, string textBookSection, string problems) : base(studentName, topic)
    {
        _textBookSection = textBookSection;
        _problems = problems;
    }

    public string GetTextBookSection()
    {
        return _textBookSection;
    }
    public string GetProblems()
    {
        return _problems;
    }
    public void SettextBookSection(string textBookSection)
    {
        _textBookSection = textBookSection;
    }
    public void SetProblems(string problems)
    {
        _problems = problems;
    }
    public string GetHomeworkList()
    {
        //return $"Student name: {base.GetStudentName} Topic: {base.GetTopic()} TextBookSection: {_textBookSection} Problems {_problems}";
        return $"{base.GetSummary()} TextBookSection: {_textBookSection} Problems {_problems}";
    }

}