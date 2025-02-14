using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ScreenSound_ASP.NET.Migrations
{
    /// <inheritdoc />
    public partial class PopulateArtistIdColumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("UPDATE Songs SET ArtistId = 1 WHERE Id = 1");
            migrationBuilder.Sql("UPDATE Songs SET ArtistId = 2 WHERE Id = 2");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Songs WHERE ArtistId = 1");
            migrationBuilder.Sql("DELETE FROM Songs WHERE ArtistId = 2");
        }
    }
}
