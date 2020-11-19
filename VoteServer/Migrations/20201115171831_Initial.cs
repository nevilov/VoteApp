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
                    TitleVoting = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    DescriptionVoting = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Start_dateVoting = table.Column<DateTime>(type: "datetime2", nullable: false),
                    End_dateVoting = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VoteInfos", x => x.TitleVoting);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VoteInfos");
        }
    }
}
