using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace Word
{
    public class WordGenerator
    {
        private static List<string> words = new List<string>
        {
            "Therefore whosoever heareth these sayings of mine, and doeth them, I will liken him unto a wise man, which built his house upon a rock",
            "And the rain descended, and the floods came, and the winds blew, and beat upon that house; and it fell not: for it was founded upon a rock",
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
            return (randomScripture, randomWordIndex);
            //return string.Join(" ", splitdWords);
            
        }

        static WordSentisaizer sentisaized = new WordSentisaizer();
        public static string sentisaizedWord = sentisaized.GetWord();
        public static List<string> splitdWords = sentisaizedWord.Split(' ').ToList();
        
        
        

        public class WordSentisaizer()
        
        {
            
        
            private string selectedWord = WordGenerator.GetRandomWord().Item1;
             private int selectedIndex = WordGenerator.GetRandomWord().Item2;
             public string GetWord()
             {
                return selectedWord;
             }

             public void setWord(string newWord)
             {
                selectedWord = newWord;

             }
            /*
            public (string, int) GetWordDetails()
            {
                
                List<string> splitdWords = selectedWord.Split(' ').ToList();
                int wordLen = splitdWords.Count;
                Random random = new Random();
                int index = random.Next(words.Count);
                int randomWordIndex = random.Next(0, wordLen);
                return (selectedWord, randomWordIndex);
            }*/

        }

        public class IndexInitializeInts()
        {
            //List<string> splitdWords = sentisaizedWord.Split(' ').ToList();
            private int wordLen = splitdWords.Count;
            private  List<int> Ints = new List<int>();
            public List<int> GetIndexList()
        {
            
            for (int i = 0; i < wordLen-1 ; i++)
                Ints.Add(i);
            return Ints;
        }

        public List<int> RemoveIndex(int newIndex)
             {
                Ints.RemoveAt(newIndex);
                return Ints;
             }


        }

        
        

          
         //public static List<int> ints = new List<int>();

        public static (string, int) GetFullScripture()
        {
             //WordSentisaizer sentisaized = new WordSentisaizer();
             //string sentisaizedWord = sentisaized.GetWord();
             List<string> splitdWords = sentisaizedWord.Split(' ').ToList();
                int wordLen = splitdWords.Count;
                /*for (int i = 0; i < wordLen ; i++)
                    ints.Add(i);*/
             
             return (sentisaizedWord, wordLen);
        }
        
        
        
       
        static IndexInitializeInts initialindex = new IndexInitializeInts();
        public static List<int> ints = initialindex.GetIndexList();
        static List<int> hiddenIndices = new List<int>();
        
        
        
        public static string WordHider()
        {
            
                //WordSentisaizer sentisaized = new WordSentisaizer();
                //string sentisaizedWord = sentisaized.GetWord();
                List<string> splitdWords = sentisaizedWord.Split(' ').ToList();
                

                int wordLen = splitdWords.Count;
                Random random = new Random();
                int indexx = random.Next(ints.Count);
                int randomWordIndex = random.Next(0, wordLen);
                //List<int> hidens = [randomWordIndex];
                //List<int> hiddenIndices = new List<int>();
                //int intigers = 0;
                
                
                //hiddenIndices.RemoveAt(0);

                
                    
                hiddenIndices.Add(ints[indexx]);
                foreach (int hiddenIndex in hiddenIndices)
                splitdWords[hiddenIndex] = "_______";
                ints.Remove(ints[indexx]);
                //initialindex.RemoveIndex(indexx);
                
                
                return string.Join(" ", splitdWords);
                

                //return sentisaizedWord;
        }

        
       









  }


}