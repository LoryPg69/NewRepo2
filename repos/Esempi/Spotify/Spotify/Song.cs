namespace Spotify
{
    internal class Song
    {

        public string artist;
        public string album;
        public string genre;
        public string title;
        public string times;

        public Song(string artist, string album, string genre, string title, string times)
        {
            this.artist = artist;
            this.album = album;
            this.genre = genre;
            this.title = title;
            this.times = times;
        }

    }
}

