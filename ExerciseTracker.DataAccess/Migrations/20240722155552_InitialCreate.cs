using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ExerciseTracker.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Exercises",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateStart = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateEnd = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Duration = table.Column<TimeSpan>(type: "time", nullable: false),
                    Comments = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExerciseType = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: false),
                    Distance = table.Column<float>(type: "real", nullable: true),
                    Pace = table.Column<TimeSpan>(type: "time", nullable: true),
                    Weight = table.Column<float>(type: "real", nullable: true),
                    Reps = table.Column<int>(type: "int", nullable: true),
                    Sets = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exercises", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "Id", "Comments", "DateEnd", "DateStart", "Distance", "Duration", "ExerciseType", "Pace" },
                values: new object[,]
                {
                    { 1, "Morning jog", new DateTime(2023, 7, 1, 7, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 7, 1, 7, 0, 0, 0, DateTimeKind.Unspecified), 3.5f, new TimeSpan(0, 0, 30, 0, 0), "Cardio", new TimeSpan(0, 0, 8, 34, 0) },
                    { 2, "Evening bike ride", new DateTime(2023, 7, 3, 19, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 7, 3, 18, 0, 0, 0, DateTimeKind.Unspecified), 15f, new TimeSpan(0, 1, 0, 0, 0), "Cardio", new TimeSpan(0, 0, 4, 0, 0) },
                    { 3, "Swimming", new DateTime(2023, 7, 5, 7, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 7, 5, 6, 30, 0, 0, DateTimeKind.Unspecified), 2f, new TimeSpan(0, 1, 0, 0, 0), "Cardio", new TimeSpan(0, 0, 30, 0, 0) }
                });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "Id", "Comments", "DateEnd", "DateStart", "Duration", "ExerciseType", "Reps", "Sets", "Weight" },
                values: new object[,]
                {
                    { 4, "Chest day", new DateTime(2023, 7, 2, 16, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 7, 2, 16, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 45, 0, 0), "Weight", 8, 3, 135f },
                    { 5, "Leg day", new DateTime(2023, 7, 4, 18, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 7, 4, 17, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0), "Weight", 6, 4, 225f },
                    { 6, "Arms", new DateTime(2023, 7, 6, 16, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 7, 6, 15, 30, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 45, 0, 0), "Weight", 12, 3, 50f }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Exercises");
        }
    }
}
