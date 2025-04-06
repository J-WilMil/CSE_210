using System;

class Program
{
    static void Main(string[] args)
    {
        string choice = "";
        while (choice != "4")
        {
            Console.Clear();
            Console.WriteLine("Mindfulness Program");
            Console.WriteLine("1. Start Breathing Activity");
            Console.WriteLine("2. Start Reflecting Activity");
            Console.WriteLine("3. Start Listing Activity");
            Console.WriteLine("4. Quit");
            Console.Write("Select an option: ");
            choice = Console.ReadLine();

            if (choice == "1")
            {
                Breathing b = new Breathing();
                b.Run();
            }
            else if (choice == "2")
            {
                Reflecting r = new Reflecting();
                r.Run();
            }
            else if (choice == "3")
            {
                Listing l = new Listing();
                l.Run();
            }
            else if (choice == "4")
            {
                Console.WriteLine("Goodbye! Stay mindful.");
            }
            else
            {
                Console.WriteLine("Invalid choice. Press Enter to try again.");
                Console.ReadLine();
            }
        }
    }
}
