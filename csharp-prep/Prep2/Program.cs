using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Prep2 World!");

        Console.Write("What is your grade percentage? ");
        string percentage = Console.ReadLine();
        int number = int.Parse(percentage);
        int lastNumber = number % 10;
        string letter;
        string sign = "";

        if (number >= 90)
        {
            letter = "A";
        }
        else if (number >= 80)
        {
            letter = "B";
        }
        else if (number >= 70)
        {
            letter = "C";
        }
        else if (number >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }
        if (lastNumber >= 7)
        {
            sign = "+";
        }

        else if (lastNumber < 3)
        {
            sign = "-";
        }

        else
        {
            sign = "";
        }

        if (lastNumber >= 7 && letter == "A")
        {
            sign = "";
        }

        if (letter == "F")
        {
            sign = "";
        }

        Console.WriteLine($"Your grade was a {sign}{letter}");
        if (number >= 70)
        {
            Console.Write("Congrats you passed");
        }
        else
        {
            Console.Write("You'll get it next time");
        }
    }
}