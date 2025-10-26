using System;

class Program
{
    static void Main(string[] args)
    {
        string userInput = "";



            Scripture scripture = new Scripture();
            scripture.Setter("O be wise; what can I say more?");
            Reference reference = new Reference("Jacob", "6", "12");
            Word word = new Word();
        while  (userInput != "quit"){


            //Console.WriteLine("Hello Develop03 World!");

            reference.Display();
            scripture.Display();

            userInput = Console.ReadLine();
            Console.Clear();

            word.HideWord(2, scripture.Getter());
            scripture.Setter(word.Getter());
            userInput = scripture.hiddenChecker();
            
            

        }
    }
}