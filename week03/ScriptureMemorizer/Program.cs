using System;
using System.Collections.Concurrent;

class Program
{
    static void Main(string[] args)
    {
        bool gameon = true;

        while (gameon)
        {
            Console.Clear();
            Console.WriteLine("Welcome to the Scripture Memorization Program!");
            Console.WriteLine("// If you want to copy and paste into prompts, please use CTRL+SHIFT+V. Also, if multiple verses are being pasted, please use option 'paste as one line.' :) //");

            Console.Write("Please enter the name of the book you will like to learn from: ");
            string book = Console.ReadLine();

            Console.Write("Please enter the chapter number you will like to learn from: ");
            string enter = Console.ReadLine();
            int chap = int.Parse(enter);

            Console.Write("Does this scripture contain more then one verse? Y/N: ");
            string multi = Console.ReadLine();

            Reference reference;

            if (multi.ToLower() == "n")
            {
                Console.Write("Please enter the verse number you will like to learn from: ");
                enter = Console.ReadLine();
                int verse = int.Parse(enter);

                reference = new Reference(book, chap, verse);
            }

            else if (multi.ToLower() == "y")
            {
                Console.Write("Please enter the first verse number you will like to learn from: ");
                enter = Console.ReadLine();
                int verse = int.Parse(enter);

                Console.Write("Please enter the last verse number you will like to learn from: ");
                enter = Console.ReadLine();
                int end = int.Parse(enter);

                reference = new Reference(book, chap, verse, end);
            }

            else
            {
                Console.WriteLine("Invalid input. Please enter 'Y' or 'N': ");
                continue; 
            }

            Console.Write("Please enter the verse(s) of the scriptures you will like to learn from: ");
            string text = Console.ReadLine();

            Scripture scripture = new Scripture(reference, text);

            while (!scripture.IsCompletelyHidden())
            {
                Console.Clear();
                Console.WriteLine(scripture.GetDisplayText());
                Console.WriteLine("\nPress Enter to hide more words, type 'undo' to unhide last words, or 'quit' to exit.");

                string input = Console.ReadLine().ToLower();

                if (input == "quit")
                    break;
                else if (input == "undo")
                    scripture.UndoLastHide();
                else
                    scripture.HideRandomWords(2);
            }

            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            
            Console.Write("Would you like to play again? Y/N: ");
            string play = Console.ReadLine();

            if (play.ToLower() == "n")
            {
                gameon = false;
                Console.WriteLine("Thank you for playing.");
            }

        }
    }
}
