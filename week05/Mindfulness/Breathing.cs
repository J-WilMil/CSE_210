using System;
using System.Threading;

public class Breathing : Activity
{
    public Breathing()
    {
        SetName("Breathing");
        SetDescription("This activity will help you relax by guiding you through slow breathing. Clear your mind and focus on your breathing.");
    }

    public void Run()
    {
        DisplayStartingMessage();
        int time = 0;

        while (time < GetDuration())
        {
            Console.WriteLine("Breathe in...");
            ShowCountdown(3);
            time += 3;
            if (time >= GetDuration()) break;

            Console.WriteLine("Now breathe out...");
            ShowCountdown(3);
            time += 3;
        }

        DisplayEndingMessage();
    }
}
