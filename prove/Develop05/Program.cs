using System;
using System.Dynamic;
using System.Formats.Asn1;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {   
        //I added a bonus system where if you complete 3 goals in one session you'll get a bonus
        //and for every 3 goals you do it will be 50 points more, it also counts how many you times you complete goals.
        //Console.WriteLine("Hello Develop05 World!");
        string userInput = "";
        SaveLoad saveLoad = new SaveLoad();
        List<Goal> goals = saveLoad.GoalGetter();
        
        int totalPoints = 0;
        int goalscompleted = 0;
        int goalsneeded = 0;
        
        while (userInput != "6")
        {
            Console.WriteLine($"\nYou have {totalPoints} points.\n");
            Console.WriteLine("Menu Options");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Quit");
            Console.Write("Select a choice from the menu: ");
            userInput = Console.ReadLine();

            if (userInput == "1")
            {
                
                Console.WriteLine("The types of Goals are:");
                Console.WriteLine("  1. Simple Goal");
                Console.WriteLine("  2. Eternal Goal");
                Console.WriteLine("  3. Checklist Goal");
                Console.Write("Which type of goal would you like to create? ");
                userInput = Console.ReadLine();

                Console.Write("What is the name of your goal? ");
                string name = Console.ReadLine();
                Console.Write("What is a short description of it? ");
                string description = Console.ReadLine();
                Console.Write("What is the amount of points associated with this goal? ");
                int points = int.Parse(Console.ReadLine());
                
                if (userInput == "1")
                {
                    Simple simple = new Simple(name, description, points, false);
                    goals.Add(simple);
                }
                else if (userInput == "2")
                {
                    Eternal eternal = new Eternal(name, description, points);
                    goals.Add(eternal);
                }
                else if (userInput == "3")
                {
                    Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                    int timesNeeded = int.Parse(Console.ReadLine());
                    Console.Write("What is the bonus for accomplishing it that many times? ");
                    int bonus = int.Parse(Console.ReadLine());

                    Checklist checklist = new Checklist(name, description, points, false, timesNeeded, 0, bonus);
                    goals.Add(checklist);
                }

            }
        
            else if (userInput == "2")
            {   int i = 1;
                foreach (Goal goal in goals)
                {
                    
                    Console.Write($"{i}.");
                    goal.DisplayGoal();
                    i = i + 1;
                }
            }
            
            else if(userInput == "3")
            {
                saveLoad.PointSetter(totalPoints);
                saveLoad.GoalSetter(goals);
                saveLoad.SaveFile();
            }

            else if(userInput == "4")
            {
                saveLoad.LoadFile();
                goals = saveLoad.GoalGetter();
                totalPoints = saveLoad.PointGetter();
            }

            else if(userInput == "5")
            {
                int i = 1;
                foreach (Goal goal in goals)
                {
                    
                    Console.Write($"{i}.");
                    Console.WriteLine(goal.GetName());
                    i = i + 1;
                }
                Console.Write("Which goal did you accomplish? ");
                totalPoints = goals[int.Parse(Console.ReadLine()) - 1].RecordEvent(totalPoints);
                goalscompleted = goalscompleted + 1;
                 goalsneeded = goalsneeded + 1;
                Console.WriteLine($"Good job, you have completed {goalscompleted} this session, if you do {3 - goalsneeded} more you'll get a bonus!");
                if (goalsneeded == 3)
                {
                    goalsneeded = 0;
                    totalPoints = totalPoints + (50 * (goalscompleted/3));
                    Console.WriteLine($"You got {(50 * (goalscompleted/3))} bonus points!!!");
                    Console.WriteLine($"You have {totalPoints} points.");
                    
                }

            }
           
        }
    }

}