public class Fractions
{
    private int _numerator;
    private int _denominator;

    public Fractions()
    {
        _numerator = 1;
        _denominator = 1;
    }

    public Fractions(int numerator)
    {
        _numerator = numerator;
        _denominator = 1;
    }

    public Fractions(int numerator, int denominator)
    {
        _numerator = numerator;
        _denominator = denominator;
    }

    public override string ToString()
    {
        return $"{_numerator}/{_denominator}";
    }

    public string GetFractionString()
    {
        return $"{_numerator}/{_denominator}";
    }

    public double GetDecimalValue()
    {
        return (double)_numerator / _denominator;
    }

    public void SetDenominator(int denominator)
    {
        _denominator = denominator;
    }

    public void SetNumerator(int numerator)
    {
        _numerator = numerator;
    }
}




    /*
    public int Numerator { get; set; }
    public int Denominator { get; set; }

    public Fraction(int numerator, int denominator)
    {
        Numerator = numerator;
        Denominator = denominator;
    }

    public override string ToString()
    {
        return $"{Numerator}/{Denominator}";
    }

    public static Fraction operator +(Fraction f1, Fraction f2)
    {
        int newNumerator = f1.Numerator * f2.Denominator + f2.Numerator * f1.Denominator;
        int newDenominator = f1.Denominator * f2.Denominator;
        return new Fraction(newNumerator, newDenominator);
    }

    public static Fraction operator -(Fraction f1, Fraction f2)
    {
        int newNumerator = f1.Numerator * f2.Denominator - f2.Numerator * f1.Denominator;
        int newDenominator = f1.Denominator * f2.Denominator;
        return new Fraction(newNumerator, newDenominator);
    }

    public static Fraction operator *(Fraction f1, Fraction f2)
    {
        int newNumerator = f1.Numerator * f2.Numerator;
        int newDenominator = f1.Denominator * f2.Denominator;
        return new Fraction(newNumerator, newDenominator);
    }

    public static Fraction operator /(Fraction f1, Fraction f2)
    {
        int newNumerator = f1.Numerator * f2.Denominator;
        int newDenominator = f1.Denominator * f2.Numerator;
        return new Fraction(newNumerator, newDenominator);
    }
}*/