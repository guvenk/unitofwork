using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace UnitOfWork.DataAccess.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(maxLength: 256, nullable: false),
                    Author = table.Column<string>(maxLength: 256, nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Libraries",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    CreateDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Libraries", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "CreateDate", "Title" },
                values: new object[,]
                {
                    { 1, "J. K. Rowling", new DateTime(2020, 4, 18, 14, 42, 40, 866, DateTimeKind.Utc).AddTicks(3324), "Harry Potter" },
                    { 2, "Miguel De Cervantes", new DateTime(2020, 4, 18, 14, 42, 40, 866, DateTimeKind.Utc).AddTicks(4054), "Don Quixote" },
                    { 3, "Fyodor Dostoyevsky", new DateTime(2020, 4, 18, 14, 42, 40, 866, DateTimeKind.Utc).AddTicks(4069), "Crime and Punishment" }
                });

            migrationBuilder.InsertData(
                table: "Libraries",
                columns: new[] { "Id", "CreateDate", "Name" },
                values: new object[] { 1, new DateTime(2020, 4, 18, 14, 42, 40, 864, DateTimeKind.Utc).AddTicks(8894), "Library 1" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "Libraries");
        }
    }
}