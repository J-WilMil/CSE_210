using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        
        string username = PromptUserName();
        int favouritenumber = PromptUserNumber();
        int sqdnumber = SquareNumber(favouritenumber);
        
        DisplayResult(username, sqdnumber);
    }
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }
    
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        return Console.ReadLine();
    }
    
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        return int.Parse(Console.ReadLine());
    }
    
    static int SquareNumber(int number)
    {
        return number * number;
    }
    
    static void DisplayResult(string name, int sqdnumber)
    {
        Console.WriteLine($"{name}, the square of your number is {sqdnumber}");
    }
    
}