﻿using AlbumCollection.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlbumCollection.Repositories
{
    public interface ISongRepository
    {
        Song GetById(int id);
        void Create(Song song);

    }
}
