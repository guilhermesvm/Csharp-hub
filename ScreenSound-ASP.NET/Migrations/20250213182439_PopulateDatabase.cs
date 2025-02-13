using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ScreenSound_ASP.NET.Migrations
{
    /// <inheritdoc />
    public partial class PopulateDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData("Artists", new string[] { "Name", "Bio", "ProfilePicture" }, new object[] {"Blink-182", "Punk", "https://cdn.pixabay.com/photo/2016/08/08/09/17/avatar-1577909_1280.png" });
            migrationBuilder.InsertData("Artists", new string[] { "Name", "Bio", "ProfilePicture" }, new object[] { "Green Day", "Punk", "https://cdn.pixabay.com/photo/2016/08/08/09/17/avatar-1577909_1280.png" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Artists");

        }
    }
}
