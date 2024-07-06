namespace Music_Streaming_System;

public class User
{
    public int UserId { get; set; }
    public string Name { get; set; }
    public List<Playlist> Playlists { get; set; }
}
