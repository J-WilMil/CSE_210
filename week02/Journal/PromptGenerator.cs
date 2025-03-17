using System;
using System.Collections.Generic;

public class PromptGenerator
{
    private List<string> _prompts;
    private Random _random;

    public PromptGenerator()
    {
        _prompts = new List<string>
        {
            "What is one thing I did today that I am proud of?",
            "What challenge did I face today, and how did I handle it well?",
            "What is one kind thing someone did for me today?",
            "Who in my life am I especially grateful for right now, and why?",
            "What is something fun or enjoyable I did today?",
            "What is one way I can make tomorrow even better than today?",
            "What is a lesson I learned today that will help me in the future?",
            "What is a goal I can set for myself tomorrow that will make me feel accomplished?",
            "What am I looking forward to tomorrow?"
        };
        _random = new Random();
    }

    public string GetRandomPrompt()
    {
        int index = _random.Next(_prompts.Count);
        return _prompts[index];
    }
}
