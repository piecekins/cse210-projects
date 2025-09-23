using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Security.Principal;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Prep4 World!");
        int number = -1;
        List<int> numbers = new List<int>();
        float total = 0;
        float smallest = 0;

        int largest = 0;

        Console.WriteLine("Enter a list of numbers, type 0 when finished");
        while (number != 0)
        {
            Console.Write("Enter number: ");
            number = int.Parse(Console.ReadLine());
            numbers.Add(number);
        }
        foreach (int item in numbers)
        {
            total += item;

            if (largest < item)
            {
                largest = item;
            }
            smallest = largest;
        }

        foreach (int item in numbers)
        {
            if (smallest > item && item > 0)
            {
                smallest = item;
            }
        }

        double average = total / (numbers.Count - 1);
        //double average = 5.5 * 55;

        Console.WriteLine($"Sum: {total}");
        Console.WriteLine($"The Average: {average}");
        Console.WriteLine($"largest: {largest}");
        Console.WriteLine($"smallest positive number: {smallest}");
        
    }
}