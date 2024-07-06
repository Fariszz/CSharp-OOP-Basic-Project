namespace Music_Streaming_System
{
    class Program
    {
        static void Main(string[] args)
        {
            MusicStreamingSystem musicStreamingSystem = new MusicStreamingSystem();

            User user1 = new User { UserId = 1, Name = "John" };
            User user2 = new User { UserId = 2, Name = "Jane" };

            musicStreamingSystem.AddUser(user1);
            musicStreamingSystem.AddUser(user2);

            Song song1 = new Song { SongId = 1, Title = "Song1" };
            Song song2 = new Song { SongId = 2, Title = "Song2" };
            Song song3 = new Song { SongId = 3, Title = "Song3" };
            Song song4 = new Song { SongId = 4, Title = "Song4" };

            Artist artist1 = new Artist { ArtistId = 1, Name = "Artist1", Songs = new List<Song> { song1, song2 } };
            Artist artist2 = new Artist { ArtistId = 2, Name = "Artist2", Songs = new List<Song> { song3, song4 } };

            musicStreamingSystem.AddArtist(artist1);
            musicStreamingSystem.AddArtist(artist2);

            Playlist playlist1 = new Playlist { PlaylistId = 1, Name = "Playlist1", User = user1, Songs = new List<Song> { song1, song2 } };
            Playlist playlist2 = new Playlist { PlaylistId = 2, Name = "Playlist2", User = user2, Songs = new List<Song> { song3, song4 } };

            musicStreamingSystem.AddPlaylist(playlist1);
            musicStreamingSystem.AddPlaylist(playlist2);

            musicStreamingSystem.FollowArtist(user1, artist1);
            musicStreamingSystem.FollowArtist(user2, artist1);

            musicStreamingSystem.GetPlaylistsByUserConsole(user1);        

            musicStreamingSystem.GetListFollowerByArtistConsole(artist1);

            musicStreamingSystem.UnfollowArtist(user1, artist1);

            musicStreamingSystem.GetListFollowerByArtistConsole(artist1);            
        }
    }
}