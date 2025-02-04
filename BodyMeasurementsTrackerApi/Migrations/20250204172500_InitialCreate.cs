using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BodyMeasurementsTrackerApi.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Username = table.Column<string>(type: "TEXT", nullable: false),
                    Password = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "BodyMeasurements",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    MeasuredDate = table.Column<DateOnly>(type: "TEXT", nullable: false),
                    BodyWeight = table.Column<double>(type: "REAL", nullable: false),
                    BodyFatPercentage = table.Column<double>(type: "REAL", nullable: false),
                    Neck = table.Column<double>(type: "REAL", nullable: true),
                    Shoulder = table.Column<double>(type: "REAL", nullable: true),
                    Chest = table.Column<double>(type: "REAL", nullable: true),
                    Biceps = table.Column<double>(type: "REAL", nullable: true),
                    Forearm = table.Column<double>(type: "REAL", nullable: true),
                    Waist = table.Column<double>(type: "REAL", nullable: true),
                    Hips = table.Column<double>(type: "REAL", nullable: true),
                    Thighs = table.Column<double>(type: "REAL", nullable: true),
                    Calves = table.Column<double>(type: "REAL", nullable: true),
                    ProgressPicture = table.Column<string>(type: "TEXT", nullable: true),
                    Notes = table.Column<string>(type: "TEXT", nullable: true),
                    UserId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BodyMeasurements", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BodyMeasurements_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BodyMeasurements_UserId",
                table: "BodyMeasurements",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BodyMeasurements");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
