using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        int numberToAdd;
        do{
            Console.Write("Number to add: ");
            numberToAdd = Convert.ToInt32(Console.ReadLine());
            numbers.Add(numberToAdd);
        }
        while (numberToAdd != 0);
        
        Console.Write("Numbers in list: ");
        foreach (int num in numbers)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();

        int total = 0;
        foreach (int item in numbers)
        {
            total += item;
        }
        Console.WriteLine($"Total of all numbers in list is {total}");
    }
}