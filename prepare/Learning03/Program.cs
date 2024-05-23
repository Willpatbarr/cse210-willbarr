using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction fraction1 = new Fraction();
        Console.WriteLine(fraction1.GetFractionString());

        Fraction fraction2 = new Fraction(5);
        Console.WriteLine(fraction2.GetFractionString());

        Fraction fraction3 = new Fraction(6, 2);
        Console.WriteLine(fraction3.GetFractionString());
    }
}