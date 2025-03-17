using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Journal Project.");

        Journal theJournal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        bool gameon = true;
        while (gameon)
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Write.");
            Console.WriteLine("2. Display.");
            Console.WriteLine("3. Save.");
            Console.WriteLine("4. Load.");
            Console.WriteLine("5. Exit.");
            Console.Write("Your choice: ");
            string choice = Console.ReadLine().ToLower();

            switch (choice)
            {
                case "1" or "write":
                    string prompt = promptGenerator.GetRandomPrompt();
                    Console.WriteLine($"Prompt: {prompt}");
                    Console.Write("Your response: ");
                    string response = Console.ReadLine();
                    
                    Entry newEntry = new Entry(prompt, response);
                    theJournal.AddEntry(newEntry);
                    Console.WriteLine("Entry added successfully!");
                    break;

                case "2" or "display":
                    theJournal.DisplayAll();
                    break;

                case "3" or "save":
                    Console.Write("Enter filename to save to: ");
                    string saveFile = Console.ReadLine();
                    theJournal.SaveToFile(saveFile);
                    Console.WriteLine("Journal saved!");
                    break;

                case "4" or "load":
                    Console.Write("Enter filename to load from: ");
                    string loadFile = Console.ReadLine();
                    theJournal.LoadFromFile(loadFile);
                    Console.WriteLine("Journal loaded!");
                    break;

                case "5" or "exit":
                    gameon = false;
                    break;

                default:
                    Console.WriteLine("Invalid choice. Try again.");
                    break;
            }
        }
    }
}