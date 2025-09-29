using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");

        Video video1 = new Video("C# Tutorial", "John Doe", 600);
        video1.AddComment(new Comment("Alice", "Great tutorial!"));
        video1.AddComment(new Comment("Bob", "Very helpful, thanks!"));
        video1.AddComment(new Comment("Charlie", "I learned a lot."));

        video1.DisplayVideoInfo();
        video1.DisplayAllComment();

        Video video2 = new Video("C# Advanced", "Rudna Sou", 800);
        video2.AddComment(new Comment("Alice", "Amazing content!"));
        video2.AddComment(new Comment("Bob", "Very informative."));
        video2.AddComment(new Comment("Charlie", "I learned a lot."));

        video2.DisplayVideoInfo();
        video2.DisplayAllComment();

        List<Video> video = new List<Video> { video1, video2 };

        foreach (Video v in video)
        {
            v.DisplayVideoInfo();
            v.DisplayAllComment();
            Console.WriteLine();
        }
    }
}