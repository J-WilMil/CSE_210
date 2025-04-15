using System;

public class Running : Activity
{
    private double distance;

    public Running(DateTime activityDate, int duration, double distance)
        : base(activityDate, duration)
    {
        this.distance = distance;
    }

    public override string GetDistance()
    {
        return $"{distance} miles";
    }

    public override string GetSpeed()
    {
        return $"{(distance / duration) * 60:F1} mph";
    }

    public override string GetPace()
    {
        return $"{duration / distance:F1} min per mile";
    }
}
