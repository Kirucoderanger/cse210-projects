using System;

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
    
        //theJournal.AddEntry(new Entry());
        Entry anEntry = new Entry();
        anEntry._date = "2021-09-01";
        anEntry._promptText = "What are you grateful for today?";
        anEntry._entryText = "I am grateful for my family.";
        theJournal.AddEntry(anEntry);
        theJournal.DisplayAll();
        anEntry.Display();
        //theJournal.SaveToFile("journal.txt");

    }
}