namespace ExerciseTracker.Domain.Models;

class CardioExercise : Exercise
{
    public float Distance { get; set; }
    public TimeSpan Pace { get; set; }
}
