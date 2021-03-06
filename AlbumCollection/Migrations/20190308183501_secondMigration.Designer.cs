﻿// <auto-generated />
using System;
using AlbumCollection;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AlbumCollection.Migrations
{
    [DbContext(typeof(MusicContext))]
    [Migration("20190308183501_secondMigration")]
    partial class secondMigration
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
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ArtistName");

                    b.Property<string>("Name");

                    b.Property<int?>("SongId");

                    b.HasKey("Id");

                    b.HasIndex("SongId");

                    b.ToTable("Albums");
                });

            modelBuilder.Entity("AlbumCollection.Models.Song", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Songs");
                });

            modelBuilder.Entity("AlbumCollection.Models.Album", b =>
                {
                    b.HasOne("AlbumCollection.Models.Song")
                        .WithMany("Albums")
                        .HasForeignKey("SongId");
                });
#pragma warning restore 612, 618
        }
    }
}
