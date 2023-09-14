using System;
using System.Collections.Generic;

namespace Spotify
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            List<Song> songs = new List<Song>();
            songs = FileReader.Reader();
            Lettore lettore = new Lettore(songs);
            lettore.ShowArtists();
        }
    }
}
