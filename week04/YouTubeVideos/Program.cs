using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        // Video 1
        Video video1 = new Video("Morning Desk Setup & Coffee Routine", "TechWithKingsley", 540);
        video1.AddComment(new Comment("John Carter", "That mug warmer is a lifesaver during winter mornings."));
        video1.AddComment(new Comment("Sofia Mmadu", "Cleanest cable management I have seen all week."));
        video1.AddComment(new Comment("Noah Kim", "What monitor arm are you using in this clip?"));
        video1.AddComment(new Comment("Hannah Brooks", "Super relaxing pace, watched the whole thing."));
        videos.Add(video1);

        // Video 2
        Video video2 = new Video("Testing 5 Budget Running Shoes on a 10K", "PaceAndPace", 785);
        video2.AddComment(new Comment("Jideon Peter", "Appreciate the honest review after putting real miles on them."));
        video2.AddComment(new Comment("Obi Clifford", "Can these truly give comfort to wider feet?"));
        video2.AddComment(new Comment("Oliver Grant", "Solid value for daily easy runs."));
        video2.AddComment(new Comment("William Smith", "Very comfortable even on rough paths; love it!."));
        videos.Add(video2);

        // Video 3
        Video video3 = new Video("One-Pan Garlic Butter Pasta in 15 Minutes", "QuickMeal", 410);
        video3.AddComment(new Comment("Rufai Demian", "Made this tonight and added spinach—so good!"));
        video3.AddComment(new Comment("Caleb Foster", "Fast weeknight meal with barely any dishes."));
        video3.AddComment(new Comment("Joy Walter", "Simple ingredients and great timing."));
        video3.AddComment(new Comment("Ahmed Ahmed", "Saving this for busy work nights."));
        videos.Add(video3);

        // Video 4
        Video video4 = new Video("Packing Light for a 5-Day City Trip", "ExplorerLife", 125);
        video4.AddComment(new Comment("Grace Lee", "Packing cubes completely changed how I pack; I am grateful!."));
        video4.AddComment(new Comment("Juliet John", "Great breakdown of what you actually wear vs. overpack."));
        video4.AddComment(new Comment("Adam Love", "Love seeing a real backpack test rather than all-talks and studio shots."));
        videos.Add(video4);

        // Display each video and its comments
        foreach (Video video in videos)
        {
            video.DisplayDetails();
        }
    }
}