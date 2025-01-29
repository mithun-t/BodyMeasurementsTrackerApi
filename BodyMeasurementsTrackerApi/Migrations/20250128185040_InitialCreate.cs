using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

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
                name: "BodyMeasurements",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    MeasuredDate = table.Column<DateOnly>(type: "date", nullable: false),
                    BodyWeight = table.Column<double>(type: "double precision", nullable: false),
                    BodyFatPercentage = table.Column<double>(type: "double precision", nullable: false),
                    Neck = table.Column<double>(type: "double precision", nullable: true),
                    Shoulder = table.Column<double>(type: "double precision", nullable: true),
                    Chest = table.Column<double>(type: "double precision", nullable: true),
                    Biceps = table.Column<double>(type: "double precision", nullable: true),
                    Forearm = table.Column<double>(type: "double precision", nullable: true),
                    Waist = table.Column<double>(type: "double precision", nullable: true),
                    Hips = table.Column<double>(type: "double precision", nullable: true),
                    Thighs = table.Column<double>(type: "double precision", nullable: true),
                    Calves = table.Column<double>(type: "double precision", nullable: true),
                    ProgressPicture = table.Column<string>(type: "text", nullable: true),
                    Notes = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BodyMeasurements", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BodyMeasurements");
        }
    }
}
