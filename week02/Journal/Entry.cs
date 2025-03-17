using System;

public class Entry
{
    public string Date {get; set; }
    public string PromptText {get; set; }
    public string EntryText {get; set; }

    public Entry(string prompt, string response)
    {
        Date = DateTime.Now.ToString("yyyy-mm-dd");
        PromptText = prompt;
        EntryText = response;
    }

    public void Display()
    {
        Console.WriteLine($"Date: {Date}");
        Console.WriteLine($"Prompt: {PromptText}");
        Console.WriteLine($"Response: {EntryText}");
        Console.WriteLine("------------------------------");
    }
}
