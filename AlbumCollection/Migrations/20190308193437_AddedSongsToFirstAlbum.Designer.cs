﻿// <auto-generated />
using AlbumCollection;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AlbumCollection.Migrations
{
    [DbContext(typeof(MusicContext))]
    [Migration("20190308193437_AddedSongsToFirstAlbum")]
    partial class AddedSongsToFirstAlbum
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.8-servicing-32085")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AlbumCollection.Models.Album", b =>
                {
                    b.Property<int>("AlbumId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ArtistName");

                    b.Property<string>("Name");

                    b.HasKey("AlbumId");

                    b.ToTable("Albums");

                    b.HasData(
                        new { AlbumId = 1, ArtistName = "Lou Reed", Name = "Transformer" },
                        new { AlbumId = 2, ArtistName = "Opeth", Name = "Ghost Reveries" },
                        new { AlbumId = 3, ArtistName = "Creedence Clearwater Revival", Name = "Green River" }
                    );
                });

            modelBuilder.Entity("AlbumCollection.Models.Song", b =>
                {
                    b.Property<int>("SongId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AlbumId");

                    b.Property<string>("Name");

                    b.HasKey("SongId");

                    b.HasIndex("AlbumId");

                    b.ToTable("Songs");

                    b.HasData(
                        new { SongId = 1, AlbumId = 1, Name = "Vicious" },
                        new { SongId = 2, AlbumId = 1, Name = "Andy's Chest" }
                    );
                });

            modelBuilder.Entity("AlbumCollection.Models.Song", b =>
                {
                    b.HasOne("AlbumCollection.Models.Album")
                        .WithMany("Songs")
                        .HasForeignKey("AlbumId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
