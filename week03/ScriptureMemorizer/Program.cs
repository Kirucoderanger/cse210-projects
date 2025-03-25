using System;
using System.Security.Cryptography.X509Certificates;
using System.Collections.Generic;
using Word;
using Reference;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");
        Console.WriteLine("Select scripture you want to memorize with one verse or two verse");

        Scripture scripture = new Scripture();
        //Scripture scripture1 = new Scripture();
        string refing = scripture.DesplayReferance();
        DisplayScripture(scripture, refing);
        static void DisplayScripture(Scripture scripture, string refing)
        {           
            // Add your scripture display logic here
            //Console.WriteLine($"{refing}: {scripture.PrintMessage()} ");            
        }
        DisplayFullScripture(scripture, refing);
        static void DisplayFullScripture(Scripture scripture, string refing)
        {
            Console.WriteLine(refing);
            Console.Write(scripture.DisplayFull().Item1);
        }

        //Scripture scripture2 = new Scripture();
        
        string choice = Console.ReadLine();
        int limit = scripture.DisplayFull().Item2;
        int counter = 0;

        while ( counter < limit)
        {
            Console.Clear();
            Scripture scripture1 = new Scripture();                
            DisplayHidenScripture(scripture1, refing);
            static void DisplayHidenScripture(Scripture scripture1, string refing)
            {
                Console.WriteLine(refing);                
                Console.Write(scripture1.DisplayHiden());
            }
            string choice1 = Console.ReadLine();

            counter++;

        
                //string choice = Console.ReadLine();
                /*string virseAmount = Console.ReadLine();
                string wordx = WordGenerator.GetRandomWord().Item1;
                int indexx = WordGenerator.GetRandomWord().Item2;
                Console.Write(wordx);*/
                if (choice1.ToLower() == "quit")
                    {
                        break;
                        
                    }
            
               

        }

        
    }
}
