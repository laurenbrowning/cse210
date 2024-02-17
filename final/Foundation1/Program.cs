using System;

class Program
{
    static void Main(string[] args)
    {
         List<Video> videosList = new List<Video>();

        // Video 1
        Video vid1 = new Video("Thumb Follow me - Trailer!", "Thumb Follow Me", 45);

        Comment vid1Comm1 = new Comment("Logan", "Looking forward to sharing this with my kids!");
        Comment vid1Comm2 = new Comment("Covey", "My new favorite animation YouTube channel! Keep it up guys :)");
        Comment vid1Comm3 = new Comment("Nick", "This looks incredible! So excited to share this with my kids!");

        vid1.AddComment(vid1Comm1);
        vid1.AddComment(vid1Comm2);
        vid1.AddComment(vid1Comm3);

        videosList.Add(vid1);

        // vid 2
        Video vid2 = new Video("From Darkness To Hope: Unveiling The Light Of Christmas", "The Church of Jesus Christ of Latter-day Saints", 306);

        Comment vid2Comm1 = new Comment("William", "Someone asked me what was the greatest gift I ever got for Christmas, my answer was Jesus Christ.");
        Comment vid2Comm2 = new Comment("Bill", "You are wonderful, beautiful, and amazing! Thank you for your story. It inspires me to embrace Christ!");
        Comment vid2Comm3 = new Comment("Aliya", "That's a gorgeous mural with a beautiful message");

        vid2.AddComment(vid2Comm1);
        vid2.AddComment(vid2Comm2);
        vid2.AddComment(vid2Comm3);

        videosList.Add(vid2);

        // vid 3
        Video vid3 = new Video("Come Follow Me (February 12-18) 2 Nephi 3-5 THE JOSEPHS", "Line Upon Line", 417);

        Comment vid3Comm1 = new Comment("Rose", "Im literally waiting your videos every saturday. Thank you!");
        Comment vid3Comm2 = new Comment("Cali", "Thank you once again for an amazing video!");
        Comment vid3Comm3 = new Comment("Gladys", "Love this ❤");

        vid3.AddComment(vid3Comm1);
        vid3.AddComment(vid3Comm2);
        vid3.AddComment(vid3Comm3);

        videosList.Add(vid3);

        foreach (Video video in videosList)
        {
            video.DisplayInfo();
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}