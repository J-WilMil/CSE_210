using System;

class Program
{
    static void Main()
    {
        List<Video> videos = new List<Video>();

        var video1 = new Video("Tech Review", "Gadget Guru", 420);
        video1.AddComment("blademaster", "Great review! Very detailed.");
        video1.AddComment("pokemanic", "I love this gadget!");
        video1.AddComment("vergantexv", "Looking forward to more videos.");

        var video2 = new Video("Cooking Tips", "Chef Tony", 300);
        video2.AddComment("zulfikarel", "Tried this recipe, and it was amazing!");
        video2.AddComment("xankreigor", "Can you make a vegan version?");
        video2.AddComment("avigorus", "Loved the presentation!");

        var video3 = new Video("Fitness Routine", "Gym Hero", 180);
        video3.AddComment("garen", "Challenging but effective!");
        video3.AddComment("sweetguy", "I did this for a week, and it works!");
        video3.AddComment("jeff", "Perfect for beginners!");

        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        foreach (var video in videos)
        {
            video.Display();
        }
    }
}