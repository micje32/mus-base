using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MusBase.Models.Music
{
    public class Song
    {
        private int Id { get; set; }
        private string Artist { get; set; }
        private string Title { get; set; }
        private string Album { get; set; }
        private string Track { get; set; }
        [DataType(DataType.Date)]
        private DateTime ReleaseDate { get; set; }
        private bool IsPendingForCheck { get; set; }

        //TODO: data consistency protection
        public Song(string artist, string title)
        {
            Id = new Random().Next(0, int.MaxValue);
            Artist = artist;
            Title = title;
            IsPendingForCheck = true;
        }
        //TODO: JSON serialization
        public List<string> ExportSongData()
        {
            List<string> data = new List<string>();
            data.Add(Artist);
            data.Add(Title);
            data.Add(Album);
            data.Add(Track);
            return data;
        }
    }
}
