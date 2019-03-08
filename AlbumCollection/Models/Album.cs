﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlbumCollection.Models
{
    public class Album
    {
        public int AlbumId { get; set; }
        public string Name { get; set; }
        public string ArtistName { get; set; }

        public virtual IEnumerable<Song> Songs { get; set; }
    }
}
