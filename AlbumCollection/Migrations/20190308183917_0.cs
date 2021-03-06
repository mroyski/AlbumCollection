﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace AlbumCollection.Migrations
{
    public partial class _0 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Albums_Songs_SongId",
                table: "Albums");

            migrationBuilder.DropIndex(
                name: "IX_Albums_SongId",
                table: "Albums");

            migrationBuilder.DropColumn(
                name: "SongId",
                table: "Albums");

            migrationBuilder.AddColumn<int>(
                name: "AlbumId",
                table: "Songs",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Songs_AlbumId",
                table: "Songs",
                column: "AlbumId");

            migrationBuilder.AddForeignKey(
                name: "FK_Songs_Albums_AlbumId",
                table: "Songs",
                column: "AlbumId",
                principalTable: "Albums",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Songs_Albums_AlbumId",
                table: "Songs");

            migrationBuilder.DropIndex(
                name: "IX_Songs_AlbumId",
                table: "Songs");

            migrationBuilder.DropColumn(
                name: "AlbumId",
                table: "Songs");

            migrationBuilder.AddColumn<int>(
                name: "SongId",
                table: "Albums",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Albums_SongId",
                table: "Albums",
                column: "SongId");

            migrationBuilder.AddForeignKey(
                name: "FK_Albums_Songs_SongId",
                table: "Albums",
                column: "SongId",
                principalTable: "Songs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
