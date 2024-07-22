namespace ExerciseTracker.Domain.Models;

public class WeightExercise : Exercise
{
    public float Weight { get; set; }
    public int Reps { get; set; }
    public int Sets { get; set; }
}
