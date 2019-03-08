using Microsoft.EntityFrameworkCore.Migrations;

namespace AlbumCollection.Migrations
{
    public partial class AddedAlbums : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Songs_Albums_AlbumId",
                table: "Songs");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Songs",
                newName: "SongId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Albums",
                newName: "AlbumId");

            migrationBuilder.AlterColumn<int>(
                name: "AlbumId",
                table: "Songs",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Albums",
                columns: new[] { "AlbumId", "ArtistName", "Name" },
                values: new object[] { 1, "Lou Reed", "Transformer" });

            migrationBuilder.InsertData(
                table: "Albums",
                columns: new[] { "AlbumId", "ArtistName", "Name" },
                values: new object[] { 2, "Opeth", "Ghost Reveries" });

            migrationBuilder.InsertData(
                table: "Albums",
                columns: new[] { "AlbumId", "ArtistName", "Name" },
                values: new object[] { 3, "Creedence Clearwater Revival", "Green River" });

            migrationBuilder.AddForeignKey(
                name: "FK_Songs_Albums_AlbumId",
                table: "Songs",
                column: "AlbumId",
                principalTable: "Albums",
                principalColumn: "AlbumId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Songs_Albums_AlbumId",
                table: "Songs");

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 3);

            migrationBuilder.RenameColumn(
                name: "SongId",
                table: "Songs",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "AlbumId",
                table: "Albums",
                newName: "Id");

            migrationBuilder.AlterColumn<int>(
                name: "AlbumId",
                table: "Songs",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Songs_Albums_AlbumId",
                table: "Songs",
                column: "AlbumId",
                principalTable: "Albums",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
