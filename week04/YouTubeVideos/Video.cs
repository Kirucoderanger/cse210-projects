using System.Runtime.InteropServices;

public class Video
{
    public static List<List<string>> videos = new List<List<string>>();

    static Video()
    {
        // Creating inner lists
        videos.Add(new List<string> { "video1", "Understanding C#", "John Doe", "600"});
        videos.Add(new List<string> { "video2", "Introduction to LINQ", "Jane Smith", "450"});
        videos.Add(new List<string> { "video3", "Mastering ASP.NET Core", "Alice Johnson", "1200"});
    }
    
    public static string DisplayVideoDetail(List<List<string>> comments)
    {

        string videoDetails = "";
        foreach (var video in videos)
        {
            int i = 0;
            int j = 0;
            int numComments = 0;
            var comment = "";

            for (i = 0; i < comments.Count; i++)
            {
                for (j = 0; j < comments[i].Count; j++)
                {
                    if (comments[i][0] == video[0])
                    {
                    comment += comments[i][j] + " ";
                    numComments += 1;
                    }
                }
            }
            int numComent = numComments / 3;

            videoDetails += $"ID: {video[0]}, Title: {video[1]}, Author: {video[2]}, Length: {video[3]} seconds\n {numComent} Comments \n {comment} \n";
        }
        return videoDetails.Trim();
           
    }
    
}


/*namespace YouTubeVideos
{
    public class Comment
    {
        public string Author { get; set; }
        public string Text { get; set; }

        public Comment(string author, string text)
        {
            Author = author;
            Text = text;
        }
    }

    public class Video
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int Length { get; set; } // Length in seconds
        public List<Comment> Comments { get; set; }

        public Video(string title, string author, int length)
        {
            Title = title;
            Author = author;
            Length = length;
            Comments = new List<Comment>();
        }

        public void AddComment(Comment comment)
        {
            Comments.Add(comment);
        }
    }

    
    public class VideoManager
    {
        public static List<Video> GetVideos()
        {
            return new List<Video>
            {
                new Video("Understanding C#", "John Doe", 600),
                new Video("Introduction to LINQ", "Jane Smith", 450),
                new Video("Mastering ASP.NET Core", "Alice Johnson", 1200)
            };
        }
    }



    public class WordGenerator
    {
        private static List<Video> video = new List<Video>
        {
            new Video("Understanding C#", "John Doe", 600),
            new Video("Introduction to LINQ", "Jane Smith", 450),
            new Video("Mastering ASP.NET Core", "Alice Johnson", 1200)
        };
    }

}*/

