using System;
using System.Collections.Generic;
using System.Threading;

public class Listing : Activity
{
    private List<string> _prompts = new()
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "What are your favorite hobbies?"
    };

    public Listing()
    {
        SetName("Listing");
        SetDescription("This activity helps you reflect on the good things in your life by listing items in a specific area.");
    }

    public void Run()
    {
        DisplayStartingMessage();
        Random rand = new Random();
        string prompt = _prompts[rand.Next(_prompts.Count)];

        Console.WriteLine();
        Console.WriteLine($"--- {prompt} ---");
        Console.WriteLine("You may begin listing items. Press Enter after each. Time starts now!");

        ShowCountdown(3);
        int count = 0;
        int duration = GetDuration();
        DateTime endTime = DateTime.Now.AddSeconds(duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            if (!string.IsNullOrEmpty(Console.ReadLine()))
            {
                count++;
            }
        }

        Console.WriteLine($"You listed {count} items!");
        DisplayEndingMessage();
    }
}
