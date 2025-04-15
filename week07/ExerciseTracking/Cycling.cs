using System;

public class Cycling : Activity
{
    private double speed;

    public Cycling(DateTime activityDate, int duration, double speed)
        : base(activityDate, duration)
    {
        this.speed = speed;
    }

    public override string GetDistance()
    {
        return $"{(speed * duration) / 60:F1} miles";
    }

    public override string GetSpeed()
    {
        return $"{speed} mph";
    }

    public override string GetPace()
    {
        return $"{60 / speed:F1} min per mile";
    }
}
