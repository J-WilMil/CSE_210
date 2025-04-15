using System;

public abstract class Activity
{
    protected  DateTime activityDate;
    protected  int duration;

    public Activity(DateTime activityDate, int duration)
    {
        this.activityDate = activityDate;
        this.duration = duration;
    }

    public abstract string GetDistance();
    public abstract string GetSpeed();
    public abstract string GetPace();

    public string GetSummary()
    {
        return $"{activityDate:dd MMM yyyy} {this.GetType().Name} ({duration} min): Distance {GetDistance()}, Speed {GetSpeed()}, Pace: {GetPace()}";
    }
}
