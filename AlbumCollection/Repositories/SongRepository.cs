using AlbumCollection.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlbumCollection.Repositories
{
    public class SongRepository
    {
        private MusicContext db;

        public SongRepository(MusicContext db)
        {
            this.db = db;
        }

        public void Create(Song song)
        {
            db.Songs.Add(song);
            db.SaveChanges();
        }

        public Song GetById(int id)
        {
            return db.Songs.Single(Song => Song.SongId == id);
        }
    }
}
