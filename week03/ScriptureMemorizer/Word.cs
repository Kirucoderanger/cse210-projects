using System;
using System.Collections.Generic;
using System.Linq;

namespace Word
{
    public class WordGenerator
    {
        private static List<string> words = new List<string>
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
            "What is something new you tried today?", 
            "What is something you are proud of?",
            "What is something you are looking forward to?",
            "Who was the most interesting person I interacted with today?",
            "What is something I learned today?",
            "What is something I did today that I am proud of?",
            "What is something I did today that I could have done better?",
            "What is something I did today that I could have done differently?",
            "What is something I did today that I would like to do again?",
            "What was the best part of my day?",
            "What was the worst part of my day?",
            "What was the most challenging part of my day?",
            "What was the most rewarding part of my day?",
            "What was the most surprising part of my day?",
            "What was the most disappointing part of my day?",
            "What was the most frustrating part of my day?",
            "What was the most exciting part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "How did I see the hand of the Lord in the life of someone else today?",
            "What was the strongest emotion I felt today?",
            "What was the most difficult decision I made today?",
            "What was the most important decision I made today?",
            "What was the most impactful decision I made today?",
            "What was the most meaningful decision I made today?"
        };

        public static (string, int) GetRandomWord()
        {
            Random random = new Random();
            int index = random.Next(words.Count);
            List<string> splitdWords = words[index].Split(' ').ToList();
            int wordLen = splitdWords.Count;
            int randomWordIndex = random.Next(0,wordLen); 
            string randomScripture = words[index];
            return (words[index], randomWordIndex);
            //return string.Join(" ", splitdWords);
            
        }

        







  }


}