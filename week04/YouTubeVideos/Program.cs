using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video onlineEnrollmentVideo = new Video("How to enroll at BYU Pathway Online Program?", 500);
        onlineEnrollmentVideo.AddComment(new Comment("Micheal Gborluo", "Great tutorial, very helpful!"));
        onlineEnrollmentVideo.AddComment(new Comment("Samuel G. Nah", "Thanks! I finally understand classes in C# programming Language."));
        onlineEnrollmentVideo.AddComment(new Comment("Matthew P. Kollie", "Thanks for sharing."));
        onlineEnrollmentVideo.AddComment(new Comment("Precious D. Korvah", "I Will enroll soon. Thanks for sharing."));
        onlineEnrollmentVideo.AddComment(new Comment("Yassah Zubah", "Thank you Moses for sharing this interesting lessons."));
        videos.Add(onlineEnrollmentVideo);
        
        Video csharpTrainingVideo = new Video("C# Tutorial for Beginners 2025", 600);
        csharpTrainingVideo.AddComment(new Comment("Marduo Zarwu", "Great tutorial, very helpful!"));
        csharpTrainingVideo.AddComment(new Comment("Junior Gbor", "Thanks! I finally understand classes in C# programming Language."));
        csharpTrainingVideo.AddComment(new Comment("Matthew D. Browne", "Thanks for sharing."));
        csharpTrainingVideo.AddComment(new Comment("Dacious R. Moore", "I Will enroll soon. Thanks for sharing."));
        csharpTrainingVideo.AddComment(new Comment("Flourish P. Seah", "Thank you Moses for sharing this interesting lessons."));
        videos.Add(csharpTrainingVideo);

        Video generalTrainingVideo = new Video("How to use Github technology?", 800);
        generalTrainingVideo.AddComment(new Comment("Justine Yakpazuo", "Great tutorial, very helpful!"));
        generalTrainingVideo.AddComment(new Comment("Daniel Gban", "Thanks! I finally understand classes in C# programming Language."));
        generalTrainingVideo.AddComment(new Comment("Erasmus Zorkpa", "Thanks for sharing."));
        generalTrainingVideo.AddComment(new Comment("Marcus Moore", "I Will enroll soon. Thanks for sharing."));
        generalTrainingVideo.AddComment(new Comment("Tina Dahn", "Thank you Moses for sharing this interesting lessons."));
        videos.Add(generalTrainingVideo);

        Video dailyTechVideo = new Video("Basic Computer Tips and Tricks.", 900);
        dailyTechVideo.AddComment(new Comment("Justine Yakpazuo", "Great tutorial, very helpful!"));
        dailyTechVideo.AddComment(new Comment("Daniel Gban", "Thanks! I finally understand classes in C# programming Language."));
        dailyTechVideo.AddComment(new Comment("Erasmus Zorkpa", "Thanks for sharing."));
        dailyTechVideo.AddComment(new Comment("Marcus Moore", "I Will enroll soon. Thanks for sharing."));
        dailyTechVideo.AddComment(new Comment("Tina Dahn", "Thank you Moses for sharing this interesting lessons."));
        videos.Add(dailyTechVideo);
                                            
        foreach (var video in videos)
        {
            video.Display();
        }
    }
}
