using System;

public class Swimming : Activity
{
    private int laps;

    public Swimming(DateTime activityDate, int duration, int laps)
        : base(activityDate, duration)
    {
        this.laps = laps;
    }

    public override string GetDistance()
    {
        return $"{(laps * 50 / 1000) * 0.62:F1} miles";
    }

    public override string GetSpeed()
    {
        double distance = double.Parse(GetDistance().Split(' ')[0]);
        return $"{(distance / duration) * 60:F1} mph";
    }

    public override string GetPace()
    {
        double distance = double.Parse(GetDistance().Split(' ')[0]);
        return $"{duration / distance:F1} min per mile";
    }
}
