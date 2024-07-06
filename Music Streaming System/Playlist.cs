namespace Music_Streaming_System;

public class Playlist
{
    public int PlaylistId { get; set; }
    public string Name { get; set; }
    public List<Song> Songs { get; set; }
    public User User { get; set; }

    public Playlist()
    {
        Songs = new List<Song>();
    }

    
}
