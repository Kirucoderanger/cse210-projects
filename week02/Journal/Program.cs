// File: Program.cs
// Date: 2021-07-11
// Author: Gabriel Andrade
// Description: Main program for the Journal project.
// date 2025-03-16
// Purpose: Main program for the Journal project.
// The program allows the user to add entries to a journal, view all entries, save the journal to a file, and load the journal from a file.
// The program uses the Journal and Entry classes to manage the journal entries.
// The program saves the Journal date from the current date and time.
// The program also uses the PromptGenerator class to generate random prompts for the journal entries.
// The program uses the MyJournal class to manage the list of journal entries.
// The program uses the Journal class to manage the list of journal entries.
// The program uses the Entry class to represent a journal entry.
// The program uses the PromptGenerator class to generate random prompts for the journal entries.
// The program can AppendAllLines to a file as the user choses to add to an existing file or create a new one.
// To be continued on alerting the user to write a journal mornining non and evening.

using System;
using System.Collections.Generic;
using PromptGeneratorer;
class Program
{
    static void Main(string[] args)
    {
       /* MyJournal journal = new MyJournal();
        bool running = true;

        while (running)
        {
            Console.WriteLine("Journal Menu:");
            Console.WriteLine("1. Add Entry");
            Console.WriteLine("2. View Entries");
            Console.WriteLine("3. Save Journal");
            Console.WriteLine("4. Load Journal");
            Console.WriteLine("5. Exit");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
            case "1":
                Console.Write("Enter your journal entry: ");
                string entry = Console.ReadLine();
                journal.AddEntry(entry);
                break;
            case "2":
                journal.ViewEntries();
                break;
            case "3":
                Console.Write("Enter the filename to save the journal: ");
                string saveFilename = Console.ReadLine();
                journal.SaveJournal(saveFilename);
                break;
            case "4":
                Console.Write("Enter the filename to load the journal: ");
                string loadFilename = Console.ReadLine();
                journal.LoadJournal(loadFilename);
                break;
            case "5":
                running = false;
                break;
            default:
                Console.WriteLine("Invalid option. Please try again.");
                break;
            }
        }*/
        Journal theJournal = new Journal();
        //Entry anEntry = new Entry();
        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();
        //anEntry._date = dateText;
        //anEntry._promptText = "What are you grateful for today?";
        //anEntry._entryText = "I am grateful for my family.";
         bool running = true;

        while (running)
        {
            Console.WriteLine("Journal Menu:");
            Console.WriteLine("1. Add Entry");
            Console.WriteLine("2. View Entries");
            Console.WriteLine("3. Save Journal");
            Console.WriteLine("4. Load Journal");
            Console.WriteLine("5. Exit");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
            case "1":
                string prompt = PromptGenerator.GetRandomPrompt();
                Console.Write(prompt);
                Entry anEntry = new Entry();
                anEntry._date = dateText;
                anEntry._entryText = Console.ReadLine();
                anEntry._promptText = prompt;
                //anEntry._promptText = PromptGeneratorer.PromptGenerator.GetRandomPrompt();
                //PromptGenerator prompts = new PromptGenerator();
                
                theJournal.AddEntry(anEntry);
                
                break;
            case "2":
                theJournal.DisplayAll();
                break;
             case "5":
                running = false;
                break;
            
            case "3":
                Console.Write("Enter the filename to save the journal: ");
                string saveFilename = Console.ReadLine();
                Journal.SaveToFile(theJournal.entryList, saveFilename);
                break;
            case "4":
                Console.Write("Enter the filename to load the journal: ");
                string loadFilename = Console.ReadLine();
                /*List<Entry> jornalentries = Journal.LoadFromFile(loadFilename);
                foreach (Entry i in jornalentries)
                {
                    Console.WriteLine($"{i._date} - {i._promptText}\n{i._entryText}");
                }*/

                Journal.LoadFromFile(loadFilename);
                break;
            default:
                Console.WriteLine("Invalid option. Please try again.");
                break;
            }
        }
    
        //theJournal.AddEntry(new Entry());
        /* 
        Entry anEntry = new Entry();
        
        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();
        anEntry._date = dateText;
        anEntry._promptText = "What are you grateful for today?";
        anEntry._entryText = "I am grateful for my family.";
        theJournal.AddEntry(anEntry);
        theJournal.DisplayAll();
        anEntry.Display();*/
        //theJournal.SaveToFile("journal.txt");

    }
}