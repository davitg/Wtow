using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Wtow.Data.Migrations
{
    public partial class EnumAsProperty : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "imdbVotes",
                table: "Titles",
                newName: "ImdbVotes");

            migrationBuilder.RenameColumn(
                name: "imdbRating",
                table: "Titles",
                newName: "ImdbRating");

            migrationBuilder.RenameColumn(
                name: "imdbID",
                table: "Titles",
                newName: "ImdbID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ImdbVotes",
                table: "Titles",
                newName: "imdbVotes");

            migrationBuilder.RenameColumn(
                name: "ImdbRating",
                table: "Titles",
                newName: "imdbRating");

            migrationBuilder.RenameColumn(
                name: "ImdbID",
                table: "Titles",
                newName: "imdbID");
        }
    }
}
