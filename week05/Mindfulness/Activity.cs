public class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    public string GetName()
    {return _name;}
    public void SetName(string name)
    {_name = name;}
    public string GetDescription()
    {return _description;}
    public void SetDescription(string description)
    {_description = description;}
    public int GetDuration()
    {return _duration;}
    public void SetDuration(int duration)
    {_duration = duration;}
}