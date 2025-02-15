﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ScreenSound_ASP.NET.Migrations
{
    /// <inheritdoc />
    public partial class AddColumnReleaseYear : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ReleaseYear",
                table: "Songs",
                type: "int",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ReleaseYear",
                table: "Songs");
        }
    }
}
