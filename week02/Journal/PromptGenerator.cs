/* using System;
using System.Collections.Generic;

namespace Journal
{
    public class PromptGenerator
    {
        private static List<string> prompts = new List<string>
        {
            "What are you grateful for today?",
            "Describe a memorable moment from your day.",
            "What did you learn today?",
            "How did you overcome a challenge today?",
            "What made you smile today?",
            "What are your goals for tomorrow?",
            "Reflect on a recent accomplishment.",
            "What is something you are looking forward to?",
            "Describe a person who made a positive impact on your day.",
            "What is something new you tried today?"
        };

        public static string GetRandomPrompt()
        {
            Random random = new Random();
            int index = random.Next(prompts.Count);
            return prompts[index];
        }
    }
}
*/
public class PromptGenerator
{
    public List<string> _prompts;
    public string GetRandomPrompt()
    {
        return "";
    }
    //public string _promptText;
    //public string _entryText;

    /*
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
    */
}