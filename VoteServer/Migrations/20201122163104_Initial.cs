using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace VoteServer.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "VoteInfos",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    TitleVoting = table.Column<string>(nullable: true),
                    DescriptionVoting = table.Column<string>(nullable: true),
                    Start_dateVoting = table.Column<DateTime>(nullable: false),
                    End_dateVoting = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VoteInfos", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VoteInfos");
        }
    }
}
