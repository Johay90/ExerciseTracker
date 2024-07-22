namespace ExerciseTracker.Domain.Models;

public class CardioExercise : Exercise
{
    public float Distance { get; set; }
    public TimeSpan Pace { get; set; }
}
