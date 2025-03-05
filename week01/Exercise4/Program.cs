using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers one after another when you finish enter 0.");
        List<double> numbers = new List<double>();
        int sum = 0;
        int number = 1;
        while (number != 0)
        {
            Console.WriteLine("Enter a number: ");
            number = int.Parse(Console.ReadLine());
            numbers.Add(number);

            sum += number;
        }
        int count = numbers.Count - 1;
        foreach (double num in numbers)
        {
            Console.WriteLine(num);
        }
        Console.WriteLine($"You entered {count} numbers.");
        Console.WriteLine($"The sum of the numbers is {sum}.");
        Console.WriteLine($"The average of the numbers is {sum / count}.");

    }
}