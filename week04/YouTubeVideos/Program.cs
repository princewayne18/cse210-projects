using System;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("They Are Their Own Judges ", "David A. Bednar", 855);
        Video video2 = new Video(" Place No More for the Enemy of My Soul", "Elder Jeffrey R.Holland", 971);
        Video video3 = new Video("Of Regrets and Resolutions", "President Dieter F. Uchtdorf", 1168);

        video1.AddComment(new Comment("@zanele", "Powerfull talk!"));
        video1.AddComment(new Comment("@john", "May God be with all who struggle with this difficult issue.."));
        video1.AddComment(new Comment("@michael", "Great word."));

        video2.AddComment(new Comment("@Debra", "I am struggling with anxiety. This helped me a lot. This reminds me that even if I cannot control everything in this life, I can choose to be happy and enjoy my life while enduring."));
        video2.AddComment(new Comment("@Prince", "One day we will look back at our lives and wonder if we could have been better, made better decisions, or used our time more wisely. To avoid some of the deepest regrets of life, it would be wise to make some resolutions today."));
        video2.AddComment(new Comment("@Eric", "No matter our circumstances, no matter our challenges or trials, there is something in each day to embrace and cherish."));

        video3.AddComment(new Comment("@cliff", "I pray we will not wait until we are ready to die until we learn to live. What powerful words!  And ones so neede."));
        video3.AddComment(new Comment("@Karen", "All of these talks have a very special meaning to everyone who listens. The magic of this is that we will all interpret these talks differently in our own special way"));
        video3.AddComment(new Comment("@kelly ", "President Uchdorf,  we love you. Thank you"));

        List<Video> videos = new List<Video>
        {
            video1,
            video2,
            video3
        };

        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length: {video.GetLengthInSeconds()} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");
            Console.WriteLine("Comments:");

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($" - {comment.GetCommenterName()}: {comment.GetCommentText()}");
            }

            Console.WriteLine("---------------------------------------------------------------------------------------------------ssssssssssssssss");
            Console.WriteLine("");
        }
    }
}
