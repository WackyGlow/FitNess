using Common;
using Microsoft.AspNetCore.Mvc;
using WorkoutService.Database;

namespace WorkoutService.Conrollers;


[ApiController]
[Route("[controller]")]
public class WorkoutController : ControllerBase
{
    private WorkoutCollection _workout;

    /// <summary>
    /// Initializes a new instance of the <see cref="WorkoutController"/> class.
    /// </summary>
    public WorkoutController()
    {
        _workout = new WorkoutCollection();
    }

    /// <summary>
    /// Retrieves the intensity of a workout by its ID.
    /// </summary>
    /// <param name="id">The ID of the workout.</param>
    /// <returns>The workout intensity as a <see cref="WorkoutDTO"/> object.</returns>
    [HttpGet("{id}")]
    public  WorkoutDTO GetWorkOutIntensity(int id)
    {
        var workout = _workout.GetWorkOutIntensity(id);
        var newworkout = new WorkoutDTO
        {
            Intensity = workout.WorkOutIntensity
        };
        return newworkout;
    }
}