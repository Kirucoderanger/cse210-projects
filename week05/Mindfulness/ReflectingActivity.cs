using System;
using System.Collections.Generic;
using System.Threading;
using System.Runtime.InteropServices;


    public class ReflectingActivity
    {
        private List<string> prompts = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };

        private List<string> questions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };

        public void Start()
        {
            Console.WriteLine("Welcome to the Reflecting Activity.");
            Console.WriteLine("This activity will help you reflect on times in your life when you have shown strength and resilience.");
            Console.WriteLine("This will help you recognize the power you have and how you can use it in other aspects of your life.");
            Console.Write("How many seconds would you like to spend on this activity? ");
            int duration = int.Parse(Console.ReadLine());

            Console.WriteLine("\nGet ready to begin...");
            Thread.Sleep(2000);

            ShowRandomPrompt();
            ReflectOnQuestions(duration);

            Console.WriteLine("\nGreat job! You have completed the Reflecting Activity.");
        }

        private void ShowRandomPrompt()
        {
            Random random = new Random();
            string prompt = prompts[random.Next(prompts.Count)];
            Console.WriteLine($"\nConsider the following prompt:\n--- {prompt} ---");
            Console.WriteLine("\nWhen you have something in mind, press Enter to continue.");
            Console.ReadLine();
        }

        private void ReflectOnQuestions(int duration)
        {
            Console.WriteLine("Now, reflect on the following questions as they relate to your experience.");
            Console.WriteLine("You may take a moment to think after each question.");

            Random random = new Random();
            int elapsedTime = 0;

            while (elapsedTime < duration)
            {
                string question = questions[random.Next(questions.Count)];
                Console.WriteLine($"\n{question}");
                ShowSpinner(5); // Pause for 5 seconds for each question
                elapsedTime += 5;
            }
        }

        private void ShowSpinner(int seconds)
        {
            DateTime endTime = DateTime.Now.AddSeconds(seconds);
            while (DateTime.Now < endTime)
            {
                Console.Write("/");
                Thread.Sleep(200);
                Console.Write("\b-");
                Thread.Sleep(200);
                Console.Write("\b\\");
                Thread.Sleep(200);
                Console.Write("\b|");
                Thread.Sleep(200);
                Console.Write("\b");
            }
        }
    }
 