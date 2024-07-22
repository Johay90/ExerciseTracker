using ExerciseTracker.Domain.Models;

namespace ExerciseTracker.DataAccess.Interfaces;

interface IExerciseRepository
{
    Exercise Add(Exercise exercise);
    List<Exercise> GetAll();
    Exercise GetById(int Id);
    Exercise Update(Exercise exercise);
    void Delete(int Id);
}
