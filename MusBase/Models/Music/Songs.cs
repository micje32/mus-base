using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusBase.Models.Music
{
    public class Songs
    {
        private int Id { get; set; }
        private string Owner { get; set; }
        private int OwnerId { get; set; }
        private List<Song> SongList { get; set; }
        public Song(string owner, int ownerId)
        {
            Owner = owner;
            OwnerId = ownerId;
        }
        public void AddSong(Song song)
        {
            SongList.Add(song);
        }
    }
}
