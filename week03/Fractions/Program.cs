using System;

class Program
{
    static void Main(string[] args)
    {
        Fractions f1 = new Fractions();
        Fractions f2 = new Fractions(6);
        Fractions f3 = new Fractions(6, 7);

        Console.WriteLine(f1);
        Console.WriteLine(f2);
        Console.WriteLine(f3);

        Fractions f4 = new Fractions();
        Fractions f5 = new Fractions(3, 4);
        f4.GetFractionString();
        f5.GetDecimalValue();
        Console.WriteLine(f4.GetFractionString());
        Console.WriteLine(f5.GetDecimalValue());
        //f4.SetNumerator(3);
        //f4.SetDenominator(4);



        
        
    }
}