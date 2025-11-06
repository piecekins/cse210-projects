using System;

class Program
{

    //Adding more meaningful animations for the breathing (such as text that
    //grows out quickly at first and then slows as they near the end of the breath).
    //And I added the oppiste for when you breath out
    //
    //
    //



    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Develop04 World!");
        string answer = "0";
        while (answer != "4")
        {
            Breathing breathing = new Breathing("Breathing", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
            Reflection reflection = new Reflection("Reflection", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
            Listing listing = new Listing("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");


            Console.WriteLine("Menu Options");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflecting activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Quit");

            Console.Write("Select a choice from the menu: ");
            answer = Console.ReadLine();

            if (answer == "1")
            {
                breathing.Begin();
                breathing.Breath();
                breathing.End();
            }
            else if (answer == "2")
            {
                reflection.Begin();
                reflection.reflecting();
                reflection.End();
            }
            else if (answer == "3")
            {
                listing.Begin();
                listing.ItemListing();
                listing.End();
            }

            

        }
    }
}