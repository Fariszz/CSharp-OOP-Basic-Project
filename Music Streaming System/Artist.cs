namespace Music_Streaming_System;

public class Artist
{
    public int ArtistId { get; set; }
    public string Name { get; set; }
    public List<Song> Songs { get; set; }
    public List<User>? Followers { get; set; }

    public Artist()
    {
        Songs = new List<Song>();
        Followers = new List<User>();
    }
}
