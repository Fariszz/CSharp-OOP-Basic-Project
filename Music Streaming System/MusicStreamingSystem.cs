namespace Music_Streaming_System;

public class MusicStreamingSystem
{
    public List<User> users;
    public List<Song> songs;
    public List<Playlist> playlists;
    public List<Artist> artists;
    public MusicStreamingSystem()
    {
        users = new List<User>();
        songs = new List<Song>();
        playlists = new List<Playlist>();
        artists = new List<Artist>();
    }

    public void AddArtist(Artist artist)
    {
        artists.Add(artist);
    }

    public void AddUser(User user)
    {
        users.Add(user);
    }
    public void AddSong(Song song)
    {
        songs.Add(song);
    }
    public void AddPlaylist(Playlist playlist)
    {
        playlists.Add(playlist);
    }
    public void RemoveUser(User user)
    {
        users.Remove(user);
    }
    public void RemoveSong(Song song)
    {
        songs.Remove(song);
    }
    public void RemovePlaylist(Playlist playlist)
    {
        playlists.Remove(playlist);
    }
    public List<Song> GetSongs()
    {
        return songs;
    }

    public void GetPlaylistsByUserConsole(User user)
    {
        List<Playlist> userPlaylists = new List<Playlist>();
        foreach (Playlist playlist in playlists)
        {
            if (playlist.User == user)
            {
                userPlaylists.Add(playlist);
            }
        }

        // return list song too
        foreach (Playlist playlist in userPlaylists)
        {
            Console.WriteLine("Playlist: " + playlist.Name + " User: " + playlist.User.Name);
            foreach (Song song in playlist.Songs)
            {
                Console.WriteLine("Song: " + song.Title);
            }
        }
    }

    public void FollowArtist(User user, Artist artist)
    {
        artist.Followers?.Add(user);
    }

    public void UnfollowArtist(User user, Artist artist)
    {
        artist.Followers.Remove(user);
    }

    public void GetListFollowerByArtistConsole(Artist artist)
    {
        Console.WriteLine("Artist: " + artist.Name);
        foreach (User user in artist.Followers)
        {
            Console.WriteLine("Follower: " + user.Name);
        }
    }
}
