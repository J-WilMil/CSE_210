using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your first name? ");
        string first = Console.ReadLine();
        Console.Write("What is your surname name? ");
        string surname = Console.ReadLine();

        Console.WriteLine($"Your name is {surname}, {first} {surname}.");
        
    }
}