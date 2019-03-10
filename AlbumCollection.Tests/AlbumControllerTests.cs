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

        public AlbumControllerTests()
        {
            repo = Substitute.For<IAlbumRepository>();
            underTest = new AlbumController(repo);
        }

        [Fact]
        public void Index_Model_Is_Expected_Model()
        {
            var expectedModel = new List<Album>();
            repo.GetAll().Returns(expectedModel);

            var result = underTest.Index();
            var model = (IEnumerable<Album>)result.Model;

            Assert.Equal(expectedModel, model);
        }

        [Fact]
        public void Details_Sets_Model_To_Correct_Album()
        {
            var expectedId = 2;
            var expectedModel = new Album();
            repo.GetById(expectedId).Returns(expectedModel);

            var result = underTest.Details(expectedId);
            var model = (Album)result.Model;

            Assert.Equal(expectedModel, model);
        }
    }
}
