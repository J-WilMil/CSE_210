using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;

    public void AddGoal(Goal goal) => _goals.Add(goal);

    public void RecordEvent(int index)
    {
        int earned = _goals[index].RecordEvent();
        _score += earned;
        Console.WriteLine($"You earned {earned} points! Total: {_score}");
    }

    public void ShowGoals()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetStatus()}");
        }
    }

    public void ShowScore() => Console.WriteLine($"Score: {_score}");

    public void Save(string filename)
    {
        using (StreamWriter sw = new StreamWriter(filename))
        {
            sw.WriteLine(_score);
            foreach (Goal g in _goals)
                sw.WriteLine(g.GetStringRepresentation());
        }
    }

    public void Load(string filename)
    {
        _goals.Clear();
        var lines = File.ReadAllLines(filename);
        _score = int.Parse(lines[0]);

        foreach (var line in lines[1..])
        {
            var parts = line.Split(':');
            var type = parts[0];
            var data = parts[1].Split(',');

            switch (type)
            {
                case "SimpleGoal":
                    _goals.Add(new SimpleGoal(data[0], data[1], int.Parse(data[2]), bool.Parse(data[3])));
                    break;
                case "EternalGoal":
                    _goals.Add(new EternalGoal(data[0], data[1], int.Parse(data[2])));
                    break;
                case "ChecklistGoal":
                    _goals.Add(new ChecklistGoal(data[0], data[1], int.Parse(data[2]), int.Parse(data[4]), int.Parse(data[3]), int.Parse(data[5])));
                    break;
            }
        }
    }
}
