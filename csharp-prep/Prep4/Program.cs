using System;
using System.Numerics;
using System.Security.Principal;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Prep4 World!");
        int number = -1;
        List<int> numbers = new List<int>();
        int total = 0;
        int average = 0;
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

        }
        average = total / (numbers.Count - 1);

        Console.WriteLine($"Sum: {total}");
        Console.WriteLine($"The Average: {average}");
        Console.WriteLine($"largest: {largest}");
    }
}