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
            if (number == 0)
            {
                break;
            }
            else
            {
            
            numbers.Add(number);

            sum += number;
            }
        }
        int count = numbers.Count;
        
        Console.WriteLine($"You entered {count} numbers.");
        Console.WriteLine($"The sum of the numbers is {sum}.");
        Console.WriteLine($"The average of the numbers is {sum / count}.");
        Console.WriteLine($"The largest number is {numbers.Max()}.");
        Console.WriteLine($"The smallest number is {numbers.Min()}.");
        Console.WriteLine("the sorted numbers in Ascending order are: ");
        numbers.Sort();
        //numbers.Reverse();
        foreach (double num in numbers)
        {
            Console.WriteLine(num);
        }
        Console.WriteLine("the positive number closest to zero is: ");
        double closestToZero = numbers[0];
        foreach (double num in numbers)
        {
            if (num > 0 && num < closestToZero)
            {
                closestToZero = num;
            }
        }
        Console.WriteLine(closestToZero);


    }
}