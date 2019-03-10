using AlbumCollection.Controllers;
using AlbumCollection.Models;
using AlbumCollection.Repositories;
using NSubstitute;
using System;
using System.Collections.Generic;
using Xunit;
using Microsoft.AspNetCore.Mvc;


namespace AlbumCollection.Tests
{
    public class AlbumControllerTests
    {
        AlbumController underTest;
        private IAlbumRepository repo;

        [Fact]
        public void Index_Model_Is_Expected_Model()
        {
            var expectedModel = new List<Album>();
            repo.GetAll().Returns(expectedModel);

            var result = underTest.Index();
            var model = (IEnumerable<Album>)result.Model;

            Assert.Equal(expectedModel, model);
        }
    }
}
