using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Tomappto.Infrastructure.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Tomappto");

            migrationBuilder.CreateTable(
                name: "Tomatoes",
                schema: "Tomappto",
                columns: table => new
                {
                    TomatoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PickedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PickedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tomatoes", x => x.TomatoId);
                });

            migrationBuilder.InsertData(
                schema: "Tomappto",
                table: "Tomatoes",
                columns: new[] { "TomatoId", "PickedBy", "PickedOn" },
                values: new object[] { new Guid("8503ddab-6ea8-4b21-ae9d-e7b500490be1"), "Person1", new DateTime(2021, 9, 18, 11, 8, 9, 155, DateTimeKind.Local).AddTicks(9086) });

            migrationBuilder.InsertData(
                schema: "Tomappto",
                table: "Tomatoes",
                columns: new[] { "TomatoId", "PickedBy", "PickedOn" },
                values: new object[] { new Guid("99ac725b-eb7c-4bd8-8070-35be26938531"), "Person2", new DateTime(2021, 9, 18, 11, 8, 9, 160, DateTimeKind.Local).AddTicks(9737) });

            migrationBuilder.InsertData(
                schema: "Tomappto",
                table: "Tomatoes",
                columns: new[] { "TomatoId", "PickedBy", "PickedOn" },
                values: new object[] { new Guid("c500614b-30df-4e42-83b7-0b605b971499"), "Person3", new DateTime(2021, 9, 18, 11, 8, 9, 160, DateTimeKind.Local).AddTicks(9816) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tomatoes",
                schema: "Tomappto");
        }
    }
}
