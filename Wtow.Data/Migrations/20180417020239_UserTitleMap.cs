using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Wtow.Data.Migrations
{
    public partial class UserTitleMap : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserTitles");

            migrationBuilder.CreateTable(
                name: "UserTitleMaps",
                columns: table => new
                {
                    UserTitleMapId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Raiting = table.Column<int>(nullable: false),
                    Review = table.Column<string>(nullable: true),
                    ReviewDate = table.Column<DateTime>(nullable: false),
                    TitleId = table.Column<int>(nullable: false),
                    UserId = table.Column<string>(nullable: true),
                    WatchList = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserTitleMaps", x => x.UserTitleMapId);
                    table.ForeignKey(
                        name: "FK_UserTitleMaps_Titles_TitleId",
                        column: x => x.TitleId,
                        principalTable: "Titles",
                        principalColumn: "TitleId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserTitleMaps_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserTitleMaps_TitleId",
                table: "UserTitleMaps",
                column: "TitleId");

            migrationBuilder.CreateIndex(
                name: "IX_UserTitleMaps_UserId",
                table: "UserTitleMaps",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserTitleMaps");

            migrationBuilder.CreateTable(
                name: "UserTitles",
                columns: table => new
                {
                    UserTitleId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Raiting = table.Column<int>(nullable: false),
                    Review = table.Column<string>(nullable: true),
                    ReviewDate = table.Column<DateTime>(nullable: false),
                    TitleId = table.Column<int>(nullable: true),
                    UserId = table.Column<string>(nullable: true),
                    Watched = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserTitles", x => x.UserTitleId);
                    table.ForeignKey(
                        name: "FK_UserTitles_Titles_TitleId",
                        column: x => x.TitleId,
                        principalTable: "Titles",
                        principalColumn: "TitleId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UserTitles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserTitles_TitleId",
                table: "UserTitles",
                column: "TitleId");

            migrationBuilder.CreateIndex(
                name: "IX_UserTitles_UserId",
                table: "UserTitles",
                column: "UserId");
        }
    }
}
