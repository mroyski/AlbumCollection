using AlbumCollection.Controllers;
using AlbumCollection.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using NSubstitute;
using Xunit;
using AlbumCollection.Models;

namespace AlbumCollection.Tests
{
    public class SongControllerTests
    {
        SongController underTest;
        private ISongRepository repo;

        public SongControllerTests()
        {
            repo = Substitute.For<ISongRepository>();
            underTest = new SongController(repo);
        }

        [Fact]
        public void Create_Adds_New_Song()
        {
            var song = new Song();
            var otherSong = new Song();

            repo.Create(song);
            repo.Received().Create(song);
            repo.DidNotReceive().Create(otherSong);
        }

    }
}
