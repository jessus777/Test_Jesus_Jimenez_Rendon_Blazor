using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NorthWind.EfCore.Repositories.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MathOperations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumberOne = table.Column<decimal>(type: "decimal(8,2)", precision: 8, scale: 2, nullable: false),
                    NumberTwo = table.Column<decimal>(type: "decimal(8,2)", precision: 8, scale: 2, nullable: false),
                    OperationType = table.Column<int>(type: "int", nullable: false),
                    Result = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OperationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NameOperation = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MathOperations", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MathOperations");
        }
    }
}
