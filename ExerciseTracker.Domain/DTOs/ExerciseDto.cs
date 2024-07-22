namespace ExerciseTracker.Domain.DTOs;

class ExerciseDto
{
    public int Id { get; set; }
    public DateTime DateStart { get; set; }
    public DateTime DateEnd { get; set; }
    public TimeSpan Duration { get; set; }
    public string Comments { get; set; }
    public string ExerciseType { get; set; }
    public float? Weight { get; set; }
    public int? Reps { get; set; }
    public int? Sets { get; set; }
    public float? Distance { get; set; }
    public TimeSpan? Pace { get; set; }
}
