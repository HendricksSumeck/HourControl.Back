using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HourControl.Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class Inicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Project",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "varchar", nullable: false),
                    Color = table.Column<string>(type: "varchar", nullable: false),
                    DeletedIn = table.Column<DateTime>(type: "timestamp", nullable: true),
                    Active = table.Column<bool>(type: "boolean", nullable: false),
                    RegisteredIn = table.Column<DateTime>(type: "timestamp", nullable: false),
                    UpdatedIn = table.Column<DateTime>(type: "timestamp", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Project", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Activity",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "varchar", nullable: false),
                    TimeStart = table.Column<TimeSpan>(type: "time", nullable: true),
                    TimeEnd = table.Column<TimeSpan>(type: "time", nullable: true),
                    TimeTotal = table.Column<TimeSpan>(type: "time", nullable: true),
                    Date = table.Column<DateTime>(type: "timestamp", nullable: true),
                    ProjectId = table.Column<Guid>(type: "uuid", nullable: false),
                    DeletedIn = table.Column<DateTime>(type: "timestamp", nullable: true),
                    Active = table.Column<bool>(type: "boolean", nullable: false),
                    RegisteredIn = table.Column<DateTime>(type: "timestamp", nullable: false),
                    UpdatedIn = table.Column<DateTime>(type: "timestamp", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Activity", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Activity_Project_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Project",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Activity_ProjectId",
                table: "Activity",
                column: "ProjectId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Activity");

            migrationBuilder.DropTable(
                name: "Project");
        }
    }
}
