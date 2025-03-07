using System;
using System.Diagnostics.Contracts;

class Program
{
    static void Main(string[] args)
    {
        bool gameon = true;

        while (gameon)
        {
            Random randomGenerator = new Random();
            int number = randomGenerator.Next(1, 100);

            Console.WriteLine("Are you able to guess my magic number?");
            Console.Write("Please enter a guess: ");
            string guess = Console.ReadLine();
            int guessnumber = int.Parse(guess);

            int countguess = 1;

            while (guessnumber != number)
            {
                if (guessnumber > number)
                {
                    Console.WriteLine("My number is LOWER.");
                    countguess += 1;
                }

                else if (guessnumber < number)
                {
                    Console.WriteLine("My number is HIGHER.");
                    countguess += 1;
                }

                Console.Write("Please enter a guess: ");
                guess = Console.ReadLine();
                guessnumber = int.Parse(guess);
            }

            if (guessnumber == number)
            {
                Console.WriteLine("WELL DONE, YOU GUESSED CORRECT!");
                Console.WriteLine($"You guessed // {countguess} // amount of times.");
            }

            Console.Write("Do you wish to keep playing? yes or no? ");
            string play = Console.ReadLine();

            if (play == "no")
            {gameon = false;}
        }
    }
}