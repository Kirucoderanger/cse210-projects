using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Sandbox Project.");

        int x;
        int y = 10;
        int z = 20;
        x = 5;
        Console.WriteLine(x);
        Console.Write("There will not be a newline after this.");
        
        if (x > y)
            {
                Console.WriteLine("greater");
            }
        else
            {
                Console.WriteLine("less");
            }
        string school = "BYU-Idaho";
        Console.WriteLine($"I am studying at {school}."); // Output: I am studying at BYU-Idaho.


        
        if (x > y)
        {
            if (x > z)
            {
                Console.WriteLine("greater than both");
            }
        }

        
        if (x > y)
        {
            Console.WriteLine("greater than");
        }
        else
        {
            Console.WriteLine("less than");
        }

        
        if (x > y)
        {
            Console.WriteLine("greater than y");
        }
        else if (x > z)
        {
            Console.WriteLine("greater than z");
        }
        else
        {
            Console.WriteLine("less than both");
        }


        /* string color;
        string firstName;
        string lastName;
        int velocityBeforeImpactWasMade;*/


        string name = "John";
        string favoriteColor = "blue";
        string color = "red";
        string firstName = "Brigham";
        string lastName = "Young";
        int velocityBeforeImpactWasMade = 88;

        if (name == "John")
        {
            Console.WriteLine("The name is John");
        }

        if (color != favoriteColor)
        {
            Console.WriteLine("That color is not my favorite");
        }



        if (name == "Peter" || name == "James" || name == "John")
        {
            Console.WriteLine("This is a biblical name.");
        }

        if (firstName == "Brigham" && lastName == "Young")
        {
            Console.WriteLine("Welcome Brother Brigham!");
        }

        if (!(name == "Peter" || name == "James" || name == "John"))
        {
            Console.WriteLine("This is a not one of those three");
        }

        if (velocityBeforeImpactWasMade > 88)
        {
            Console.WriteLine("The speed was greater than 88 mph");
        }
        else
        {
            Console.WriteLine("The speed was 88 mph or less");
        }




       
        string valueInText = "42";
        int number = int.Parse(valueInText);



        Console.Write("What is your favorite number? ");
        string userInput = Console.ReadLine();
        int number1 = int.Parse(userInput);
        string textVersion = number.ToString();

        
string response = "yes";

while (response == "yes")
{
    Console.Write("Do you want to continue? ");
    response = Console.ReadLine();
}

Console.WriteLine("Goodbye!");



string response1;

do
{
    Console.Write("Do you want to continue? ");
    response1 = Console.ReadLine();
} while (response1 == "yes");

Console.WriteLine("Goodbye!");

for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i);
    {
        Console.WriteLine("Hello World!");
    }
}


for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i);
}



for (int i = 2; i <= 20; i = i + 2)
{
    Console.WriteLine(i);
}


foreach (char letter in "Hello World!")
{
    Console.WriteLine(letter);
}

string[] colors = { "red", "green", "blue" };


foreach (string clr in colors)
{
    Console.WriteLine(color);
}


Random randomGenerator = new Random();
int numberRandom = randomGenerator.Next(1, 11);








    }
}