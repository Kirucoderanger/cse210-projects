using System;

class Program
{
    static void Main(string[] args)
    {
        Fractions f1 = new Fractions();
        Fractions f2 = new Fractions(6);
        Fractions f3 = new Fractions(6, 7);

        Console.WriteLine(f1.GetFractionString());
        Console.WriteLine(f1.GetDecimalValue());
        Console.WriteLine(f2.GetFractionString());
        Console.WriteLine(f2.GetDecimalValue());
        Console.WriteLine(f3.GetFractionString());
        Console.WriteLine(f3.GetDecimalValue());

        Fractions f4 = new Fractions();
        Fractions f5 = new Fractions(3, 4);
        f4.GetFractionString();
        f5.GetDecimalValue();
         Console.WriteLine(f4.GetFractionString());
        Console.WriteLine(f4.GetDecimalValue());
        Console.WriteLine(f5.GetFractionString());
        Console.WriteLine(f5.GetDecimalValue());
        Fractions f6 = new Fractions();
        //f6.SetNumerator(3);
        //f4.SetNumerator(3);
        //f4.SetDenominator(4);



        
        
    }
}