using ExerciseTracker.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System.Configuration;

namespace ExerciseTracker.DataAccess.EFCore;

public class ExerciseDbContext : DbContext
{
    public DbSet<Exercise> Exercises { get; set; }
    public DbSet<CardioExercise> CardioExercises { get; set; }
    public DbSet<WeightExercise> WeightExercises { get; set; }

    public ExerciseDbContext(DbContextOptions<ExerciseDbContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Configure the inheritance strategy using Table-Per-Hierarchy (TPH)
        // TPH uses a single table for all types in an inheritance hierarchy
        modelBuilder.Entity<Exercise>()
            .HasDiscriminator<string>("ExerciseType")
            .HasValue<CardioExercise>("Cardio")
            .HasValue<WeightExercise>("Weight");

        modelBuilder.Entity<CardioExercise>().HasData(
            new CardioExercise
            {
                Id = 1,
                DateStart = new DateTime(2023, 7, 1, 7, 0, 0),
                DateEnd = new DateTime(2023, 7, 1, 7, 30, 0),
                Duration = TimeSpan.FromMinutes(30),
                Comments = "Morning jog",
                Distance = 3.5f,
                Pace = TimeSpan.FromMinutes(8).Add(TimeSpan.FromSeconds(34))
            },
            new CardioExercise
            {
                Id = 2,
                DateStart = new DateTime(2023, 7, 3, 18, 0, 0),
                DateEnd = new DateTime(2023, 7, 3, 19, 0, 0),
                Duration = TimeSpan.FromHours(1),
                Comments = "Evening bike ride",
                Distance = 15.0f,
                Pace = TimeSpan.FromMinutes(4)
            },
            new CardioExercise
            {
                Id = 3,
                DateStart = new DateTime(2023, 7, 5, 6, 30, 0),
                DateEnd = new DateTime(2023, 7, 5, 7, 30, 0),
                Duration = TimeSpan.FromHours(1),
                Comments = "Swimming",
                Distance = 2.0f,
                Pace = TimeSpan.FromMinutes(30)
            }
        );

        modelBuilder.Entity<WeightExercise>().HasData(
            new WeightExercise
            {
                Id = 4,
                DateStart = new DateTime(2023, 7, 2, 16, 0, 0),
                DateEnd = new DateTime(2023, 7, 2, 16, 45, 0),
                Duration = TimeSpan.FromMinutes(45),
                Comments = "Chest day",
                Weight = 135.0f,
                Reps = 8,
                Sets = 3
            },
            new WeightExercise
            {
                Id = 5,
                DateStart = new DateTime(2023, 7, 4, 17, 0, 0),
                DateEnd = new DateTime(2023, 7, 4, 18, 0, 0),
                Duration = TimeSpan.FromHours(1),
                Comments = "Leg day",
                Weight = 225.0f,
                Reps = 6,
                Sets = 4
            },
            new WeightExercise
            {
                Id = 6,
                DateStart = new DateTime(2023, 7, 6, 15, 30, 0),
                DateEnd = new DateTime(2023, 7, 6, 16, 15, 0),
                Duration = TimeSpan.FromMinutes(45),
                Comments = "Arms",
                Weight = 50.0f,
                Reps = 12,
                Sets = 3
            }
        );
    }
}
