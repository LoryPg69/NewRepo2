using System.Collections.Generic;
using System.IO;

namespace Spotify
{

    internal class FileReader
    {

        public static List<Song> Reader()
        {
            var path = @"C:\Users\lorenzo.pioggia\Documents\DB\DatabaseSpotify.csv";
            List<Song> songs = new List<Song>();

            using (StreamReader sr = new StreamReader(path))
            {


                while (!sr.EndOfStream)
                {
                    var line = sr.ReadLine();
                    var values = line.Split(',');

                    Song song = new Song(values[0], values[1], values[2], values[3], values[4]);
                    songs.Add(song);
                }


                return songs;

            }


        }
    }
}
