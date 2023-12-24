using GraphQL_Sample.Type;

namespace GraphQL_Sample.Repository;

public class VideoQuery
{
    private static List<Video> videos = new List<Video>
        {
            new Video { Id = 1, Title = "Video 1", Quality = "1080p", Review = "Good" },
            new Video { Id = 2, Title = "Video 2", Quality = "720p", Review = "Good" },
            new Video { Id = 3, Title = "Video 3", Quality = "480p", Review = "Good" },
        };

    public List<Video> Videos => videos;

    public Video? FindVideo(int id) => videos.FirstOrDefault(v => v.Id == id); 
}
