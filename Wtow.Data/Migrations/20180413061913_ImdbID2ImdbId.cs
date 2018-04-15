using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Wtow.Data.Migrations
{
    public partial class ImdbID2ImdbId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ImdbID",
                table: "Titles",
                newName: "ImdbId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ImdbId",
                table: "Titles",
                newName: "ImdbID");
        }
    }
}
