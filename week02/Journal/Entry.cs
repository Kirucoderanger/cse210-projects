/* using System;

namespace Journal
{
    public class Entry
    {
        public DateTime Date { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }

        public Entry(DateTime date, string title, string content)
        {
            Date = date;
            Title = title;
            Content = content;
        }

        public override string ToString()
        {
            return $"{Date.ToShortDateString()} - {Title}\n{Content}";
        }
    }
}
*/

public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;
    //Journal theJournal = new Journal();
    //theJournal.AddEntry(anEntry);

    public void Display()
    {
        Console.WriteLine($"{_date} - {_promptText}\n{_entryText}");
    }
}