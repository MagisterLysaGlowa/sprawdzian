using System.Collections.Generic;

namespace konsola
{
    public class Program
    {
        public static List<MusicAlbum> ReadAlbums(string filepath)
        {
            string[] lines = File.ReadAllLines(filepath);
            List<MusicAlbum> albums = new();
            for (int i = 0; i < lines.Length; i+=6)
            {
                string artist = lines[i];
                string album = lines[i + 1];
                uint songsNumber = uint.Parse(lines[i + 2]);
                int yearOfEdition = int.Parse(lines[i + 3]);
                uint downloadNumber = uint.Parse(lines[i + 4]);
                albums.Add(new MusicAlbum(artist, album, songsNumber, yearOfEdition, downloadNumber));
            }
            return albums;
        }

        private static void DisplayAlbums(List<MusicAlbum> albums)
        {
            foreach (var item in albums)
            {
                Console.WriteLine(item.Artist);
                Console.WriteLine(item.Album);
                Console.WriteLine(item.SongsNumber);
                Console.WriteLine(item.YearOfEdition);
                Console.WriteLine(item.DownloadNumber);
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            string filepath = "../../../Data.txt";
            //DisplayAlbums(ReadAlbums(filepath));
        }
    }
}
