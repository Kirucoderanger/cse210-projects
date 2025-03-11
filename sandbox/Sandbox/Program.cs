using System;
/*
// Week 1: Added more complex conditional statements, loops, and a class with attributes, constructor, and methods.
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
        }*/


/* string color;
string firstName;
string lastName;
int velocityBeforeImpactWasMade;*/

/*
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





List<int> numbers = new List<int>();
List<string> words = new List<string>();


words.Add("phone");
words.Add("keyboard");
words.Add("mouse");

Console.WriteLine(words.Count);


foreach (string word in words)
{
    Console.WriteLine(word);
}


for (int i = 0; i < words.Count; i++)
{
    Console.WriteLine(words[i]);
}



    }
}

*/
// Week 2: Added a new class with additional attributes, methods, and inheritance.
// creating a class
// top-level statements must come before any namespace or type declarations. or class declaretion must be in separet file.
        
    
    
        Console.WriteLine("Hello, World!");
        Person person  = new Person();
        person._givenName = "Joseph";
        person._familyName = "Smith";
        person.ShowWesternName();
        person.ShowEasternName();
        
// more than 1 instance can be created on the same class symultinously
 
       Person person1 = new Person();
        person1._givenName = "Emma";
        person1._familyName = "Smith";
        person1.ShowWesternName();

        Person person2 = new Person();
        person2._givenName = "Joseph";
        person2._familyName = "Smith";
        person2.ShowWesternName();
 
// Custom Data Types

        Blind kitchen = new Blind();
        kitchen._width = 60;
        kitchen._height = 48;
        kitchen._color = "white";
        // the value can be acessed directly from consol
        Console.WriteLine(kitchen._width);
        double materialAmount = kitchen.GetArea();
        Console.WriteLine(materialAmount);
        Console.WriteLine(kitchen.GetArea());


//nested class
House kirubel = new House();
kirubel._kitchen = new Blind();
kirubel._kitchen._width = 80;
kirubel._kitchen._height = 33;
kirubel._kitchen._color = "blue";
kirubel._livingRoom = new Blind();
kirubel._livingRoom._width = 100;
kirubel._livingRoom._height = 56;
kirubel._livingRoom._color ="Violet";
kirubel._owner = "Kirubel Family";
double materialAmountKitchen = kirubel._kitchen.GetArea();
Console.WriteLine(materialAmountKitchen);
Console.WriteLine(kirubel._kitchen.GetArea());
double materialAmountLivingRoom = kirubel._livingRoom.GetArea();
Console.WriteLine(materialAmountLivingRoom);
Console.WriteLine(kirubel._livingRoom.GetArea());




// nested class list manuplation
HouseList kirubelList = new HouseList();
kirubelList._blinds.Add(kitchen);
kirubelList._blinds.Add(kirubel._livingRoom);
Console.WriteLine(kirubelList._blinds[0].GetArea());
Console.WriteLine(kirubelList._blinds[1].GetArea());
double amountKitchen = kirubelList._blinds[0].GetArea();
Console.WriteLine(amountKitchen);
double amountLivingRoom = kirubelList._blinds[0].GetArea();
Console.WriteLine(amountLivingRoom);


foreach (Blind b in kirubelList._blinds)
{
    double amount = b.GetArea();
    Console.WriteLine(amount);
}



