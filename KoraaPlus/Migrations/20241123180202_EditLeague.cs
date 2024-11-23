﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KoraaPlus.Migrations
{
    /// <inheritdoc />
    public partial class EditLeague : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "LogoUrl",
                table: "Leagues",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LogoUrl",
                table: "Leagues");
        }
    }
}
