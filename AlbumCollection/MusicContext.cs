using AlbumCollection.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlbumCollection
{
    public class MusicContext : DbContext
    {
        public DbSet<Song> Songs { get; set; }
        public DbSet<Album> Albums { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=(localdb)\\mssqllocaldb;Database=AlbumCollections;Trusted_Connection=True;";

            optionsBuilder.UseSqlServer(connectionString)
                          .UseLazyLoadingProxies();

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Album>().HasData(
                new Album()
                {
                    AlbumId = 1,
                    Name = "Transformer",
                    ArtistName = "Lou Reed"
                },

                new Album()
                {
                    AlbumId = 2,
                    Name = "Ghost Reveries",
                    ArtistName = "Opeth"
                },

                new Album()
                {
                    AlbumId = 3,
                    Name = "Green River",
                    ArtistName = "Creedence Clearwater Revival"
                });

            modelBuilder.Entity<Song>().HasData(
                new Song()
                {
                    SongId = 1,
                    Name = "Vicious",
                    AlbumId = 1
                },

                new Song()
                {
                    SongId = 2,
                    Name = "Andy's Chest",
                    AlbumId = 1
                },

                new Song()
                {
                    SongId = 3,
                    Name = "Perfect Day",
                    AlbumId = 1
                },

                new Song()
                {
                    SongId = 4,
                    Name = "Hangin' Round",
                    AlbumId = 1
                },

                new Song()
                {
                    SongId = 5,
                    Name = "Walk on the Wild Side",
                    AlbumId = 1
                },

                new Song()
                {
                    SongId = 6,
                    Name = "Make Up",
                    AlbumId = 1
                },

                new Song()
                {
                    SongId = 7,
                    Name = "Satellite of Love",
                    AlbumId = 1
                },

                new Song()
                {
                    SongId = 8,
                    Name = "Wagon Wheel",
                    AlbumId = 1
                },

                new Song()
                {
                    SongId = 9,
                    Name = "New York Telephone Conversation",
                    AlbumId = 1
                },

                new Song()
                {
                    SongId = 10,
                    Name = "I'm So Free",
                    AlbumId = 1
                },

                new Song()
                {
                    SongId = 11,
                    Name = "Goodnight Ladies",
                    AlbumId = 1
                });

        }
    }
}
