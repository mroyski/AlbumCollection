﻿using AlbumCollection.Models;
using AlbumCollection.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlbumCollection.Controllers
{
    public class SongController : Controller
    {
        ISongRepository songRepo;
        public SongController(ISongRepository songRepo)
        {
            this.songRepo = songRepo;
        }

        [HttpGet]
        public ViewResult Create(int id)
        {
            var newSong = new Song()
            {
                AlbumId = id
            };
            return View(newSong);
        }

        [HttpPost]
        public ActionResult Create(Song song)
        {
            songRepo.Create(song);
            return RedirectToAction("../Album/Details/" + song.AlbumId);
        }

        public ViewResult Details(int id)
        {
            var model = songRepo.GetById(id);
            return View(model);
        }
    }
}
