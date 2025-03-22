using System;
using System.Security.Cryptography.X509Certificates;
using System.Collections.Generic;
using Word;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");
        Console.Write("Select scripture you want to memorize with one verse or two verse");

        Scripture scripture = new Scripture();
        //Scripture scripture1 = new Scripture();
        
        
            DisplayScripture(scripture);
        
            static void DisplayScripture(Scripture scripture)

        {
            
            // Add your scripture display logic here
            Console.WriteLine(scripture.PrintMessage());

        }

        while (true)
        {
                    Scripture scripture1 = new Scripture();

            DisplayHidenScripture(scripture1);
            static void DisplayHidenScripture(Scripture scripture1)
            {
                Console.Write(scripture1.DisplayHiden());
            }

            

        
                string choice = Console.ReadLine();
                /*string virseAmount = Console.ReadLine();
                string wordx = WordGenerator.GetRandomWord().Item1;
                int indexx = WordGenerator.GetRandomWord().Item2;
                Console.Write(wordx);*/
                if (choice.ToLower() == "quit")
                    {
                        break;
                        
                    }
            
               

        }

        
    }
}
