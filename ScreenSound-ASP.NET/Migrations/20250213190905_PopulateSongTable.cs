using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ScreenSound_ASP.NET.Migrations
{
    /// <inheritdoc />
    public partial class PopulateSongTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData("Songs", new string[] {"Name", "ReleaseYear"}, new object[] { "What's My Age Again?", 1999});
            migrationBuilder.InsertData("Songs", new string[] { "Name", "ReleaseYear" }, new object[] { "Basket Case", 1994 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Songs WHERE Name = 'What's My Age Again?' AND ReleaseYear = 1999");
            migrationBuilder.Sql("DELETE FROM Songs WHERE Name = 'Basket Case' AND ReleaseYear = 1994");
        }
    }
}
