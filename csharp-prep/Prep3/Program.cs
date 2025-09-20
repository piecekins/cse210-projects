using System;
using System.Data;
using System.Formats.Asn1;

class Program
{
    static void Main(string[] args)
    {
        bool guessed = false;
        int trys = 0;
        //Console.WriteLine("Hello Prep3 World!");

        //Console.Write("What is the magic number? ");
        //int magicNumber = int.Parse(Console.ReadLine());

        Random randomGenerator = new Random();
        // After looking at the Sample Solution I changed this line of code from (1, 100) to (1, 101) as I didn't relize it had to be 101 to have it 1 through 100 its the same thing with line 49 as well. 
        int magicNumber = randomGenerator.Next(1, 101);

        while (guessed == false)
        {
            trys += 1;
            Console.Write("What is your guess? ");
            int guess = int.Parse(Console.ReadLine());

            if (guess < magicNumber)
            {
                Console.WriteLine("Higher");
            }

            else if (guess > magicNumber)
            {
                Console.WriteLine("Lower");
            }

            else
            {
                Console.WriteLine("You Guessed it!!!");
                Console.WriteLine($"You took {trys} guesses to win!");

                Console.WriteLine("Do you want to play again?");
                string answer = Console.ReadLine();

                if (answer == "yes" || answer == "Yes")
                {
                    guessed = false;
                    trys = 0;
                    randomGenerator = new Random();
                    magicNumber = randomGenerator.Next(1, 101);
                }
                else
                {
                    guessed = true;
                }
            }


        }
    }
}