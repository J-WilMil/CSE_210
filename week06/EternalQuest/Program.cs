using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager gm = new GoalManager();
        bool running = true;

        while (running)
        {
            Console.WriteLine("\n-- Eternal Quest --");
            Console.WriteLine("1. Create Goal\n2. List Goals\n3. Record Event\n4. Show Score\n5. Save\n6. Load\n0. Exit");
            Console.Write("Choose: ");
            string input = Console.ReadLine();

            if (input == "1")
            {
                CreateGoal(gm);
            }
            else if (input == "2")
            {
                gm.ShowGoals();
            }
            else if (input == "3")
            {
                gm.ShowGoals();
                Console.Write("Which goal? ");
                int i = int.Parse(Console.ReadLine()) - 1;
                gm.RecordEvent(i);
            }
            else if (input == "4")
            {
                gm.ShowScore();
            }
            else if (input == "5")
            {
                gm.Save("goals.txt");
            }
            else if (input == "6")
            {
                gm.Load("goals.txt");
            }
            else if (input == "0")
            {
                running = false;
            }

        }
    }

    static void CreateGoal(GoalManager gm)
    {
        Console.Write("Name: ");
        string name = Console.ReadLine();
        Console.Write("Description: ");
        string desc = Console.ReadLine();
        Console.Write("Points: ");
        int points = int.Parse(Console.ReadLine());

        Console.WriteLine("1=Simple, 2=Eternal, 3=Checklist");
        string choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                gm.AddGoal(new SimpleGoal(name, desc, points));
                break;
            case "2":
                gm.AddGoal(new EternalGoal(name, desc, points));
                break;
            case "3":
                Console.Write("Target Count: ");
                int target = int.Parse(Console.ReadLine());
                Console.Write("Bonus Points: ");
                int bonus = int.Parse(Console.ReadLine());
                gm.AddGoal(new ChecklistGoal(name, desc, points, target, bonus));
                break;
        }
    }
}