using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace konsola
{
    public class MusicAlbum
    {
        public string? Artist { get; set; }
        public string? Album { get; set; }
        public uint SongsNumber { get; set; }
        public int YearOfEdition { get; set; }
        public uint DownloadNumber { get; set; }

        public MusicAlbum(string? artist, string? album, uint songsNumber, int yearOfEdition, uint downloadNumber)
        {
            Artist = artist;
            Album = album;
            SongsNumber = songsNumber;
            YearOfEdition = yearOfEdition;
            DownloadNumber = downloadNumber;
        }
    }
}
